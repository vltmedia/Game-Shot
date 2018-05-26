
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.IO.Compression
Imports System.Threading


Public Class Set_Project_Location
    Private Sub btnNewRoot_Click(sender As Object, e As EventArgs) Handles btnNewRoot.Click

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

        If Directory.Exists(Projrootglobal & "\Export") Then
            Console.WriteLine("Poop")
        Else
            My.Computer.FileSystem.CreateDirectory(Projrootglobal & "\Export")

            'Process.Start(Projrootglobal & "\Export")
        End If


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
End Class