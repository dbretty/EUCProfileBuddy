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
        icnNotify = New NotifyIcon(components)
        ctxMenu = New ContextMenuStrip(components)
        mnuBackup = New ToolStripMenuItem()
        ResetToolStripMenuItem = New ToolStripMenuItem()
        EdgeProfileToolStripMenuItem = New ToolStripMenuItem()
        BackupToolStripMenuItem = New ToolStripMenuItem()
        EMailSignaturesToolStripMenuItem = New ToolStripMenuItem()
        ChromeFavoritesToolStripMenuItem = New ToolStripMenuItem()
        EdgeFavoritesToolStripMenuItem = New ToolStripMenuItem()
        ctxSep1 = New ToolStripSeparator()
        ctxMenuExit = New ToolStripMenuItem()
        grpProfileDetails = New GroupBox()
        lblAppDataLocal = New Label()
        lblAppDataLocalTitle = New Label()
        btnRefreshProfileSize = New Button()
        lblProfileSize = New Label()
        lblProfileSizeTitle = New Label()
        lblProfileDirectory = New Label()
        lblProfileDirectoryTitle = New Label()
        lblUserName = New Label()
        lblUserNameTitle = New Label()
        mnuMain = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        mnuExit = New ToolStripMenuItem()
        mnuReset = New ToolStripMenuItem()
        resetEdge = New ToolStripMenuItem()
        btnResetEdge = New Button()
        btnClearTempFiles = New Button()
        ctxMenu.SuspendLayout()
        grpProfileDetails.SuspendLayout()
        mnuMain.SuspendLayout()
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
        ctxMenu.Items.AddRange(New ToolStripItem() {mnuBackup, ctxSep1, ctxMenuExit})
        ctxMenu.Name = "ctxMenu"
        ctxMenu.Size = New Size(144, 54)
        ' 
        ' mnuBackup
        ' 
        mnuBackup.DropDownItems.AddRange(New ToolStripItem() {ResetToolStripMenuItem, BackupToolStripMenuItem})
        mnuBackup.Name = "mnuBackup"
        mnuBackup.Size = New Size(143, 22)
        mnuBackup.Text = "Maintenance"
        ' 
        ' ResetToolStripMenuItem
        ' 
        ResetToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EdgeProfileToolStripMenuItem})
        ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        ResetToolStripMenuItem.Size = New Size(113, 22)
        ResetToolStripMenuItem.Text = "Reset"
        ' 
        ' EdgeProfileToolStripMenuItem
        ' 
        EdgeProfileToolStripMenuItem.Name = "EdgeProfileToolStripMenuItem"
        EdgeProfileToolStripMenuItem.Size = New Size(137, 22)
        EdgeProfileToolStripMenuItem.Text = "Edge Profile"
        ' 
        ' BackupToolStripMenuItem
        ' 
        BackupToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EMailSignaturesToolStripMenuItem, ChromeFavoritesToolStripMenuItem, EdgeFavoritesToolStripMenuItem})
        BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        BackupToolStripMenuItem.Size = New Size(113, 22)
        BackupToolStripMenuItem.Text = "Backup"
        ' 
        ' EMailSignaturesToolStripMenuItem
        ' 
        EMailSignaturesToolStripMenuItem.Name = "EMailSignaturesToolStripMenuItem"
        EMailSignaturesToolStripMenuItem.Size = New Size(167, 22)
        EMailSignaturesToolStripMenuItem.Text = "eMail Signatures"
        ' 
        ' ChromeFavoritesToolStripMenuItem
        ' 
        ChromeFavoritesToolStripMenuItem.Name = "ChromeFavoritesToolStripMenuItem"
        ChromeFavoritesToolStripMenuItem.Size = New Size(167, 22)
        ChromeFavoritesToolStripMenuItem.Text = "Chrome Favorites"
        ' 
        ' EdgeFavoritesToolStripMenuItem
        ' 
        EdgeFavoritesToolStripMenuItem.Name = "EdgeFavoritesToolStripMenuItem"
        EdgeFavoritesToolStripMenuItem.Size = New Size(167, 22)
        EdgeFavoritesToolStripMenuItem.Text = "Edge Favorites"
        ' 
        ' ctxSep1
        ' 
        ctxSep1.Name = "ctxSep1"
        ctxSep1.Size = New Size(140, 6)
        ' 
        ' ctxMenuExit
        ' 
        ctxMenuExit.Name = "ctxMenuExit"
        ctxMenuExit.Size = New Size(143, 22)
        ctxMenuExit.Text = "Exit"
        ' 
        ' grpProfileDetails
        ' 
        grpProfileDetails.Controls.Add(lblAppDataLocal)
        grpProfileDetails.Controls.Add(lblAppDataLocalTitle)
        grpProfileDetails.Controls.Add(btnRefreshProfileSize)
        grpProfileDetails.Controls.Add(lblProfileSize)
        grpProfileDetails.Controls.Add(lblProfileSizeTitle)
        grpProfileDetails.Controls.Add(lblProfileDirectory)
        grpProfileDetails.Controls.Add(lblProfileDirectoryTitle)
        grpProfileDetails.Controls.Add(lblUserName)
        grpProfileDetails.Controls.Add(lblUserNameTitle)
        grpProfileDetails.Font = New Font("Segoe UI", 9F)
        grpProfileDetails.Location = New Point(12, 37)
        grpProfileDetails.Name = "grpProfileDetails"
        grpProfileDetails.Size = New Size(312, 189)
        grpProfileDetails.TabIndex = 1
        grpProfileDetails.TabStop = False
        grpProfileDetails.Text = "Profile Details"
        ' 
        ' lblAppDataLocal
        ' 
        lblAppDataLocal.AutoSize = True
        lblAppDataLocal.Location = New Point(118, 111)
        lblAppDataLocal.Name = "lblAppDataLocal"
        lblAppDataLocal.Size = New Size(94, 15)
        lblAppDataLocal.TabIndex = 8
        lblAppDataLocal.Text = "lblAppDataLocal"
        ' 
        ' lblAppDataLocalTitle
        ' 
        lblAppDataLocalTitle.AutoSize = True
        lblAppDataLocalTitle.Location = New Point(22, 111)
        lblAppDataLocalTitle.Name = "lblAppDataLocalTitle"
        lblAppDataLocalTitle.Size = New Size(89, 15)
        lblAppDataLocalTitle.TabIndex = 7
        lblAppDataLocalTitle.Text = "Appdata Local: "
        lblAppDataLocalTitle.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnRefreshProfileSize
        ' 
        btnRefreshProfileSize.Location = New Point(226, 82)
        btnRefreshProfileSize.Name = "btnRefreshProfileSize"
        btnRefreshProfileSize.Size = New Size(75, 23)
        btnRefreshProfileSize.TabIndex = 6
        btnRefreshProfileSize.Text = "Refresh"
        btnRefreshProfileSize.UseVisualStyleBackColor = True
        ' 
        ' lblProfileSize
        ' 
        lblProfileSize.AutoSize = True
        lblProfileSize.Location = New Point(118, 82)
        lblProfileSize.Name = "lblProfileSize"
        lblProfileSize.Size = New Size(74, 15)
        lblProfileSize.TabIndex = 5
        lblProfileSize.Text = "lblProfileSize"
        ' 
        ' lblProfileSizeTitle
        ' 
        lblProfileSizeTitle.AutoSize = True
        lblProfileSizeTitle.Location = New Point(41, 82)
        lblProfileSizeTitle.Name = "lblProfileSizeTitle"
        lblProfileSizeTitle.Size = New Size(70, 15)
        lblProfileSizeTitle.TabIndex = 4
        lblProfileSizeTitle.Text = "Profile Size: "
        lblProfileSizeTitle.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblProfileDirectory
        ' 
        lblProfileDirectory.AutoSize = True
        lblProfileDirectory.Location = New Point(118, 54)
        lblProfileDirectory.Name = "lblProfileDirectory"
        lblProfileDirectory.Size = New Size(102, 15)
        lblProfileDirectory.TabIndex = 3
        lblProfileDirectory.Text = "lblProfileDirectory"
        ' 
        ' lblProfileDirectoryTitle
        ' 
        lblProfileDirectoryTitle.AutoSize = True
        lblProfileDirectoryTitle.Location = New Point(14, 54)
        lblProfileDirectoryTitle.Name = "lblProfileDirectoryTitle"
        lblProfileDirectoryTitle.Size = New Size(98, 15)
        lblProfileDirectoryTitle.TabIndex = 2
        lblProfileDirectoryTitle.Text = "Profile Directory: "
        lblProfileDirectoryTitle.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Location = New Point(118, 27)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(75, 15)
        lblUserName.TabIndex = 1
        lblUserName.Text = "lblUserName"
        ' 
        ' lblUserNameTitle
        ' 
        lblUserNameTitle.AutoSize = True
        lblUserNameTitle.Location = New Point(41, 27)
        lblUserNameTitle.Name = "lblUserNameTitle"
        lblUserNameTitle.Size = New Size(71, 15)
        lblUserNameTitle.TabIndex = 0
        lblUserNameTitle.Text = "User Name: "
        lblUserNameTitle.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' mnuMain
        ' 
        mnuMain.Items.AddRange(New ToolStripItem() {mnuFile, mnuReset})
        mnuMain.Location = New Point(0, 0)
        mnuMain.Name = "mnuMain"
        mnuMain.Size = New Size(800, 24)
        mnuMain.TabIndex = 2
        mnuMain.Text = "MenuStrip1"
        ' 
        ' mnuFile
        ' 
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {ToolStripSeparator1, mnuExit})
        mnuFile.Name = "mnuFile"
        mnuFile.Size = New Size(37, 20)
        mnuFile.Text = "File"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(90, 6)
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(93, 22)
        mnuExit.Text = "Exit"
        ' 
        ' mnuReset
        ' 
        mnuReset.DropDownItems.AddRange(New ToolStripItem() {resetEdge})
        mnuReset.Name = "mnuReset"
        mnuReset.Size = New Size(47, 20)
        mnuReset.Text = "Reset"
        ' 
        ' resetEdge
        ' 
        resetEdge.Name = "resetEdge"
        resetEdge.Size = New Size(154, 22)
        resetEdge.Text = "Microsoft Edge"
        ' 
        ' btnResetEdge
        ' 
        btnResetEdge.FlatStyle = FlatStyle.Flat
        btnResetEdge.Location = New Point(458, 55)
        btnResetEdge.Name = "btnResetEdge"
        btnResetEdge.Size = New Size(169, 32)
        btnResetEdge.TabIndex = 3
        btnResetEdge.Text = "Reset Microsoft Edge"
        btnResetEdge.UseCompatibleTextRendering = True
        btnResetEdge.UseVisualStyleBackColor = True
        ' 
        ' btnClearTempFiles
        ' 
        btnClearTempFiles.FlatStyle = FlatStyle.Flat
        btnClearTempFiles.Location = New Point(486, 175)
        btnClearTempFiles.Name = "btnClearTempFiles"
        btnClearTempFiles.Size = New Size(169, 32)
        btnClearTempFiles.TabIndex = 4
        btnClearTempFiles.Text = "Clear Temp Files"
        btnClearTempFiles.UseCompatibleTextRendering = True
        btnClearTempFiles.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClearTempFiles)
        Controls.Add(btnResetEdge)
        Controls.Add(mnuMain)
        Controls.Add(grpProfileDetails)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = mnuMain
        Name = "frmMain"
        Text = "EUC Profile Buddy"
        ctxMenu.ResumeLayout(False)
        grpProfileDetails.ResumeLayout(False)
        grpProfileDetails.PerformLayout()
        mnuMain.ResumeLayout(False)
        mnuMain.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents icnNotify As NotifyIcon
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents ctxSep1 As ToolStripSeparator
    Friend WithEvents ctxMenuExit As ToolStripMenuItem
    Friend WithEvents mnuBackup As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdgeProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EMailSignaturesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChromeFavoritesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdgeFavoritesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpProfileDetails As GroupBox
    Friend WithEvents lblUserNameTitle As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblProfileDirectoryTitle As Label
    Friend WithEvents btnRefreshProfileSize As Button
    Friend WithEvents lblProfileSize As Label
    Friend WithEvents lblProfileSizeTitle As Label
    Friend WithEvents lblProfileDirectory As Label
    Friend WithEvents lblAppDataLocal As Label
    Friend WithEvents lblAppDataLocalTitle As Label
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuReset As ToolStripMenuItem
    Friend WithEvents resetEdge As ToolStripMenuItem
    Friend WithEvents btnResetEdge As Button
    Friend WithEvents btnClearTempFiles As Button

End Class
