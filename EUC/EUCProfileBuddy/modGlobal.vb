Module modGlobal

    ' Global Variables for Notify Icon
    Public AppTitle As String = "EUC Profile Buddy"
    Public balloonTipTitle As String = "EUC Profile Buddy"
    Public balloonTipText As String = "Application Minimized To System Tray"
    Public baloonTipTimeout As Integer = 2000

    ' Global variables for user information
    Public userName As String = Environment.UserName
    Public userDomain As String = Environment.UserDomainName
    Public userProfileDirectory As String
    Public currentProfileSize As Integer
    Public appdataLocal As String

End Module
