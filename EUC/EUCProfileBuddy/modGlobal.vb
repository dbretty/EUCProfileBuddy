Module modGlobal

    ' Global Variables for Notify Icon
    Public appTitle As String = "EUC Profile Buddy"
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
    Public userProfileType As String

    ' Global Variables for Temp Data Locations
    Public tempData As String() = {
        "AppData\Local\Temp",
        "AppData\Roaming\Temp",
        "AppData\Local\Microsoft\Windows\GameExplorer",
        "AppData\Local\Microsoft\Windows\WER",
        "AppData\Local\Microsoft\Windows\CrashReports",
        "AppData\Local\Microsoft\MSOIdentityCRL\Tracing",
        "AppData\Local\CrashDumps",
        "AppData\Local\Package Cache",
        "AppData\Local\D3DSCache",
        "AppData\Local\Microsoft\Windows\WebCache.old"
    }
    Public Directories() As String

    Public tempFiles As String() = {
        "AppData\Local\Temp\file1.txt",
        "AppData\Roaming\Temp\file2.txt"
    }
    Public Files() As String

    Public tempScripts As String() = {
        "tempscript1.ps1",
        "tempscript2.ps1"
    }
    Public Scripts() As String

End Module
