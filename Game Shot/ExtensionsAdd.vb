Public Class ExtensionsAdd
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim Empty = "Not Entered"
        Dim Type = Empty
        Dim i As ListViewItem



        If Chck3d.Checked = True Then
            Type = "3d"
        End If


        If ChckAudio.Checked = True Then
            Type = "Audio"
        End If


        If ChckVideo.Checked = True Then
            Type = "Video"
        End If


        If ChckImage.Checked = True Then
            Type = "Image"
        End If


        If ChckDoc.Checked = True Then
            Type = "Doc"
            Extlist1g.Add("TxtExt.Text")
        End If


        If ChckMisc.Checked = True Then
            Type = "Misc"
        End If

        If Type = Empty Then



            MessageBox.Show("Please chose a Type, we gotta be organized.")
        End If

        If Type <> Empty Then

            Extlist1g.Add("TxtExt.Text")

            i = ListExt.Items.Add(TxtExt.Text)

            i.SubItems.Add(Type)
        End If



    End Sub


    Public Sub closingform1() Handles Me.FormClosing
        'Dim allItems(ListExt.Items.Count - 1) As ListViewItem
        'ListExt.Items.CopyTo(allItems, 0)
        'MessageBox.Show(ListExt.geti(1)
        'For i = 1 To ListExt.Items.Count - 1



        '    If Not FoundFiles.ListofPaths.Items.Contains(ListExt(i)) Then
        '        ' It is not already in the list box so add it
        '        FoundFiles.ListofPaths.Items.Add(ListExt(i))
        '    End If
        'Next

        Form1.Show()


    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListExt.SelectedIndexChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class