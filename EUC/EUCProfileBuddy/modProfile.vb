Imports System.Data.Common
Imports System.DirectoryServices.ActiveDirectory
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Security.AccessControl
Imports System.Threading

Module modProfile

    Public Sub LoadProfileData()
        ' Subroutine to load the profile data

        ' Get the User Profile Directory, AppData Local and AppData Roaming details
        userProfileDirectory = ReadVolatileEnvironment("USERPROFILE")
        appdataLocal = ReadVolatileEnvironment("LOCALAPPDATA")
        appdataRoaming = ReadVolatileEnvironment("APPDATA")

        ' Read in the EUC Profile Buddy Registry keys
        Directories = ReadEUCBuddy("Directories")
        Files = ReadEUCBuddy("Files")
        Scripts = ReadEUCBuddy("CustomScripts")

        ' Get the profile size using GetFolderSize
        ' Then run that through the Clean Profile Data to convert it to readable formatting
        Dim profileSize As String = CleanProfileSize(GetFolderSize(userProfileDirectory, True))

        ' Load the User Profile Data into the form
        frmMain.lblUserName.Text = userName
        frmMain.lblProfileDirectory.Text = userProfileDirectory
        frmMain.lblProfileSize.Text = profileSize

    End Sub

    Public Function GetFolderSize(ByVal path As String, Optional recurse As Boolean = True) As Long
        ' Function to get a folder size from a path passed in

        ' Declare the Local variables to use
        Dim totalSize As Long = 0

        Try
            ' Get all the files into an array
            Dim files() As String = Directory.GetFiles(path)

            ' Whip through the files and total up the size
            Parallel.For(0, files.Length,
                   Sub(index As Integer)
                       Dim fi As New FileInfo(files(index))
                       Dim size As Long = fi.Length
                       Interlocked.Add(totalSize, size)
                   End Sub)
            ' Catch and exceptions
        Catch ex As Exception
        End Try

        ' If recurse passed in (by default its True) loop through the subfolders
        Try
            If recurse Then

                ' Get the subdirectories and declare the subTotal variable
                Dim subDirs() As String = Directory.GetDirectories(path)
                Dim subTotal As Long = 0

                ' Whip through the subfolder and total up the size
                Parallel.For(0, subDirs.Length,
                       Function(index As Integer)
                           If (File.GetAttributes(subDirs(index)) And FileAttributes.ReparsePoint) <> FileAttributes.ReparsePoint Then
                               Interlocked.Add(subTotal, GetFolderSize(subDirs(index), True))
                               Return subTotal
                           End If
                           Return 0
                       End Function)

                ' Add the subtotal size to the grand total
                Interlocked.Add(totalSize, subTotal)
            End If
            ' Catch any exceptions
        Catch ex As Exception
        End Try

        ' Ruturn the total size of the folder
        Return totalSize

    End Function

    Public Function CleanProfileSize(profileSize As Long) As String
        ' Function to clean the profile size

        Try
            ' Define the local variables to use in the function
            Dim suffixNames As String() = {"bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"}
            Dim counter = 0
            Dim dValue As Decimal = 0
            Decimal.TryParse(profileSize.ToString(), dValue)

            ' Loop through the value dividing it until < 1
            While Math.Round(dValue / 1024) >= 1
                dValue /= 1024
                counter += 1
            End While

            ' Return the data from the function
            Return String.Format("{0:n1} {1}", dValue, suffixNames(counter))

        Catch ex As Exception
            'catch and handle the exception
            Return String.Empty
        End Try

    End Function

    Public Sub LoadFolderGrid(rootDirectory As String)
        ' Subroutine to load the folder grid

        ' Declare the local variables to hold the Directories
        Dim folderDirectories As New Dictionary(Of String, Long)

        ' Load the folders from the root directory passed in
        folderDirectories = LoadFolderDictionary(rootDirectory)

        ' Update the data grid header to the root directory
        frmMain.lblLastFolder.Text = rootDirectory

        ' Order the folder (descending) by folder size
        Dim folderDirectoriesSorted = (From entry In folderDirectories Order By entry.Value Descending Select entry)

        ' Declare a row counter integer
        Dim i As Integer = 0

        ' Clear the Folder data grid 
        frmMain.dgFolders.Rows.Clear()

        ' Loop through the sorted folders and add them to the data grid
        For Each subFolder In folderDirectoriesSorted
            frmMain.dgFolders.Rows.Add(folderDirectoriesSorted(i).Key, CleanProfileSize(folderDirectoriesSorted(i).Value))
            i = i + 1
        Next

        ' Set the Folder column to a fixed width
        frmMain.dgFolders.Columns(0).Width = 450

    End Sub

    Public Function LoadFolderDictionary(rootDirectory As String) As Dictionary(Of String, Long)
        ' Function to create a dictionary object based on the passed in path
        ' This will include both Folders and Files

        ' Declare local variables to hold the folder and file data
        Dim rootDirectories = My.Computer.FileSystem.GetDirectories(rootDirectory)
        Dim rootFiles = My.Computer.FileSystem.GetFiles(rootDirectory)
        Dim dictionaryDirectories As New Dictionary(Of String, Long)
        Dim directorySize As Long
        Dim fileSize As Long

        ' Loop through each of the sub directories 
        For Each subDirectory In rootDirectories

            ' Initalize the directorySize variable
            directorySize = 0

            ' Get the size of the directory
            directorySize = GetFolderSize(subDirectory)

            ' Add the directory name and size to the dictionary object if it is above 0
            If directorySize > 0 Then
                dictionaryDirectories.Add(subDirectory, directorySize)
            End If

        Next

        ' Loop through the subfiles fileFilter
        For Each subFile In rootFiles
            ' Check that the subFile is not in the File Filter
            Dim validFile As Boolean = True
            For Each fileSearch In fileFilter
                If (subFile.ToLower).Contains(fileSearch.ToLower) Then
                    validFile = False
                    Exit For
                End If
            Next
            If validFile = True Then

                ' Initialize the File Size Variable
                fileSize = 0

                ' Get the size of the file
                fileSize = GetFileSize(subFile)

                ' Add the file name and size to the dictionary object if it is above 0
                If fileSize > 0 Then
                    dictionaryDirectories.Add(subFile, fileSize)
                End If

            End If
        Next

        ' Return the dictionary object
        LoadFolderDictionary = dictionaryDirectories

    End Function

    Public Function GetFileSize(ByVal path As String) As Long
        ' Function to get a file size

        ' Initialize the totalSize variable
        Dim totalSize As Long = 0

        ' Try to get the file size
        Try
            Dim info As New FileInfo(path)
            totalSize = info.Length
            ' Catch any exceptions
        Catch ex As Exception
        End Try

        ' Return the total size
        Return totalSize

    End Function

    Public Sub DeleteFolder(currentFolder As String)
        ' Subroutine to delete a folder from the profile

        ' Display a YesNo box to ask if the folder should be deleted
        If (DisplayYesNoBox("Are you sure you want to delete the following folder: " & currentFolder) = vbYes) Then

            ' If vbYes then try to delete the folder
            Try
                System.IO.Directory.Delete(currentFolder, True)
                ' Catch any errors
            Catch ex As Exception
                ' Code here to handle errors
            End Try

        End If

    End Sub

    Public Sub ResetMicrosoftEdge(appdataLocal As String)
        ' Subroutine to reset the Microsoft Edge Browser settings

        ' Define the Edge data path
        Dim edgePath As String = appdataLocal & "\" & edgeConfig

        ' Display a YesNo box to the user and ask about profile deletion
        If (DisplayYesNoBox("Are you sure you want to reset Microsoft Edge to defaults? The following folder and all its contents will be deleted: " & edgePath) = vbYes) Then

            ' Kill all the running Microsoft Edge Processes
            For Each processEdge As Process In Process.GetProcessesByName("msedge")
                processEdge.Kill()
            Next

            ' Delete the Microsoft Edge Profile Data
            Try
                System.IO.Directory.Delete(edgePath, True)
                ' Catch any errors
            Catch ex As Exception
                ' Code here to handle errors
            End Try

            ' Display a message confirming the MS Edge Profile Reset
            DisplayInformationBox("Microsoft Edge Reset to Default Settings")

        End If

    End Sub

    Public Sub ClearTemporaryFiles(userProfileDirectory As String, Optional silentMode As Boolean = False)
        ' Subroutine to delete the temporary files and folders

        ' Check if Silent mode is on
        If silentMode = True Then

            ' Delete the temp data
            RemoveTemporaryFiles(userProfileDirectory)

        Else

            ' If not silent then display a YesNo box to the user asking for confirmation
            If (DisplayYesNoBox("Are you sure you want to clear yout TEMP data?") = vbYes) Then

                ' Delete the temp data
                RemoveTemporaryFiles(userProfileDirectory)

                ' Reload the profile data to cater for new sizing
                LoadProfileData()
                LoadFolderGrid(userProfileDirectory)

                ' Display a message box to the user stating the deletion is complete
                DisplayInformationBox("Temporary Files Deleted")

            End If

        End If

    End Sub

    Public Sub RemoveTemporaryFiles(userProfileDirectory As String)
        ' Subroutine to actually delete the temporary Files and Folders

        ' Declare the local variables to use
        Dim tempPath As String

        ' Loop through the temp directories and delete them
        For Each tempFolder As String In Directories

            ' Build the Temp Path
            tempPath = userProfileDirectory & "\" & tempFolder

            ' Delete the folder
            Try
                System.IO.Directory.Delete(tempPath, True)
                ' Catch any errors
            Catch ex As Exception
                ' Code here to handle errors
            End Try

        Next

        ' Loop through the temp files and delete them
        For Each tempFile As String In Files

            ' Build the Temp Path
            tempPath = userProfileDirectory & "\" & tempFile

            ' Delete the file
            Try
                System.IO.File.Delete(tempPath)
                ' Catch any exceptions
            Catch ex As Exception
                ' Code here to handle errors
            End Try

        Next

    End Sub

    Public Sub ExecuteCustomScript(Scripts As String(), userProfileDirectory As String)
        ' Subroutine to actualy execute the custom scripts after validation

        ' Declare local variables to use
        Dim scriptFile As String

        ' Loop through each script and execute
        For Each script In Scripts

            ' Build Script File Path
            scriptFile = userProfileDirectory & "\" & scriptLocation & "\" & script

            ' Build the arguments
            Dim args As String = scriptParameters & " " & scriptFile

            ' Execute the script
            Process.Start(scriptEngine, args)
        Next

    End Sub
    Public Sub RunCustomScripts(Scripts As String(), userProfileDirectory As String, Optional silentMode As Boolean = False)
        ' Subroutine to run the custom scripts

        ' Declare local variables to use
        Dim messageText As String = "Are you sure you want to run the following custom scripts?" & vbCrLf & vbCrLf
        Dim allScriptsFound As Boolean = True
        Dim scriptFile As String

        ' Loop through the scripts and validate the script exists
        For Each script In Scripts

            ' Build the script path
            scriptFile = userProfileDirectory & "\" & scriptLocation & "\" & script

            ' Check for a valid script file
            If My.Computer.FileSystem.FileExists(scriptFile) = True Then

                ' Update the message to display to the user
                messageText = messageText & scriptFile & vbCrLf
            Else

                ' If the script is not found and silent mode is False
                If silentMode = False Then

                    ' Display error message to the user
                    DisplayErrorBox("Script File Missing! " & scriptFile & " was not found, please ensure it exists before executing")

                End If

                ' Set all Scripts found to False and exit the loop
                allScriptsFound = False
                Exit For

            End If

        Next

        ' If all scripts are found
        If allScriptsFound = True Then

            ' If silent mode is True
            If silentMode = True Then

                ' Execute the Scripts
                ExecuteCustomScript(Scripts, userProfileDirectory)

            Else

                ' Display a message to the user asking for confirmation
                If (DisplayYesNoBox(messageText) = vbYes) Then

                    ' Execute the Scripts
                    ExecuteCustomScript(Scripts, userProfileDirectory)

                    ' Reload the profile data to cater for new sizing
                    LoadProfileData()
                    LoadFolderGrid(userProfileDirectory)

                    ' Display a message to the user indicating success
                    DisplayInformationBox("Custom Scripts executed")

                End If

            End If

        End If

    End Sub

    Public Sub LoadProfileDetails()

        ' Subroutine to load all the profile details into the profile detail form

        ' Set the mouse cursor to hourglass
        SetMouseBusy()

        ' Get the user profile type
        userProfileType = ProfileType()

        ' Clear the user profile detail data grid
        frmProfileDetail.dgProfile.Rows.Clear()

        ' FSLogix Profile - load details into data grid
        If userProfileType = fslogixProfileDescription Then

            ' Set the title for the data grid
            frmProfileDetail.lblProfileSettings.Text = fslogixProfileDescription

            ' Loop through registry array and populate the data grid
            For Each fslogixLocation In fsLogixRegistryLocations
                LoadProfileRegistryDetails(fslogixLocation, hkeyLocalMachine)
            Next

        End If

        ' Local Profile - load details into data grid
        If userProfileType = localProfileDescription Then

            ' Set the title for the data grid
            frmProfileDetail.lblProfileSettings.Text = localProfileDescription

            ' Loop through registry array and populate the data grid
            For Each localLocation In localRegistryLocations
                LoadProfileRegistryDetails(localLocation, hkeyCurrentUser)
            Next

        End If

        ' Citrix Profile Management - load details into data grid
        If userProfileType = citrixPmProfileDescription Then

            ' Set the title for the grid
            frmProfileDetail.lblProfileSettings.Text = citrixPmProfileDescription

            ' Loop through registry array and populate the data grid
            For Each cpmLocation In cpmRegistryLocations
                LoadProfileRegistryDetails(cpmLocation, hkeyLocalMachine)
            Next

        End If

        ' Load the profile shell folder redirection details
        LoadProfileShellRedirectionDetails(shellFolders, hkeyCurrentUser)

        ' Load the profile detail form headers
        frmProfileDetail.lblAppDataLocal.Text = appdataLocal
        frmProfileDetail.lblAppDataRoaming.Text = appdataRoaming
        frmProfileDetail.lblProfileType.Text = userProfileType

    End Sub

End Module
