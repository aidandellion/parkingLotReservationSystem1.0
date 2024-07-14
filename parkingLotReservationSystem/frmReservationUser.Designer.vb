<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReservationUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservationUser))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPark = New System.Windows.Forms.Button()
        Me.btnVacate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEntryDate = New System.Windows.Forms.Label()
        Me.lblExitDate = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbParkingLotCode = New System.Windows.Forms.ComboBox()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.lblParkingCode24 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblParkingCode12 = New System.Windows.Forms.Label()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.lblParkingCode20 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblParkingCode8 = New System.Windows.Forms.Label()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.lblParkingCode23 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.lblParkingCode11 = New System.Windows.Forms.Label()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.lblParkingCode19 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblParkingCode7 = New System.Windows.Forms.Label()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.lblParkingCode22 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lblParkingCode10 = New System.Windows.Forms.Label()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.lblParkingCode21 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lblParkingCode9 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.lblParkingCode16 = New System.Windows.Forms.Label()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.lblParkingCode18 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblParkingCode4 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.lblParkingCode15 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblParkingCode6 = New System.Windows.Forms.Label()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.lblParkingCode17 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblParkingCode3 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.lblParkingCode14 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblParkingCode5 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.lblParkingCode13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblParkingCode2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblParkingCode1 = New System.Windows.Forms.Label()
        Me.DataSet1 = New parkingLotReservationSystem.DataSet1()
        Me.ParkinglotBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParkinglotBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnReservation)
        Me.Panel1.Controls.Add(Me.btnProfile)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 596)
        Me.Panel1.TabIndex = 35
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Silver
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(0, 533)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(200, 65)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
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
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.Silver
        Me.btnProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProfile.Location = New System.Drawing.Point(0, 0)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(200, 65)
        Me.btnProfile.TabIndex = 0
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(680, 55)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Parking Lot Bangunan Sarjana"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(332, 474)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 29)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Parking Lot Code"
        '
        'btnPark
        '
        Me.btnPark.BackColor = System.Drawing.Color.Coral
        Me.btnPark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPark.Location = New System.Drawing.Point(716, 471)
        Me.btnPark.Name = "btnPark"
        Me.btnPark.Size = New System.Drawing.Size(80, 36)
        Me.btnPark.TabIndex = 40
        Me.btnPark.Text = "Park"
        Me.btnPark.UseVisualStyleBackColor = False
        '
        'btnVacate
        '
        Me.btnVacate.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnVacate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVacate.Location = New System.Drawing.Point(802, 471)
        Me.btnVacate.Name = "btnVacate"
        Me.btnVacate.Size = New System.Drawing.Size(80, 36)
        Me.btnVacate.TabIndex = 41
        Me.btnVacate.Text = "Vacate"
        Me.btnVacate.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.White
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReset.Location = New System.Drawing.Point(888, 470)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(80, 36)
        Me.btnReset.TabIndex = 42
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(332, 529)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 29)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Entry Date:"
        '
        'lblEntryDate
        '
        Me.lblEntryDate.AutoSize = True
        Me.lblEntryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntryDate.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblEntryDate.Location = New System.Drawing.Point(467, 529)
        Me.lblEntryDate.Name = "lblEntryDate"
        Me.lblEntryDate.Size = New System.Drawing.Size(21, 29)
        Me.lblEntryDate.TabIndex = 44
        Me.lblEntryDate.Text = "-"
        '
        'lblExitDate
        '
        Me.lblExitDate.AutoSize = True
        Me.lblExitDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExitDate.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblExitDate.Location = New System.Drawing.Point(787, 529)
        Me.lblExitDate.Name = "lblExitDate"
        Me.lblExitDate.Size = New System.Drawing.Size(21, 29)
        Me.lblExitDate.TabIndex = 46
        Me.lblExitDate.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(667, 529)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 29)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Exit Date:"
        '
        'cmbParkingLotCode
        '
        Me.cmbParkingLotCode.FormattingEnabled = True
        Me.cmbParkingLotCode.Location = New System.Drawing.Point(537, 474)
        Me.cmbParkingLotCode.Name = "cmbParkingLotCode"
        Me.cmbParkingLotCode.Size = New System.Drawing.Size(121, 28)
        Me.cmbParkingLotCode.TabIndex = 73
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel25.Controls.Add(Me.lblParkingCode24)
        Me.Panel25.Location = New System.Drawing.Point(915, 284)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(55, 70)
        Me.Panel25.TabIndex = 130
        '
        'lblParkingCode24
        '
        Me.lblParkingCode24.AutoSize = True
        Me.lblParkingCode24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode24.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode24.Name = "lblParkingCode24"
        Me.lblParkingCode24.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode24.TabIndex = 50
        Me.lblParkingCode24.Text = "BS24"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.lblParkingCode12)
        Me.Panel13.Location = New System.Drawing.Point(915, 158)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(55, 70)
        Me.Panel13.TabIndex = 118
        '
        'lblParkingCode12
        '
        Me.lblParkingCode12.AutoSize = True
        Me.lblParkingCode12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode12.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode12.Name = "lblParkingCode12"
        Me.lblParkingCode12.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode12.TabIndex = 50
        Me.lblParkingCode12.Text = "BS12"
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel21.Controls.Add(Me.lblParkingCode20)
        Me.Panel21.Location = New System.Drawing.Point(699, 284)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(55, 70)
        Me.Panel21.TabIndex = 126
        '
        'lblParkingCode20
        '
        Me.lblParkingCode20.AutoSize = True
        Me.lblParkingCode20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode20.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode20.Name = "lblParkingCode20"
        Me.lblParkingCode20.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode20.TabIndex = 50
        Me.lblParkingCode20.Text = "BS20"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.lblParkingCode8)
        Me.Panel9.Location = New System.Drawing.Point(699, 158)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(55, 70)
        Me.Panel9.TabIndex = 114
        '
        'lblParkingCode8
        '
        Me.lblParkingCode8.AutoSize = True
        Me.lblParkingCode8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode8.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode8.Name = "lblParkingCode8"
        Me.lblParkingCode8.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode8.TabIndex = 50
        Me.lblParkingCode8.Text = "BS08"
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel24.Controls.Add(Me.lblParkingCode23)
        Me.Panel24.Location = New System.Drawing.Point(861, 284)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(55, 70)
        Me.Panel24.TabIndex = 129
        '
        'lblParkingCode23
        '
        Me.lblParkingCode23.AutoSize = True
        Me.lblParkingCode23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode23.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode23.Name = "lblParkingCode23"
        Me.lblParkingCode23.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode23.TabIndex = 50
        Me.lblParkingCode23.Text = "BS23"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.lblParkingCode11)
        Me.Panel12.Location = New System.Drawing.Point(861, 158)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(55, 70)
        Me.Panel12.TabIndex = 117
        '
        'lblParkingCode11
        '
        Me.lblParkingCode11.AutoSize = True
        Me.lblParkingCode11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode11.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode11.Name = "lblParkingCode11"
        Me.lblParkingCode11.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode11.TabIndex = 50
        Me.lblParkingCode11.Text = "BS11"
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel20.Controls.Add(Me.lblParkingCode19)
        Me.Panel20.Location = New System.Drawing.Point(645, 284)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(55, 70)
        Me.Panel20.TabIndex = 125
        '
        'lblParkingCode19
        '
        Me.lblParkingCode19.AutoSize = True
        Me.lblParkingCode19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode19.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode19.Name = "lblParkingCode19"
        Me.lblParkingCode19.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode19.TabIndex = 50
        Me.lblParkingCode19.Text = "BS19"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.lblParkingCode7)
        Me.Panel8.Location = New System.Drawing.Point(645, 158)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(55, 70)
        Me.Panel8.TabIndex = 113
        '
        'lblParkingCode7
        '
        Me.lblParkingCode7.AutoSize = True
        Me.lblParkingCode7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode7.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode7.Name = "lblParkingCode7"
        Me.lblParkingCode7.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode7.TabIndex = 50
        Me.lblParkingCode7.Text = "BS07"
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel23.Controls.Add(Me.lblParkingCode22)
        Me.Panel23.Location = New System.Drawing.Point(807, 284)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(55, 70)
        Me.Panel23.TabIndex = 128
        '
        'lblParkingCode22
        '
        Me.lblParkingCode22.AutoSize = True
        Me.lblParkingCode22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode22.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode22.Name = "lblParkingCode22"
        Me.lblParkingCode22.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode22.TabIndex = 50
        Me.lblParkingCode22.Text = "BS22"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.lblParkingCode10)
        Me.Panel11.Location = New System.Drawing.Point(807, 158)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(55, 70)
        Me.Panel11.TabIndex = 116
        '
        'lblParkingCode10
        '
        Me.lblParkingCode10.AutoSize = True
        Me.lblParkingCode10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode10.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode10.Name = "lblParkingCode10"
        Me.lblParkingCode10.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode10.TabIndex = 50
        Me.lblParkingCode10.Text = "BS10"
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel22.Controls.Add(Me.lblParkingCode21)
        Me.Panel22.Location = New System.Drawing.Point(753, 284)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(55, 70)
        Me.Panel22.TabIndex = 127
        '
        'lblParkingCode21
        '
        Me.lblParkingCode21.AutoSize = True
        Me.lblParkingCode21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode21.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode21.Name = "lblParkingCode21"
        Me.lblParkingCode21.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode21.TabIndex = 50
        Me.lblParkingCode21.Text = "BS21"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.lblParkingCode9)
        Me.Panel10.Location = New System.Drawing.Point(753, 158)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(55, 70)
        Me.Panel10.TabIndex = 115
        '
        'lblParkingCode9
        '
        Me.lblParkingCode9.AutoSize = True
        Me.lblParkingCode9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode9.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode9.Name = "lblParkingCode9"
        Me.lblParkingCode9.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode9.TabIndex = 50
        Me.lblParkingCode9.Text = "BS09"
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel17.Controls.Add(Me.lblParkingCode16)
        Me.Panel17.Location = New System.Drawing.Point(483, 284)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(55, 70)
        Me.Panel17.TabIndex = 122
        '
        'lblParkingCode16
        '
        Me.lblParkingCode16.AutoSize = True
        Me.lblParkingCode16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode16.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode16.Name = "lblParkingCode16"
        Me.lblParkingCode16.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode16.TabIndex = 50
        Me.lblParkingCode16.Text = "BS16"
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel19.Controls.Add(Me.lblParkingCode18)
        Me.Panel19.Location = New System.Drawing.Point(591, 284)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(55, 70)
        Me.Panel19.TabIndex = 124
        '
        'lblParkingCode18
        '
        Me.lblParkingCode18.AutoSize = True
        Me.lblParkingCode18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode18.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode18.Name = "lblParkingCode18"
        Me.lblParkingCode18.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode18.TabIndex = 50
        Me.lblParkingCode18.Text = "BS18"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblParkingCode4)
        Me.Panel5.Location = New System.Drawing.Point(483, 158)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(55, 70)
        Me.Panel5.TabIndex = 110
        '
        'lblParkingCode4
        '
        Me.lblParkingCode4.AutoSize = True
        Me.lblParkingCode4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode4.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode4.Name = "lblParkingCode4"
        Me.lblParkingCode4.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode4.TabIndex = 50
        Me.lblParkingCode4.Text = "BS04"
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.lblParkingCode15)
        Me.Panel16.Location = New System.Drawing.Point(429, 284)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(55, 70)
        Me.Panel16.TabIndex = 121
        '
        'lblParkingCode15
        '
        Me.lblParkingCode15.AutoSize = True
        Me.lblParkingCode15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode15.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode15.Name = "lblParkingCode15"
        Me.lblParkingCode15.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode15.TabIndex = 50
        Me.lblParkingCode15.Text = "BS15"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.lblParkingCode6)
        Me.Panel7.Location = New System.Drawing.Point(591, 158)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(55, 70)
        Me.Panel7.TabIndex = 112
        '
        'lblParkingCode6
        '
        Me.lblParkingCode6.AutoSize = True
        Me.lblParkingCode6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode6.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode6.Name = "lblParkingCode6"
        Me.lblParkingCode6.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode6.TabIndex = 50
        Me.lblParkingCode6.Text = "BS06"
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel18.Controls.Add(Me.lblParkingCode17)
        Me.Panel18.Location = New System.Drawing.Point(537, 284)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(55, 70)
        Me.Panel18.TabIndex = 123
        '
        'lblParkingCode17
        '
        Me.lblParkingCode17.AutoSize = True
        Me.lblParkingCode17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode17.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode17.Name = "lblParkingCode17"
        Me.lblParkingCode17.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode17.TabIndex = 50
        Me.lblParkingCode17.Text = "BS17"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblParkingCode3)
        Me.Panel4.Location = New System.Drawing.Point(429, 158)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(55, 70)
        Me.Panel4.TabIndex = 109
        '
        'lblParkingCode3
        '
        Me.lblParkingCode3.AutoSize = True
        Me.lblParkingCode3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode3.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode3.Name = "lblParkingCode3"
        Me.lblParkingCode3.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode3.TabIndex = 50
        Me.lblParkingCode3.Text = "BS03"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel15.Controls.Add(Me.lblParkingCode14)
        Me.Panel15.Location = New System.Drawing.Point(375, 284)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(55, 70)
        Me.Panel15.TabIndex = 120
        '
        'lblParkingCode14
        '
        Me.lblParkingCode14.AutoSize = True
        Me.lblParkingCode14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode14.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode14.Name = "lblParkingCode14"
        Me.lblParkingCode14.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode14.TabIndex = 50
        Me.lblParkingCode14.Text = "BS14"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.lblParkingCode5)
        Me.Panel6.Location = New System.Drawing.Point(537, 158)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(55, 70)
        Me.Panel6.TabIndex = 111
        '
        'lblParkingCode5
        '
        Me.lblParkingCode5.AutoSize = True
        Me.lblParkingCode5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode5.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode5.Name = "lblParkingCode5"
        Me.lblParkingCode5.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode5.TabIndex = 50
        Me.lblParkingCode5.Text = "BS05"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.lblParkingCode13)
        Me.Panel14.Location = New System.Drawing.Point(321, 284)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(55, 70)
        Me.Panel14.TabIndex = 119
        '
        'lblParkingCode13
        '
        Me.lblParkingCode13.AutoSize = True
        Me.lblParkingCode13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode13.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode13.Name = "lblParkingCode13"
        Me.lblParkingCode13.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode13.TabIndex = 50
        Me.lblParkingCode13.Text = "BS13"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblParkingCode2)
        Me.Panel3.Location = New System.Drawing.Point(375, 158)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(55, 70)
        Me.Panel3.TabIndex = 108
        '
        'lblParkingCode2
        '
        Me.lblParkingCode2.AutoSize = True
        Me.lblParkingCode2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode2.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode2.Name = "lblParkingCode2"
        Me.lblParkingCode2.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode2.TabIndex = 50
        Me.lblParkingCode2.Text = "BS02"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblParkingCode1)
        Me.Panel2.Location = New System.Drawing.Point(321, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(55, 70)
        Me.Panel2.TabIndex = 107
        '
        'lblParkingCode1
        '
        Me.lblParkingCode1.AutoSize = True
        Me.lblParkingCode1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblParkingCode1.Location = New System.Drawing.Point(3, 28)
        Me.lblParkingCode1.Name = "lblParkingCode1"
        Me.lblParkingCode1.Size = New System.Drawing.Size(49, 20)
        Me.lblParkingCode1.TabIndex = 50
        Me.lblParkingCode1.Text = "BS01"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ParkinglotBindingSource
        '
        Me.ParkinglotBindingSource.DataMember = "parkinglot"
        Me.ParkinglotBindingSource.DataSource = Me.DataSet1
        '
        'frmReservationUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 596)
        Me.Controls.Add(Me.Panel25)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel21)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel24)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel20)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel23)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel22)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel17)
        Me.Controls.Add(Me.Panel19)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel16)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmbParkingLotCode)
        Me.Controls.Add(Me.lblExitDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblEntryDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnVacate)
        Me.Controls.Add(Me.btnPark)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReservationUser"
        Me.Text = "Reservation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel25.ResumeLayout(False)
        Me.Panel25.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel24.ResumeLayout(False)
        Me.Panel24.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParkinglotBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReservation As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPark As Button
    Friend WithEvents btnVacate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblEntryDate As Label
    Friend WithEvents lblExitDate As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbParkingLotCode As ComboBox
    Friend WithEvents Panel25 As Panel
    Friend WithEvents lblParkingCode24 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents lblParkingCode12 As Label
    Friend WithEvents Panel21 As Panel
    Friend WithEvents lblParkingCode20 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblParkingCode8 As Label
    Friend WithEvents Panel24 As Panel
    Friend WithEvents lblParkingCode23 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents lblParkingCode11 As Label
    Friend WithEvents Panel20 As Panel
    Friend WithEvents lblParkingCode19 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblParkingCode7 As Label
    Friend WithEvents Panel23 As Panel
    Friend WithEvents lblParkingCode22 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblParkingCode10 As Label
    Friend WithEvents Panel22 As Panel
    Friend WithEvents lblParkingCode21 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lblParkingCode9 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents lblParkingCode16 As Label
    Friend WithEvents Panel19 As Panel
    Friend WithEvents lblParkingCode18 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblParkingCode4 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents lblParkingCode15 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblParkingCode6 As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents lblParkingCode17 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblParkingCode3 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents lblParkingCode14 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblParkingCode5 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents lblParkingCode13 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblParkingCode2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblParkingCode1 As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ParkinglotBindingSource As BindingSource
End Class
