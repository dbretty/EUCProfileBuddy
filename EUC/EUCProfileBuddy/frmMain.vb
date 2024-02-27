
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class frmMain

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        If Me.WindowState = FormWindowState.Minimized Then
            MinimizeApplication(icnNotify, Me)
        End If

    End Sub

    Private Sub icnNotify_DoubleClick(sender As Object, e As EventArgs) Handles icnNotify.DoubleClick

        MaximizeApplication(icnNotify, Me)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim commandLineArgs() As String = Environment.GetCommandLineArgs
        Dim sanitizedCommand As String

        If commandLineArgs.Count > 1 Then
            LoadProfileData()
            For Each commandLine In commandLineArgs
                sanitizedCommand = LCase(commandLine)
                Select Case sanitizedCommand
                    Case "/cleartemp"
                        ClearTemporaryFiles(userProfileDirectory, True)
                    Case "/customscripts"
                        RunCustomScripts(Scripts, userProfileDirectory, True)
                End Select
            Next
            Application.Exit()
        Else
            SetMouseBusy()
            LoadProfileData()
            LoadFolderGrid(userProfileDirectory)
            SetMouseNotBusy()

            Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
            Me.WindowState = FormWindowState.Minimized
        End If


    End Sub

    Private Sub ctxMenuExit_Click(sender As Object, e As EventArgs) Handles ctxMenuExit.Click

        ExitApplication()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ExitApplication()

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click

        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub dgFolders_DoubleClick(sender As Object, e As EventArgs) Handles dgFolders.DoubleClick

        If (dgFolders.CurrentCell.ColumnIndex = 0) Then
            Dim selectedFolder As String = dgFolders.CurrentCell.Value
            SetMouseBusy()
            LoadFolderGrid(selectedFolder)
            SetMouseNotBusy()
        End If

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        If (dgFolders.CurrentCell.ColumnIndex = 0) Then
            Dim selectedFolder As String = dgFolders.CurrentCell.Value
            SetMouseBusy()
            DeleteFolder(selectedFolder)
            LoadFolderGrid(Me.lblLastFolder.Text)
            LoadProfileData()
            SetMouseNotBusy()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Dim lastFolder As String = Me.lblLastFolder.Text
        If Not (lastFolder = userProfileDirectory) Then
            Dim trimmedFolder As String = lastFolder.Substring(0, lastFolder.LastIndexOf("\"))
            SetMouseBusy()
            LoadFolderGrid(trimmedFolder)
            SetMouseNotBusy()
        Else
            DisplayErrorBox("You cannot roam above the root User Profile directory of " & userProfileDirectory)
        End If



    End Sub

    Private Sub cmdExecute_Click(sender As Object, e As EventArgs) Handles cmdExecute.Click

        Select Case Me.cmbAction.Text
            Case "Select Action"
                DisplayErrorBox("You must select an action to execute")
            Case "Clear Temp Files"
                ClearTemporaryFiles(userProfileDirectory, False)
            Case "Reset Microsoft Edge"
                ResetMicrosoftEdge(appdataLocal)
            Case "Run Custom Scripts"
                RunCustomScripts(Scripts, userProfileDirectory, False)
        End Select
        Me.cmbAction.Text = "Select Action"

    End Sub

    Private Sub btnShowProfileDetail_Click(sender As Object, e As EventArgs) Handles btnShowProfileDetail.Click

        frmProfileDetail.Show()

    End Sub
End Class
