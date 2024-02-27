Public Class frmProfileDetail
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Subroutine to close the profile details form
        Me.Close()

    End Sub

    Private Sub frmProfileDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Subroutine to load the profile details into the form

        ' Load the profile details
        LoadProfileDetails()

        ' Position the form correctly next to the other main window
        Me.Location = New Point(((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) - frmMain.Width) - 3, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height))

    End Sub
End Class