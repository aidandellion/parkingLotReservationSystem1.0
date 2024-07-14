
Imports System.Data.Odbc

Public Class frmProfile
    ' Connection string to your Access database
    Private connectionString As String = "DSN=parkingLotReservationSystemDB"

    Private userId As Integer = GlobalVariables.loggedInUserId

    Private Sub frmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load user data from the database
        LoadUserData()
    End Sub

    Private Sub LoadUserData()
        ' Define your SQL query for fetching the user profile with positional parameters
        Dim query As String = "SELECT fullName, icNo, phoneNo, vehicleNo FROM Users WHERE userId = ?"

        ' Use OdbcConnection and OdbcCommand to fetch the data
        Using connection As New OdbcConnection(connectionString)
            Using command As New OdbcCommand(query, connection)
                command.Parameters.AddWithValue("?", userId)

                ' Open the connection
                connection.Open()

                ' Execute the query and read the data
                Using reader As OdbcDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        txtName.Text = reader("fullName").ToString()
                        txtIC.Text = reader("icNo").ToString()
                        txtPhone.Text = reader("phoneNo").ToString()
                        txtPlate.Text = reader("vehicleNo").ToString()
                    End If
                End Using

                ' Close the connection
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim fullName As String = txtName.Text
        Dim icNo As String = txtIC.Text
        Dim phoneNo As String = txtPhone.Text
        Dim vehicleNo As String = txtPlate.Text

        ' Handle the updated profile information here
        UpdateProfile(fullName, icNo, phoneNo, vehicleNo)
    End Sub

    Private Sub UpdateProfile(fullName As String, icNo As String, phoneNo As String, vehicleNo As String)
        ' Define your SQL query for updating the profile with positional parameters
        Dim query As String = "UPDATE Users SET fullName = ?, icNo = ?, phoneNo = ?, vehicleNo = ? WHERE userId = ?"

        ' Use OdbcConnection and OdbcCommand to execute the query
        Using connection As New OdbcConnection(connectionString)
            Using command As New OdbcCommand(query, connection)
                command.Parameters.AddWithValue("?", fullName)
                command.Parameters.AddWithValue("?", icNo)
                command.Parameters.AddWithValue("?", phoneNo)
                command.Parameters.AddWithValue("?", vehicleNo)
                command.Parameters.AddWithValue("?", userId)

                ' Open the connection and execute the query
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                connection.Close()

                ' Show a message box to confirm the update
                If rowsAffected > 0 Then
                    MessageBox.Show("Profile Updated Successfully", "Success")
                Else
                    MessageBox.Show("Profile Update Failed", "Error")
                End If
            End Using
        End Using
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' Perform log out action
            Dim frm As New frmLogin() ' Assuming you have a login form
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        ' Show reservation section or perform actions related to reservations
        Dim frm As New frmReservationUser()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ' Refresh the current profile form
        Dim frm As New frmProfile()
        frm.Show()
        Me.Close()
    End Sub
End Class