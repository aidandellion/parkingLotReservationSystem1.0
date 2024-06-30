Public Class frmReservationAdmin

    Private ToolTip1 As New ToolTip()

    Private Sub frmReservationAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize parking spaces
        InitializeParkingSpace(Panel4, "BS01", True)
        InitializeParkingSpace(Panel2, "BS02", True)
        InitializeParkingSpace(Panel3, "BS03", False) ' Not available
        ' Add more panels as needed
    End Sub

    ' Method to initialize a parking space panel
    Private Sub InitializeParkingSpace(panel As Panel, label As String, isAvailable As Boolean)
        SetPanelColor(panel, isAvailable)
        AddLabelToPanel(panel, label)
        ToolTip1.SetToolTip(panel, If(isAvailable, "Available", "Not Available"))
    End Sub

    ' Method to set the color of a panel
    Private Sub SetPanelColor(panel As Panel, isAvailable As Boolean)
        If isAvailable Then
            panel.BackColor = Color.White
        Else
            panel.BackColor = Color.Red
        End If
    End Sub

    ' Method to add a label to a panel
    Private Sub AddLabelToPanel(panel As Panel, text As String)
        Dim lbl As New Label()
        lbl.Text = text
        lbl.AutoSize = True
        lbl.Location = New Point(panel.Width / 2 - lbl.Width / 2, panel.Height / 2 - lbl.Height / 2)
        panel.Controls.Add(lbl)
    End Sub


    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        ' Show reservation section or perform actions related to reservations
        Dim frm As New frmReservationAdmin()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnVehicleRecords_Click(sender As Object, e As EventArgs) Handles btnVehicleRecords.Click
        ' Show vehicle records section or perform actions related to vehicle records
        Dim frm As New frmVehicleRecords()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        ' Show users section or perform actions related to users
        Dim frm As New frmUserList()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        ' Perform log out action
        Dim frm As New frmLogin() ' Assuming you have a login form
        frm.Show()
        Me.Close()
    End Sub
End Class