Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        'frmRegister.Hide()
    End Sub
    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        Dim oForm As New frmRegister
        oForm.Show()
        Me.Hide()
    End Sub

    Private connectionString As String = "Data Source=your_server;Initial Catalog=your_database;Integrated Security=True"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Get the input from the text boxes
        Dim icNumber As String = txtICNumber.Text
        Dim password As String = txtPassword.Text

        ' Validate input (optional but recommended)
        If String.IsNullOrEmpty(icNumber) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both IC number and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Connection string (update the path to your database file)
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\path\to\your\UserDatabase.accdb"

        ' SQL query to check for matching user
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE ICNumber = ? AND Password = ?"

        ' Create a connection and command
        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                ' Add parameters to the command
                command.Parameters.AddWithValue("@ICNumber", icNumber)
                command.Parameters.AddWithValue("@Password", password)

                Try
                    ' Open the connection
                    connection.Open()

                    ' Execute the query and get the result
                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' Check if a matching user was found
                    If result > 0 Then
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Hide the login form and show the main form
                        Me.Hide()
                        'Dim mainForm As New frmReservation()
                        'mainForm.Show()
                    Else
                        MessageBox.Show("Invalid IC number or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class