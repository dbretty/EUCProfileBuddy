Module modGeneral

    ' This module holds all the functions and subroutines for general use within the application
    ' Anything that cannot be put into another module should go here

    Sub MinimizeApplication(iconNotify As NotifyIcon, currentForm As Form)

        ' Minimize the application to the system tray
        ' Hide the task bar icon when doing so
        iconNotify.Visible = True
        iconNotify.BalloonTipIcon = ToolTipIcon.Info
        iconNotify.BalloonTipTitle = userName + " (" + userProfileDirectory + ")"
        iconNotify.BalloonTipText = balloonTipText
        iconNotify.ShowBalloonTip(baloonTipTimeout)
        iconNotify.Text = appTitle & ": " & userName & " (" & userProfileDirectory & ")"
        currentForm.ShowInTaskbar = False

    End Sub

    Sub MaximizeApplication(iconNotify As NotifyIcon, currentForm As Form)

        ' Maximize the main application window
        ' Show the taskbar icon when doing so
        currentForm.ShowInTaskbar = True
        currentForm.WindowState = FormWindowState.Normal
        iconNotify.Visible = False

    End Sub

    Sub ExitApplication()

        ' Display a YesNo box asking the user if they want to quit the application
        If (DisplayYesNoBox("Are you sure you want to quit?") = vbYes) Then
            Application.Exit()
        End If

    End Sub

    Public Function DisplayYesNoBox(messageText) As String

        ' Display a YesNo box with a Question Icon to the user and return the result (vbYes or vbNo)
        DisplayYesNoBox = MsgBox(messageText, vbYesNo + vbQuestion, appTitle)

    End Function

    Public Function DisplayCriticalYesNoBox(messageText) As String

        ' Display a YesNo box with a Critical Icon to the user and return the result (vbYes or vbNo)
        DisplayCriticalYesNoBox = MsgBox(messageText, vbYesNo + vbCritical, appTitle)

    End Function

    Sub DisplayInformationBox(messageText As String)

        ' Display an information box to the user
        MsgBox(messageText, vbOKOnly + vbInformation, appTitle)

    End Sub

    Sub DisplayErrorBox(messageText As String)

        ' Display an error box to the user
        MsgBox(messageText, vbOKOnly + vbCritical, appTitle)

    End Sub

    Sub SetMouseBusy()

        ' Set the mouse cursor to an hourglass
        Cursor.Current = Cursors.WaitCursor

    End Sub

    Sub SetMouseNotBusy()

        ' Set the mouse pointer back to an arrow
        Cursor.Current = Cursors.Default

    End Sub

End Module
