Imports System.Data.OleDb

Public Class frmRegister
    ' Connection string to your Access database
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=path_to_your_database.accdb"

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Hide the login form if necessary
        ' frmLogin.Hide()
    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Dim oForm As New frmLogin
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim name As String = txtName.Text
        Dim icNumber As String = txtICNumber.Text
        Dim phoneNumber As String = txtPhoneNumber.Text
        Dim vehicleNoPlate As String = txtVehicleNoPlate.Text
        Dim password As String = txtPassword.Text

        ' Check if the ICNumber already exists
        If ICNumberExists(icNumber) Then
            MessageBox.Show("IC Number already registered. Please use a different IC Number.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Insert the new user into the database
        If RegisterUser(name, icNumber, phoneNumber, vehicleNoPlate, password) Then
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Proceed to the login form
            Dim loginForm As New frmLogin()
            loginForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ICNumberExists(icNumber As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE ICNumber = ?"
        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("?", icNumber)
                connection.Open()
                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                connection.Close()
                Return result > 0
            End Using
        End Using
    End Function

    Private Function RegisterUser(name As String, icNumber As String, phoneNumber As String, vehicleNoPlate As String, password As String) As Boolean
        Dim query As String = "INSERT INTO Users (Name, ICNumber, PhoneNumber, VehicleNoPlate, Password) VALUES (?, ?, ?, ?, ?)"
        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("?", name)
                command.Parameters.AddWithValue("?", icNumber)
                command.Parameters.AddWithValue("?", phoneNumber)
                command.Parameters.AddWithValue("?", vehicleNoPlate)
                command.Parameters.AddWithValue("?", password)
                connection.Open()
                Dim result As Integer = command.ExecuteNonQuery()
                connection.Close()
                Return result > 0
            End Using
        End Using
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
