
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

        LoadProfileData()

        Dim profileDirectories As New Dictionary(Of String, Long)
        profileDirectories = LoadProfileSizing(userProfileDirectory)
        Me.lblLastFolder.Text = userProfileDirectory
        Dim profileDirectoriesSorted = (From entry In profileDirectories Order By entry.Value Descending Select entry)
        Dim i As Integer = 0
        For Each subFolder In profileDirectoriesSorted
            dgFolders.Rows.Add(profileDirectoriesSorted(i).Key, profileDirectoriesSorted(i).Value)
            i = i + 1
        Next
        For x As Integer = 0 To dgFolders.ColumnCount - 1
            dgFolders.Columns(x).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)

    End Sub

    Private Sub ctxMenuExit_Click(sender As Object, e As EventArgs) Handles ctxMenuExit.Click

        ExitApplication()

    End Sub

    Private Sub LoadProfileData()

        ' Set the mouse cursor
        SetMouseBusy()

        ' Get the User Profile Data
        userProfileDirectory = ReadVolatileEnvironment("USERPROFILE")
        appdataLocal = ReadVolatileEnvironment("LOCALAPPDATA")
        appdataRoaming = ReadVolatileEnvironment("APPDATA")
        Dim profileSize As String = Math.Round(GetProfileSize(userProfileDirectory, True) / (1024 * 1024 * 1024), 2) & " GB"

        ' Load the User Profile Data
        Me.lblUserName.Text = userName
        Me.lblProfileDirectory.Text = userProfileDirectory
        Me.lblProfileSize.Text = profileSize
        Me.lblAppDataLocal.Text = appdataLocal
        Me.lblAppdataRoaming.Text = appdataRoaming

        ' Set the mouse cursor
        SetMouseNotBusy()

    End Sub

    Private Sub btnRefreshProfileSize_Click(sender As Object, e As EventArgs)

        LoadProfileData()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ExitApplication()

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnClearTempFiles_Click(sender As Object, e As EventArgs) Handles btnClearTempFiles.Click

        ClearTemporaryFiles(appdataLocal)

    End Sub

    Private Sub btnResetEdge_Click(sender As Object, e As EventArgs) Handles btnResetEdge.Click

        ResetMicrosoftEdge(appdataLocal)

    End Sub


    Private Sub dgFolders_DoubleClick(sender As Object, e As EventArgs) Handles dgFolders.DoubleClick

        Dim selectedFolder As String = (dgFolders.Item("colFolder", 0).Value.ToString)
        lblLastFolder.Text = selectedFolder
        Dim profileDirectories As New Dictionary(Of String, Long)
        profileDirectories = LoadProfileSizing(selectedFolder)
        Dim profileDirectoriesSorted = (From entry In profileDirectories Order By entry.Value Descending Select entry)
        Dim i As Integer = 0
        dgFolders.Rows.Clear()
        For Each subFolder In profileDirectoriesSorted
            dgFolders.Rows.Add(profileDirectoriesSorted(i).Key, profileDirectoriesSorted(i).Value)
            i = i + 1
        Next
        For x As Integer = 0 To dgFolders.ColumnCount - 1
            dgFolders.Columns(x).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

    End Sub

    Private Sub lblLastFolder_Click(sender As Object, e As EventArgs) Handles lblLastFolder.Click
        Dim selectedFolder As String = Me.lblLastFolder.Text
        Me.lblLastFolder.Text = selectedFolder
        Dim profileDirectories As New Dictionary(Of String, Long)
        profileDirectories = LoadProfileSizing(selectedFolder)
        Dim profileDirectoriesSorted = (From entry In profileDirectories Order By entry.Value Descending Select entry)
        Dim i As Integer = 0
        dgFolders.Rows.Clear()
        For Each subFolder In profileDirectoriesSorted
            dgFolders.Rows.Add(profileDirectoriesSorted(i).Key, profileDirectoriesSorted(i).Value)
            i = i + 1
        Next
        For x As Integer = 0 To dgFolders.ColumnCount - 1
            dgFolders.Columns(x).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub
End Class
