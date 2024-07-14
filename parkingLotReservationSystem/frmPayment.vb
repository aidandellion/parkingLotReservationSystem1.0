Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO

Public Class frmPayment
    ' Declare the event
    Public Event PaymentSubmitted As EventHandler

    Public Property ParkingCode As String
        Get
            Return lblParkingLot.Text
        End Get
        Set(value As String)
            lblParkingLot.Text = value
        End Set
    End Property

    Public Property Duration As Double
        Get
            Return Double.Parse(lblDuration.Text)
        End Get
        Set(value As Double)
            lblDuration.Text = value.ToString("F2")
        End Set
    End Property

    Public Property TotalPayment As Double
        Get
            Return Double.Parse(lblPayment.Text)
        End Get
        Set(value As Double)
            lblPayment.Text = value.ToString("F2")
        End Set
    End Property

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' No need to initialize parking spaces or combo box here
    End Sub

    Private Sub btnUploadReceipt_Click(sender As Object, e As EventArgs) Handles btnUploadReceipt.Click
        ' Configure the OpenFileDialog
        OpenFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png"
        OpenFileDialog1.Title = "Select an Image"
        ' Show the OpenFileDialog
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Display the selected image name in the lblFIleName
            lblFileName.Text = Path.GetFileName(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim bookingId As Integer = GetBookingId(GlobalVariables.loggedInUserId) + 1

        ' Check if a receipt file is selected
        If OpenFileDialog1.FileName = "" Then
            MessageBox.Show("Please upload a receipt file.")
            Return
        End If

        ' Handle file upload and database insertion
        Try
            ' Upload the file to a specific folder
            Dim fileName As String = Path.GetFileName(OpenFileDialog1.FileName)
            Dim fileExtension As String = Path.GetExtension(fileName).ToLower()
            Dim allowedExtensions As String() = {".jpg", ".jpeg", ".png"}

            If Not allowedExtensions.Contains(fileExtension) Then
                MessageBox.Show("Only JPG, JPEG, and PNG files are allowed.")
                Return
            End If

            ' Get the base directory of the application
            Dim baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory

            Dim receiptDir As String = IO.Path.Combine(baseDirectory, "payReceipt")

            ' Check if the directory exists, if not, create it
            If Not IO.Directory.Exists(receiptDir) Then
                IO.Directory.CreateDirectory(receiptDir)
            End If

            ' Construct the full path to the receipt destination
            Dim receiptDestination As String = IO.Path.Combine(baseDirectory, "payReceipt", bookingId & fileExtension)

            ' Print the destination to verify
            Console.WriteLine(receiptDestination)
            'MessageBox.Show("Destination Path: " & receiptDestination) ' Add this line for debugging

            ' Move the uploaded file to the destination folder
            File.Copy(OpenFileDialog1.FileName, receiptDestination)

            ' Pass file location stored into frmReservationUser insert in database
            GlobalVariables.receiptLocation = bookingId & fileExtension

            ''Display the moved image in the PictureBox
            'PictureBox1.Image = Image.FromFile(receiptDestination)

            ' Raise the PaymentSubmitted event
            RaiseEvent PaymentSubmitted(Me, EventArgs.Empty)
            Dim receiptForm As New frmReceipt()
            receiptForm.ParkingCode = ParkingCode
            receiptForm.Duration = Duration
            receiptForm.TotalPayment = TotalPayment
            Me.Close()

            ' Show the receipt form
            receiptForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Error uploading receipt: " & ex.Message)
        End Try
    End Sub

    ' Method to retrieve bookingId from parkingCode
    Private Function GetBookingId(userId As Integer) As Integer
        Dim connectionString As String = "dsn=parkinglotreservationsystemdb;"
        Dim query As String = "SELECT TOP 1 bookingId FROM booking WHERE userId = ? ORDER BY bookingId DESC"

        Using connection As New OdbcConnection(connectionString)
            Using command As New OdbcCommand(query, connection)
                command.Parameters.AddWithValue("?", userId)
                connection.Open()
                Dim reader As OdbcDataReader = command.ExecuteReader()

                If reader.Read() Then
                    Dim bookingId As Integer = Convert.ToInt32(reader("bookingId"))
                    connection.Close()
                    Return bookingId
                Else
                    ' Handle case where no booking is found
                    connection.Close()
                    Return Nothing ' Or handle default values or error condition
                End If
            End Using
        End Using
    End Function


End Class
