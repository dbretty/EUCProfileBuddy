Imports System.IO
Imports Microsoft.Win32

Module modRegistry

    ' This module holds all the functions and subroutines for registry calls use within the application
    ' Anything that touches the registry of the client machine should go here

    Public Function ReadVolatileEnvironment(valueName As String) As String
        ' Function to read a value from the users volatile environment registry location

        ' Read the passed in value and retuen the data from the function
        ReadVolatileEnvironment = My.Computer.Registry.GetValue(volatileEnvironment, valueName, Nothing)

    End Function

    Public Function ReadEUCBuddy(valueName As String) As String()
        ' Function to read in the EUC Profile Buddy configuration settings
        ' If the settings do not exist (such as first run) it will create them

        ' Check if the key already exists
        If My.Computer.Registry.CurrentUser.OpenSubKey(eucProfileBuddyKey) Is Nothing Then

            ' Key does not exist so open the Software master Key
            Dim keyEUCProfileBuddy As RegistryKey = Registry.CurrentUser.OpenSubKey("Software", True)

            ' Create the subkey for EUCProfileBuddy
            Dim newSubKey As RegistryKey = keyEUCProfileBuddy.CreateSubKey("EUCProfileBuddy")

            ' Set the default values for the EUC Profile Buddy application
            ' These are defined in the modGlobal file
            newSubKey.SetValue("Directories", tempData)
            newSubKey.SetValue("Files", tempFiles)
            newSubKey.SetValue("CustomScripts", tempScripts)

        End If

        ' Get the required values from the value name passed into the function
        ' Return them as an Array from the function
        ReadEUCBuddy = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\" & eucProfileBuddyKey, valueName, Nothing)

    End Function

    Public Function ProfileType() As String
        ' Function to get the profile type in use 
        ' Returns the profile type as a text string

        ' Checks for the FSLogix Enablement Key
        If Not My.Computer.Registry.GetValue(fslogixProfileKey, fslogixProfileValue, Nothing) Is Nothing Then
            ProfileType = fslogixProfileDescription
        Else
            ' Checks for the Citrix Profile Management Enablement Key
            If Not My.Computer.Registry.GetValue(citrixPmProfileKey, citrixPmProfileValue, Nothing) Is Nothing Then
                ProfileType = citrixPmProfileDescription
            Else
                ' Assumes its a Local Profile
                ProfileType = localProfileDescription
            End If
        End If

    End Function

    Public Sub LoadProfileRegistryDetails(registryRoot As String, registryLocation As String)
        ' Subroutine to load the Profile Details into the data grid from the registry

        ' Declare all local variables for use within the subroutine
        Dim valueDetail As String
        Dim parentKey As RegistryKey

        ' Clear the Profile Detail data grid prior to loading it
        frmProfileDetail.dgProfile.Rows.Clear()

        ' Set the registry Parent Key based on HKLM or HKCU
        ' Default to HKCU if no valid entry found
        Select Case registryLocation
            Case "HKLM"
                parentKey = My.Computer.Registry.LocalMachine.OpenSubKey(registryRoot)
            Case "HKCU"
                parentKey = My.Computer.Registry.CurrentUser.OpenSubKey(registryRoot)
            Case Else
                parentKey = My.Computer.Registry.CurrentUser.OpenSubKey(registryRoot)
        End Select

        ' Loop through each value in the registry key
        For Each valueName As String In parentKey.GetValueNames()

            ' Set error handing to ResumeNext in the event of a rights issue
            On Error Resume Next

            'Get the value from the registry key
            valueDetail = parentKey.GetValue(valueName)

            ' Add the value to the data grid item
            frmProfileDetail.dgProfile.Rows.Add(valueName, valueDetail)

        Next

    End Sub

    Public Sub LoadProfileShellRedirectionDetails(registryRoot As String, registryLocation As String)
        ' Subroutine to load the Folder Shell Redirection details into a Data Grid object

        ' Declare all local variables for use within the subroutine
        Dim valueDetail As String
        Dim parentKey As RegistryKey

        ' Clear the Shell Redirection Folder data grid
        frmProfileDetail.dgShell.Rows.Clear()

        ' Set the registry Parent Key based on HKLM or HKCU
        ' Default to HKCU if no valid entry found
        Select Case registryLocation
            Case "HKLM"
                parentKey = My.Computer.Registry.LocalMachine.OpenSubKey(registryRoot)
            Case "HKCU"
                parentKey = My.Computer.Registry.CurrentUser.OpenSubKey(registryRoot)
            Case Else
                parentKey = My.Computer.Registry.CurrentUser.OpenSubKey(registryRoot)
        End Select

        ' Loop through each value in the registry key
        For Each valueName As String In parentKey.GetValueNames()

            ' Set error handing to ResumeNext in the event of a rights issue
            On Error Resume Next

            'Get the value from the registry key
            valueDetail = parentKey.GetValue(valueName)

            ' Check if the folder is due to be processed based on the folderRedirectionFilter Array
            If folderRedirectionFilter.Contains(valueName) Then
                frmProfileDetail.dgShell.Rows.Add(valueName, valueDetail)
            End If

        Next

    End Sub

End Module
