Module modRegistry

    Public Function ReadVolatileEnvironment(valueName As String) As String

        ReadVolatileEnvironment = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Volatile Environment", valueName, Nothing)

    End Function

End Module
