Imports System.IO
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Threading

Module modProfileGeneral

    Public Function GetProfileSize(ByVal path As String, Optional recurse As Boolean = True) As Long

        Dim totalSize As Long = 0

        Try
            Dim files() As String = Directory.GetFiles(path)
            Parallel.For(0, files.Length,
                   Sub(index As Integer)
                       Dim fi As New FileInfo(files(index))
                       Dim size As Long = fi.Length
                       Interlocked.Add(totalSize, size)
                   End Sub)
        Catch ex As Exception
        End Try

        Try
            If recurse Then
                Dim subDirs() As String = Directory.GetDirectories(path)
                Dim subTotal As Long = 0
                Parallel.For(0, subDirs.Length,
                       Function(index As Integer)
                           If (File.GetAttributes(subDirs(index)) And FileAttributes.ReparsePoint) <> FileAttributes.ReparsePoint Then
                               Interlocked.Add(subTotal, GetProfileSize(subDirs(index), True))
                               Return subTotal
                           End If
                           Return 0
                       End Function)
                Interlocked.Add(totalSize, subTotal)
            End If
        Catch ex As Exception
        End Try

        Return totalSize

    End Function

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

    Public Sub ClearTemporaryFiles(appdataLocal As String)

        Dim tempPath As String

        If (DisplayYesNoBox("Are you sure you want to clear yout TEMP data?") = vbYes) Then
            For Each tempFolder As String In tempData
                tempPath = appdataLocal & "\" & tempFolder
                Try
                    System.IO.Directory.Delete(tempPath, True)
                Catch ex As Exception
                    ' Code here to handle errors
                End Try
            Next

            DisplayInformationBox("Temporary Files Deleted")

        End If

    End Sub

    Public Function GetFolderSize(ByVal path As String) As Long

        Dim totalSize As Long = 0

        Try
            Dim files() As String = Directory.GetFiles(path)
            Parallel.For(0, files.Length,
                   Sub(index As Integer)
                       Dim fi As New FileInfo(files(index))
                       Dim size As Long = fi.Length
                       Interlocked.Add(totalSize, size)
                   End Sub)
        Catch ex As Exception
        End Try

        Try
            Dim subDirs() As String = Directory.GetDirectories(path)
            Dim subTotal As Long = 0
            Parallel.For(0, subDirs.Length,
                   Function(index As Integer)
                       If (File.GetAttributes(subDirs(index)) And FileAttributes.ReparsePoint) <> FileAttributes.ReparsePoint Then
                           Interlocked.Add(subTotal, GetProfileSize(subDirs(index), True))
                           Return subTotal
                       End If
                       Return 0
                   End Function)
            Interlocked.Add(totalSize, subTotal)
        Catch ex As Exception
        End Try

        Return totalSize

    End Function

    Public Function LoadProfileSizing(rootDirectory As String) As Dictionary(Of String, Long)

        Dim rootDirectories = My.Computer.FileSystem.GetDirectories(rootDirectory)

        Dim dictionaryDirectories As New Dictionary(Of String, Long)
        Dim directorySize As Long

        For Each subDirectory In rootDirectories
            directorySize = 0
            directorySize = GetFolderSize(subDirectory)
            dictionaryDirectories.Add(subDirectory, directorySize)
        Next

        LoadProfileSizing = dictionaryDirectories
    End Function

End Module
