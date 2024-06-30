Imports System.Data.Odbc

Public Class frmReservationAdmin
    Private Sub frmReservationAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize parking spaces
        InitializeParkingSpacesFromDatabase()

        ' Initialize combo box parking lot code
        InitializeCmbParkingLotCode()

        ' Initialize combo box status
        InitializeCmbStatus()

        ' Add event handler for cmbParkingLotCode SelectedIndexChanged
        AddHandler cmbParkingLotCode.SelectedIndexChanged, AddressOf cmbParkingLotCode_SelectedIndexChanged
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

    ' Method to initialize combo box status
    Private Sub InitializeCmbStatus()
        Dim connectionString As String = "dsn=parkinglotreservationsystemdb;"
        Dim query As String = "SELECT statusId, statusName FROM status"

        Using connection As New OdbcConnection(connectionString)
            Dim command As New OdbcCommand(query, connection)

            Try
                connection.Open()
                Dim reader As OdbcDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim statusName As String = reader("statusName").ToString()

                    ' Add the item to cmbStatus
                    cmbStatus.Items.Add(statusName)
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("An error occurred while initializing status combo box: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Event handler for cmbParkingLotCode SelectedIndexChanged
    Private Sub cmbParkingLotCode_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' Retrieve selected parking lot code
        Dim selectedParkingCode As String = cmbParkingLotCode.SelectedItem.ToString() ' Replace with actual logic to get parking code

        ' Query to retrieve statusId for the selected parking code
        Dim connectionString As String = "dsn=parkinglotreservationsystemdb;"
        Dim query As String = $"SELECT statusId FROM parkinglot WHERE parkingCode = '{selectedParkingCode}'"

        Using connection As New OdbcConnection(connectionString)
            Dim command As New OdbcCommand(query, connection)

            Try
                connection.Open()
                Dim statusId As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' Set the default selected item in cmbStatus based on statusId
                Select Case statusId
                    Case 1
                        cmbStatus.SelectedIndex = cmbStatus.FindStringExact("Occupied")
                    Case 2
                        cmbStatus.SelectedIndex = cmbStatus.FindStringExact("Unoccupied")
                    Case Else
                        cmbStatus.SelectedIndex = -1 ' No default selection
                End Select
            Catch ex As Exception
                MessageBox.Show("An error occurred while retrieving status: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
        If cmbStatus.SelectedItem IsNot Nothing AndAlso cmbParkingLotCode.SelectedItem IsNot Nothing Then
            Dim selectedStatusName As String = cmbStatus.SelectedItem.ToString()
            Dim selectedParkingCode As String = cmbParkingLotCode.SelectedItem.ToString() ' Replace with actual logic to get parking code
            Dim selectedStatus As Integer = 2

            If selectedStatusName = "Occupied" Then
                selectedStatus = 1
            Else
                selectedStatus = 2
            End If

            ' Extract the numeric part from the parking code
            Dim numericPart As String = selectedParkingCode.Substring(2) ' Assuming the numeric part starts at index 2

            ' Convert the numeric part to an integer to get the parkingId
            Dim parkingId As Integer = Integer.Parse(numericPart)

            Dim connectionString As String = "dsn=parkinglotreservationsystemdb;"
            Dim query As String = $"UPDATE parkinglot SET statusId = {selectedStatus} WHERE parkingId = {parkingId}"

            Using connection As New OdbcConnection(connectionString)
                Dim command As New OdbcCommand(query, connection)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Parking lot status updated successfully.")
                Catch ex As Exception
                    MessageBox.Show("An error occurred while updating parking lot status: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please select a status and parking lot code.")
        End If

        ' After updating, refresh the form
        Dim frm As New frmReservationAdmin()
        frm.Show()
        Me.Hide()
    End Sub




    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        ' Show admin section or perform actions related to admin
        MessageBox.Show("Admin selected")
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
