
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class frmMain

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ' Check if the window state was set to minimized and set the application properties accordingly
        If Me.WindowState = FormWindowState.Minimized Then
            MinimizeApplication(icnNotify, Me)
        End If

    End Sub

    Private Sub icnNotify_DoubleClick(sender As Object, e As EventArgs) Handles icnNotify.DoubleClick

        ' Maximize the application back to normal state
        MaximizeApplication(icnNotify, Me)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Subroutine to handle the application startup

        ' Declare local variables to use at startup
        Dim commandLineArgs() As String = Environment.GetCommandLineArgs
        Dim sanitizedCommand As String

        ' Check to see if and command lines have been passed in
        If commandLineArgs.Count > 1 Then

            ' Load the profile base data to be able to act on command lines
            LoadProfileData()

            ' Loop through each command line option passed in and trigger the relevant action
            For Each commandLine In commandLineArgs

                ' Convert the command line to lowercase
                sanitizedCommand = LCase(commandLine)

                ' Select action based on command line passed in
                Select Case sanitizedCommand
                    Case cliCleanTemp
                        ' Clean the temp files
                        ClearTemporaryFiles(userProfileDirectory, True)
                    Case cliCustomScripts
                        ' Run the custom scripts
                        RunCustomScripts(Scripts, userProfileDirectory, True)
                End Select
            Next

            ' Command Line Options finished
            ' Exit Application
            Application.Exit()

        Else
            ' No command line options passed in
            ' Start application GUI

            ' Set the mouse pointer to an hourglass
            SetMouseBusy()

            ' Load user profile base data
            LoadProfileData()

            ' Load the profile data size grid
            LoadFolderGrid(userProfileDirectory)

            ' Show the form and minimize to the system tray
            Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
            Me.WindowState = FormWindowState.Minimized

            ' Set the mouse pointer back to an arrow
            SetMouseNotBusy()

        End If

    End Sub

    Private Sub ctxMenuExit_Click(sender As Object, e As EventArgs) Handles ctxMenuExit.Click

        ' Subroutine to exit the application from the context menu
        ExitApplication()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Subroutine to exit the application from the exit button
        ExitApplication()

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click

        ' Subroutine to minimize the application to the system tray
        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub dgFolders_DoubleClick(sender As Object, e As EventArgs) Handles dgFolders.DoubleClick

        ' Subroutine to handle the double click on the data folder list

        ' Check the column 0 was clicked
        If (dgFolders.CurrentCell.ColumnIndex = 0) Then

            ' Get the selected folder value
            Dim selectedFolder As String = dgFolders.CurrentCell.Value

            ' Set the mouse cursor to an hourglass
            SetMouseBusy()

            ' Load the data folder grid with the data
            LoadFolderGrid(selectedFolder)

            ' Set the mouse pointer back to an arrow
            SetMouseNotBusy()

        End If

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        ' Subroutine to delete data based on the right click delete menu option

        ' Check that column 0 was right clicked
        If (dgFolders.CurrentCell.ColumnIndex = 0) Then

            ' Get the selected folder value
            Dim selectedFolder As String = dgFolders.CurrentCell.Value

            ' Set the mouse cursor to an hourglass
            SetMouseBusy()

            ' Delete the selected data
            DeleteFolder(selectedFolder)

            ' Reload the profile data as a refresh
            LoadFolderGrid(Me.lblLastFolder.Text)
            LoadProfileData()

            ' Set the mouse pointer back to an arrow
            SetMouseNotBusy()

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        ' Subroutine to move up a folder in the data grid view

        ' Decalre variable to hold the last folder value
        Dim lastFolder As String = Me.lblLastFolder.Text

        ' Validate that the last folder is not the top level user profile directory
        If Not (lastFolder = userProfileDirectory) Then

            ' Trim the last folder from the last Folder Value
            Dim trimmedFolder As String = lastFolder.Substring(0, lastFolder.LastIndexOf("\"))

            ' Set the mouse cursor to an hourglass
            SetMouseBusy()

            ' Reload the data grid folder
            LoadFolderGrid(trimmedFolder)

            ' Set the mouse cursor to a pointer
            SetMouseNotBusy()

        Else

            ' Display an error stating you cannot navigate outside of the user profile
            DisplayErrorBox("You cannot roam above the root User Profile directory of " & userProfileDirectory)

        End If

    End Sub

    Private Sub cmdExecute_Click(sender As Object, e As EventArgs) Handles cmdExecute.Click

        ' Subroutine to execute the action selected in the drop down list

        ' Set the mouse cursor to hour glass
        SetMouseBusy()

        ' Select based on the text in the combo box
        Select Case Me.cmbAction.Text
            ' Nothing selected - display an error
            Case "Select Action"
                ' Error so set the mouse back to pointer
                SetMouseNotBusy()
                DisplayErrorBox("You must select an action to execute")
            ' Clear the temp files
            Case "Clear Temp Files"
                ClearTemporaryFiles(userProfileDirectory, False)
            ' Reset the Microsoft Edge Settings
            Case "Reset Microsoft Edge"
                ResetMicrosoftEdge(appdataLocal)
            ' Run the custom scripts
            Case "Run Custom Scripts"
                RunCustomScripts(Scripts, userProfileDirectory, False)
        End Select

        ' Reset the text in the combo box to the default
        Me.cmbAction.Text = "Select Action"

        ' Set the mouse pointer back to normal
        SetMouseNotBusy()

    End Sub

    Private Sub btnShowProfileDetail_Click(sender As Object, e As EventArgs) Handles btnShowProfileDetail.Click

        ' Subroutine to show the profile details form
        frmProfileDetail.Show()

    End Sub

End Class
