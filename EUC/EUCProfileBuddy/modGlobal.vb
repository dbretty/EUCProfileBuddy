Module modGlobal
    ' This module holds all the global variables for use within the application

    ' Global Variables for Notify Icon
    Public Const appTitle As String = "EUC Profile Buddy"
    Public Const balloonTipTitle As String = appTitle
    Public Const balloonTipText As String = "Profile Buddy has been minimized to the system tray. To open the application double click on the system tray icon."
    Public Const baloonTipTimeout As Integer = 1000

    ' Global Variables for Registry Locations
    Public Const hkeyLocalMachine As String = "HKLM"
    Public Const hkeyCurrentUser As String = "HKCU"
    Public Const fslogixProfileKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\FSLogix\Profiles"
    Public Const fslogixProfileValue As String = "Enabled"
    Public Const fslogixProfileDescription As String = "Microsoft FSLogix"
    Public Const citrixPmProfileKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Citrix\UserProfileManager"
    Public Const citrixPmProfileValue As String = "ServiceActive"
    Public Const citrixPmProfileDescription As String = "Citrix Profile Management"
    Public Const localProfileDescription As String = "Local Profile"
    Public Const eucProfileBuddyKey As String = "Software\EUCProfileBuddy"
    Public Const volatileEnvironment As String = "HKEY_CURRENT_USER\Volatile Environment"

    ' Global Variables for CLI Switches
    Public Const cliCleanTemp As String = "/cleantemp"
    Public Const cliCustomScripts As String = "/customscripts"

    ' Global variables for user information
    Public Const shellFolders As String = "Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders"
    Public userName As String = Environment.UserName
    Public userDomain As String = Environment.UserDomainName
    Public userProfileDirectory As String
    Public currentProfileSize As Integer
    Public appdataLocal As String
    Public appdataRoaming As String
    Public userProfileType As String

    ' Global Variables for Browser Data
    Public Const edgeConfig As String = "Microsoft\Edge"

    ' Global Variables for Custom Scripts
    Public Const scriptLocation As String = "AppData\Local\EUCProfileBuddy"
    Public Const scriptParameters As String = "-executionpolicy bypass -File"
    Public Const scriptEngine As String = "powershell.exe"

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

    ' Global variables for Folder Redirection filter
    Public folderRedirectionFilter As String() = {
        "AppData",
        "Cookies",
        "Desktop",
        "Favorites",
        "Local AppData",
        "Personal",
        "Recent",
        "Start Menu",
        "Templates"
    }

    ' Global variables for profile type filters
    Public fsLogixRegistryLocations As String() = {
        "SOFTWARE\FSLogix\Profiles",
        "SOFTWARE\FSLogix\Apps",
        "SOFTWARE\FSLogix\Logging",
        "SOFTWARE\Policies\FSLogix\ODFC"
    }

    Public localRegistryLocations As String() = {
        "Volatile Environment"
    }

    Public cpmRegistryLocations As String() = {
        "SOFTWARE\Policies\Citrix\UserProfileManager"
    }

    ' Global variables for File and Folder Data Grid Filter
    Public fileFilter As String() = {
        "ntuser",
        "desktop.ini"
    }

End Module
