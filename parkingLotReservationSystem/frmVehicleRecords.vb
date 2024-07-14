Imports System.Data.Odbc

Public Class frmVehicleRecords
    ' Connection string for ODBC DSN
    Private connectionString As String = "DSN=parkinglotreservationsystemdb;"

    ' Create a DataTable to hold the vehicle data
    Private vehicleTable As DataTable

    Private Sub frmVehicleRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load vehicle data from the database
        LoadVehicleData()

        ' Populate the ListView with vehicle data
        PopulateListView(vehicleTable)
    End Sub

    Private Sub LoadVehicleData()
        vehicleTable = New DataTable()

        ' Define your SQL query with correct join syntax
        Dim query As String = "SELECT B.bookingId, U.fullName AS OwnerName, U.vehicleNo AS VehicleNumber, B.dateTimeStart AS EntryDate, B.dateTimeEnd AS ExitDate " &
                              "FROM users U INNER JOIN booking B ON U.userId = B.userId " &
                              "ORDER BY B.dateTimeStart DESC" ' Order by EntryDate in descending order

        ' Use OdbcConnection and OdbcDataAdapter to fetch the data
        Try
            Using connection As New OdbcConnection(connectionString)
                Using adapter As New OdbcDataAdapter(query, connection)
                    ' Fill the DataTable with the data
                    adapter.Fill(vehicleTable)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub PopulateListView(dt As DataTable)
        lvVehicleRecords.Items.Clear()

        For Each row As DataRow In dt.Rows
            Dim item As New ListViewItem(row("OwnerName").ToString())
            item.SubItems.Add(row("VehicleNumber").ToString())
            item.SubItems.Add(row("EntryDate").ToString())
            item.SubItems.Add(row("ExitDate").ToString())
            item.SubItems.Add("View Receipt")
            item.SubItems.Add("Delete")
            item.Tag = row("bookingId") ' Store bookingId in the tag
            lvVehicleRecords.Items.Add(item)
        Next
    End Sub


    'Private Sub btnSearch_Click(sender As Object, e As EventArgs)
    '    ' Filter the DataTable based on the search text
    '    Dim filterText As String = txtSearch.Text.Trim().ToLower()
    '    Dim filteredRows = vehicleTable.AsEnumerable().Where(Function(row) row("OwnerName").ToString().ToLower().Contains(filterText) OrElse
    '                                                           row("VehicleNumber").ToString().ToLower().Contains(filterText) OrElse
    '                                                           row("EntryDate").ToString().ToLower().Contains(filterText) OrElse
    '                                                           row("ExitDate").ToString().ToLower().Contains(filterText))

    '    Dim filteredTable As DataTable = vehicleTable.Clone()
    '    For Each row In filteredRows
    '        filteredTable.ImportRow(row)
    '    Next

    '    ' Populate the ListView with filtered data
    '    PopulateListView(filteredTable)
    'End Sub

    Private Sub lvVehicleRecords_MouseClick(sender As Object, e As MouseEventArgs) Handles lvVehicleRecords.MouseClick
        Dim info As ListViewHitTestInfo = lvVehicleRecords.HitTest(e.X, e.Y)
        Dim subItem As ListViewItem.ListViewSubItem = info.SubItem

        If subItem IsNot Nothing Then
            If subItem.Text = "Delete" Then
                ' Confirm deletion
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    ' Delete the record from the database
                    DeleteRecord(info.Item)
                    ' Reload data and refresh the ListView
                    LoadVehicleData()
                    PopulateListView(vehicleTable)
                End If
            ElseIf subItem.Text = "View Receipt" Then
                ' Open the receipt form
                ViewReceipt(info.Item)
            End If
        End If
    End Sub

    Private Sub DeleteRecord(item As ListViewItem)
        Dim bookingId As Integer = Convert.ToInt32(item.Tag) ' Retrieve bookingId from the tag
        Dim query As String = "DELETE FROM Booking WHERE bookingId = ?"

        Using connection As New OdbcConnection(connectionString)
            Using command As New OdbcCommand(query, connection)
                command.Parameters.AddWithValue("?", bookingId)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    Private Sub ViewReceipt(item As ListViewItem)
        ' Retrieve bookingId from the tag
        Dim bookingId As Integer = Convert.ToInt32(item.Tag)

        ' Open the receipt form and pass bookingId
        Using viewReceiptForm As New frmViewReciept(bookingId)
            viewReceiptForm.ShowDialog()
        End Using
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
End Class