﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfileDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfileDetail))
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblTitle = New Label()
        pctLogo = New PictureBox()
        btnExit = New Button()
        lblAppDataLocal = New Label()
        Label2 = New Label()
        lblAppDataRoaming = New Label()
        Label4 = New Label()
        lblProfileType = New Label()
        Label3 = New Label()
        lblProfileSettings = New Label()
        dgProfile = New DataGridView()
        colSetting = New DataGridViewTextBoxColumn()
        colDetail = New DataGridViewTextBoxColumn()
        CType(pctLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F)
        lblTitle.ForeColor = Color.DimGray
        lblTitle.Location = New Point(96, 35)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(136, 30)
        lblTitle.TabIndex = 20
        lblTitle.Text = "Profile Detail"
        ' 
        ' pctLogo
        ' 
        pctLogo.Image = CType(resources.GetObject("pctLogo.Image"), Image)
        pctLogo.Location = New Point(12, 12)
        pctLogo.Name = "pctLogo"
        pctLogo.Size = New Size(78, 69)
        pctLogo.SizeMode = PictureBoxSizeMode.StretchImage
        pctLogo.TabIndex = 19
        pctLogo.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.White
        btnExit.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 9F)
        btnExit.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnExit.Location = New Point(510, 5)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(42, 26)
        btnExit.TabIndex = 17
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblAppDataLocal
        ' 
        lblAppDataLocal.AutoSize = True
        lblAppDataLocal.Font = New Font("Segoe UI", 10F)
        lblAppDataLocal.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblAppDataLocal.Location = New Point(143, 98)
        lblAppDataLocal.Name = "lblAppDataLocal"
        lblAppDataLocal.Size = New Size(108, 19)
        lblAppDataLocal.TabIndex = 28
        lblAppDataLocal.Text = "lblAppDataLocal"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(35, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 19)
        Label2.TabIndex = 27
        Label2.Text = "Local AppData: "
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblAppDataRoaming
        ' 
        lblAppDataRoaming.AutoSize = True
        lblAppDataRoaming.Font = New Font("Segoe UI", 10F)
        lblAppDataRoaming.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblAppDataRoaming.Location = New Point(143, 127)
        lblAppDataRoaming.Name = "lblAppDataRoaming"
        lblAppDataRoaming.Size = New Size(131, 19)
        lblAppDataRoaming.TabIndex = 30
        lblAppDataRoaming.Text = "lblAppDataRoaming"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(12, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 19)
        Label4.TabIndex = 29
        Label4.Text = "Roaming AppData: "
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblProfileType
        ' 
        lblProfileType.AutoSize = True
        lblProfileType.Font = New Font("Segoe UI", 10F)
        lblProfileType.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblProfileType.Location = New Point(144, 156)
        lblProfileType.Name = "lblProfileType"
        lblProfileType.Size = New Size(89, 19)
        lblProfileType.TabIndex = 32
        lblProfileType.Text = "lblProfileType"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(53, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 19)
        Label3.TabIndex = 31
        Label3.Text = "Profile Type: "
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblProfileSettings
        ' 
        lblProfileSettings.AutoSize = True
        lblProfileSettings.Font = New Font("Segoe UI", 10F)
        lblProfileSettings.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblProfileSettings.Location = New Point(6, 182)
        lblProfileSettings.Name = "lblProfileSettings"
        lblProfileSettings.Size = New Size(92, 19)
        lblProfileSettings.TabIndex = 88
        lblProfileSettings.Text = "Profile Details"
        ' 
        ' dgProfile
        ' 
        dgProfile.AllowUserToAddRows = False
        dgProfile.AllowUserToDeleteRows = False
        dgProfile.AllowUserToResizeRows = False
        dgProfile.Anchor = AnchorStyles.None
        dgProfile.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgProfile.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgProfile.BackgroundColor = Color.White
        dgProfile.BorderStyle = BorderStyle.None
        dgProfile.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgProfile.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgProfile.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgProfile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgProfile.ColumnHeadersVisible = False
        dgProfile.Columns.AddRange(New DataGridViewColumn() {colSetting, colDetail})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgProfile.DefaultCellStyle = DataGridViewCellStyle5
        dgProfile.Location = New Point(8, 206)
        dgProfile.MultiSelect = False
        dgProfile.Name = "dgProfile"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgProfile.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgProfile.RowHeadersVisible = False
        dgProfile.ScrollBars = ScrollBars.Vertical
        dgProfile.ShowEditingIcon = False
        dgProfile.Size = New Size(545, 308)
        dgProfile.TabIndex = 86
        ' 
        ' colSetting
        ' 
        colSetting.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        colSetting.HeaderText = "Setting"
        colSetting.Name = "colSetting"
        colSetting.Width = 5
        ' 
        ' colDetail
        ' 
        colDetail.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        colDetail.HeaderText = "Detail"
        colDetail.Name = "colDetail"
        colDetail.Width = 5
        ' 
        ' frmProfileDetail
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(559, 526)
        ControlBox = False
        Controls.Add(lblProfileSettings)
        Controls.Add(dgProfile)
        Controls.Add(lblProfileType)
        Controls.Add(Label3)
        Controls.Add(lblAppDataRoaming)
        Controls.Add(Label4)
        Controls.Add(lblAppDataLocal)
        Controls.Add(Label2)
        Controls.Add(lblTitle)
        Controls.Add(pctLogo)
        Controls.Add(btnExit)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmProfileDetail"
        ShowInTaskbar = False
        Text = "frmProfileDetail"
        CType(pctLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(dgProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents pctLogo As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAppDataLocal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAppDataRoaming As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblProfileType As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblProfileSettings As Label
    Friend WithEvents dgProfile As DataGridView
    Friend WithEvents colSetting As DataGridViewTextBoxColumn
    Friend WithEvents colDetail As DataGridViewTextBoxColumn
End Class
