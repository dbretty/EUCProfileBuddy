Imports EUCProfileBuddy.modGlobal
Module modGeneral

    Sub MinimizeApplication(iconNotify As NotifyIcon, currentForm As Form)

        iconNotify.Visible = True
        iconNotify.BalloonTipIcon = ToolTipIcon.Info
        iconNotify.BalloonTipTitle = userName + " (" + userProfileDirectory + ")"
        iconNotify.BalloonTipText = balloonTipTitle + ": " + balloonTipText
        iconNotify.ShowBalloonTip(baloonTipTimeout)
        currentForm.ShowInTaskbar = False

    End Sub

    Sub MaximizeApplication(iconNotify As NotifyIcon, currentForm As Form)

        currentForm.ShowInTaskbar = True
        currentForm.WindowState = FormWindowState.Normal
        iconNotify.Visible = False

    End Sub

    Sub ExitApplication()

        If (DisplayYesNoBox("Are you sure you want to quit?") = vbYes) Then

            Application.Exit()

        End If

    End Sub

    Public Function DisplayYesNoBox(messageText) As String

        DisplayYesNoBox = MsgBox(messageText, vbYesNo + vbQuestion, AppTitle)

    End Function

    Public Function DisplayCriticalYesNoBox(messageText) As String

        DisplayCriticalYesNoBox = MsgBox(messageText, vbYesNo + vbCritical, AppTitle)

    End Function

    Sub DisplayInformationBox(messageText As String)

        MsgBox(messageText, vbOKOnly + vbInformation, AppTitle)

    End Sub

    Sub DisplayErrorBox(messageText As String)

        MsgBox(messageText, vbOKOnly + vbCritical, AppTitle)

    End Sub

End Module
