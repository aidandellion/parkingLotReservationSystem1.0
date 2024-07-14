Imports System.Data.Odbc

Public Class frmUserList
    ' Connection string to your Access database
    Private connectionString As String = "DSN=parkingLotReservationSystemDB"

    ' Create a DataTable to hold the user data
    Private userTable As DataTable

    Private Sub frmUserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load user data from the database
        LoadUserData()

        ' Populate the ListBoxes with user data
        PopulateListBoxes(userTable)
    End Sub

    Private Sub LoadUserData()
        userTable = New DataTable()

        ' Define your SQL query
        Dim query As String = "SELECT fullName, vehicleNo, icNo, phoneNo FROM Users"

        ' Use OdbcConnection and OdbcDataAdapter to fetch the data
        Using connection As New OdbcConnection(connectionString)
            Using adapter As New OdbcDataAdapter(query, connection)
                ' Fill the DataTable with the data
                adapter.Fill(userTable)
            End Using
        End Using
    End Sub

    Private Sub PopulateListBoxes(dt As DataTable)
        lstName.Items.Clear()
        lstPlate.Items.Clear()
        lstIC.Items.Clear()
        lstPhone.Items.Clear()

        For Each row As DataRow In dt.Rows
            lstName.Items.Add(row("fullName"))
            lstPlate.Items.Add(row("vehicleNo"))
            lstIC.Items.Add(row("icNo"))
            lstPhone.Items.Add(row("phoneNo"))
        Next
    End Sub

    'Private Sub btnSearch_Click(sender As Object, e As EventArgs)
    '    ' Filter the DataTable based on the search text
    '    Dim filterText As String = txtSearch.Text.Trim().ToLower()
    '    Dim filteredRows = userTable.AsEnumerable().Where(Function(row) row("fullName").ToString().ToLower().Contains(filterText) OrElse
    '                                                       row("vehicleNo").ToString().ToLower().Contains(filterText) OrElse
    '                                                       row("icNo").ToString().ToLower().Contains(filterText) OrElse
    '                                                       row("phoneNo").ToString().ToLower().Contains(filterText))

    '    Dim filteredTable As DataTable = userTable.Clone()
    '    For Each row In filteredRows
    '        filteredTable.ImportRow(row)
    '    Next

    '    ' Populate the ListBoxes with filtered data
    '    PopulateListBoxes(filteredTable)
    'End Sub

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
End Class