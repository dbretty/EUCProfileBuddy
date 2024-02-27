<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        icnNotify = New NotifyIcon(components)
        ctxMenu = New ContextMenuStrip(components)
        ctxMenuExit = New ToolStripMenuItem()
        btnExit = New Button()
        btnMinimize = New Button()
        pctLogo = New PictureBox()
        lblTitle = New Label()
        lblProfileSize = New Label()
        lblProfileSizeTitle = New Label()
        lblProfileDirectory = New Label()
        lblProfileDirectoryTitle = New Label()
        lblUserName = New Label()
        lblUserNameTitle = New Label()
        dgFolders = New DataGridView()
        colFolder = New DataGridViewTextBoxColumn()
        colSize = New DataGridViewTextBoxColumn()
        ctxFolders = New ContextMenuStrip(components)
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        lblLastFolder = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnBack = New Button()
        cmdExecute = New Button()
        cmbAction = New ComboBox()
        btnShowProfileDetail = New Button()
        ctxMenu.SuspendLayout()
        CType(pctLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgFolders, ComponentModel.ISupportInitialize).BeginInit()
        ctxFolders.SuspendLayout()
        SuspendLayout()
        ' 
        ' icnNotify
        ' 
        icnNotify.ContextMenuStrip = ctxMenu
        icnNotify.Icon = CType(resources.GetObject("icnNotify.Icon"), Icon)
        icnNotify.Text = "NotifyIcon1"
        icnNotify.Visible = True
        ' 
        ' ctxMenu
        ' 
        ctxMenu.Items.AddRange(New ToolStripItem() {ctxMenuExit})
        ctxMenu.Name = "ctxMenu"
        ctxMenu.Size = New Size(94, 26)
        ' 
        ' ctxMenuExit
        ' 
        ctxMenuExit.Name = "ctxMenuExit"
        ctxMenuExit.Size = New Size(93, 22)
        ctxMenuExit.Text = "Exit"
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
        btnExit.TabIndex = 5
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnMinimize
        ' 
        btnMinimize.BackColor = Color.White
        btnMinimize.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatAppearance.MouseOverBackColor = Color.Silver
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Font = New Font("Segoe UI", 9F)
        btnMinimize.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnMinimize.Location = New Point(462, 5)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(42, 26)
        btnMinimize.TabIndex = 6
        btnMinimize.Text = "_"
        btnMinimize.UseVisualStyleBackColor = False
        ' 
        ' pctLogo
        ' 
        pctLogo.Image = My.Resources.Resources.Profile_PNG_Free_Download_2356358018
        pctLogo.Location = New Point(12, 12)
        pctLogo.Name = "pctLogo"
        pctLogo.Size = New Size(78, 69)
        pctLogo.SizeMode = PictureBoxSizeMode.StretchImage
        pctLogo.TabIndex = 7
        pctLogo.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F)
        lblTitle.ForeColor = Color.SteelBlue
        lblTitle.Location = New Point(96, 35)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(189, 30)
        lblTitle.TabIndex = 8
        lblTitle.Text = "EUC Profile Buddy"
        ' 
        ' lblProfileSize
        ' 
        lblProfileSize.AutoSize = True
        lblProfileSize.Font = New Font("Segoe UI", 10F)
        lblProfileSize.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblProfileSize.Location = New Point(133, 153)
        lblProfileSize.Name = "lblProfileSize"
        lblProfileSize.Size = New Size(84, 19)
        lblProfileSize.TabIndex = 16
        lblProfileSize.Text = "lblProfileSize"
        ' 
        ' lblProfileSizeTitle
        ' 
        lblProfileSizeTitle.AutoSize = True
        lblProfileSizeTitle.Font = New Font("Segoe UI", 10F)
        lblProfileSizeTitle.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblProfileSizeTitle.Location = New Point(47, 152)
        lblProfileSizeTitle.Name = "lblProfileSizeTitle"
        lblProfileSizeTitle.Size = New Size(81, 19)
        lblProfileSizeTitle.TabIndex = 15
        lblProfileSizeTitle.Text = "Profile Size: "
        lblProfileSizeTitle.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblProfileDirectory
        ' 
        lblProfileDirectory.AutoSize = True
        lblProfileDirectory.Font = New Font("Segoe UI", 10F)
        lblProfileDirectory.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblProfileDirectory.Location = New Point(133, 125)
        lblProfileDirectory.Name = "lblProfileDirectory"
        lblProfileDirectory.Size = New Size(117, 19)
        lblProfileDirectory.TabIndex = 14
        lblProfileDirectory.Text = "lblProfileDirectory"
        ' 
        ' lblProfileDirectoryTitle
        ' 
        lblProfileDirectoryTitle.AutoSize = True
        lblProfileDirectoryTitle.Font = New Font("Segoe UI", 10F)
        lblProfileDirectoryTitle.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblProfileDirectoryTitle.Location = New Point(14, 124)
        lblProfileDirectoryTitle.Name = "lblProfileDirectoryTitle"
        lblProfileDirectoryTitle.Size = New Size(114, 19)
        lblProfileDirectoryTitle.TabIndex = 13
        lblProfileDirectoryTitle.Text = "Profile Directory: "
        lblProfileDirectoryTitle.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Segoe UI", 10F)
        lblUserName.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblUserName.Location = New Point(133, 98)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(87, 19)
        lblUserName.TabIndex = 12
        lblUserName.Text = "lblUserName"
        ' 
        ' lblUserNameTitle
        ' 
        lblUserNameTitle.AutoSize = True
        lblUserNameTitle.Font = New Font("Segoe UI", 10F)
        lblUserNameTitle.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblUserNameTitle.Location = New Point(44, 97)
        lblUserNameTitle.Name = "lblUserNameTitle"
        lblUserNameTitle.Size = New Size(84, 19)
        lblUserNameTitle.TabIndex = 11
        lblUserNameTitle.Text = "User Name: "
        lblUserNameTitle.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' dgFolders
        ' 
        dgFolders.AllowUserToAddRows = False
        dgFolders.AllowUserToDeleteRows = False
        dgFolders.AllowUserToResizeRows = False
        dgFolders.Anchor = AnchorStyles.None
        dgFolders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgFolders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgFolders.BackgroundColor = Color.White
        dgFolders.BorderStyle = BorderStyle.None
        dgFolders.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgFolders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgFolders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgFolders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgFolders.ColumnHeadersVisible = False
        dgFolders.Columns.AddRange(New DataGridViewColumn() {colFolder, colSize})
        dgFolders.ContextMenuStrip = ctxFolders
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgFolders.DefaultCellStyle = DataGridViewCellStyle2
        dgFolders.Location = New Point(7, 256)
        dgFolders.MultiSelect = False
        dgFolders.Name = "dgFolders"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgFolders.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgFolders.RowHeadersVisible = False
        dgFolders.ShowEditingIcon = False
        dgFolders.Size = New Size(545, 232)
        dgFolders.TabIndex = 79
        ' 
        ' colFolder
        ' 
        colFolder.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colFolder.HeaderText = "Folder"
        colFolder.Name = "colFolder"
        colFolder.SortMode = DataGridViewColumnSortMode.NotSortable
        colFolder.Width = 450
        ' 
        ' colSize
        ' 
        colSize.HeaderText = "Size"
        colSize.Name = "colSize"
        colSize.SortMode = DataGridViewColumnSortMode.NotSortable
        colSize.Width = 5
        ' 
        ' ctxFolders
        ' 
        ctxFolders.Items.AddRange(New ToolStripItem() {DeleteToolStripMenuItem})
        ctxFolders.Name = "ctxFolders"
        ctxFolders.Size = New Size(108, 26)
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(107, 22)
        DeleteToolStripMenuItem.Text = "Delete"
        ' 
        ' lblLastFolder
        ' 
        lblLastFolder.AutoSize = True
        lblLastFolder.Font = New Font("Segoe UI", 10F)
        lblLastFolder.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblLastFolder.Location = New Point(123, 209)
        lblLastFolder.Name = "lblLastFolder"
        lblLastFolder.Size = New Size(127, 19)
        lblLastFolder.TabIndex = 80
        lblLastFolder.Text = "C:\Users\Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(5, 232)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 19)
        Label1.TabIndex = 83
        Label1.Text = "Path"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(455, 234)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 19)
        Label2.TabIndex = 84
        Label2.Text = "Size"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(5, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 19)
        Label3.TabIndex = 85
        Label3.Text = "Current Directory: "
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.White
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnBack.FlatAppearance.MouseOverBackColor = Color.Silver
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Location = New Point(9, 181)
        btnBack.Margin = New Padding(0)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(42, 24)
        btnBack.TabIndex = 87
        btnBack.Text = "<<"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' cmdExecute
        ' 
        cmdExecute.BackColor = Color.White
        cmdExecute.FlatAppearance.BorderColor = Color.SteelBlue
        cmdExecute.FlatAppearance.BorderSize = 2
        cmdExecute.FlatStyle = FlatStyle.Flat
        cmdExecute.Location = New Point(379, 494)
        cmdExecute.Name = "cmdExecute"
        cmdExecute.Size = New Size(175, 27)
        cmdExecute.TabIndex = 88
        cmdExecute.Text = "Execute Action"
        cmdExecute.UseVisualStyleBackColor = False
        ' 
        ' cmbAction
        ' 
        cmbAction.Font = New Font("Segoe UI", 10F)
        cmbAction.ForeColor = Color.SteelBlue
        cmbAction.FormattingEnabled = True
        cmbAction.Items.AddRange(New Object() {"Select Action", "Clear Temp Files", "Reset Microsoft Edge", "Run Custom Scripts"})
        cmbAction.Location = New Point(5, 494)
        cmbAction.Name = "cmbAction"
        cmbAction.Size = New Size(370, 25)
        cmbAction.TabIndex = 89
        cmbAction.Text = "Select Action"
        ' 
        ' btnShowProfileDetail
        ' 
        btnShowProfileDetail.BackColor = Color.White
        btnShowProfileDetail.FlatAppearance.BorderColor = Color.SteelBlue
        btnShowProfileDetail.FlatAppearance.BorderSize = 2
        btnShowProfileDetail.FlatStyle = FlatStyle.Flat
        btnShowProfileDetail.Font = New Font("Segoe UI", 8F)
        btnShowProfileDetail.Location = New Point(54, 181)
        btnShowProfileDetail.Margin = New Padding(0)
        btnShowProfileDetail.Name = "btnShowProfileDetail"
        btnShowProfileDetail.Size = New Size(121, 24)
        btnShowProfileDetail.TabIndex = 90
        btnShowProfileDetail.Text = "Show Detail"
        btnShowProfileDetail.UseVisualStyleBackColor = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(560, 526)
        Controls.Add(btnShowProfileDetail)
        Controls.Add(cmbAction)
        Controls.Add(cmdExecute)
        Controls.Add(btnBack)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblLastFolder)
        Controls.Add(dgFolders)
        Controls.Add(lblProfileSize)
        Controls.Add(lblProfileSizeTitle)
        Controls.Add(lblProfileDirectory)
        Controls.Add(lblProfileDirectoryTitle)
        Controls.Add(lblUserName)
        Controls.Add(lblUserNameTitle)
        Controls.Add(lblTitle)
        Controls.Add(pctLogo)
        Controls.Add(btnMinimize)
        Controls.Add(btnExit)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmMain"
        Text = "EUC Profile Buddy"
        ctxMenu.ResumeLayout(False)
        CType(pctLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(dgFolders, ComponentModel.ISupportInitialize).EndInit()
        ctxFolders.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents icnNotify As NotifyIcon
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents ctxMenuExit As ToolStripMenuItem
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents pctLogo As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblProfileSize As Label
    Friend WithEvents lblProfileSizeTitle As Label
    Friend WithEvents lblProfileDirectory As Label
    Friend WithEvents lblProfileDirectoryTitle As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblUserNameTitle As Label
    Friend WithEvents dgFolders As DataGridView
    Friend WithEvents lblLastFolder As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ctxFolders As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnBack As Button
    Friend WithEvents colFolder As DataGridViewTextBoxColumn
    Friend WithEvents colSize As DataGridViewTextBoxColumn
    Friend WithEvents cmdExecute As Button
    Friend WithEvents cmbAction As ComboBox
    Friend WithEvents btnShowProfileDetail As Button

End Class
