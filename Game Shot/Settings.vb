Public Class Settings
    Private Sub lblRoots_Click(sender As Object, e As EventArgs) Handles lblRoots.Click, Label1.Click, Label2.Click

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        LblMonitor.Text = Monitorfolderglobal


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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

                Projfolder = CStr(IO.Directory.GetParent(obj.FileName).FullName)

                Projrootglobal = Projfolder
                'Prjlocation = Projfolder

                'Dim secondNum As Integer = CInt(txtAddVal2.Text)
                ' Dim sum = firstNum + secondNum

                'txtSumAnswer.Text = CStr(sum)


            End If
        End Using

        For Each Dir As String In System.IO.Directory.GetDirectories(Projrootglobal)
            Dim dirInfo As New System.IO.DirectoryInfo(Dir)
            Form1.comboClients.Items.Add(dirInfo.Name)
        Next

        My.Settings.ProjRoot = Projrootglobal
        My.Settings.Save()
        Form1.Show()
        Me.Close()


    End Sub

    Public Sub closingSettings() Handles Me.FormClosing

        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Root2 = True
        'Projfolder = txtName1.Text
        Dim Projfolder2 As String = (My.Computer.FileSystem.SpecialDirectories.MyDocuments)
        Using obj As New OpenFileDialog
            obj.Filter = "foldersOnly|*.none"
            obj.CheckFileExists = False
            obj.CheckPathExists = False
            obj.InitialDirectory = Projfolder2
            obj.CustomPlaces.Add("H:\OIS") ' add your custom location, appears upper left
            obj.CustomPlaces.Add("H:\Permits") ' add your custom location
            obj.Title = "Select Projects Root Folder"
            obj.FileName = "Choose a Folder"
            If obj.ShowDialog = Windows.Forms.DialogResult.OK Then
                '  MsgBox(IO.Directory.GetParent(obj.FileName).FullName)

                Projfolder2 = CStr(IO.Directory.GetParent(obj.FileName).FullName)

                Projrootglobal2 = Projfolder2
                'Prjlocation = Projfolder

                'Dim secondNum As Integer = CInt(txtAddVal2.Text)
                ' Dim sum = firstNum + secondNum

                'txtSumAnswer.Text = CStr(sum)


            End If
        End Using

        For Each Dir As String In System.IO.Directory.GetDirectories(Projrootglobal2)
            Dim dirInfo As New System.IO.DirectoryInfo(Dir)
            Form1.comboClients.Items.Add(dirInfo.Name)
        Next

        My.Settings.ProjRoot2 = Projrootglobal2
        My.Settings.Save()
        Form1.Show()
        Me.Close()


    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click

        Projrootglobal = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        Projrootglobal2 = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        ProjClientglobal = "Client"
        ProjNameglobal = "name"

        ProjFolderglobal = ProjClientglobal & "\" & ProjNameglobal

        My.Settings.FirstStart = False


        ProjClientglobal = "Client"


        Form1.ComboProjectslist.Items.Clear()

        Form1.comboClients.Text = ""

        Form1.comboProjects.Text = ""


        My.Settings.Save()
        Form1.Show()
        Me.Close()


    End Sub

    Private Sub BtnExtadd_Click(sender As Object, e As EventArgs) Handles BtnExtadd.Click
        ExtensionsAdd.Show()
        Me.Close()


    End Sub

    Private Sub BtnSet_Click(sender As Object, e As EventArgs) Handles BtnSet.Click

        Screencapturekey = TxtShortcut.Text

        LabelKey.Text = TxtShortcut.Text





    End Sub

    Private Sub BtnSetMonnitor_Click(sender As Object, e As EventArgs) Handles BtnSetMonnitor.Click

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

                Projfolder = CStr(IO.Directory.GetParent(obj.FileName).FullName)

                Monitorfolderglobal = Projfolder
                'Prjlocation = Projfolder

                'Dim secondNum As Integer = CInt(txtAddVal2.Text)
                ' Dim sum = firstNum + secondNum

                'txtSumAnswer.Text = CStr(sum)


            End If
        End Using



    End Sub

    Private Sub LblMonitor_Click(sender As Object, e As EventArgs) Handles LblMonitor.Click

    End Sub
End Class