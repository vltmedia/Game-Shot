Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.IO.Compression
Imports System.Threading

Public Class Caught


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Caught_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Thread.Sleep(1000)
        Me.Close()


    End Sub
End Class