Imports System.Data.Odbc
Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmReservationUser

    Private isPaymentSubmitted As Boolean = True
    Dim userId As Integer = GlobalVariables.loggedInUserId
    Dim startTime As DateTime = DateTime.Now
    Dim endTime As DateTime = DateTime.Now
    Dim formattedStartTime As String = startTime.ToString("yyyy-MM-dd H:mm:ss")
    Dim formattedEndTime As String = endTime.ToString("yyyy-MM-dd H:mm:ss")

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

    Private Sub btnPark_Click(sender As Object, e As EventArgs) Handles btnPark.Click
        ' Check if a parking lot code is selected
        If cmbParkingLotCode.SelectedItem IsNot Nothing Then
            isPaymentSubmitted = False
            SetControlState(False)
            Dim selectedParkingCode As String = cmbParkingLotCode.SelectedItem.ToString()
            Dim connectionString As String = "dsn=parkinglotreservationsystemdb;"
            Dim updateQuery As String = "UPDATE parkinglot SET statusId = 1 WHERE parkingCode = ? AND statusId = 2"

            ' Save start time
            startTime = DateTime.Now ' Current date and time
            formattedStartTime = startTime.ToString("yyyy-MM-dd H:mm:ss")

            Using connection As New OdbcConnection(connectionString)
                Dim command As New OdbcCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@parkingCode", selectedParkingCode)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Parking lot " & selectedParkingCode & " has been successfully updated to occupied.")
                        lblEntryDate.Text = formattedStartTime

                        ' Optionally, you can update the UI here to reflect the change
                        ReloadDataAndUpdateUI()
                    Else
                        MessageBox.Show("Failed to update parking lot " & selectedParkingCode)
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred while updating parking lot status: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please select a parking lot code.")
        End If
    End Sub

    Private Sub btnVacate_Click(sender As Object, e As EventArgs) Handles btnVacate.Click
        ' Check if a parking lot code is selected
        If cmbParkingLotCode.SelectedItem IsNot Nothing Then
            Dim selectedParkingCode As String = cmbParkingLotCode.SelectedItem.ToString()
            Dim connectionString As String = "dsn=parkinglotreservationsystemdb;"
            Dim updateQuery As String = "UPDATE parkinglot SET statusId = 2 WHERE parkingCode = ? AND statusId = 1"

            ' Save end time
            endTime = DateTime.Now ' Current date and time
            formattedEndTime = endTime.ToString("yyyy-MM-dd H:mm:ss")

            ' Create the payment form
            Dim paymentForm As New frmPayment()
            paymentForm.ParkingCode = selectedParkingCode
            paymentForm.Duration = (endTime - startTime).TotalHours
            paymentForm.TotalPayment = paymentForm.Duration * 0.2

            ' Handle the PaymentSubmitted event
            AddHandler paymentForm.PaymentSubmitted, AddressOf OnPaymentSubmitted

            ' Show the payment form
            paymentForm.ShowDialog()
        Else
            MessageBox.Show("Please select a parking lot code.")
        End If
    End Sub

    Private Sub OnPaymentSubmitted(sender As Object, e As EventArgs)
        Dim selectedParkingCode As String = cmbParkingLotCode.SelectedItem.ToString()
        Dim connectionString As String = "dsn=parkinglotreservationsystemdb;"
        Dim updateQuery As String = "UPDATE parkinglot SET statusId = 2 WHERE parkingCode = ? AND statusId = 1"

        Using connection As New OdbcConnection(connectionString)
            Dim command As New OdbcCommand(updateQuery, connection)
            command.Parameters.AddWithValue("@parkingCode", selectedParkingCode)

            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Parking lot " & selectedParkingCode & " has been successfully vacated.")

                    lblExitDate.Text = formattedEndTime

                    ' Optionally, you can update the UI here to reflect the change
                    ReloadDataAndUpdateUI()

                    ' Save the booking information
                    SaveBookingInformation(formattedStartTime, formattedEndTime, selectedParkingCode, userId)

                    ' Show the reset button
                    btnReset.Visible = True

                    ' Set payment submitted flag to true
                    isPaymentSubmitted = True

                    ' Enable the controls
                    SetControlState(True)
                Else
                    MessageBox.Show("Failed to vacate parking lot " & selectedParkingCode)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while vacating parking lot: " & ex.Message)
            End Try
        End Using
    End Sub


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        btnReset.Visible = False ' Initially hide the reset button
    End Sub

    Private Sub SetControlState(isEnabled As Boolean)
        For Each ctrl As Control In Me.Controls
            If Not (TypeOf ctrl Is Button AndAlso ctrl.Name = "btnVacate") Then
                ctrl.Enabled = isEnabled
            End If
        Next
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cmbParkingLotCode.SelectedIndex = -1
        lblEntryDate.Text = "-"
        lblExitDate.Text = "-"
        btnReset.Visible = False
    End Sub

    ' Method to save booking information to the booking table
    Private Sub SaveBookingInformation(startTime As DateTime, endTime As DateTime, parkingCode As String, userId As Integer)
        Dim connectionString As String = "dsn=parkinglotreservationsystemdb;"
        Dim insertQuery As String = "INSERT INTO booking (dateTimeStart, dateTimeEnd, parkingId, userId, receipt) VALUES (?, ?, ?, ?, ?)"

        Using connection As New OdbcConnection(connectionString)
            Dim command As New OdbcCommand(insertQuery, connection)
            command.Parameters.AddWithValue("@dateTimeStart", formattedStartTime)
            command.Parameters.AddWithValue("@dateTimeEnd", formattedEndTime)
            ' Assuming parkingId can be retrieved based on parkingCode from a query
            command.Parameters.AddWithValue("@parkingId", GetParkingIdFromCode(parkingCode))
            command.Parameters.AddWithValue("@userId", userId)
            command.Parameters.AddWithValue("@receipt", receiptLocation)

            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Booking information saved successfully.")
                Else
                    MessageBox.Show("Failed to save booking information.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while saving booking information: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to retrieve parkingId from parkingCode
    Private Function GetParkingIdFromCode(parkingCode As String) As Integer
        Dim connectionString As String = "dsn=parkinglotreservationsystemdb;"
        ' SQL query to get user type
        Dim query As String = "SELECT parkingId FROM parkinglot WHERE parkingCode = ?"
        ' Create a connection and command
        Using connection As New OdbcConnection(connectionString)
            Using command As New OdbcCommand(query, connection)
                ' Add parameters to the command
                command.Parameters.AddWithValue("?", parkingCode)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                connection.Close()
                Return Convert.ToInt32(result)
            End Using
        End Using
        Dim parkingId As Integer = 0 ' Initialize with appropriate default or query result
        ' Implement your database query here to get parkingId

        Return parkingId
    End Function


    ' Example method to reload data from database and update UI
    Private Sub ReloadDataAndUpdateUI()
        ' Assuming you have a method to reload data from database
        InitializeParkingSpacesFromDatabase()
        InitializeCmbParkingLotCode()

        ' Optionally update any other controls or UI elements
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
        If isPaymentSubmitted Then
            Dim frm As New frmProfile()
            frm.Show()
            Me.Close()
        Else
            MessageBox.Show("Please complete the payment before proceeding.")
        End If
    End Sub

    Private Sub frmReservationUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not isPaymentSubmitted Then
            MessageBox.Show("Please complete the payment before closing the application.")
            e.Cancel = True
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