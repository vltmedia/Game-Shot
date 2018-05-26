Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.IO.Compression
Imports System.Threading

Public Class CreateFolderMissing

    Public Copyfile = False

    Public Path1 = "Path"

    Public Path2 = "Path"

    Public Todaydate = "Path"

    Private Sub Copyfile_Go()



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnno_Click(sender As Object, e As EventArgs) Handles btnno.Click
        Form1.Show()
        Me.Hide()
        Me.Close()


    End Sub

    Private Sub btnyes_Click(sender As Object, e As EventArgs) Handles btnyes.Click



        Dim Pathway = CreateThisFolder
        Console.WriteLine("Path 1:" & Path1)

        Console.WriteLine("Path 2:" & Path2)

        Try
            My.Computer.FileSystem.CreateDirectory(Pathway)
        Catch ex As Exception

        End Try

        Thread.Sleep(500)
        Try
            If Copyfile = True Then


                File.Copy(Path.Combine(Path1), Path.Combine(Path2), True)
                Process.Start(CreateThisFolder)




            End If
        Catch ex As Exception
        End Try
        Form1.Show()
        Process.Start(Pathway)
        Me.Hide()
        Me.Close()
    End Sub
    Public Sub closingSettings() Handles Me.FormClosing

        Form1.Show()
    End Sub

    Private Sub CreateFolderMissing_Load(sender As Object, e As EventArgs) Handles Me.Load




    End Sub
End Class