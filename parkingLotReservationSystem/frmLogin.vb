Imports System.Data.Odbc
Module GlobalVariables
    Public loggedInUserId As Integer = 0
    Public receiptLocation As String = ""
End Module

Public Class frmLogin
    ' Connection string for ODBC DSN
    Private connectionString As String = "DSN=parkinglotreservationsystemdb;"
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmRegister.Hide()
    End Sub

    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        Dim oForm As New frmRegister
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Get the input from the text boxes
        Dim icNumber As String = txtICNumber.Text
        Dim password As String = txtPassword.Text

        ' Validate input (optional but recommended)
        If String.IsNullOrEmpty(icNumber) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both IC number and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If LoginUser(icNumber, password) Then
            Dim userType As Integer = CheckType(icNumber)
            If userType = 1 Then
                MessageBox.Show("Login successful! You are an admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ide the login form and show the admin form
                Me.Hide()
                Dim adminForm As New frmReservationAdmin()
                adminForm.Show()
            ElseIf userType = 2 Then
                MessageBox.Show("Login successful! You are a user.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GlobalVariables.loggedInUserId = getUserId(icNumber, password)
                'ide the login form and show the user form
                Me.Hide()
                Dim userForm As New frmReservationUser()
                userForm.Show()
            Else
                MessageBox.Show("Login failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Login failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function LoginUser(icNumber As String, password As String) As Boolean
        ' SQL query to check for matching user
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE icNo = ? AND password = ?"
        ' Create a connection and command
        Using connection As New OdbcConnection(connectionString)
            Using command As New OdbcCommand(query, connection)
                ' Add parameters to the command in the correct order
                command.Parameters.AddWithValue("?", icNumber)
                command.Parameters.AddWithValue("?", password)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                connection.Close()
                Return Convert.ToInt32(result) > 0
            End Using
        End Using
    End Function
    Private Function getUserId(icNumber As String, password As String) As Integer
        ' SQL query to retrieve user ID based on IC number and password
        Dim query As String = "SELECT userId FROM Users WHERE icNo = ? AND password = ?"

        ' Variable to store userId
        Dim userId As Integer = 0

        ' Create a connection and command
        Using connection As New OdbcConnection(connectionString)
            Using command As New OdbcCommand(query, connection)
                ' Add parameters to the command in the correct order
                command.Parameters.AddWithValue("@icNumber", icNumber)
                command.Parameters.AddWithValue("@password", password)

                Try
                    connection.Open()
                    ' Execute the query and retrieve the userId
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        userId = Convert.ToInt32(result)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error retrieving user ID: " & ex.Message)
                End Try
            End Using
        End Using

        Return userId
    End Function


    Private Function CheckType(icNumber As String) As Integer
        ' SQL query to get user type
        Dim query As String = "SELECT typeId FROM Users WHERE icNo = ?"
        ' Create a connection and command
        Using connection As New OdbcConnection(connectionString)
            Using command As New OdbcCommand(query, connection)
                ' Add parameters to the command
                command.Parameters.AddWithValue("?", icNumber)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                connection.Close()
                Return Convert.ToInt32(result)
            End Using
        End Using
    End Function
End Class
