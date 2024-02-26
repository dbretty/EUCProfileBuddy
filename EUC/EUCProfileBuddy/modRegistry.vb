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

End Module
