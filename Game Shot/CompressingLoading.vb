Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.IO.Compression
Imports System.Threading

Public Class CompressingLoading

    Dim Timee = 0

    Private Sub CompressingLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LableProjLoc.Text = ProjFolderglobal & "\Export"

    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles LableProjLoc.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(1)

        If ProgressBar1.Value < (2) Then

            Dim Todaydate As String = Today.ToString("MMddyy")

            Thread.Sleep(1000)
            Dim startPath As String = ProjFolderglobal & "\Export\Final"
            Dim zipPath As String = ProjFolderglobal & "\Export\" & ProjNameglobal & "_FINALS_" & Todaydate & ".zip"




            ProgressBar1.Value = (5)
            ProgressBar1.Value = (10)
            ProgressBar1.Value = (25)
            ZipFile.CreateFromDirectory(startPath, zipPath)
            ProgressBar1.Value = (60)
            ProgressBar1.Value = (75)
            ProgressBar1.Value = (100)
            Process.Start(ProjFolderglobal & "\Export")


        End If

        If ProgressBar1.Value = (100) Then
            Form1.Show()
            Me.Close()


        End If

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class