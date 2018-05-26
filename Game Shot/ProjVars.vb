Module ProjVars

    Public Projrootglobal As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments

    Public Projrootglobal2 As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments

    Public ProjClientglobal As String = "Client"


    Public ProjClientglobal2 As String = "Client"

    Public ProjNameglobal As String = "name"

    Public ProjFolderglobal As String = ProjClientglobal

    Public ProjFolderglobal2 As String = ProjClientglobal2

    Public Screencapturekey As String = "V"

    Public Monitorfolderglobal As String = "V"
    'Public ProjFolderglobal As String = ProjClientglobal & "\" & ProjNameglobal

    'Public ProjFolderglobal2 As String = ProjClientglobal2 & "\" & ProjNameglobal

    Public ProjFoldersGlobal As String() = {ProjFolderglobal, ProjFolderglobal2}


    Public Foldersbatloc As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\VLT\Folders.bat"

    Public FoldersbatlocDesign As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\VLT\Folders_Design.bat"

    Public FoldersbatlocAudio As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\VLT\Folders_Audio.bat"

    Public FoldersbatlocVideo As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\VLT\Folders_Video.bat"

    Public Foldersbatloc3d As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\VLT\Folders_3d.bat"

    Public AudioProj As Boolean = False

    Public h3dProj As Boolean = False

    Public DesignProj As Boolean = False

    Public VideoProj As Boolean = False

    Public AllProj As Boolean = True

    Public CreateThisFolder As String

    Public ProjClientnameglobal As String = "Client"

    Public Root2 As Boolean = False

    Public Foundfiles() As String

    Public VidExtensions As New List(Of String)

    Public Extlist1g As New List(Of String)

    Public Extlist2g As New List(Of String)


    ' APP LOCATIONS

    Public PremiereLocation = "C:\Program Files\Adobe\Adobe Premiere Pro CC 2018\Adobe Premiere Pro.exe"



End Module
