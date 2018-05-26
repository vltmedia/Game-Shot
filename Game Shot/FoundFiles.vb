Imports System
Imports System.IO
Public Class FoundFiles
    Private Sub ListofPaths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListofPaths.SelectedIndexChanged

        Dim curItem As String = ListofPaths.SelectedItem.ToString()
        Dim directory As String = Path.GetDirectoryName(curItem)

        'MessageBox.Show(directory)
        If curItem <> "." Then


            Process.Start(directory)
        End If
        'Form1.Show()
        'Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Form1.Show()
        Me.Close()


    End Sub
End Class