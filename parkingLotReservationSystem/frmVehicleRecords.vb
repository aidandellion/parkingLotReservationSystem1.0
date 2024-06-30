Imports System.Data.SqlClient

Public Class frmVehicleRecords
    ' Connection string to your database
    Private connectionString As String = "Your_Connection_String_Here"

    ' Create a DataTable to hold the vehicle data
    Private vehicleTable As DataTable

    Private Sub frmVehicleRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load vehicle data from the database
        LoadVehicleData()

        ' Populate the ListBoxes with vehicle data
        PopulateListBoxes(vehicleTable)
    End Sub

    Private Sub LoadVehicleData()
        vehicleTable = New DataTable()

        ' Define your SQL query
        Dim query As String = "SELECT U.fullName AS OwnerName, U.vehicleNoPlate AS VehicleNumber, B.dateTimeStart AS EntryDate, B.dateTimeEnd AS ExitDate " &
                              "FROM Users U " &
                              "INNER JOIN Booking B ON U.userId = B.userId " &
                              "INNER JOIN ParkingLot P ON B.bookId = P.bookId " &
                              "INNER JOIN Status S ON P.statusId = S.statusId " &
                              "WHERE S.statusName = 'Occupied'"

        ' Use SqlConnection and SqlDataAdapter to fetch the data
        'Using connection As New SqlConnection(connectionString)
        '    Using adapter As New SqlDataAdapter(query, connection)
        '        ' Fill the DataTable with the data
        '        adapter.Fill(vehicleTable)
        '    End Using
        'End Using
    End Sub

    Private Sub PopulateListBoxes(dt As DataTable)
        lstName.Items.Clear()
        lstPlate.Items.Clear()
        lstEntryDate.Items.Clear()
        lstExitDate.Items.Clear()

        For Each row As DataRow In dt.Rows
            lstName.Items.Add(row("OwnerName"))
            lstPlate.Items.Add(row("VehicleNumber"))
            lstEntryDate.Items.Add(row("EntryDate"))
            lstExitDate.Items.Add(row("ExitDate"))
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Filter the DataTable based on the search text
        Dim filterText As String = txtSearch.Text.Trim().ToLower()
        Dim filteredRows = vehicleTable.AsEnumerable().Where(Function(row) row("OwnerName").ToString().ToLower().Contains(filterText) OrElse
                                                               row("VehicleNumber").ToString().ToLower().Contains(filterText) OrElse
                                                               row("EntryDate").ToString().ToLower().Contains(filterText) OrElse
                                                               row("ExitDate").ToString().ToLower().Contains(filterText))

        Dim filteredTable As DataTable = vehicleTable.Clone()
        For Each row In filteredRows
            filteredTable.ImportRow(row)
        Next

        ' Populate the ListBoxes with filtered data
        PopulateListBoxes(filteredTable)
    End Sub

    Private Sub lstDeleteRecord_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDeleteRecord.SelectedIndexChanged
        ' Handle the delete record action
        Dim selectedIndex As Integer = lstDeleteRecord.SelectedIndex
        If selectedIndex >= 0 Then
            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ' Delete the record from the database
                DeleteRecord(selectedIndex)
                ' Reload data and refresh the ListBoxes
                LoadVehicleData()
                PopulateListBoxes(vehicleTable)
            End If
        End If
    End Sub

    Private Sub DeleteRecord(index As Integer)
        Dim ownerName As String = lstName.Items(index).ToString()
        Dim vehicleNumber As String = lstPlate.Items(index).ToString()
        Dim query As String = "DELETE FROM Booking WHERE userId = (SELECT userId FROM Users WHERE fullName = @OwnerName AND vehicleNoPlate = @VehicleNumber)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@OwnerName", ownerName)
                command.Parameters.AddWithValue("@VehicleNumber", vehicleNumber)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
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
        ' Perform log out action
        Dim frm As New frmLogin() ' Assuming you have a login form
        frm.Show()
        Me.Close()
    End Sub
End Class
