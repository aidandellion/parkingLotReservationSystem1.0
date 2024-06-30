<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserList))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstPhone = New System.Windows.Forms.ListBox()
        Me.lstIC = New System.Windows.Forms.ListBox()
        Me.lstPlate = New System.Windows.Forms.ListBox()
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnVehicleRecords = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(894, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 25)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(697, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "IC Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(461, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 25)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Vehicle Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Owner Name"
        '
        'lstPhone
        '
        Me.lstPhone.BackColor = System.Drawing.Color.LightGray
        Me.lstPhone.FormattingEnabled = True
        Me.lstPhone.ItemHeight = 20
        Me.lstPhone.Location = New System.Drawing.Point(862, 149)
        Me.lstPhone.Name = "lstPhone"
        Me.lstPhone.Size = New System.Drawing.Size(213, 344)
        Me.lstPhone.TabIndex = 35
        '
        'lstIC
        '
        Me.lstIC.BackColor = System.Drawing.Color.LightGray
        Me.lstIC.FormattingEnabled = True
        Me.lstIC.ItemHeight = 20
        Me.lstIC.Location = New System.Drawing.Point(649, 149)
        Me.lstIC.Name = "lstIC"
        Me.lstIC.Size = New System.Drawing.Size(213, 344)
        Me.lstIC.TabIndex = 34
        '
        'lstPlate
        '
        Me.lstPlate.BackColor = System.Drawing.Color.LightGray
        Me.lstPlate.FormattingEnabled = True
        Me.lstPlate.ItemHeight = 20
        Me.lstPlate.Location = New System.Drawing.Point(436, 149)
        Me.lstPlate.Name = "lstPlate"
        Me.lstPlate.Size = New System.Drawing.Size(213, 344)
        Me.lstPlate.TabIndex = 33
        '
        'lstName
        '
        Me.lstName.BackColor = System.Drawing.Color.LightGray
        Me.lstName.FormattingEnabled = True
        Me.lstName.ItemHeight = 20
        Me.lstName.Location = New System.Drawing.Point(223, 149)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(213, 344)
        Me.lstName.TabIndex = 32
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.Silver
        Me.btnUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.Location = New System.Drawing.Point(0, 231)
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
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(200, 65)
        Me.btnReservation.TabIndex = 1
        Me.btnReservation.Text = "Reservation"
        Me.btnReservation.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.Silver
        Me.btnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdmin.Location = New System.Drawing.Point(0, 0)
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 596)
        Me.Panel1.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Location = New System.Drawing.Point(442, 23)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(420, 52)
        Me.Panel2.TabIndex = 53
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(318, 9)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(97, 34)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.AcceptsReturn = True
        Me.txtSearch.AcceptsTab = True
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Location = New System.Drawing.Point(14, 12)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(300, 26)
        Me.txtSearch.TabIndex = 0
        '
        'frmUserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 596)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPhone)
        Me.Controls.Add(Me.lstIC)
        Me.Controls.Add(Me.lstPlate)
        Me.Controls.Add(Me.lstName)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUserList"
        Me.Text = "Users"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstPhone As ListBox
    Friend WithEvents lstIC As ListBox
    Friend WithEvents lstPlate As ListBox
    Friend WithEvents lstName As ListBox
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnVehicleRecords As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnReservation As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
End Class
