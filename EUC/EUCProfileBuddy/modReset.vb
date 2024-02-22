Imports System.IO

Module modReset

    Public Sub ResetMicrosoftEdge(appdataLocal As String)


        Dim edgePath As String = appdataLocal & "\Microsoft\Edge"

        If (DisplayYesNoBox("Are you sure you want to reset Microsoft Edge to defaults? The following folder and all its contents will be deleted: " & edgePath) = vbYes) Then

            For Each processEdge As Process In Process.GetProcessesByName("msedge")
                processEdge.Kill()
            Next
            Try
                System.IO.Directory.Delete(edgePath, True)
            Catch ex As Exception
                ' Code here to handle errors
            End Try
            DisplayInformationBox("Microsoft Edge Reset to Default Settings")

        End If

    End Sub

    Public Sub ResetTemporaryFiles(appdataLocal As String)


        Dim tempPath As String = appdataLocal & "\Temp"

        If (DisplayYesNoBox("Are you sure you want to clear yout TEMP data? The following folder and all its contents will be deleted: " & tempPath) = vbYes) Then

            Try
                System.IO.Directory.Delete(tempPath, True)
            Catch ex As Exception
                ' Code here to handle errors
            End Try
            DisplayInformationBox("Temporary Files Deleted")

        End If

    End Sub


End Module
