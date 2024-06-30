Imports System.Data.Odbc

Public Class frmReservationUser

    Private ToolTip1 As New ToolTip()
    Private Sub frmReservationUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize parking spaces
        InitializeParkingSpacesFromDatabase()

        ' Initialize combo box parking lot code
        InitializeCmbParkingLotCode()
    End Sub

    ' Method to initialize parking spaces from the ODBC database
    Private Sub InitializeParkingSpacesFromDatabase()
        Dim connectionString As String = "dsn=parkinglotreservationsystemdb;"
        Dim query As String = "SELECT parkingId, statusId FROM parkinglot"

        Using connection As New OdbcConnection(connectionString)
            Dim command As New OdbcCommand(query, connection)

            Try
                connection.Open()
                Dim reader As OdbcDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim parkingId As String = reader("parkingId").ToString()
                    Dim statusId As Integer = Convert.ToInt32(reader("statusId"))

                    ' Find the panel by parking code (assuming panel names are Panel1, Panel2, etc.)
                    Dim panel As Panel = Me.Controls.Find("Panel" & (parkingId + 1), True).FirstOrDefault()

                    If panel IsNot Nothing Then
                        InitializeParkingSpace(panel, statusId)
                    End If
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("An error occurred while initializing parking spaces: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to initialize a parking space panel
    Private Sub InitializeParkingSpace(panel As Panel, statusId As Integer)
        SetPanelColor(panel, statusId)
    End Sub

    ' Method to set the color of a panel based on statusId
    Private Sub SetPanelColor(panel As Panel, statusId As Integer)
        If statusId = 2 Then
            panel.BackColor = Color.White
        Else
            panel.BackColor = Color.Red
        End If
    End Sub

    ' Method to initialize combo box parking lot codef
    Private Sub InitializeCmbParkingLotCode()
        Dim connectionString As String = "dsn=parkinglotreservationsystemdb;"
        Dim query As String = "SELECT parkingCode FROM parkinglot"

        Using connection As New OdbcConnection(connectionString)
            Dim command As New OdbcCommand(query, connection)

            Try
                connection.Open()
                Dim reader As OdbcDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim parkingCode As String = reader("parkingCode").ToString()

                    ' Add the item to cmbStatus
                    cmbParkingLotCode.Items.Add(parkingCode)
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("An error occurred while initializing status combo box: " & ex.Message)
            End Try
        End Using
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