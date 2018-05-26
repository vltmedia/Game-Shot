Imports System.IO

Public Class AddProject

    Public Sub closingSettings() Handles Me.FormClosing

        Form1.Show()
    End Sub

    Private Sub btnNewProject_Click(sender As Object, e As EventArgs) Handles btnNewProject.Click

        ProjNameglobal = txtProjname.Text






        ProjClientglobal = ProjClientglobal




        Dim Pathway = ProjClientglobal & "\" & ProjNameglobal

        My.Computer.FileSystem.CreateDirectory(Pathway)

        '' Creates ALL Folders if checked
        If ChckAll.Checked = True Then

            Dim sourceDir As String = "C:\plugins\"
            Dim backupDir As String = "c:\archives\2008"

            Dim Foldersbat As String = "C:\plugins\Folders.bat"
            Dim Folder As String = Pathway & "\" & "Folders.bat"

            Dim fName As String = "Folders.bat"

            Dim fileExe As String = "Folders.bat"

            File.Copy(Path.Combine(Foldersbatloc), Path.Combine(Pathway, fName), True)

            Dim Folderbatfile As String = Pathway & fName
            Process.Start(Folder)
        End If





        '' Creates Design Folders if checked
        If chkDesign.Checked = True Then

            Dim sourceDir As String = "C:\plugins\"
            Dim backupDir As String = "c:\archives\2008"

            Dim Foldersbat As String = "C:\plugins\Folders_Design.bat"
            Dim Folder As String = Pathway & "\" & "Folders_Design.bat"

            Dim fName As String = "Folders_Design.bat"

            File.Copy(Path.Combine(FoldersbatlocDesign), Path.Combine(Pathway, fName), True)

            Dim Folderbatfile As String = Pathway & fName
            Process.Start(Folder)

            DesignProj = True



        End If

        If chkVideo.Checked = True Then

            Dim sourceDir As String = "C:\plugins\"
            Dim backupDir As String = "c:\archives\2008"

            Dim Foldersbat As String = "C:\plugins\Folders_Video.bat"
            Dim Folder As String = Pathway & "\" & "Folders_Video.bat"

            Dim fName As String = "Folders_Video.bat"

            File.Copy(Path.Combine(FoldersbatlocVideo), Path.Combine(Pathway, fName), True)

            Dim Folderbatfile As String = Pathway & fName
            Process.Start(Folder)

            VideoProj = True

        End If

        If chkAudio.Checked = True Then

            Dim sourceDir As String = "C:\plugins\"
            Dim backupDir As String = "c:\archives\2008"

            Dim Foldersbat As String = "C:\plugins\Folders_Audio.bat"
            Dim Folder As String = Pathway & "\" & "Folders_Audio.bat"

            Dim fName As String = "Folders_Audio.bat"

            File.Copy(Path.Combine(FoldersbatlocAudio), Path.Combine(Pathway, fName), True)

            Dim Folderbatfile As String = Pathway & fName
            Process.Start(Folder)

            AudioProj = True

        End If

        If Chk3D.Checked = True Then

            Dim sourceDir As String = "C:\plugins\"
            Dim backupDir As String = "c:\archives\2008"

            Dim Foldersbat As String = "C:\plugins\Folders_3D.bat"
            Dim Folder As String = Pathway & "\" & "Folders_3D.bat"

            Dim fName As String = "Folders_3D.bat"

            File.Copy(Path.Combine(Foldersbatloc3d), Path.Combine(Pathway, fName), True)

            Dim Folderbatfile As String = Pathway & fName
            Process.Start(Folder)

            h3dProj = True

        End If

























        For Each Dir As String In System.IO.Directory.GetDirectories(ProjClientglobal)
            Dim dirInfo As New System.IO.DirectoryInfo(Dir)
            Form1.comboProjects.Items.Add(dirInfo.Name)
        Next
        Form1.comboProjects.Text = txtProjname.Text
        Process.Start(ProjFolderglobal)
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub AddProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class