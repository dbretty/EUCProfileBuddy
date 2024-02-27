Imports System.IO
Imports Microsoft.Win32

Module modRegistry

    Public Function ReadVolatileEnvironment(valueName As String) As String

        ReadVolatileEnvironment = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Volatile Environment", valueName, Nothing)

    End Function

    Public Function ReadEUCBuddy(valueName As String) As String()

        If My.Computer.Registry.CurrentUser.OpenSubKey("Software\EUCProfileBuddy") Is Nothing Then
            Dim keyEUCProfileBuddy As RegistryKey = Registry.CurrentUser.OpenSubKey("Software", True)
            Dim newSubKey As RegistryKey = keyEUCProfileBuddy.CreateSubKey("EUCProfileBuddy")
            newSubKey.SetValue("Directories", tempData)
            newSubKey.SetValue("Files", tempFiles)
            newSubKey.SetValue("CustomScripts", tempScripts)
        End If

        ReadEUCBuddy = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\EUCProfileBuddy", valueName, Nothing)

    End Function

    Public Function ProfileType() As String

        If Not My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\FSLogix\Profiles", "Enabled", Nothing) Is Nothing Then
            ProfileType = "Microsoft FSLogix"
        Else
            If Not My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Citrix\UserProfileManager", "ServiceActive", Nothing) Is Nothing Then
                ProfileType = "Citrix Profile Management"
            Else
                ProfileType = "Local"
            End If
        End If

    End Function

    Public Sub LoadProfileRegistryDetails(registryRoot As String, registryLocation As String)

        Dim valueDetail As String
        Dim parentKey As RegistryKey

        If registryLocation = "HKLM" Then
            parentKey = My.Computer.Registry.LocalMachine.OpenSubKey(registryRoot)
        Else
            parentKey = My.Computer.Registry.CurrentUser.OpenSubKey(registryRoot)
        End If

        For Each valueName As String In parentKey.GetValueNames()
            On Error Resume Next
            valueDetail = parentKey.GetValue(valueName)
            frmProfileDetail.dgProfile.Rows.Add(valueName, valueDetail)
        Next

    End Sub

    Public Sub LoadProfileShellRedirectionDetails(registryRoot As String, registryLocation As String)

        Dim valueDetail As String
        Dim parentKey As RegistryKey

        If registryLocation = "HKLM" Then
            parentKey = My.Computer.Registry.LocalMachine.OpenSubKey(registryRoot)
        Else
            parentKey = My.Computer.Registry.CurrentUser.OpenSubKey(registryRoot)
        End If

        For Each valueName As String In parentKey.GetValueNames()
            On Error Resume Next
            valueDetail = parentKey.GetValue(valueName)
            frmProfileDetail.dgShell.Rows.Add(valueName, valueDetail)
        Next

    End Sub

End Module
