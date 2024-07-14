Imports System.Data.Odbc
Imports System.Drawing

Public Class frmViewReciept
    ' Connection string for ODBC DSN
    Private connectionString As String = "DSN=parkinglotreservationsystemdb;"

    Public Sub New(bookingId As Integer)
        InitializeComponent()

        ' Retrieve receipt image path based on bookingId
        Dim receiptPath As String = GetReceiptImagePath(bookingId)

        ' Display the moved image in the PictureBoxReceipt
        If Not String.IsNullOrEmpty(receiptPath) AndAlso IO.File.Exists(receiptPath) Then
            PictureBoxReceipt.Image = Image.FromFile(receiptPath)
        Else
            MessageBox.Show("No receipt found for this booking.")
            Me.Close()
        End If
    End Sub

    ' Method to retrieve receipt image path based on bookingId
    Private Function GetReceiptImagePath(bookingId As Integer) As String
        Dim query As String = "SELECT receipt FROM booking WHERE bookingId = ?"
        Dim receiptPath As String = ""

        ' Get the base directory of the application
        Dim baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory

        Using connection As New OdbcConnection(connectionString)
            Using command As New OdbcCommand(query, connection)
                command.Parameters.AddWithValue("?", bookingId)
                connection.Open()
                Using reader As OdbcDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Example: Assuming 'receipt' is the column name storing the file path
                        ' Construct the full path to the receipt destination
                        Dim receiptDestination As String = IO.Path.Combine(baseDirectory, "payReceipt", reader("receipt").ToString())
                        receiptPath = receiptDestination
                    End If
                End Using
            End Using
        End Using

        ' You may need to adjust the return logic based on your actual receipt storage
        Return receiptPath
    End Function
End Class
