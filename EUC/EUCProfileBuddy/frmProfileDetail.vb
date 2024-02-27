Imports System.ComponentModel

Public Class frmProfileDetail
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Subroutine to close the profile details form
        Me.Close()

    End Sub

    Private Sub frmProfileDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Subroutine to load the profile details into the form

        ' Load the profile details
        LoadProfileDetails()

        ' Sort the data grids
        dgShell.Sort(dgShell.Columns(0), ListSortDirection.Ascending)
        btnSortFolderRedirection.Text = "Descending"
        dgProfile.Sort(dgProfile.Columns(0), ListSortDirection.Ascending)
        btnSortProfileData.Text = "Descending"

        ' Position the form correctly next to the other main window
        Me.Location = New Point(((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) - frmMain.Width) - 3, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height))

    End Sub

    Private Sub btnSortProfileData_Click(sender As Object, e As EventArgs) Handles btnSortProfileData.Click
        ' Subroutine to sort the Profile Data Grid

        ' Select on currently sorted case and sort accordingly
        Select Case dgProfile.SortOrder
            Case SortOrder.Ascending
                dgProfile.Sort(dgProfile.Columns(0), ListSortDirection.Descending)
                btnSortProfileData.Text = "Ascending"
            Case SortOrder.Descending
                dgProfile.Sort(dgProfile.Columns(0), ListSortDirection.Ascending)
                btnSortProfileData.Text = "Descending"
            Case Else
                dgProfile.Sort(dgProfile.Columns(0), ListSortDirection.Ascending)
                btnSortProfileData.Text = "Descending"
        End Select

    End Sub

    Private Sub btnSortFolderRedirection_Click(sender As Object, e As EventArgs) Handles btnSortFolderRedirection.Click
        ' Subroutine to sort the Folder Redirection Data Grid

        ' Select on currently sorted case and sort accordingly
        Select Case dgShell.SortOrder
            Case SortOrder.Ascending
                dgShell.Sort(dgShell.Columns(0), ListSortDirection.Descending)
                btnSortFolderRedirection.Text = "Ascending"
            Case SortOrder.Descending
                dgShell.Sort(dgShell.Columns(0), ListSortDirection.Ascending)
                btnSortFolderRedirection.Text = "Descending"
            Case Else
                dgShell.Sort(dgShell.Columns(0), ListSortDirection.Ascending)
                btnSortFolderRedirection.Text = "Descending"
        End Select
    End Sub
End Class