Imports System.Data.Odbc

Public Class frmReceipt

    Dim userId As Integer = GlobalVariables.loggedInUserId
    Private Sub frmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dates As Tuple(Of DateTime, DateTime) = GetEntryExitDate(userId)

        If dates IsNot Nothing Then
            Dim entryDate As DateTime = dates.Item1
            Dim exitDate As DateTime = dates.Item2

            ' Use entryDate and exitDate as needed
            lblEntryDate.Text = entryDate.ToString()
            lblExitDate.Text = exitDate.ToString()
        Else
            Console.WriteLine("No booking found for userId: " & userId)
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Capture the form as a bitmap
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))

        ' Draw the bitmap on the print document
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub
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
            lblDuration.Text = value.ToString("F2") & " hour(s)"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Show the print preview dialog
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    ' Method to retrieve parkingId from parkingCode
    Private Function GetEntryExitDate(userId As Integer) As Tuple(Of DateTime, DateTime)
        Dim connectionString As String = "dsn=parkinglotreservationsystemdb;"
        Dim query As String = "SELECT TOP 1 dateTimeStart, dateTimeEnd FROM booking WHERE userId = ? ORDER BY bookingId DESC"

        Using connection As New OdbcConnection(connectionString)
            Using command As New OdbcCommand(query, connection)
                command.Parameters.AddWithValue("?", userId)
                connection.Open()
                Dim reader As OdbcDataReader = command.ExecuteReader()

                If reader.Read() Then
                    Dim dateTimeStart As DateTime = Convert.ToDateTime(reader("dateTimeStart"))
                    Dim dateTimeEnd As DateTime = Convert.ToDateTime(reader("dateTimeEnd"))
                    connection.Close()
                    Return New Tuple(Of DateTime, DateTime)(dateTimeStart, dateTimeEnd)
                Else
                    ' Handle case where no booking is found
                    connection.Close()
                    Return Nothing ' Or handle default values or error condition
                End If
            End Using
        End Using
    End Function

End Class