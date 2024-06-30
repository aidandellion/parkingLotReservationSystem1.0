﻿Public Class frmReservationUser

    Private ToolTip1 As New ToolTip()
    Private Sub frmReservationUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize parking spaces
        InitializeParkingSpace(Panel2, "BS01", True)
        InitializeParkingSpace(Panel3, "BS02", True)
        InitializeParkingSpace(Panel4, "BS03", False) ' Not available
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