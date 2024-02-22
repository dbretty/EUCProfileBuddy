Module modGlobal

    ' Global Variables for Notify Icon
    Public AppTitle As String = "EUC Profile Buddy"
    Public balloonTipTitle As String = "EUC Profile Buddy"
    Public balloonTipText As String = "Profile Buddy has been minimized to the system tray. To open the application double click on the system tray icon."
    Public baloonTipTimeout As Integer = 1000

    ' Global variables for user information
    Public userName As String = Environment.UserName
    Public userDomain As String = Environment.UserDomainName
    Public userProfileDirectory As String
    Public currentProfileSize As Integer
    Public appdataLocal As String
    Public appdataRoaming As String

    ' Global Variables for Temp Data Locations
    Public tempData As String() = {"Temp", "SquirrelTemp"}

End Module
