Imports System.Data.Odbc

Public Class frmRegister
    ' Connection string to your Access database via ODBC
    Private connectionString As String = "DSN=parkinglotreservationsystemdb;"

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Hide the login form if necessary
        frmLogin.Hide()
    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Dim oForm As New frmLogin
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim fullName As String = txtName.Text
        Dim icNo As String = txtICNumber.Text
        Dim phoneNo As String = txtPhoneNumber.Text
        Dim vehicleNo As String = txtVehicleNoPlate.Text
        Dim password As String = txtPassword.Text

        ' Check if the icNo already exists
        If ICNumberExists(icNo) Then
            MessageBox.Show("IC Number already registered. Please use a different IC Number.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Insert the new user into the database
        If RegisterUser(fullName, icNo, phoneNo, vehicleNo, password) Then
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Proceed to the login form
            Dim loginForm As New frmLogin()
            loginForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ICNumberExists(icNo As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE icNo = ?"
        Using connection As New OdbcConnection(connectionString)
            Using command As New OdbcCommand(query, connection)
                ' Add parameter to the command in the correct order
                command.Parameters.AddWithValue("?", icNo)
                connection.Open()
                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                connection.Close()
                Return result > 0
            End Using
        End Using
    End Function

    Private Function RegisterUser(fullName As String, icNo As String, phoneNo As String, vehicleNo As String, password As String) As Boolean
        Dim query As String = "INSERT INTO Users (fullName, icNo, phoneNo, vehicleNo, Password, typeId) VALUES (?, ?, ?, ?, ?,2)"
        Using connection As New OdbcConnection(connectionString)
            Using command As New OdbcCommand(query, connection)
                ' Add parameters to the command in the correct order
                command.Parameters.AddWithValue("?", fullName)
                command.Parameters.AddWithValue("?", icNo)
                command.Parameters.AddWithValue("?", phoneNo)
                command.Parameters.AddWithValue("?", vehicleNo)
                command.Parameters.AddWithValue("?", password)
                connection.Open()
                Dim result As Integer = command.ExecuteNonQuery()
                connection.Close()
                Return result > 0
            End Using
        End Using
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Handle PictureBox click event if necessary
    End Sub
End Class
