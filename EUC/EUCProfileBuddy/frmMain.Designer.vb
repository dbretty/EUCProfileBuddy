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
        lblProfileDetailsTitle = New Label()
        lblAppDataLocal = New Label()
        lblAppDataLocalTitle = New Label()
        btnRefreshProfileSize = New Button()
        lblProfileSize = New Label()
        lblProfileSizeTitle = New Label()
        lblProfileDirectory = New Label()
        lblProfileDirectoryTitle = New Label()
        lblUserName = New Label()
        lblUserNameTitle = New Label()
        lblAppdataRoaming = New Label()
        lblAppDataRoamingTitle = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        Label26 = New Label()
        Label27 = New Label()
        Label28 = New Label()
        Label29 = New Label()
        Label30 = New Label()
        Label31 = New Label()
        Label32 = New Label()
        Label33 = New Label()
        Label34 = New Label()
        Label35 = New Label()
        Label36 = New Label()
        Label37 = New Label()
        Label38 = New Label()
        Label39 = New Label()
        Label40 = New Label()
        Label41 = New Label()
        Label42 = New Label()
        Label43 = New Label()
        Label44 = New Label()
        Label45 = New Label()
        Label46 = New Label()
        Label47 = New Label()
        Label48 = New Label()
        Label49 = New Label()
        Label50 = New Label()
        Label51 = New Label()
        Label52 = New Label()
        btnClearTempFiles = New Button()
        btnResetEdge = New Button()
        dgFolders = New DataGridView()
        colFolder = New DataGridViewTextBoxColumn()
        colSize = New DataGridViewTextBoxColumn()
        lblLastFolder = New Label()
        ctxMenu.SuspendLayout()
        CType(pctLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgFolders, ComponentModel.ISupportInitialize).BeginInit()
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
        btnExit.BackColor = Color.IndianRed
        btnExit.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 9F)
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(510, 5)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(42, 26)
        btnExit.TabIndex = 5
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnMinimize
        ' 
        btnMinimize.BackColor = Color.RosyBrown
        btnMinimize.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Font = New Font("Segoe UI", 9F)
        btnMinimize.ForeColor = Color.White
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
        ' lblProfileDetailsTitle
        ' 
        lblProfileDetailsTitle.AutoSize = True
        lblProfileDetailsTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblProfileDetailsTitle.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblProfileDetailsTitle.Location = New Point(12, 90)
        lblProfileDetailsTitle.Name = "lblProfileDetailsTitle"
        lblProfileDetailsTitle.Size = New Size(118, 21)
        lblProfileDetailsTitle.TabIndex = 10
        lblProfileDetailsTitle.Text = "Profile Details"
        ' 
        ' lblAppDataLocal
        ' 
        lblAppDataLocal.AutoSize = True
        lblAppDataLocal.Font = New Font("Segoe UI", 10F)
        lblAppDataLocal.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblAppDataLocal.Location = New Point(135, 208)
        lblAppDataLocal.Name = "lblAppDataLocal"
        lblAppDataLocal.Size = New Size(108, 19)
        lblAppDataLocal.TabIndex = 19
        lblAppDataLocal.Text = "lblAppDataLocal"
        ' 
        ' lblAppDataLocalTitle
        ' 
        lblAppDataLocalTitle.AutoSize = True
        lblAppDataLocalTitle.Font = New Font("Segoe UI", 10F)
        lblAppDataLocalTitle.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblAppDataLocalTitle.Location = New Point(26, 207)
        lblAppDataLocalTitle.Name = "lblAppDataLocalTitle"
        lblAppDataLocalTitle.Size = New Size(103, 19)
        lblAppDataLocalTitle.TabIndex = 18
        lblAppDataLocalTitle.Text = "Appdata Local: "
        lblAppDataLocalTitle.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnRefreshProfileSize
        ' 
        btnRefreshProfileSize.BackColor = Color.SteelBlue
        btnRefreshProfileSize.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnRefreshProfileSize.FlatStyle = FlatStyle.Flat
        btnRefreshProfileSize.Location = New Point(138, 90)
        btnRefreshProfileSize.Name = "btnRefreshProfileSize"
        btnRefreshProfileSize.Size = New Size(75, 24)
        btnRefreshProfileSize.TabIndex = 17
        btnRefreshProfileSize.Text = "Refresh"
        btnRefreshProfileSize.UseVisualStyleBackColor = False
        ' 
        ' lblProfileSize
        ' 
        lblProfileSize.AutoSize = True
        lblProfileSize.Font = New Font("Segoe UI", 10F)
        lblProfileSize.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblProfileSize.Location = New Point(135, 179)
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
        lblProfileSizeTitle.Location = New Point(45, 178)
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
        lblProfileDirectory.Location = New Point(135, 151)
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
        lblProfileDirectoryTitle.Location = New Point(18, 150)
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
        lblUserName.Location = New Point(135, 124)
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
        lblUserNameTitle.Location = New Point(45, 123)
        lblUserNameTitle.Name = "lblUserNameTitle"
        lblUserNameTitle.Size = New Size(84, 19)
        lblUserNameTitle.TabIndex = 11
        lblUserNameTitle.Text = "User Name: "
        lblUserNameTitle.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblAppdataRoaming
        ' 
        lblAppdataRoaming.AutoSize = True
        lblAppdataRoaming.Font = New Font("Segoe UI", 10F)
        lblAppdataRoaming.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblAppdataRoaming.Location = New Point(135, 239)
        lblAppdataRoaming.Name = "lblAppdataRoaming"
        lblAppdataRoaming.Size = New Size(129, 19)
        lblAppdataRoaming.TabIndex = 21
        lblAppdataRoaming.Text = "lblAppdataRoaming"
        ' 
        ' lblAppDataRoamingTitle
        ' 
        lblAppDataRoamingTitle.AutoSize = True
        lblAppDataRoamingTitle.Font = New Font("Segoe UI", 10F)
        lblAppDataRoamingTitle.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblAppDataRoamingTitle.Location = New Point(3, 238)
        lblAppDataRoamingTitle.Name = "lblAppDataRoamingTitle"
        lblAppDataRoamingTitle.Size = New Size(126, 19)
        lblAppDataRoamingTitle.TabIndex = 20
        lblAppDataRoamingTitle.Text = "Appdata Roaming: "
        lblAppDataRoamingTitle.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(8, 275)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 21)
        Label1.TabIndex = 22
        Label1.Text = "Profile Specifics"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(454, 239)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 19)
        Label2.TabIndex = 32
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(322, 238)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 19)
        Label3.TabIndex = 31
        Label3.Text = "Appdata Roaming: "
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(454, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 19)
        Label4.TabIndex = 30
        Label4.Text = "Label4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label5.Location = New Point(345, 207)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 19)
        Label5.TabIndex = 29
        Label5.Text = "Appdata Local: "
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label6.Location = New Point(454, 179)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 19)
        Label6.TabIndex = 28
        Label6.Text = "Label6"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label7.Location = New Point(364, 178)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 19)
        Label7.TabIndex = 27
        Label7.Text = "Profile Size: "
        Label7.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F)
        Label8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label8.Location = New Point(454, 151)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 19)
        Label8.TabIndex = 26
        Label8.Text = "Label8"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F)
        Label9.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label9.Location = New Point(337, 150)
        Label9.Name = "Label9"
        Label9.Size = New Size(114, 19)
        Label9.TabIndex = 25
        Label9.Text = "Profile Directory: "
        Label9.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F)
        Label10.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label10.Location = New Point(454, 124)
        Label10.Name = "Label10"
        Label10.Size = New Size(57, 19)
        Label10.TabIndex = 24
        Label10.Text = "Label10"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F)
        Label11.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label11.Location = New Point(364, 123)
        Label11.Name = "Label11"
        Label11.Size = New Size(84, 19)
        Label11.TabIndex = 23
        Label11.Text = "User Name: "
        Label11.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10F)
        Label12.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label12.Location = New Point(451, 424)
        Label12.Name = "Label12"
        Label12.Size = New Size(57, 19)
        Label12.TabIndex = 52
        Label12.Text = "Label12"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10F)
        Label13.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label13.Location = New Point(319, 423)
        Label13.Name = "Label13"
        Label13.Size = New Size(126, 19)
        Label13.TabIndex = 51
        Label13.Text = "Appdata Roaming: "
        Label13.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10F)
        Label14.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label14.Location = New Point(451, 393)
        Label14.Name = "Label14"
        Label14.Size = New Size(57, 19)
        Label14.TabIndex = 50
        Label14.Text = "Label14"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 10F)
        Label15.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label15.Location = New Point(342, 392)
        Label15.Name = "Label15"
        Label15.Size = New Size(103, 19)
        Label15.TabIndex = 49
        Label15.Text = "Appdata Local: "
        Label15.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 10F)
        Label16.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label16.Location = New Point(451, 364)
        Label16.Name = "Label16"
        Label16.Size = New Size(57, 19)
        Label16.TabIndex = 48
        Label16.Text = "Label16"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 10F)
        Label17.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label17.Location = New Point(361, 363)
        Label17.Name = "Label17"
        Label17.Size = New Size(81, 19)
        Label17.TabIndex = 47
        Label17.Text = "Profile Size: "
        Label17.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 10F)
        Label18.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label18.Location = New Point(451, 336)
        Label18.Name = "Label18"
        Label18.Size = New Size(57, 19)
        Label18.TabIndex = 46
        Label18.Text = "Label18"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 10F)
        Label19.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label19.Location = New Point(334, 335)
        Label19.Name = "Label19"
        Label19.Size = New Size(114, 19)
        Label19.TabIndex = 45
        Label19.Text = "Profile Directory: "
        Label19.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 10F)
        Label20.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label20.Location = New Point(451, 309)
        Label20.Name = "Label20"
        Label20.Size = New Size(57, 19)
        Label20.TabIndex = 44
        Label20.Text = "Label20"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 10F)
        Label21.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label21.Location = New Point(361, 308)
        Label21.Name = "Label21"
        Label21.Size = New Size(84, 19)
        Label21.TabIndex = 43
        Label21.Text = "User Name: "
        Label21.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 10F)
        Label22.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label22.Location = New Point(132, 424)
        Label22.Name = "Label22"
        Label22.Size = New Size(57, 19)
        Label22.TabIndex = 42
        Label22.Text = "Label22"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 10F)
        Label23.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label23.Location = New Point(0, 423)
        Label23.Name = "Label23"
        Label23.Size = New Size(126, 19)
        Label23.TabIndex = 41
        Label23.Text = "Appdata Roaming: "
        Label23.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 10F)
        Label24.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label24.Location = New Point(132, 393)
        Label24.Name = "Label24"
        Label24.Size = New Size(57, 19)
        Label24.TabIndex = 40
        Label24.Text = "Label24"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 10F)
        Label25.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label25.Location = New Point(23, 392)
        Label25.Name = "Label25"
        Label25.Size = New Size(103, 19)
        Label25.TabIndex = 39
        Label25.Text = "Appdata Local: "
        Label25.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 10F)
        Label26.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label26.Location = New Point(132, 364)
        Label26.Name = "Label26"
        Label26.Size = New Size(57, 19)
        Label26.TabIndex = 38
        Label26.Text = "Label26"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI", 10F)
        Label27.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label27.Location = New Point(42, 363)
        Label27.Name = "Label27"
        Label27.Size = New Size(81, 19)
        Label27.TabIndex = 37
        Label27.Text = "Profile Size: "
        Label27.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI", 10F)
        Label28.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label28.Location = New Point(132, 336)
        Label28.Name = "Label28"
        Label28.Size = New Size(57, 19)
        Label28.TabIndex = 36
        Label28.Text = "Label28"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Segoe UI", 10F)
        Label29.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label29.Location = New Point(15, 335)
        Label29.Name = "Label29"
        Label29.Size = New Size(114, 19)
        Label29.TabIndex = 35
        Label29.Text = "Profile Directory: "
        Label29.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Segoe UI", 10F)
        Label30.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label30.Location = New Point(132, 309)
        Label30.Name = "Label30"
        Label30.Size = New Size(57, 19)
        Label30.TabIndex = 34
        Label30.Text = "Label30"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Segoe UI", 10F)
        Label31.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label31.Location = New Point(42, 308)
        Label31.Name = "Label31"
        Label31.Size = New Size(84, 19)
        Label31.TabIndex = 33
        Label31.Text = "User Name: "
        Label31.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Segoe UI", 10F)
        Label32.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label32.Location = New Point(451, 568)
        Label32.Name = "Label32"
        Label32.Size = New Size(57, 19)
        Label32.TabIndex = 72
        Label32.Text = "Label32"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Segoe UI", 10F)
        Label33.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label33.Location = New Point(319, 567)
        Label33.Name = "Label33"
        Label33.Size = New Size(126, 19)
        Label33.TabIndex = 71
        Label33.Text = "Appdata Roaming: "
        Label33.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Segoe UI", 10F)
        Label34.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label34.Location = New Point(451, 537)
        Label34.Name = "Label34"
        Label34.Size = New Size(57, 19)
        Label34.TabIndex = 70
        Label34.Text = "Label34"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Segoe UI", 10F)
        Label35.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label35.Location = New Point(342, 536)
        Label35.Name = "Label35"
        Label35.Size = New Size(103, 19)
        Label35.TabIndex = 69
        Label35.Text = "Appdata Local: "
        Label35.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Font = New Font("Segoe UI", 10F)
        Label36.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label36.Location = New Point(451, 508)
        Label36.Name = "Label36"
        Label36.Size = New Size(57, 19)
        Label36.TabIndex = 68
        Label36.Text = "Label36"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Font = New Font("Segoe UI", 10F)
        Label37.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label37.Location = New Point(361, 507)
        Label37.Name = "Label37"
        Label37.Size = New Size(81, 19)
        Label37.TabIndex = 67
        Label37.Text = "Profile Size: "
        Label37.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Font = New Font("Segoe UI", 10F)
        Label38.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label38.Location = New Point(451, 480)
        Label38.Name = "Label38"
        Label38.Size = New Size(57, 19)
        Label38.TabIndex = 66
        Label38.Text = "Label38"
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Font = New Font("Segoe UI", 10F)
        Label39.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label39.Location = New Point(334, 479)
        Label39.Name = "Label39"
        Label39.Size = New Size(114, 19)
        Label39.TabIndex = 65
        Label39.Text = "Profile Directory: "
        Label39.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Font = New Font("Segoe UI", 10F)
        Label40.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label40.Location = New Point(451, 453)
        Label40.Name = "Label40"
        Label40.Size = New Size(57, 19)
        Label40.TabIndex = 64
        Label40.Text = "Label40"
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Font = New Font("Segoe UI", 10F)
        Label41.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label41.Location = New Point(361, 452)
        Label41.Name = "Label41"
        Label41.Size = New Size(84, 19)
        Label41.TabIndex = 63
        Label41.Text = "User Name: "
        Label41.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.Font = New Font("Segoe UI", 10F)
        Label42.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label42.Location = New Point(132, 568)
        Label42.Name = "Label42"
        Label42.Size = New Size(57, 19)
        Label42.TabIndex = 62
        Label42.Text = "Label42"
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.Font = New Font("Segoe UI", 10F)
        Label43.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label43.Location = New Point(0, 567)
        Label43.Name = "Label43"
        Label43.Size = New Size(126, 19)
        Label43.TabIndex = 61
        Label43.Text = "Appdata Roaming: "
        Label43.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.Font = New Font("Segoe UI", 10F)
        Label44.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label44.Location = New Point(132, 537)
        Label44.Name = "Label44"
        Label44.Size = New Size(57, 19)
        Label44.TabIndex = 60
        Label44.Text = "Label44"
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.Font = New Font("Segoe UI", 10F)
        Label45.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label45.Location = New Point(23, 536)
        Label45.Name = "Label45"
        Label45.Size = New Size(103, 19)
        Label45.TabIndex = 59
        Label45.Text = "Appdata Local: "
        Label45.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label46
        ' 
        Label46.AutoSize = True
        Label46.Font = New Font("Segoe UI", 10F)
        Label46.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label46.Location = New Point(132, 508)
        Label46.Name = "Label46"
        Label46.Size = New Size(57, 19)
        Label46.TabIndex = 58
        Label46.Text = "Label46"
        ' 
        ' Label47
        ' 
        Label47.AutoSize = True
        Label47.Font = New Font("Segoe UI", 10F)
        Label47.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label47.Location = New Point(42, 507)
        Label47.Name = "Label47"
        Label47.Size = New Size(81, 19)
        Label47.TabIndex = 57
        Label47.Text = "Profile Size: "
        Label47.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label48
        ' 
        Label48.AutoSize = True
        Label48.Font = New Font("Segoe UI", 10F)
        Label48.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label48.Location = New Point(132, 480)
        Label48.Name = "Label48"
        Label48.Size = New Size(57, 19)
        Label48.TabIndex = 56
        Label48.Text = "Label48"
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Font = New Font("Segoe UI", 10F)
        Label49.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label49.Location = New Point(15, 479)
        Label49.Name = "Label49"
        Label49.Size = New Size(114, 19)
        Label49.TabIndex = 55
        Label49.Text = "Profile Directory: "
        Label49.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label50
        ' 
        Label50.AutoSize = True
        Label50.Font = New Font("Segoe UI", 10F)
        Label50.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label50.Location = New Point(132, 453)
        Label50.Name = "Label50"
        Label50.Size = New Size(57, 19)
        Label50.TabIndex = 54
        Label50.Text = "Label50"
        ' 
        ' Label51
        ' 
        Label51.AutoSize = True
        Label51.Font = New Font("Segoe UI", 10F)
        Label51.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label51.Location = New Point(42, 452)
        Label51.Name = "Label51"
        Label51.Size = New Size(84, 19)
        Label51.TabIndex = 53
        Label51.Text = "User Name: "
        Label51.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label52
        ' 
        Label52.AutoSize = True
        Label52.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label52.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label52.Location = New Point(8, 606)
        Label52.Name = "Label52"
        Label52.Size = New Size(122, 21)
        Label52.TabIndex = 73
        Label52.Text = "Profile Actions"
        ' 
        ' btnClearTempFiles
        ' 
        btnClearTempFiles.BackColor = Color.SteelBlue
        btnClearTempFiles.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnClearTempFiles.FlatStyle = FlatStyle.Flat
        btnClearTempFiles.Location = New Point(12, 635)
        btnClearTempFiles.Name = "btnClearTempFiles"
        btnClearTempFiles.Size = New Size(163, 27)
        btnClearTempFiles.TabIndex = 74
        btnClearTempFiles.Text = "Clear Temp Files"
        btnClearTempFiles.UseVisualStyleBackColor = False
        ' 
        ' btnResetEdge
        ' 
        btnResetEdge.BackColor = Color.SteelBlue
        btnResetEdge.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnResetEdge.FlatStyle = FlatStyle.Flat
        btnResetEdge.Location = New Point(12, 668)
        btnResetEdge.Name = "btnResetEdge"
        btnResetEdge.Size = New Size(163, 27)
        btnResetEdge.TabIndex = 75
        btnResetEdge.Text = "Reset Microsoft Edge"
        btnResetEdge.UseVisualStyleBackColor = False
        ' 
        ' dgFolders
        ' 
        dgFolders.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgFolders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgFolders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgFolders.Columns.AddRange(New DataGridViewColumn() {colFolder, colSize})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgFolders.DefaultCellStyle = DataGridViewCellStyle2
        dgFolders.Location = New Point(625, 200)
        dgFolders.Name = "dgFolders"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgFolders.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgFolders.ScrollBars = ScrollBars.Vertical
        dgFolders.Size = New Size(447, 272)
        dgFolders.TabIndex = 79
        ' 
        ' colFolder
        ' 
        colFolder.HeaderText = "Folder"
        colFolder.Name = "colFolder"
        ' 
        ' colSize
        ' 
        colSize.HeaderText = "Size"
        colSize.Name = "colSize"
        ' 
        ' lblLastFolder
        ' 
        lblLastFolder.AutoSize = True
        lblLastFolder.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblLastFolder.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblLastFolder.Location = New Point(625, 176)
        lblLastFolder.Name = "lblLastFolder"
        lblLastFolder.Size = New Size(132, 21)
        lblLastFolder.TabIndex = 80
        lblLastFolder.Text = "Profile Specifics"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(1189, 737)
        Controls.Add(lblLastFolder)
        Controls.Add(dgFolders)
        Controls.Add(btnResetEdge)
        Controls.Add(btnClearTempFiles)
        Controls.Add(Label52)
        Controls.Add(Label32)
        Controls.Add(Label33)
        Controls.Add(Label34)
        Controls.Add(Label35)
        Controls.Add(Label36)
        Controls.Add(Label37)
        Controls.Add(Label38)
        Controls.Add(Label39)
        Controls.Add(Label40)
        Controls.Add(Label41)
        Controls.Add(Label42)
        Controls.Add(Label43)
        Controls.Add(Label44)
        Controls.Add(Label45)
        Controls.Add(Label46)
        Controls.Add(Label47)
        Controls.Add(Label48)
        Controls.Add(Label49)
        Controls.Add(Label50)
        Controls.Add(Label51)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(Label14)
        Controls.Add(Label15)
        Controls.Add(Label16)
        Controls.Add(Label17)
        Controls.Add(Label18)
        Controls.Add(Label19)
        Controls.Add(Label20)
        Controls.Add(Label21)
        Controls.Add(Label22)
        Controls.Add(Label23)
        Controls.Add(Label24)
        Controls.Add(Label25)
        Controls.Add(Label26)
        Controls.Add(Label27)
        Controls.Add(Label28)
        Controls.Add(Label29)
        Controls.Add(Label30)
        Controls.Add(Label31)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label11)
        Controls.Add(Label1)
        Controls.Add(lblAppdataRoaming)
        Controls.Add(lblAppDataRoamingTitle)
        Controls.Add(lblAppDataLocal)
        Controls.Add(lblAppDataLocalTitle)
        Controls.Add(btnRefreshProfileSize)
        Controls.Add(lblProfileSize)
        Controls.Add(lblProfileSizeTitle)
        Controls.Add(lblProfileDirectory)
        Controls.Add(lblProfileDirectoryTitle)
        Controls.Add(lblUserName)
        Controls.Add(lblUserNameTitle)
        Controls.Add(lblProfileDetailsTitle)
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
    Friend WithEvents lblProfileDetailsTitle As Label
    Friend WithEvents lblAppDataLocal As Label
    Friend WithEvents lblAppDataLocalTitle As Label
    Friend WithEvents btnRefreshProfileSize As Button
    Friend WithEvents lblProfileSize As Label
    Friend WithEvents lblProfileSizeTitle As Label
    Friend WithEvents lblProfileDirectory As Label
    Friend WithEvents lblProfileDirectoryTitle As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblUserNameTitle As Label
    Friend WithEvents lblAppdataRoaming As Label
    Friend WithEvents lblAppDataRoamingTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnClearTempFiles As Button
    Friend WithEvents btnResetEdge As Button
    Friend WithEvents dgFolders As DataGridView
    Friend WithEvents colFolder As DataGridViewTextBoxColumn
    Friend WithEvents colSize As DataGridViewTextBoxColumn
    Friend WithEvents lblLastFolder As Label

End Class
