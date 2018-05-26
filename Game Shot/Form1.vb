
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.IO.Compression
Imports System.Threading

Public Class Form1
    Dim Pathtocheck As String
    Dim a As New Process

    Dim Prjlocation As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments

    Dim Documents As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments

    Dim Batlocation As String = Documents & "\VLT\Folders.bat"

    Dim Proj1Path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments

    Dim Projclient As String = "Poop"

    Dim ProjMain As String = "Poop"

    Dim Proj1en As Boolean = True

    Dim Proj2en As Boolean = False

    Dim Proj3en As Boolean = False


    Dim Proj1Name As String = (My.Settings.Proj1Name)

    Dim Proj2Name As String = (My.Settings.Proj2Name)

    Dim Proj3Name As String = (My.Settings.Proj3Name)

    Dim Proj1Pathway As String = (My.Settings.Proj1Pathway)

    Dim Proj2Pathway As String = (My.Settings.Proj2Pathway)

    Dim Proj3Pathway As String = (My.Settings.Proj3Pathway)

    Dim AllButtons As Boolean = False

    Dim FirstStart As Boolean = True

    Dim Projfolder As String = (My.Computer.FileSystem.SpecialDirectories.MyDocuments)

    Dim ProjFoldersaved As String = ""

    ' Dim MainPath As String = ""

    Dim MainName As String = ""

    Dim ProjectsDrop As Boolean = My.Settings.ProjectList

    'Dim ini As New DataViewSetting.IniFile(Documents & "\VLT\new.ini")

    Private folderBrowserDialog1 As FolderBrowserDialog
    ' Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPrjName.Click, lblProjects.Click

    'End Sub

    Private Sub btnProjLocation_Click(sender As Object, e As EventArgs) Handles BtnPrjLocation.Click

        If Directory.Exists(ProjFolderglobal) Then
            Process.Start(ProjFolderglobal)
        End If
        If Directory.Exists(ProjFolderglobal2) Then
            Process.Start(ProjFolderglobal2)
        End If

        'Process.Start(Proj1Pathway)
        'MessageBox.Show("Hope This Worked!",
        '"Successsss!")
    End Sub

    Private Sub BtnSetPrj_Click(sender As Object, e As EventArgs) Handles BtnSetPrj.Click

        If Projfolder = My.Computer.FileSystem.SpecialDirectories.MyDocuments Then
            MessageBox.Show("Please Set the Project Folder")
        End If

        If Projfolder <> My.Computer.FileSystem.SpecialDirectories.MyDocuments Then
            If Proj1en = True Then




                Proj1Name = TxtName1.Text


                Proj1Path = Projfolder
                Prjlocation = Proj1Path

                btnCrtFolders.Enabled = True


                Dim Pathway = Proj1Path & "\" & Proj1Name

                My.Computer.FileSystem.CreateDirectory(Pathway)

                Dim sourceDir As String = "C:\plugins\"
                Dim backupDir As String = "c:\archives\2008"

                Dim Foldersbat As String = "C:\plugins\Folders.bat"
                Dim Folder As String = Pathway & "\" & "Folders.bat"

                Dim fName As String = "Folders.bat"

                Dim fileExe As String = "Folders.bat"

                File.Copy(Path.Combine(Batlocation), Path.Combine(Pathway, fName), True)

                Dim Folderbatfile As String = Pathway & fName
                Process.Start(Folder)
                ' System.IO.File.Copy(Foldersbat, Folder, True)

                Proj1Pathway = Pathway
                '  MessageBox.Show(Pathway)
                ' MessageBox.Show(Folder)
                'MessageBox.Show(Proj1Pathway)
                ComboProjectslist.Items.Add(TxtName1.Text)
            End If
            If Proj2en = True Then
                'MessageBox.Show("SECOND RUNNINHG")


                Dim Proj2Path As String = ""

                Proj2Name = TxtName1.Text


                Proj2Path = Projfolder
                Prjlocation = Proj2Path

                ' MessageBox.Show(Proj2Path)

                btnCrtFolders.Enabled = True


                Dim Pathway = Proj2Path & "\" & Proj2Name

                My.Computer.FileSystem.CreateDirectory(Pathway)

                Dim sourceDir As String = "C:\plugins\"
                Dim backupDir As String = "c:\archives\2008"

                Dim Foldersbat As String = "C:\plugins\Folders.bat"
                Dim Folder As String = Pathway & "\" & "Folders.bat"

                Dim fName As String = "Folders.bat"

                Dim fileExe As String = "Folders.bat"

                File.Copy(Path.Combine(Batlocation), Path.Combine(Pathway, fName), True)

                Dim Folderbatfile As String = Pathway & fName
                Process.Start(Folder)
                ' System.IO.File.Copy(Foldersbat, Folder, True)

                Proj2Pathway = Pathway
                '  MessageBox.Show(Pathway)
                ' MessageBox.Show(Folder)
                '  MessageBox.Show(Proj2Pathway)
                ComboProjectslist.Items.Add(TxtName1.Text)

            End If
            If Proj3en = True Then

                Dim Proj3Path As String = ""


                Proj3Name = TxtName1.Text


                Proj3Path = Projfolder
                Prjlocation = Proj3Path

                btnCrtFolders.Enabled = True


                Dim Pathway = Proj3Path & "\" & Proj3Name

                My.Computer.FileSystem.CreateDirectory(Pathway)

                Dim sourceDir As String = "C:\plugins\"
                Dim backupDir As String = "c:\archives\2008"

                Dim Foldersbat As String = "C:\plugins\Folders.bat"
                Dim Folder As String = Pathway & "\" & "Folders.bat"

                Dim fName As String = "Folders.bat"

                Dim fileExe As String = "Folders.bat"

                File.Copy(Path.Combine(Batlocation), Path.Combine(Pathway, fName), True)

                Dim Folderbatfile As String = Pathway & fName
                Process.Start(Folder)
                ' System.IO.File.Copy(Foldersbat, Folder, True)

                Proj3Pathway = Pathway
                '  MessageBox.Show(Pathway)
                ' MessageBox.Show(Folder)
                'MessageBox.Show(Proj1Pathway)
                ComboProjectslist.Items.Add(TxtName1.Text)
            End If


        End If
        'ComboProjectslist.Enabled = True
        AllButtons = True
        BtnPrjLocation.Enabled = AllButtons
        BntAssets1.Enabled = AllButtons
        BtnExports1.Enabled = AllButtons
        Btnclear.Enabled = AllButtons
        Btnaddproj.Enabled = True
        LblProjects.Enabled = True
        btnSave.Enabled = AllButtons
        BtnSetPrj.Enabled = False
    End Sub

    Private Sub btnCrtFolders_Click(sender As Object, e As EventArgs) Handles btnCrtFolders.Click

        Dim Pathway = Proj1Path & "\" & Proj1Name

        My.Computer.FileSystem.CreateDirectory(Pathway)

        '  Proj1Path = Pathway

        Dim sourceDir As String = "C:\plugins\"
        Dim backupDir As String = "c:\archives\2008"

        Dim Foldersbat As String = "C:\plugins\Folders.bat"
        Dim Folder As String = Pathway & "\" & "Folders.bat"

        Dim fName As String = "Folders.bat"

        Dim fileExe As String = "Folders.bat"

        File.Copy(Path.Combine(sourceDir, fName), Path.Combine(Pathway, fName), True)

        Dim Folderbatfile As String = Pathway & fName
        Process.Start(Folder)
        ' System.IO.File.Copy(Foldersbat, Folder, True)

        Proj1Pathway = Pathway
        ' MessageBox.Show(Folderbatfile)
        ' MessageBox.Show(Folder)
        'MessageBox.Show(Proj1Pathway)
        AllButtons = True
        BtnPrjLocation.Enabled = AllButtons
        BntAssets1.Enabled = AllButtons
        BtnExports1.Enabled = AllButtons
        Btnclear.Enabled = AllButtons
        btnSave.Enabled = AllButtons


    End Sub

    ' Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)

    'End Sub

    Private Sub bntAssets1_Click(sender As Object, e As EventArgs) Handles BntAssets1.Click

        cntxmenuAssets1.Show(BntAssets1, 0, BntAssets1.Height)


    End Sub

    Private Sub BtnExports1_Click(sender As Object, e As EventArgs) Handles BtnExports1.Click
        Dim Exports = Projrootglobal & "\Export"
        If IO.Directory.Exists(Exports) Then

            Process.Start(Exports)
            'Thread.Sleep(1000)
            'My.Computer.FileSystem.DeleteFile(e.FullPath)
        Else
            CreateThisFolder = Path.GetDirectoryName(Exports)
            CreateFolderMissing.Show()
                CreateFolderMissing.TopMost = True
                Me.Hide()

            CreateFolderMissing.Copyfile = True

            CreateFolderMissing.Path2 = Exports

        End If



    End Sub


    Private Sub BtnMonitor_Click(sender As Object, e As EventArgs) Handles BtnMonitor.Click

        MonitorFolder.Show()


    End Sub





    Private Sub BtnProj_Click(sender As Object, e As EventArgs) Handles btnProjfiles.Click

        cntxmenuProjectFiles.Show(btnProjfiles, 0, btnProjfiles.Height)


    End Sub


    Private Sub PSDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PSDToolStripMenuItem.Click


        If IO.Directory.Exists(ProjFolderglobal & "\" & "Photoshop") Then
            Process.Start(ProjFolderglobal & "\" & "Photoshop")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Photoshop"
            CreateFolderMissing.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub AIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AIToolStripMenuItem.Click


        If IO.Directory.Exists(ProjFolderglobal & "\" & "Illustrator") Then
            Process.Start(ProjFolderglobal & "\" & "Illustrator")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Illustrator"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioToolStripMenuItem.Click

        '  Process.Start(MainPath & "\" & "Audio")
        If IO.Directory.Exists(ProjFolderglobal & "\" & "Audio") Then
            Process.Start(ProjFolderglobal & "\" & "Audio")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Audio"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DToolStripMenuItem.Click



        '   Process.Start(MainPath & "\" & "Assets\3D")
        If IO.Directory.Exists(ProjFolderglobal & "\" & "Assets\3D") Then
            Process.Start(ProjFolderglobal & "\" & "Assets\3D")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Assets\
3D"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub FinalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalsToolStripMenuItem.Click


        '   Process.Start(MainPath & "\" & "Export\Final")
        If IO.Directory.Exists(ProjFolderglobal & "\Export\Drafts") Then
            Process.Start(ProjFolderglobal & "\Export\Drafts")
        Else
            CreateThisFolder = ProjFolderglobal & "\Export\Drafts"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub DraftsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DraftsToolStripMenuItem.Click


        '   Process.Start(MainPath & "\" & "Export\Final")
        If IO.Directory.Exists(ProjFolderglobal & "\Export\Drafts") Then
            Process.Start(ProjFolderglobal & "\Export\Drafts")
        Else
            CreateThisFolder = ProjFolderglobal & "\Export\Drafts"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AFXOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AFXOutToolStripMenuItem.Click


        '   Process.Start(MainPath & "\" & "AFX_Out")
        If IO.Directory.Exists(ProjFolderglobal & "\" & "AFX_Out") Then
            Process.Start(ProjFolderglobal & "\" & "AFX_Out")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "AFX_Out"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub C4DOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles C4DOutToolStripMenuItem.Click


        '   Process.Start(MainPath & "\" & "C4D_Out")
        If IO.Directory.Exists(ProjFolderglobal & "\" & "C4D_Out") Then
            Process.Start(ProjFolderglobal & "\" & "C4D_Out")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "C4D_Out"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PSDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PSDToolStripMenuItem1.Click


        '     Process.Start(MainPath & "\" & "Photoshop")
        If IO.Directory.Exists(ProjFolderglobal & "\" & "Photoshop") Then
            Process.Start(ProjFolderglobal & "\" & "Photoshop")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Photoshop"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AIToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AIToolStripMenuItem1.Click


        '   Process.Start(MainPath & "\" & "Illustrator")
        If IO.Directory.Exists(ProjFolderglobal & "\" & "Illustrator") Then
            Process.Start(ProjFolderglobal & "\" & "Illustrator")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Protools"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ' MessageBox.Show(Proj1Name)
        ' MessageBox.Show(Proj1Pathway)

        My.Settings.Proj1Name = Proj1Name
        My.Settings.Proj1Pathway = Proj1Pathway
        My.Settings.ButtonsOn = AllButtons
        My.Settings.Save()

        'MessageBox.Show(My.Settings.ButtonsOn)
        ' MessageBox.Show(AllButtons)

    End Sub

    Private Sub txtName1_TextChanged(sender As Object, e As EventArgs) Handles TxtName1.TextChanged

        'txtName1.Text = My.Settings.Proj1Name

    End Sub



    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = Hotkey.WM_HOTKEY Then
            Hotkey.handleHotKeyEvent(m.WParam)
        End If
        MyBase.WndProc(m)
    End Sub 'System wide hotkey event handling

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MessageBox.Show("Started")
        Monitorfolderglobal = My.Settings.MonitorFolderglobal
        LblScreenshortcut.Text = My.Settings.Screencapturekey
        Hotkey.registerHotkey(Me, Screencapturekey, Hotkey.KeyModifier.Alt)
        Screencapturekey = My.Settings.Screencapturekey
        Projrootglobal2 = My.Settings.Projrootglobal2
        ProjClientglobal2 = My.Settings.ProjClientglobal2
        Root2 = My.Settings.Root2
        ' Me.BackColor = Color.FromArgb(33, 38, 67)
        '  MessageBox.Show(btnaddproj.Enabled)
        '  MessageBox.Show(My.Settings.Plusbutton)
        Btnaddproj.Enabled = My.Settings.Plusbutton
        ' MessageBox.Show(btnaddproj.Enabled)
        Projfolder = My.Settings.ProjFolder
        FirstStart = My.Settings.FirstStart
        ProjectsDrop = My.Settings.ProjectList
        ComboProjectslist.Enabled = ProjectsDrop
        ' For Each i As String In My.Settings.this
        '  ComboProjectslist.Items.Add(i)
        '   Next

        'My.Settings.this = New System.Collections.Specialized.StringCollection
        ' Me.TopMost = True
        ' MessageBox.Show(FirstStart)
        '  MessageBox.Show(My.Settings.FirstStart)
        ProjClientnameglobal = My.Settings.ProjClientName
        Projrootglobal = My.Settings.ProjRoot
        ProjClientglobal = My.Settings.ProjClient
        ProjNameglobal = My.Settings.ProjectName
        ProjFolderglobal = My.Settings.ProjectFolder
        'MessageBox.Show("Past Saves")
        If ProjClientglobal = "Client" Then

            Set_Project_Location.Show()
            Set_Project_Location.TopMost = True
            Me.Hide()


        End If
        'MessageBox.Show("Past Set Project Loc")
        Try
            If ProjClientglobal <> "Client" Then
                For Each Dir As String In System.IO.Directory.GetDirectories(Projrootglobal)
                    Dim dirInfo As New System.IO.DirectoryInfo(Dir)
                    comboClients.Items.Add(dirInfo.Name)

                Next
            End If
        Catch ex As Exception
            ' log or whatever, here just ignore and continue ...


        End Try

        'MessageBox.Show("Past Clients COmbo")
        Dim Clientglobal(2) As String
        Clientglobal(0) = ProjClientglobal
        Clientglobal(1) = ProjClientglobal2
        Clientglobal(2) = "gopher"

        ' Loop.
        For Each value As String In Clientglobal

            If Directory.Exists(value) Then
                If value <> "Client" Then
                    For Each Dir As String In System.IO.Directory.GetDirectories(value)
                        Dim dirInfo As New System.IO.DirectoryInfo(Dir)
                        comboProjects.Items.Add(dirInfo.Name)

                    Next
                End If

            End If
        Next
        'MessageBox.Show("Past Proj")
        'Console.WriteLine("Completed?")
        Try
            If ProjClientglobal <> "Client" Then
                For Each Dir As String In System.IO.Directory.GetDirectories(ProjClientglobal)
                    Dim dirInfo As New System.IO.DirectoryInfo(Dir)
                    comboProjects.Items.Add(dirInfo.Name)

                Next
            End If
        Catch ex As Exception
            ' log or whatever, here just ignore and continue ...


        End Try
        'Try
        '    Dim PPP = "Path"
        '    If Projrootglobal2 <> My.Computer.FileSystem.SpecialDirectories.MyDocuments Then


        '        For Each Dir As String In System.IO.Directory.GetDirectories(Projrootglobal2)
        '            Dim dirInfo As New System.IO.DirectoryInfo(Dir)
        '            comboClients.Items.Add(dirInfo.Name)
        '        Next
        '    End If
        'Catch ex As Exception
        '    ' log or whatever, here just ignore and continue ...
        'End Try
        'MessageBox.Show("Hot HEreee")

        comboClients.Text = ProjClientnameglobal
        comboProjects.Text = ProjNameglobal

        If FirstStart = True Then
            TxtName1.Text = ""
            'MessageBox.Show("Please click Set Project Location, and select where you would like your Projects to live.")
            FirstStart = False

        End If

        Proj1en = My.Settings.Proj1en
        Proj2en = My.Settings.Proj2en
        Proj3en = My.Settings.Proj3en



        'MessageBox.Show(Projfolder)


        If Projfolder = My.Computer.FileSystem.SpecialDirectories.MyDocuments Then
            BtnSetPrj.Enabled = False
            TxtName1.Enabled = False
            LblPrjName.Enabled = False
            LblProjects.Enabled = False


        End If

        If Projfolder <> My.Computer.FileSystem.SpecialDirectories.MyDocuments Then
            BtnSetPrj.Enabled = True
            TxtName1.Enabled = True
            LblPrjName.Enabled = True
            LblProjects.Enabled = True

            AllButtons = True



        End If

        MainName = My.Settings.Mainname

        AllButtons = My.Settings.ButtonsOn
        Proj1Pathway = My.Settings.Proj1Pathway
        Proj2Pathway = My.Settings.Proj2Pathway
        Proj3Pathway = My.Settings.Proj3Pathway
        Proj1Name = My.Settings.Proj1Name
        Proj2Name = My.Settings.Proj2Name
        Proj3Name = My.Settings.Proj3Name
        TxtName1.Text = MainName


        btnCrtFolders.Enabled = AllButtons

        btnSave.Enabled = AllButtons

    End Sub

    Private Sub btnProj1_Click(sender As Object, e As EventArgs) Handles btnProj1.Click, Button3.Click
        AddClient.Show()
        Me.Hide()
        '' Me.Close()






    End Sub

    Private Sub btnAddProject_Click(sender As Object, e As EventArgs) Handles btnAddProject.Click
        AddProject.Show()
        Me.Hide()
        '' Me.Close()




    End Sub



    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        AllButtons = False
        Proj1Pathway = ""
        TxtName1.Text = ""
        Proj1Name = ""
        Projfolder = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Root2 = False

        Proj2Pathway = ""
        Proj2Name = ""
        Btnaddproj.Enabled = False
        Proj3Pathway = ""
        Proj3Name = ""
        My.Settings.FirstStart = False
        BtnPrjLocation.Enabled = False
        BtnPrjfolder.Enabled = True
        BtnSetPrj.Enabled = False
        BntAssets1.Enabled = True

        TxtName1.Enabled = False
        LblPrjName.Enabled = False
        FirstStart = True
        Proj1en = True
        Proj2en = False
        Proj3en = False
        ProjectsDrop = False

        ProjClientglobal = "Client"
        ProjClientglobal2 = "Client"
        Projrootglobal2 = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        ComboProjectslist.Items.Clear()

        comboClients.Text = ""

        comboProjects.Text = ""

        My.Settings.Root2 = Root2
        My.Settings.Proj1en = Proj1en
        My.Settings.Proj2en = Proj2en
        My.Settings.Proj3en = Proj3en
        My.Settings.Mainname = MainName
        My.Settings.Proj1Name = Proj1Name
        My.Settings.Proj2Name = Proj2Name
        My.Settings.Proj3Name = Proj3Name
        My.Settings.Proj1Pathway = Proj1Pathway
        My.Settings.Proj2Pathway = Proj2Pathway
        My.Settings.Proj3Pathway = Proj3Pathway
        My.Settings.ButtonsOn = AllButtons
        My.Settings.FirstStart = FirstStart
        My.Settings.ProjFolder = ProjNameglobal
        My.Settings.ProjectList = ProjectsDrop
        My.Settings.Plusbutton = Btnaddproj.Enabled
        My.Settings.ProjRoot = Projrootglobal
        My.Settings.Projrootglobal2 = Projrootglobal2
        My.Settings.ProjClient = ProjClientglobal
        My.Settings.ProjClientglobal2 = ProjClientglobal2
        My.Settings.ProjectName = ProjNameglobal
        My.Settings.ProjectFolder = ProjFolderglobal
        My.Settings.ProjClientName = ProjClientnameglobal

        My.Settings.Save()


        Me.Close()

    End Sub




    Private Sub AssetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssetsToolStripMenuItem.Click

        Process.Start(Proj1Pathway & "\" & "Assets")

    End Sub

    Private Sub BtnPrjfolder_Click(sender As Object, e As EventArgs) Handles BtnPrjfolder.Click

        'Projfolder = txtName1.Text

        Using obj As New OpenFileDialog
            obj.Filter = "foldersOnly|*.none"
            obj.CheckFileExists = False
            obj.CheckPathExists = False
            obj.InitialDirectory = Projfolder
            obj.CustomPlaces.Add("H:\OIS") ' add your custom location, appears upper left
            obj.CustomPlaces.Add("H:\Permits") ' add your custom location
            obj.Title = "Select Projects Root Folder"
            obj.FileName = "Choose a Folder"
            If obj.ShowDialog = Windows.Forms.DialogResult.OK Then
                '  MsgBox(IO.Directory.GetParent(obj.FileName).FullName)

                Projfolder = CStr(IO.Directory.GetParent(obj.FileName).FullName)

                Projrootglobal = Projfolder
                'Prjlocation = Projfolder

                'Dim secondNum As Integer = CInt(txtAddVal2.Text)
                ' Dim sum = firstNum + secondNum

                'txtSumAnswer.Text = CStr(sum)


            End If
        End Using

        BtnSetPrj.Enabled = True
        TxtName1.Enabled = True
        LblPrjName.Enabled = True

        ' MessageBox.Show(Projfolder)
        BtnPrjfolder.Enabled = False

        For Each Dir As String In System.IO.Directory.GetDirectories(Projrootglobal)
            Dim dirInfo As New System.IO.DirectoryInfo(Dir)
            comboClients.Items.Add(dirInfo.Name)
        Next


    End Sub

    Public Sub closingform1() Handles Me.FormClosing
        My.Settings.Screencapturekey = Screencapturekey
        My.Settings.MonitorFolderglobal = Monitorfolderglobal
        If Proj1en = True Then
            MainName = Proj1Name

        End If

        If Proj2en = True Then
            MainName = Proj2Name

        End If

        If Proj3en = True Then
            MainName = Proj3Name

        End If

        For Each i As String In ComboProjectslist.Items
            '    My.Settings.this.Add(i)
        Next


        'My.Settings.addbutton = btnaddproj.Enabled
        My.Settings.Root2 = Root2
        My.Settings.Proj1en = Proj1en
        My.Settings.Proj2en = Proj2en
        My.Settings.Proj3en = Proj3en
        My.Settings.Mainname = MainName
        My.Settings.Proj1Name = Proj1Name
        My.Settings.Proj2Name = Proj2Name
        My.Settings.Proj3Name = Proj3Name
        My.Settings.Proj1Pathway = Proj1Pathway
        My.Settings.Proj2Pathway = Proj2Pathway
        My.Settings.Proj3Pathway = Proj3Pathway
        My.Settings.ButtonsOn = AllButtons
        My.Settings.FirstStart = FirstStart
        My.Settings.ProjFolder = ProjNameglobal
        My.Settings.ProjectList = ProjectsDrop
        My.Settings.Plusbutton = Btnaddproj.Enabled
        My.Settings.ProjRoot = Projrootglobal
        My.Settings.Projrootglobal2 = Projrootglobal2
        My.Settings.ProjClient = ProjClientglobal
        My.Settings.ProjClientglobal2 = ProjClientglobal2
        My.Settings.ProjectName = ProjNameglobal
        My.Settings.ProjectFolder = ProjFolderglobal
        My.Settings.ProjClientName = ProjClientnameglobal

        My.Settings.Save()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' MainPath = Proj2Pathway

        ' If MainPath = "Nothing" Then
        ' MessageBox.Show("YAY")
        'BntAssets1.Enabled = True
        'BtnExports1.Enabled = True
        'btnCrtFolders.Enabled = False
        'Btnclear.Enabled = False
        'btnSave.Enabled = False
        'TxtName1.Text = ""

        'End If
        BtnSetPrj.Enabled = True

        Proj1en = False
        Proj2en = True
        Proj3en = False
        TxtName1.Text = Proj2Name
        ComboProjectslist.Enabled = True
        ProjectsDrop = True
        TxtName1.Text = ""
        LblProjects.Enabled = True
        BntAssets1.Enabled = True
        BtnExports1.Enabled = True
        BtnPrjLocation.Enabled = False
        BtnPrjfolder.Enabled = False
        My.Settings.Reset()

    End Sub

    Private Sub btnProj3_Click(sender As Object, e As EventArgs) Handles btnProj3.Click
        BtnSetPrj.Enabled = True
        '    MainPath = Proj3Pathway
        Proj1en = False
        Proj2en = False
        Proj3en = True

        '   MainPath = Proj3Pathway
        TxtName1.Text = Proj3Name
        ComboProjectslist.Enabled = True
        ProjectsDrop = True
        TxtName1.Text = ""
        LblProjects.Enabled = True
        BntAssets1.Enabled = True
        BtnExports1.Enabled = True
        BtnPrjLocation.Enabled = False
        BtnPrjfolder.Enabled = False
    End Sub

    ' Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

    'End Sub

    Private Sub ComboProjectslist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboProjectslist.SelectedIndexChanged

        If ComboProjectslist.Text = Proj1Name Then
            '    MainPath = Proj1Pathway

            '  If MainPath = "Nothing" Then
            ' MessageBox.Show("1")
            ' BntAssets1.Enabled = True
            ' ' BtnExports1.Enabled = True
            '  btnCrtFolders.Enabled = False
            ' Btnclear.Enabled = False
            ' btnSave.Enabled = False
            ' TxtName1.Text = ""

            'End If


            Proj1en = True
            Proj2en = False
            Proj3en = False
            TxtName1.Text = Proj1Name
        End If



        If ComboProjectslist.Text = Proj2Name Then
            ' MainPath = Proj2Pathway

            'If MainPath = "Nothing" Then
            'MessageBox.Show("2")
            'BntAssets1.Enabled = True
            'BtnExports1.Enabled = True
            'btnCrtFolders.Enabled = False
            'Btnclear.Enabled = False
            'btnSave.Enabled = False
            'TxtName1.Text = ""

            ' End If


            Proj1en = False
            Proj2en = True
            Proj3en = False
            TxtName1.Text = Proj2Name
        End If

        If ComboProjectslist.Text = Proj3Name Then
            'MainPath = Proj3Pathway

            'If MainPath = "Nothing" Then
            'MessageBox.Show("3")
            'BntAssets1.Enabled = True
            'BtnExports1.Enabled = True
            'btnCrtFolders.Enabled = False
            'Btnclear.Enabled = False
            'btnSave.Enabled = False
            'TxtName1.Text = ""
            '
            'End If


            Proj1en = False
            Proj2en = False
            Proj3en = True
            TxtName1.Text = Proj3Name
        End If


    End Sub

    Private Sub btnaddproj_Click(sender As Object, e As EventArgs) Handles Btnaddproj.Click
        BtnSetPrj.Enabled = True
        If Proj2en = True Then
            Proj2en = False
            Proj3en = True
        End If

        If Proj3en = True Then
            MessageBox.Show("Last one, only 3 projects for now.")
        End If
        If Proj1en = True Then
            Proj2en = True
            Proj1en = False
            MessageBox.Show("Complete")
        End If

        ComboProjectslist.Enabled = True
        ProjectsDrop = True
        TxtName1.Text = ""
        LblProjects.Enabled = True
        BntAssets1.Enabled = True
        BtnExports1.Enabled = True
        BtnPrjLocation.Enabled = False
        BtnPrjfolder.Enabled = False

        If comboProjects.Text <> "" Then

            btnAddProject.Enabled = True
            comboProjects.Enabled = True
        Else

            btnAddProject.Enabled = False
            comboProjects.Enabled = False

        End If

        ' MessageBox.Show(ComboProjectslist.Text)
    End Sub

    Private Sub comboClients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboClients.SelectedIndexChanged
        comboProjects.Items.Clear()

        ProjClientglobal = Projrootglobal & "\" & comboClients.Text
        ProjClientglobal2 = Projrootglobal2 & "\" & comboClients.Text
        If Directory.Exists(ProjClientglobal) Then
            For Each Dir As String In System.IO.Directory.GetDirectories(ProjClientglobal)
                Dim dirInfo As New System.IO.DirectoryInfo(Dir)
                comboProjects.Items.Add(dirInfo.Name)
            Next
        End If
        If Directory.Exists(ProjClientglobal2) Then
            For Each Dir As String In System.IO.Directory.GetDirectories(ProjClientglobal2)
                Dim dirInfo As New System.IO.DirectoryInfo(Dir)
                comboProjects.Items.Add(dirInfo.Name)
            Next
        End If
        ProjFolderglobal = ProjClientglobal
        Console.WriteLine(ProjFolderglobal)
        btnAddProject.Enabled = True
        comboProjects.Enabled = True

        ProjClientnameglobal = comboClients.Text

    End Sub


    Private Sub comboCProjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProjects.SelectedIndexChanged
        ProjFolderglobal = ProjClientglobal & "\" & comboProjects.Text
        ProjFolderglobal2 = ProjClientglobal2 & "\" & comboProjects.Text
        ProjNameglobal = comboProjects.Text

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblClients.Click

    End Sub

    Private Sub LblPrjName_Click(sender As Object, e As EventArgs) Handles LblPrjName.Click

    End Sub

    Private Sub ttAssets_Popup(sender As Object, e As PopupEventArgs) Handles ttAssets.Popup

    End Sub

    Private Sub AssetsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AssetsToolStripMenuItem1.Click

        If IO.Directory.Exists(ProjFolderglobal & "\" & "Assets") Then
            Process.Start(ProjFolderglobal & "\" & "Assets")

        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Assets"
            CreateFolderMissing.Show()
            Me.Hide()
        End If



    End Sub

    Private Sub MediaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediaToolStripMenuItem.Click
        If IO.Directory.Exists(ProjFolderglobal & "\" & "Media") Then
            Process.Start(ProjFolderglobal & "\" & "Media")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Media"
            CreateFolderMissing.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub FromClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromClientToolStripMenuItem.Click
        If IO.Directory.Exists(ProjFolderglobal & "\" & "Media\From_Clients") Then
            Process.Start(ProjFolderglobal & "\" & "Media\From_Clients")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Media\From_Clients"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AIToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AIToolStripMenuItem2.Click
        If IO.Directory.Exists(ProjFolderglobal & "\" & "Illustrator") Then
            Process.Start(ProjFolderglobal & "\" & "Illustrator")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Illustrator"
            CreateFolderMissing.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub AFXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AFXToolStripMenuItem.Click

        If IO.Directory.Exists(ProjFolderglobal & "\" & "AFX") Then
            Process.Start(ProjFolderglobal & "\" & "AFX")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "AFX"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PremiereToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PremiereToolStripMenuItem.Click

        If IO.Directory.Exists(ProjFolderglobal & "\" & "Premiere") Then
            Process.Start(ProjFolderglobal & "\" & "Premiere")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Premiere"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PSDToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PSDToolStripMenuItem2.Click

        If IO.Directory.Exists(ProjFolderglobal & "\" & "PSD") Then
            Process.Start(ProjFolderglobal & "\" & "PSD")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "PSD"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ResolveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResolveToolStripMenuItem.Click

        If IO.Directory.Exists(ProjFolderglobal & "\" & "Resolve") Then
            Process.Start(ProjFolderglobal & "\" & "Resolve")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Resolve"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub UnityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnityToolStripMenuItem.Click

        If IO.Directory.Exists(ProjFolderglobal & "\" & "Unity") Then
            Process.Start(ProjFolderglobal & "\" & "Unity")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Unity"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ProtoolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProtoolsToolStripMenuItem.Click

        If IO.Directory.Exists(ProjFolderglobal & "\" & "Protools") Then
            Process.Start(ProjFolderglobal & "\" & "Protools")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Protools"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ReaperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReaperToolStripMenuItem.Click

        If IO.Directory.Exists(ProjFolderglobal & "\" & "Reaper") Then
            Process.Start(ProjFolderglobal & "\" & "Reaper")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Reaper"
            CreateFolderMissing.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        For i = 1 To ProjFoldersGlobal.Length - 1
            Console.WriteLine("If" & ProjFoldersGlobal(i))
            If Not FoundFiles.ListofPaths.Items.Contains(ProjFoldersGlobal(i)) Then
                ' It is not already in the list box so add it
                Console.WriteLine("If Not" & ProjFoldersGlobal(i))
            End If
        Next

        Settings.Show()
        Me.Hide()


    End Sub

    Private Sub C4DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles C4DToolStripMenuItem.Click
        If IO.Directory.Exists(ProjFolderglobal & "\" & "C4D") Then
            Process.Start(ProjFolderglobal & "\" & "C4D")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "C4D"
            CreateFolderMissing.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub cntxmenuProjectFiles_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cntxmenuProjectFiles.Opening

    End Sub

    Private Sub AkeytsuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AkeytsuToolStripMenuItem.Click

        If IO.Directory.Exists(ProjFolderglobal & "\" & "Akeytsu") Then
            Process.Start(ProjFolderglobal & "\" & "Akeytsu")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Akeytsu"
            CreateFolderMissing.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub MayaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MayaToolStripMenuItem.Click

        If IO.Directory.Exists(ProjFolderglobal & "\" & "Maya") Then
            Process.Start(ProjFolderglobal & "\" & "Maya")
        Else
            CreateThisFolder = ProjFolderglobal & "\" & "Maya"
            CreateFolderMissing.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub ModoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModoToolStripMenuItem.Click

        '    If IO.Directory.Exists(ProjFolderglobal & "\" & "Modo") Then
        '        Process.Start(ProjFolderglobal & "\" & "Modo")
        '    Else
        '        CreateThisFolder = ProjFolderglobal & "\" & "Modo"
        '        CreateFolderMissing.Show()
        '        Me.Hide()
        '    End If

    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click

        CntxMenu.Show(BtnMenu, 0, BtnMenu.Height)

        '    For Each value As String In ProjFoldersGlobal
        '        Console.WriteLine(value)
        '    Next
        '    Dim Pathtocheck As String

        '    'Projfolder = txtName1.Text
        '    Dim Projfolder As String = (My.Computer.FileSystem.SpecialDirectories.MyDocuments)
        '    Using obj As New OpenFileDialog
        '        obj.Filter = "foldersOnly|*.none"
        '        obj.CheckFileExists = False
        '        obj.CheckPathExists = False
        '        obj.InitialDirectory = Projfolder
        '        obj.CustomPlaces.Add("H:\OIS") ' add your custom location, appears upper left
        '        obj.CustomPlaces.Add("H:\Permits") ' add your custom location
        '        obj.Title = "Select Projects Root Folder"
        '        obj.FileName = "Choose a Folder"
        '        If obj.ShowDialog = Windows.Forms.DialogResult.OK Then
        '            '  MsgBox(IO.Directory.GetParent(obj.FileName).FullName)

        '            Pathtocheck = CStr(IO.Directory.GetParent(obj.FileName).FullName)


        '        End If
        '    End Using



        '    ''Dim ext = {"*.jpg", "*.bmp", "*png"}
        '    '' Dim files = ext.SelectMany(Function(f) Directory.GetFiles(Pathtocheck, f)).
        '    ''        OrderBy(Function(f) f).
        '    ''        ToArray()
        '    '' Console.WriteLine(files)


        '    Dim mxf() As String
        '    mxf = Directory.GetFiles(Pathtocheck, "*.mxf", SearchOption.AllDirectories)
        '    'For Each FileName As String In mxf
        '    '    '' Console.Write(FileName(2))


        '    '    Dim LinkA As String = FileName(1)
        '    'Next


        '    Dim mp4() As String
        '    mp4 = Directory.GetFiles(Pathtocheck, "*.mp4", SearchOption.AllDirectories)
        '    'For Each FileName As String In mp4
        '    '    Console.WriteLine(FileName)
        '    '    Dim LinkA As String = FileName(1)
        '    'Next



        '    Dim mov() As String
        '    mov = Directory.GetFiles(Pathtocheck, "*.mov", SearchOption.AllDirectories)





        '    Dim wmv() As String
        '    wmv = Directory.GetFiles(Pathtocheck, "*.wmv", SearchOption.AllDirectories)
        '    'For Each FileName As String In wmv
        '    '    Console.WriteLine(FileName)
        '    '    Dim LinkA As String = FileName(1)
        '    'Next


        '    FoundFiles.Show()

        '    If mp4.Length > 0 Then
        '        FoundFiles.ListofPaths.Items.Add(Environment.NewLine & "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!HERE ARE THE MP4's!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" & Environment.NewLine)
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")

        '        For i = 1 To mp4.Length - 1

        '            If Not FoundFiles.ListofPaths.Items.Contains(mp4(i)) Then
        '                ' It is not already in the list box so add it
        '                FoundFiles.ListofPaths.Items.Add(mp4(i))
        '            End If
        '        Next
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")

        '    End If


        '    If mxf.Length > 0 Then
        '        FoundFiles.ListofPaths.Items.Add(vbCrLf & vbCrLf & "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!HERE ARE THE MXF's!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" & vbCrLf & vbCrLf)
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")

        '        For i = 1 To mxf.Length - 1

        '            If Not FoundFiles.ListofPaths.Items.Contains(mxf(i)) Then
        '                ' It is not already in the list box so add it
        '                FoundFiles.ListofPaths.Items.Add(mxf(i))
        '            End If
        '        Next
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")

        '    End If


        '    If mov.Length > 0 Then
        '        FoundFiles.ListofPaths.Items.Add(vbCrLf & vbCrLf & "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!HERE ARE THE MOV's!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" & vbCrLf & vbCrLf)
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")

        '        For i = 1 To mov.Length - 1

        '            If Not FoundFiles.ListofPaths.Items.Contains(mov(i)) Then
        '                ' It is not already in the list box so add it
        '                FoundFiles.ListofPaths.Items.Add(mov(i))
        '            End If

        '        Next
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")

        '    End If


        '    If wmv.Length > 0 Then
        '        FoundFiles.ListofPaths.Items.Add(vbCrLf & vbCrLf & "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!HERE ARE THE WMV's!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" & vbCrLf & vbCrLf)
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")

        '        For i = 1 To wmv.Length - 1

        '            If Not FoundFiles.ListofPaths.Items.Contains(wmv(i)) Then
        '                ' It is not already in the list box so add it
        '                FoundFiles.ListofPaths.Items.Add(wmv(i))
        '            End If

        '        Next
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")
        '        FoundFiles.ListofPaths.Items.Add(".")

        '    End If
        '    'Console.Write(mxf(1))
        '    'MessageBox.Show(mxf(1))

    End Sub

    Private Sub BtnTest_Click(sender As Object, e As EventArgs) Handles BtnTest.Click
        'Dim array2(2) As String
        'array2(0) = ProjFolderglobal
        'array2(1) = ProjFolderglobal2
        'array2(2) = "gopher"

        '' Loop.
        'For Each value As String In array2

        '    If Directory.Exists(value) Then
        '        Process.Start(value)
        '    Else
        '        Console.WriteLine("Damn I suck")
        '    End If
        'Next

        'Create a new bitmap
        screenCapture()

        Console.WriteLine("Completed?")
        'Console.WriteLine("ProjFolder1 is:" & ProjFolderglobal)
        'Console.WriteLine("ProjFolder1 is:" & ProjFolderglobal2)

        Dim Yes As String = Today.ToString("MMddyy")

        Console.WriteLine(Yes)



    End Sub



    Public Shared Sub screenCapture()
        Dim userName As String = Environment.UserName
        Dim savePath As String = ProjFolderglobal
        Dim dateString As String = Date.Now.ToString("yyyyMMddHHmmss")
        Dim todaystring As String = Date.Now.ToString("MMddyy")
        Dim captureSavePath As String = String.Format("{0}\{1}\capture_{2}.png", savePath, todaystring, dateString)
        ' This line is modified for multiple screens, also takes into account different screen size (if any)
        Dim bmp As Bitmap = New Bitmap(
                        Screen.AllScreens.Sum(Function(s As Screen) s.Bounds.Width),
                        Screen.AllScreens.Max(Function(s As Screen) s.Bounds.Height))
        Dim gfx As Graphics = Graphics.FromImage(bmp)
        ' This line is modified to take everything based on the size of the bitmap
        gfx.CopyFromScreen(SystemInformation.VirtualScreen.X,
                       SystemInformation.VirtualScreen.Y,
                       0, 0, SystemInformation.VirtualScreen.Size)
        ' Oh, create the directory if it doesn't exist
        Directory.CreateDirectory(Path.GetDirectoryName(captureSavePath))

        bmp.Save(captureSavePath, System.Drawing.Imaging.ImageFormat.Bmp)

        Gotcha.Show()
        Gotcha.TopMost = True

        Thread.Sleep(400)

        Gotcha.Close()
        'Process.Start(Path.GetDirectoryName(captureSavePath))
    End Sub
    Private Sub VideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VideoToolStripMenuItem.Click

        For Each value As String In ProjFoldersGlobal
            Console.WriteLine(value)
        Next


        'Projfolder = txtName1.Text
        Dim Projfolder As String = (My.Computer.FileSystem.SpecialDirectories.MyDocuments)
        Using obj As New OpenFileDialog
            obj.Filter = "foldersOnly|*.none"
            obj.CheckFileExists = False
            obj.CheckPathExists = False
            obj.InitialDirectory = Projfolder
            obj.CustomPlaces.Add("H:\OIS") ' add your custom location, appears upper left
            obj.CustomPlaces.Add("H:\Permits") ' add your custom location
            obj.Title = "Select Projects Root Folder"
            obj.FileName = "Choose a Folder"
            If obj.ShowDialog = Windows.Forms.DialogResult.OK Then
                '  MsgBox(IO.Directory.GetParent(obj.FileName).FullName)

                Pathtocheck = CStr(IO.Directory.GetParent(obj.FileName).FullName)


            End If
        End Using



        ''Dim ext = {"*.jpg", "*.bmp", "*png"}
        '' Dim files = ext.SelectMany(Function(f) Directory.GetFiles(Pathtocheck, f)).
        ''        OrderBy(Function(f) f).
        ''        ToArray()
        '' Console.WriteLine(files)


        Dim mxf() As String
        mxf = Directory.GetFiles(Pathtocheck, "*.mxf", SearchOption.AllDirectories)
        'For Each FileName As String In mxf
        '    '' Console.Write(FileName(2))


        '    Dim LinkA As String = FileName(1)
        'Next


        Dim mp4() As String
        mp4 = Directory.GetFiles(Pathtocheck, "*.mp4", SearchOption.AllDirectories)
        'For Each FileName As String In mp4
        '    Console.WriteLine(FileName)
        '    Dim LinkA As String = FileName(1)
        'Next



        Dim mov() As String
        mov = Directory.GetFiles(Pathtocheck, "*.mov", SearchOption.AllDirectories)





        Dim wmv() As String
        wmv = Directory.GetFiles(Pathtocheck, "*.wmv", SearchOption.AllDirectories)
        'For Each FileName As String In wmv
        '    Console.WriteLine(FileName)
        '    Dim LinkA As String = FileName(1)
        'Next


        FoundFiles.Show()

        If mp4.Length > 0 Then
            FoundFiles.ListofPaths.Items.Add(Environment.NewLine & "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!HERE ARE THE MP4's!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" & Environment.NewLine)
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")

            For i = 1 To mp4.Length - 1

                If Not FoundFiles.ListofPaths.Items.Contains(mp4(i)) Then
                    ' It is not already in the list box so add it
                    FoundFiles.ListofPaths.Items.Add(mp4(i))
                End If
            Next
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")

        End If


        If mxf.Length > 0 Then
            FoundFiles.ListofPaths.Items.Add(vbCrLf & vbCrLf & "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!HERE ARE THE MXF's!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" & vbCrLf & vbCrLf)
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")

            For i = 1 To mxf.Length - 1

                If Not FoundFiles.ListofPaths.Items.Contains(mxf(i)) Then
                    ' It is not already in the list box so add it
                    FoundFiles.ListofPaths.Items.Add(mxf(i))
                End If
            Next
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")

        End If


        If mov.Length > 0 Then
            FoundFiles.ListofPaths.Items.Add(vbCrLf & vbCrLf & "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!HERE ARE THE MOV's!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" & vbCrLf & vbCrLf)
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")

            For i = 1 To mov.Length - 1

                If Not FoundFiles.ListofPaths.Items.Contains(mov(i)) Then
                    ' It is not already in the list box so add it
                    FoundFiles.ListofPaths.Items.Add(mov(i))
                End If

            Next
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")

        End If


        If wmv.Length > 0 Then
            FoundFiles.ListofPaths.Items.Add(vbCrLf & vbCrLf & "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!HERE ARE THE WMV's!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" & vbCrLf & vbCrLf)
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")

            For i = 1 To wmv.Length - 1

                If Not FoundFiles.ListofPaths.Items.Contains(wmv(i)) Then
                    ' It is not already in the list box so add it
                    FoundFiles.ListofPaths.Items.Add(wmv(i))
                End If

            Next
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")
            FoundFiles.ListofPaths.Items.Add(".")

        End If
        'Console.Write(mxf(1))
        'MessageBox.Show(mxf(1))



    End Sub

    Private Sub BtnExtra_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click

    End Sub

    Private Sub CHANGEEXTENSIONSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHANGEEXTENSIONSToolStripMenuItem.Click

        ExtensionsAdd.Show()
        Me.Hide()
    End Sub

    Private Sub DraftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DraftToolStripMenuItem.Click

        If Directory.Exists(ProjFolderglobal) Then
            Dim Drafts = ProjFolderglobal & "\Export\Drafts"
            a.StartInfo.FileName = PremiereLocation

            a.Start()

            Thread.Sleep(500)
            SendKeys.SendWait("^+s")
            Thread.Sleep(500)
            SendKeys.SendWait("^c")
            Thread.Sleep(500)
            SendKeys.SendWait("%{F4}")
            Thread.Sleep(50)
            SendKeys.SendWait("^m")
            Thread.Sleep(100)
            SendKeys.SendWait("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}")
            SendKeys.SendWait(" ")
            Thread.Sleep(1000)
            SendKeys.SendWait("^v")
            Thread.Sleep(1000)
            SendKeys.SendWait("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}")
            SendKeys.SendWait(" ")
            Thread.Sleep(100)
            SendKeys.SendWait(Drafts)

            Thread.Sleep(500)
            SendKeys.SendWait("{ENTER}")
            Thread.Sleep(1000)
            SendKeys.SendWait("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}")
            SendKeys.SendWait("{ENTER}")
            Thread.Sleep(1000)
            ' GOING TO HIT THE EXPORT BUTTON NOW OMG

            SendKeys.SendWait("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB} ")

        End If
        If Directory.Exists(ProjFolderglobal2) Then
            Dim Drafts = ProjFolderglobal2 & "\Export\Drafts"
            a.StartInfo.FileName = PremiereLocation

            a.Start()

            Thread.Sleep(500)
            SendKeys.SendWait("^+s")
            Thread.Sleep(500)
            SendKeys.SendWait("^c")
            Thread.Sleep(500)
            SendKeys.SendWait("%{F4}")
            Thread.Sleep(50)
            SendKeys.SendWait("^m")
            Thread.Sleep(100)
            SendKeys.SendWait("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}")
            SendKeys.SendWait(" ")
            Thread.Sleep(1000)
            SendKeys.SendWait("^v")
            Thread.Sleep(1000)
            SendKeys.SendWait("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}")
            SendKeys.SendWait(" ")
            Thread.Sleep(100)
            SendKeys.SendWait(Drafts)

            Thread.Sleep(500)
            SendKeys.SendWait("{ENTER}")
            Thread.Sleep(1000)
            SendKeys.SendWait("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}")
            SendKeys.SendWait("{ENTER}")
            Thread.Sleep(1000)
            ' GOING TO HIT THE EXPORT BUTTON NOW OMG

            SendKeys.SendWait("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB} ")

        End If



    End Sub

    Private Sub FinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalToolStripMenuItem.Click


        Dim Final = ProjFolderglobal & "\Export\Final"
        a.StartInfo.FileName = PremiereLocation

        a.Start()

        Thread.Sleep(500)
        SendKeys.SendWait("^+s")
        Thread.Sleep(500)
        SendKeys.SendWait("^c")
        Thread.Sleep(500)
        SendKeys.SendWait("%{F4}")
        Thread.Sleep(50)
        SendKeys.SendWait("^m")
        Thread.Sleep(100)
        SendKeys.SendWait("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}")
        SendKeys.SendWait(" ")
        Thread.Sleep(1000)
        SendKeys.SendWait("^v FINAL")
        Thread.Sleep(1000)
        SendKeys.SendWait("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}")
        SendKeys.SendWait(" ")
        Thread.Sleep(100)
        SendKeys.SendWait(Final)

        Thread.Sleep(500)
        SendKeys.SendWait("{ENTER}")
        Thread.Sleep(1000)
        SendKeys.SendWait("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}")
        SendKeys.SendWait("{ENTER}")
        Thread.Sleep(1000)
        ' GOING TO HIT THE EXPORT BUTTON NOW OMG

        SendKeys.SendWait("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB} ")







    End Sub

    Private Sub FinalsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FinalsToolStripMenuItem1.Click
        'Dim Todaydate As String = Today.ToString("MMddyy")
        CompressingLoading.Show()
        'Me.Hide()
        'Thread.Sleep(1000)
        'Dim startPath As String = ProjFolderglobal & "\Export\Final"
        'Dim zipPath As String = ProjFolderglobal & "\Export\" & ProjNameglobal & "_FINALS" & Todaydate & "_.zip"




        'CompressingLoading.ProgressBar1.Value = (5)
        'ZipFile.CreateFromDirectory(startPath, zipPath)
        'CompressingLoading.ProgressBar1.Value = (100)
        'Process.Start(ProjFolderglobal & "\Export")




    End Sub

    Private Sub DeleteEmptyFoldersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEmptyFoldersToolStripMenuItem.Click
        If Directory.Exists(ProjFolderglobal) Then
            Dim di As New IO.DirectoryInfo(ProjFolderglobal)

            For Each Directory As DirectoryInfo In di.GetDirectories
                If Directory.GetFiles().Length = 0 AndAlso Directory.GetDirectories.Length = 0 Then
                    Directory.Delete()
                End If
            Next
        End If
        Dim Pro2 As New IO.DirectoryInfo(ProjFolderglobal2)
        If Directory.Exists(ProjFolderglobal2) Then
            For Each Directory As DirectoryInfo In Pro2.GetDirectories
                If Directory.GetFiles().Length = 0 AndAlso Directory.GetDirectories.Length = 0 Then
                    Directory.Delete()
                End If
            Next
        End If




    End Sub

    Private Sub MonitorFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitorFolderToolStripMenuItem.Click
        MonitorFolder.Clientname = comboClients.Text
        MonitorFolder.Projname = comboProjects.Text
        MonitorFolder.Show()



    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click

    End Sub

    Private Sub ProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectToolStripMenuItem.Click


        If Directory.Exists(ProjFolderglobal) Then
            For Each Dir As String In Directory.GetDirectories(ProjFolderglobal)
                If Path.GetFileName(Dir) = "Media" Then
                    Console.WriteLine("Media Sucks")
                Else
                    If Path.GetFileName(Dir) = "Backup" Then
                        Console.WriteLine("Backup Sucks")

                    Else
                        Try
                            Dim Backup = ProjFolderglobal & "\Backup\"
                            My.Computer.FileSystem.CreateDirectory(Backup)

                            Directory.Move(Dir, Backup)
                        Catch ex As Exception
                            ' log or whatever, here just ignore and continue ...
                        End Try

                        Console.WriteLine(Path.GetFileName(Dir))
                    End If
                End If

            Next
        End If
        If Directory.Exists(ProjFolderglobal2) Then
            For Each Dir As String In Directory.GetDirectories(ProjFolderglobal2)
                If Dir = "Media " Then
                    Console.WriteLine("Media Sucks")

                Else
                    Dim Backup = ProjFolderglobal2 & "\Backup\"
                    My.Computer.FileSystem.CreateDirectory(Backup)
                    Directory.Move(Dir, Backup)
                    Console.WriteLine(Path.GetFileName(Dir))
                End If
            Next
        End If




    End Sub


    Public Shared Sub handleHotKeyEvent(ByVal hotkeyID As IntPtr)
        Select Case hotkeyID
            Case 1
                screenCapture()
            Case 2
                MsgBox("2")
            Case 3
                MsgBox("3")
        End Select
    End Sub

    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles BtnHelp.Click
        Help.Show()
    End Sub

    Private Sub LblScreenshortcut_Click(sender As Object, e As EventArgs) Handles LblScreenshortcut.Click

    End Sub
End Class








