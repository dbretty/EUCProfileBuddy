Imports EUCProfileBuddy.modRegistry

Public Class frmMain
    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        If Me.WindowState = FormWindowState.Minimized Then
            modGeneral.MinimizeApplication(icnNotify, Me)
        End If

    End Sub

    Private Sub icnNotify_DoubleClick(sender As Object, e As EventArgs) Handles icnNotify.DoubleClick

        modGeneral.MaximizeApplication(icnNotify, Me)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load


        LoadProfileData()

        'Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub ctxMenuExit_Click(sender As Object, e As EventArgs) Handles ctxMenuExit.Click

        modGeneral.ExitApplication()

    End Sub

    Private Sub LoadProfileData()

        ' Get the User Profile Data
        userProfileDirectory = ReadVolatileEnvironment("USERPROFILE")
        appdataLocal = ReadVolatileEnvironment("LOCALAPPDATA")
        Dim profileSize As String = Math.Round(GetProfileSize(userProfileDirectory, True) / (1024 * 1024 * 1024), 2) & " GB"

        ' Load the User Profile Data
        Me.lblUserName.Text = userName
        Me.lblProfileDirectory.Text = userProfileDirectory
        Me.lblProfileSize.Text = profileSize
        Me.lblAppDataLocal.Text = appdataLocal

    End Sub

    Private Sub btnRefreshProfileSize_Click(sender As Object, e As EventArgs) Handles btnRefreshProfileSize.Click

        LoadProfileData()

    End Sub

    Private Sub EdgeProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdgeProfileToolStripMenuItem.Click

        ResetMicrosoftEdge(appdataLocal)

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        modGeneral.ExitApplication()

    End Sub

    Private Sub resetEdge_Click(sender As Object, e As EventArgs) Handles resetEdge.Click

        ResetMicrosoftEdge(appdataLocal)

    End Sub

    Private Sub btnResetEdge_Click(sender As Object, e As EventArgs) Handles btnResetEdge.Click

        ResetMicrosoftEdge(appdataLocal)

    End Sub

    Private Sub btnClearTempFiles_Click(sender As Object, e As EventArgs) Handles btnClearTempFiles.Click

        ResetTemporaryFiles(appdataLocal)

    End Sub
End Class
