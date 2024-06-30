Imports System.Data.SqlClient

Public Class frmUserList
    ' Connection string to your database
    Private connectionString As String = "Your_Connection_String_Here"

    ' Create a DataTable to hold the user data
    Private userTable As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load user data from the database
        LoadUserData()

        ' Populate the ListBoxes with user data
        PopulateListBoxes(userTable)
    End Sub

    Private Sub LoadUserData()
        userTable = New DataTable()

        ' Define your SQL query
        Dim query As String = "SELECT OwnerName, VehicleNumber, ICNumber, PhoneNumber FROM Users"

        ' Use SqlConnection and SqlDataAdapter to fetch the data
        'Using connection As New SqlConnection(connectionString)
        '    Using adapter As New SqlDataAdapter(query, connection)
        '        ' Fill the DataTable with the data
        '        adapter.Fill(userTable)
        '    End Using
        'End Using
    End Sub

    Private Sub PopulateListBoxes(dt As DataTable)
        lstName.Items.Clear()
        lstPlate.Items.Clear()
        lstIC.Items.Clear()
        lstPhone.Items.Clear()

        For Each row As DataRow In dt.Rows
            lstName.Items.Add(row("OwnerName"))
            lstPlate.Items.Add(row("VehicleNumber"))
            lstIC.Items.Add(row("ICNumber"))
            lstPhone.Items.Add(row("PhoneNumber"))
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        ' Filter the DataTable based on the search text
        Dim filterText As String = txtSearch.Text.Trim().ToLower()
        Dim filteredRows = userTable.AsEnumerable().Where(Function(row) row("OwnerName").ToString().ToLower().Contains(filterText) OrElse
                                                           row("VehicleNumber").ToString().ToLower().Contains(filterText) OrElse
                                                           row("ICNumber").ToString().ToLower().Contains(filterText) OrElse
                                                           row("PhoneNumber").ToString().ToLower().Contains(filterText))

        Dim filteredTable As DataTable = userTable.Clone()
        For Each row In filteredRows
            filteredTable.ImportRow(row)
        Next

        ' Populate the ListBoxes with filtered data
        PopulateListBoxes(filteredTable)
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