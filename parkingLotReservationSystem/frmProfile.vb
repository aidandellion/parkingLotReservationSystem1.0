Public Class frmProfile
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim name As String = txtName.Text
        Dim icNumber As String = txtIC.Text
        Dim phoneNumber As String = txtPhone.Text
        Dim vehicleNumber As String = txtPlate.Text

        ' Handle the updated profile information here
        ' For now, we'll just show a message box
        MessageBox.Show("Name: " & name & vbCrLf &
                    "IC Number: " & icNumber & vbCrLf &
                    "Phone Number: " & phoneNumber & vbCrLf &
                    "Vehicle Number Plate: " & vehicleNumber,
                    "Profile Updated")
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Perform log out action
        Dim frm As New frmLogin() ' Assuming you have a login form
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        ' Show reservation section or perform actions related to reservations
        Dim frm As New frmReservationUser()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim frm As New frmProfile()
        frm.Show()
        Me.Close()
    End Sub

End Class

