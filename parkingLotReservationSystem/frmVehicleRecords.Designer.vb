<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehicleRecords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVehicleRecords))
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnVehicleRecords = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.lvVehicleRecords = New System.Windows.Forms.ListView()
        Me.OwnerColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VehicleNumberColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EntryColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ExitColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ReceiptColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DeleteColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.Silver
        Me.btnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdmin.Location = New System.Drawing.Point(0, 0)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(200, 65)
        Me.btnAdmin.TabIndex = 0
        Me.btnAdmin.Text = "ADMIN"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btnUsers)
        Me.Panel1.Controls.Add(Me.btnVehicleRecords)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.btnReservation)
        Me.Panel1.Controls.Add(Me.btnAdmin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 596)
        Me.Panel1.TabIndex = 43
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.Silver
        Me.btnUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.Location = New System.Drawing.Point(0, 231)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(200, 65)
        Me.btnUsers.TabIndex = 4
        Me.btnUsers.Text = "Users"
        Me.btnUsers.UseVisualStyleBackColor = False
        '
        'btnVehicleRecords
        '
        Me.btnVehicleRecords.BackColor = System.Drawing.Color.Silver
        Me.btnVehicleRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVehicleRecords.Location = New System.Drawing.Point(0, 124)
        Me.btnVehicleRecords.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVehicleRecords.Name = "btnVehicleRecords"
        Me.btnVehicleRecords.Size = New System.Drawing.Size(200, 110)
        Me.btnVehicleRecords.TabIndex = 3
        Me.btnVehicleRecords.Text = "Vehicle Entry " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and Exit Records" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnVehicleRecords.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Silver
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(0, 531)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(200, 65)
        Me.btnLogOut.TabIndex = 2
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnReservation
        '
        Me.btnReservation.BackColor = System.Drawing.Color.Silver
        Me.btnReservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservation.Location = New System.Drawing.Point(0, 62)
        Me.btnReservation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(200, 65)
        Me.btnReservation.TabIndex = 1
        Me.btnReservation.Text = "Reservation"
        Me.btnReservation.UseVisualStyleBackColor = False
        '
        'lvVehicleRecords
        '
        Me.lvVehicleRecords.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OwnerColumn, Me.VehicleNumberColumn, Me.EntryColumn, Me.ExitColumn, Me.ReceiptColumn, Me.DeleteColumn})
        Me.lvVehicleRecords.FullRowSelect = True
        Me.lvVehicleRecords.HideSelection = False
        Me.lvVehicleRecords.Location = New System.Drawing.Point(246, 100)
        Me.lvVehicleRecords.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvVehicleRecords.Name = "lvVehicleRecords"
        Me.lvVehicleRecords.Size = New System.Drawing.Size(952, 433)
        Me.lvVehicleRecords.TabIndex = 53
        Me.lvVehicleRecords.UseCompatibleStateImageBehavior = False
        Me.lvVehicleRecords.View = System.Windows.Forms.View.Details
        '
        'OwnerColumn
        '
        Me.OwnerColumn.Text = "Owner Name"
        Me.OwnerColumn.Width = 137
        '
        'VehicleNumberColumn
        '
        Me.VehicleNumberColumn.Text = "Vehicle Number"
        Me.VehicleNumberColumn.Width = 131
        '
        'EntryColumn
        '
        Me.EntryColumn.Text = "Entry Date"
        Me.EntryColumn.Width = 122
        '
        'ExitColumn
        '
        Me.ExitColumn.Text = "Exit Date"
        Me.ExitColumn.Width = 130
        '
        'ReceiptColumn
        '
        Me.ReceiptColumn.Text = "Receipt"
        Me.ReceiptColumn.Width = 95
        '
        'DeleteColumn
        '
        Me.DeleteColumn.Text = "Delete"
        Me.DeleteColumn.Width = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(369, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(698, 55)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Vehicle Entry and Exit Records "
        '
        'frmVehicleRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 596)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvVehicleRecords)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmVehicleRecords"
        Me.Text = "Vehicle Entry & Exit Records"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdmin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnVehicleRecords As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnReservation As Button
    Friend WithEvents lvVehicleRecords As ListView
    Friend WithEvents OwnerColumn As ColumnHeader
    Friend WithEvents VehicleNumberColumn As ColumnHeader
    Friend WithEvents EntryColumn As ColumnHeader
    Friend WithEvents ExitColumn As ColumnHeader
    Friend WithEvents ReceiptColumn As ColumnHeader
    Friend WithEvents DeleteColumn As ColumnHeader
    Friend WithEvents Label1 As Label
End Class
