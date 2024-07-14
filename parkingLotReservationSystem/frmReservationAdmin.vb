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

    ' Method to initialize combo box parking lot code
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

                    ' Add the item to cmbParkingLotCode
                    cmbParkingLotCode.Items.Add(parkingCode)
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("An error occurred while initializing parking lot code combo box: " & ex.Message)
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
        ' Optionally, you can update the UI here to reflect the change
        ReloadDataAndUpdateUI()
    End Sub

    ' Example method to reload data from database and update UI
    Private Sub ReloadDataAndUpdateUI()
        ' Assuming you have a method to reload data from database
        InitializeParkingSpacesFromDatabase()
        InitializeCmbParkingLotCode()

        ' Optionally update any other controls or UI elements
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
        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' Perform log out action
            Dim frm As New frmLogin() ' Assuming you have a login form
            frm.Show()
            Me.Close()
        End If
    End Sub

    ' Add individual click event handlers for each parking lot code label
    Private Sub lblParkingCode1_Click(sender As Object, e As EventArgs) Handles lblParkingCode1.Click
        If cmbParkingLotCode.Items.Contains("BS01") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS01")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode2_Click(sender As Object, e As EventArgs) Handles lblParkingCode2.Click
        If cmbParkingLotCode.Items.Contains("BS02") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS02")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode3_Click(sender As Object, e As EventArgs) Handles lblParkingCode3.Click
        If cmbParkingLotCode.Items.Contains("BS03") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS03")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode4_Click(sender As Object, e As EventArgs) Handles lblParkingCode4.Click
        If cmbParkingLotCode.Items.Contains("BS04") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS04")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode5_Click(sender As Object, e As EventArgs) Handles lblParkingCode5.Click
        If cmbParkingLotCode.Items.Contains("BS05") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS05")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode6_Click(sender As Object, e As EventArgs) Handles lblParkingCode6.Click
        If cmbParkingLotCode.Items.Contains("BS06") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS06")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode7_Click(sender As Object, e As EventArgs) Handles lblParkingCode7.Click
        If cmbParkingLotCode.Items.Contains("BS07") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS07")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode8_Click(sender As Object, e As EventArgs) Handles lblParkingCode8.Click
        If cmbParkingLotCode.Items.Contains("BS08") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS08")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode9_Click(sender As Object, e As EventArgs) Handles lblParkingCode9.Click
        If cmbParkingLotCode.Items.Contains("BS09") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS09")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode10_Click(sender As Object, e As EventArgs) Handles lblParkingCode10.Click
        If cmbParkingLotCode.Items.Contains("BS10") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS10")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode11_Click(sender As Object, e As EventArgs) Handles lblParkingCode11.Click
        If cmbParkingLotCode.Items.Contains("BS11") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS11")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode12_Click(sender As Object, e As EventArgs) Handles lblParkingCode12.Click
        If cmbParkingLotCode.Items.Contains("BS12") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS12")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode13_Click(sender As Object, e As EventArgs) Handles lblParkingCode13.Click
        If cmbParkingLotCode.Items.Contains("BS13") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS13")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode14_Click(sender As Object, e As EventArgs) Handles lblParkingCode14.Click
        If cmbParkingLotCode.Items.Contains("BS14") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS14")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode15_Click(sender As Object, e As EventArgs) Handles lblParkingCode15.Click
        If cmbParkingLotCode.Items.Contains("BS15") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS15")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode16_Click(sender As Object, e As EventArgs) Handles lblParkingCode16.Click
        If cmbParkingLotCode.Items.Contains("BS16") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS16")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode17_Click(sender As Object, e As EventArgs) Handles lblParkingCode17.Click
        If cmbParkingLotCode.Items.Contains("BS17") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS17")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode18_Click(sender As Object, e As EventArgs) Handles lblParkingCode18.Click
        If cmbParkingLotCode.Items.Contains("BS18") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS18")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode19_Click(sender As Object, e As EventArgs) Handles lblParkingCode19.Click
        If cmbParkingLotCode.Items.Contains("BS19") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS19")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode20_Click(sender As Object, e As EventArgs) Handles lblParkingCode20.Click
        If cmbParkingLotCode.Items.Contains("BS20") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS20")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode21_Click(sender As Object, e As EventArgs) Handles lblParkingCode21.Click
        If cmbParkingLotCode.Items.Contains("BS21") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS21")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode22_Click(sender As Object, e As EventArgs) Handles lblParkingCode22.Click
        If cmbParkingLotCode.Items.Contains("BS22") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS22")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode23_Click(sender As Object, e As EventArgs) Handles lblParkingCode23.Click
        If cmbParkingLotCode.Items.Contains("BS23") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS23")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub lblParkingCode24_Click(sender As Object, e As EventArgs) Handles lblParkingCode24.Click
        If cmbParkingLotCode.Items.Contains("BS24") Then
            cmbParkingLotCode.SelectedIndex = cmbParkingLotCode.FindStringExact("BS24")
        Else
            cmbParkingLotCode.SelectedIndex = -1
        End If
    End Sub
End Class
