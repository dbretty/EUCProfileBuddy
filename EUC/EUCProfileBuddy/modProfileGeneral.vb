Imports System.Data.Common
Imports System.DirectoryServices.ActiveDirectory
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Security.AccessControl
Imports System.Threading

Module modProfileGeneral

    Public Sub LoadProfileData()

        ' Get the User Profile Data
        userProfileDirectory = ReadVolatileEnvironment("USERPROFILE")
        appdataLocal = ReadVolatileEnvironment("LOCALAPPDATA")
        appdataRoaming = ReadVolatileEnvironment("APPDATA")
        Directories = ReadEUCBuddy("Directories")
        Files = ReadEUCBuddy("Files")
        Scripts = ReadEUCBuddy("CustomScripts")
        Dim profileSize As String = CleanProfileSize(GetFolderSize(userProfileDirectory, True))

        ' Load the User Profile Data
        frmMain.lblUserName.Text = userName
        frmMain.lblProfileDirectory.Text = userProfileDirectory
        frmMain.lblProfileSize.Text = profileSize

    End Sub

    Public Function CleanProfileSize(profileSize As Long) As String

        Try
            Dim suffixNames As String() = {"bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"}
            Dim counter = 0
            Dim dValue As Decimal = 0
            Decimal.TryParse(profileSize.ToString(), dValue)
            While Math.Round(dValue / 1024) >= 1
                dValue /= 1024
                counter += 1
            End While

            Return String.Format("{0:n1} {1}", dValue, suffixNames(counter))
        Catch ex As Exception
            'catch and handle the exception
            Return String.Empty
        End Try

    End Function

    Public Sub LoadFolderGrid(rootDirectory As String)

        Dim folderDirectories As New Dictionary(Of String, Long)
        folderDirectories = LoadFolderDictionary(rootDirectory)

        frmMain.lblLastFolder.Text = rootDirectory

        Dim folderDirectoriesSorted = (From entry In folderDirectories Order By entry.Value Descending Select entry)

        Dim i As Integer = 0
        frmMain.dgFolders.Rows.Clear()
        For Each subFolder In folderDirectoriesSorted
            frmMain.dgFolders.Rows.Add(folderDirectoriesSorted(i).Key, CleanProfileSize(folderDirectoriesSorted(i).Value))
            i = i + 1
        Next

        frmMain.dgFolders.Columns(0).Width = 450

    End Sub
    Public Function LoadFolderDictionary(rootDirectory As String) As Dictionary(Of String, Long)

        Dim rootDirectories = My.Computer.FileSystem.GetDirectories(rootDirectory)
        Dim rootFiles = My.Computer.FileSystem.GetFiles(rootDirectory)
        Dim dictionaryDirectories As New Dictionary(Of String, Long)
        Dim directorySize As Long
        Dim fileSize As Long

        For Each subDirectory In rootDirectories
            directorySize = 0
            directorySize = GetFolderSize(subDirectory)
            dictionaryDirectories.Add(subDirectory, directorySize)
        Next

        For Each subFile In rootFiles
            If Not ((subFile.ToLower).Contains("ntuser")) Then
                If Not ((subFile.ToLower).Contains("desktop.ini")) Then
                    fileSize = 0
                    fileSize = GetFileSize(subFile)
                    dictionaryDirectories.Add(subFile, fileSize)
                End If
            End If
        Next

        LoadFolderDictionary = dictionaryDirectories

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

    Public Function GetFolderSize(ByVal path As String, Optional recurse As Boolean = True) As Long

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
                               Interlocked.Add(subTotal, GetFolderSize(subDirs(index), True))
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

    Public Function GetFileSize(ByVal path As String) As Long

        Dim totalSize As Long = 0

        Try
            Dim info As New FileInfo(path)
            totalSize = info.Length
        Catch ex As Exception
        End Try

        Return totalSize

    End Function

    Public Sub DeleteFolder(currentFolder As String)

        If (DisplayYesNoBox("Are you sure you want to delete the following folder: " & currentFolder) = vbYes) Then

            Try
                System.IO.Directory.Delete(currentFolder, True)
            Catch ex As Exception
                ' Code here to handle errors
            End Try
            DisplayInformationBox("Folder " & currentFolder & " deleted")

        End If

    End Sub

    Public Sub ResetMicrosoftEdge(appdataLocal As String)


        Dim edgePath As String = appdataLocal & "\Microsoft\Edge"

        If (DisplayYesNoBox("Are you sure you want to reset Microsoft Edge to defaults? The following folder and all its contents will be deleted: " & edgePath) = vbYes) Then

            SetMouseBusy()
            For Each processEdge As Process In Process.GetProcessesByName("msedge")
                processEdge.Kill()
            Next
            Try
                System.IO.Directory.Delete(edgePath, True)
            Catch ex As Exception
                ' Code here to handle errors
            End Try
            SetMouseNotBusy()
            DisplayInformationBox("Microsoft Edge Reset to Default Settings")

        End If

    End Sub

    Public Sub ClearTemporaryFiles(userProfileDirectory As String)

        Dim tempPath As String

        If (DisplayYesNoBox("Are you sure you want to clear yout TEMP data?") = vbYes) Then
            SetMouseBusy()

            For Each tempFolder As String In Directories
                tempPath = userProfileDirectory & "\" & tempFolder
                Try
                    System.IO.Directory.Delete(tempPath, True)
                Catch ex As Exception
                    ' Code here to handle errors
                End Try
            Next

            For Each tempFile As String In Files
                tempPath = userProfileDirectory & "\" & tempFile
                Try
                    System.IO.Directory.Delete(tempPath, True)
                Catch ex As Exception
                    ' Code here to handle errors
                End Try
            Next

            LoadProfileData()
            LoadFolderGrid(userProfileDirectory)
            SetMouseNotBusy()
            DisplayInformationBox("Temporary Files Deleted")

        End If

    End Sub

    Public Sub RunCustomScripts(Scripts As String(), userProfileDirectory As String)

        Dim messageText As String = "Are you sure you want to run the following custom scripts?" & vbCrLf & vbCrLf
        Dim allScriptsFound As Boolean = True
        Dim scriptFile As String

        For Each script In Scripts
            scriptFile = userProfileDirectory & "\AppData\Local\EUCProfileBuddy\" & script
            If My.Computer.FileSystem.FileExists(scriptFile) = True Then
                messageText = messageText & scriptFile & vbCrLf
            Else
                DisplayErrorBox("Script File Missing! " & scriptFile & " was not found, please ensure it exists before executing")
                allScriptsFound = False
                Exit For
            End If
        Next

        If allScriptsFound = True Then
            If (DisplayYesNoBox(messageText) = vbYes) Then
                SetMouseBusy()
                For Each script In Scripts
                    scriptFile = userProfileDirectory & "\AppData\Local\EUCProfileBuddy\" & script
                    Dim args As String = "-executionpolicy bypass -File " & scriptFile
                    Process.Start("powershell.exe", args)
                Next
                LoadProfileData()
                LoadFolderGrid(userProfileDirectory)
                SetMouseNotBusy()
                DisplayInformationBox("Custom Scripts executed")

            End If
        End If

    End Sub

    Public Sub LoadProfileDetails()

        frmProfileDetail.lblAppDataLocal.Text = appdataLocal
        frmProfileDetail.lblAppDataRoaming.Text = appdataRoaming

    End Sub

End Module
