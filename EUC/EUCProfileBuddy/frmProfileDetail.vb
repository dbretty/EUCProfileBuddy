Public Class frmProfileDetail
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub frmProfileDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadProfileDetails()
        Me.Location = New Point(((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) - frmMain.Width) - 5, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height))

    End Sub
End Class