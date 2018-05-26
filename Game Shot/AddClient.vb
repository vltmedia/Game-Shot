Imports System.IO

Public Class AddClient
    Private Sub btnNewProject_Click(sender As Object, e As EventArgs) Handles btnNewProject.Click

        ProjClientglobal = txtClientjname.Text











        Dim Pathway = Projrootglobal & "\" & ProjClientglobal

        My.Computer.FileSystem.CreateDirectory(Pathway)

        ProjClientglobal = Pathway
        Form1.comboClients.Items.Clear()
        For Each Dir As String In System.IO.Directory.GetDirectories(ProjClientglobal)
            Dim dirInfo As New System.IO.DirectoryInfo(Dir)
            Form1.comboProjects.Items.Add(dirInfo.Name)
        Next
        For Each Dir As String In System.IO.Directory.GetDirectories(Projrootglobal)
            Dim dirInfo As New System.IO.DirectoryInfo(Dir)
            Form1.comboClients.Items.Add(dirInfo.Name)
        Next
        Form1.comboClients.Text = txtClientjname.Text

        Form1.comboProjects.Text = ""

        Form1.Show()
        Me.Close()
    End Sub
    Public Sub closingSettings() Handles Me.FormClosing

        Form1.Show()
    End Sub
End Class