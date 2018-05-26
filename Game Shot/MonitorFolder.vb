Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.IO.Compression
Imports System.Threading
Imports System.ComponentModel

Public Class MonitorFolder

    Public Clientname = "Client"
    Public Projname = "Project"
    Public Seconds = 0

    Public Sub Go()

        fswMonitor.Path = Monitorfolderglobal
        Dim fsw As New FileSystemWatcher(My.Computer.FileSystem.SpecialDirectories.MyDocuments)
        'LabelProj.Text = Clientname & "." & Projname
        fswMonitor.Path = Monitorfolderglobal

        '
        ' Assign event procedures to the events to watch.
        '
        AddHandler fsw.Created, AddressOf OnChanged
        AddHandler fsw.Changed, AddressOf OnChanged
        AddHandler fsw.Deleted, AddressOf OnChanged
        AddHandler fsw.Renamed, AddressOf OnRenamed

        With fsw
            .EnableRaisingEvents = True
            .IncludeSubdirectories = True
            '
            ' Specif the event to watch for.
            '
            .WaitForChanged(WatcherChangeTypes.Created Or
                        WatcherChangeTypes.Changed Or
                        WatcherChangeTypes.Deleted Or
                        WatcherChangeTypes.Renamed)
            '
            ' Watch certain file types.
            '
            .Filter = "*.txt"
            '
            ' Specify file change notifications.
            '
            .NotifyFilter = (NotifyFilters.LastAccess Or
                         NotifyFilters.LastWrite Or
                         NotifyFilters.FileName Or
                         NotifyFilters.DirectoryName)
        End With


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim fsw As New FileSystemWatcher("C:\Users\Justin Jaro\Downloads")
        'Label1.Text = fswMonitor.Path
        'fswMonitor.Path = "C:\Users\Justin Jaro\Downloads"

        ''
        '' Assign event procedures to the events to watch.
        ''
        'AddHandler fsw.Created, AddressOf OnChanged
        'AddHandler fsw.Changed, AddressOf OnChanged
        'AddHandler fsw.Deleted, AddressOf OnChanged
        'AddHandler fsw.Renamed, AddressOf OnRenamed

        'With fsw
        '    .EnableRaisingEvents = True
        '    .IncludeSubdirectories = True
        '    '
        '    ' Specif the event to watch for.
        '    '
        '    .WaitForChanged(WatcherChangeTypes.Created Or
        '                WatcherChangeTypes.Changed Or
        '                WatcherChangeTypes.Deleted Or
        '                WatcherChangeTypes.Renamed)
        '    '
        '    ' Watch certain file types.
        '    '
        '    .Filter = "*.txt"
        '    '
        '    ' Specify file change notifications.
        '    '
        '    .NotifyFilter = (NotifyFilters.LastAccess Or
        '                 NotifyFilters.LastWrite Or
        '                 NotifyFilters.FileName Or
        '                 NotifyFilters.DirectoryName)
        'End With

        Monitor.Close()
        Me.Close()

    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Thread.Sleep(3000)
        'Monitor.Show()

        BackgroundWorker1.RunWorkerAsync()



        'Go()
        'fswMonitor.Path = "C:\Users\Justin Jaro\Downloads"
        'Dim fsw As New FileSystemWatcher("C:\Users\Justin Jaro\Downloads")
        'Label1.Text = fswMonitor.Path
        'fswMonitor.Path = "C:\Users\Justin Jaro\Downloads"

        ''
        '' Assign event procedures to the events to watch.
        ''
        'AddHandler fsw.Created, AddressOf OnChanged
        'AddHandler fsw.Changed, AddressOf OnChanged
        'AddHandler fsw.Deleted, AddressOf OnChanged
        'AddHandler fsw.Renamed, AddressOf OnRenamed

        'With fsw
        '    .EnableRaisingEvents = True
        '    .IncludeSubdirectories = True
        '    '
        '    ' Specif the event to watch for.
        '    '
        '    .WaitForChanged(WatcherChangeTypes.Created Or
        '                WatcherChangeTypes.Changed Or
        '                WatcherChangeTypes.Deleted Or
        '                WatcherChangeTypes.Renamed)
        '    '
        '    ' Watch certain file types.
        '    '
        '    .Filter = "*.txt"
        '    '
        '    ' Specify file change notifications.
        '    '
        '    .NotifyFilter = (NotifyFilters.LastAccess Or
        '                 NotifyFilters.LastWrite Or
        '                 NotifyFilters.FileName Or
        '                 NotifyFilters.DirectoryName)
        'End With
    End Sub

    Private Sub fswMonitor_Changed(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles fswMonitor.Changed

        Dim Todaydate As String = Today.ToString("MMddyy")
        Dim Filename = Path.GetFileName(e.FullPath)
        Dim Images = ProjFolderglobal & "\" & Todaydate & Filename
        Dim Zip = ProjFolderglobal & "\" & "Assets\Zip\" & Filename
        Dim Audio = ProjFolderglobal & "\" & "Audio\" & Filename
        Dim Video = ProjFolderglobal & "\" & "Media\" & Filename
        Dim PSD = ProjFolderglobal & "\" & "Assets\PSD\" & Filename
        Dim Illustrator = ProjFolderglobal & "\" & "Assets\AI\" & Filename




        If Filename.Contains("tmp") Then

            Console.WriteLine("Tmp:" & Filename)

        Else
            If Filename.Contains("jpg") Or Filename.Contains("png") Or Filename.Contains("tiff") Or Filename.Contains("tif") Or Filename.Contains("gif") Or Filename.Contains("bmp") Then
                Console.WriteLine("Images: " & Images)

                If IO.Directory.Exists(Path.GetDirectoryName(Images)) Then
                    Console.WriteLine(e.FullPath)
                    Console.WriteLine(Images)
                    File.Copy(Path.Combine(e.FullPath), Path.Combine(Images), True)
                    My.Computer.FileSystem.DeleteFile(e.FullPath)
                    Process.Start(Path.GetDirectoryName(Images))
                    'Thread.Sleep(1000)
                    'My.Computer.FileSystem.DeleteFile(e.FullPath)
                Else
                    CreateThisFolder = Path.GetDirectoryName(Images)
                    CreateFolderMissing.Show()
                    CreateFolderMissing.TopMost = True
                    Me.Hide()
                    CreateFolderMissing.Todaydate = Todaydate
                    CreateFolderMissing.Copyfile = True
                    CreateFolderMissing.Path1 = e.FullPath
                    CreateFolderMissing.Path2 = Images

                End If


                'File.Copy(Path.Combine(e.FullPath), Path.Combine(Images), True)
                Console.WriteLine("Succesfully cuppied to:" & Images)
                Process.Start(Path.GetDirectoryName(Images))
            Else
                Console.WriteLine("Not a baked file yet:" & Filename)
            End If
            If Filename.Contains("mp4") Or Filename.Contains("mov") Or Filename.Contains("avi") Or Filename.Contains("mxf") Or Filename.Contains("R3D") Then
                Console.WriteLine("Video: " & Video)

                If IO.Directory.Exists(Path.GetDirectoryName(Video)) Then
                    File.Copy(Path.Combine(e.FullPath), Path.Combine(Video), True)
                    Process.Start(Path.GetDirectoryName(Video))
                Else
                    CreateThisFolder = Path.GetDirectoryName(Video)
                    CreateFolderMissing.Show()
                    CreateFolderMissing.TopMost = True
                    Me.Hide()
                    CreateFolderMissing.Copyfile = True
                    CreateFolderMissing.Path1 = e.FullPath
                    CreateFolderMissing.Path2 = Video

                End If


                'File.Copy(Path.Combine(e.FullPath), Path.Combine(Video), True)
                Console.WriteLine("Succesfully cuppied to:" & Video)
                Process.Start(Path.GetDirectoryName(Video))
            Else
                Console.WriteLine("Not a baked file yet:" & Filename)
            End If
            If Filename.Contains("mp3") Or Filename.Contains("wav") Or Filename.Contains("aif") Or Filename.Contains("vog") Or Filename.Contains("sound") Or Filename.Contains("flac") Then
                Console.WriteLine("Audio: " & Audio)

                If IO.Directory.Exists(Path.GetDirectoryName(Audio)) Then
                    File.Copy(Path.Combine(e.FullPath), Path.Combine(Audio), True)
                    Process.Start(Path.GetDirectoryName(Audio))
                Else
                    CreateThisFolder = Path.GetDirectoryName(Audio)
                    CreateFolderMissing.Show()
                    CreateFolderMissing.TopMost = True
                    Me.Hide()
                    CreateFolderMissing.Copyfile = True
                    CreateFolderMissing.Path1 = e.FullPath
                    CreateFolderMissing.Path2 = Audio

                End If


                'File.Copy(Path.Combine(e.FullPath), Path.Combine(Audio), True)
                Console.WriteLine("Succesfully cuppied to:" & Audio)
                'Process.Start(Path.GetDirectoryName(Audio))
            Else
                Console.WriteLine("Not a baked file yet:" & Filename)
            End If
            If Filename.Contains("psd") Then
                Console.WriteLine("PSD: " & PSD)

                If IO.Directory.Exists(Path.GetDirectoryName(PSD)) Then
                    File.Copy(Path.Combine(e.FullPath), Path.Combine(PSD), True)
                    Process.Start(Path.GetDirectoryName(Audio))
                Else
                    CreateThisFolder = Path.GetDirectoryName(PSD)
                    CreateFolderMissing.Show()
                    CreateFolderMissing.TopMost = True
                    Me.Hide()
                    CreateFolderMissing.Copyfile = True
                    CreateFolderMissing.Path1 = e.FullPath
                    CreateFolderMissing.Path2 = PSD

                End If


                'File.Copy(Path.Combine(e.FullPath), Path.Combine(PSD), True)
                Console.WriteLine("Succesfully cuppied to:" & PSD)
                Process.Start(Path.GetDirectoryName(PSD))
            Else
                Console.WriteLine("Not a baked file yet:" & Filename)
            End If
            If Filename.Contains("ai") Then
                Console.WriteLine("AI: " & Illustrator)

                If IO.Directory.Exists(Path.GetDirectoryName(Illustrator)) Then
                    File.Copy(Path.Combine(e.FullPath), Path.Combine(Illustrator), True)
                    Process.Start(Path.GetDirectoryName(Illustrator))
                Else
                    CreateThisFolder = Path.GetDirectoryName(Illustrator)
                    CreateFolderMissing.Show()
                    CreateFolderMissing.TopMost = True
                    Me.Hide()
                    CreateFolderMissing.Copyfile = True
                    CreateFolderMissing.Path1 = e.FullPath
                    CreateFolderMissing.Path2 = Illustrator

                End If


                'File.Copy(Path.Combine(e.FullPath), Path.Combine(Illustrator), True)
                Console.WriteLine("Succesfully cuppied to:" & Illustrator)
                Process.Start(Path.GetDirectoryName(Illustrator))
            Else
                Console.WriteLine("Not a baked file yet:" & Filename)
            End If
            If Filename.Contains("zip") Then
                Console.WriteLine("Zip: " & Zip)
                If IO.Directory.Exists(Path.GetDirectoryName(Zip)) Then
                    File.Copy(Path.Combine(e.FullPath), Path.Combine(Zip), True)
                    Process.Start(Path.GetDirectoryName(Illustrator))
                Else
                    CreateThisFolder = Path.GetDirectoryName(Zip)
                    CreateFolderMissing.Show()
                    CreateFolderMissing.TopMost = True
                    Me.Hide()
                    CreateFolderMissing.Copyfile = True
                    CreateFolderMissing.Path1 = e.FullPath
                    CreateFolderMissing.Path2 = Zip

                End If


                'File.Copy(Path.Combine(e.FullPath), Path.Combine(Zip), True)
                Console.WriteLine("Succesfully cuppied to:" & Zip)

                Process.Start(Path.GetDirectoryName(Zip))
            Else
                Console.WriteLine("Not a baked file yet:" & Filename)
            End If


        End If


        Console.WriteLine("Complete")


    End Sub

    Private Sub fswMonitor_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles fswMonitor.Created
        Dim Todaydate As String = Today.ToString("MMddyy")
        Dim Filename = Path.GetFileName(e.FullPath)
        Dim Images = ProjFolderglobal & "\" & Todaydate & "\" & Filename
        Dim Zip = ProjFolderglobal & "\" & "Assets\Zip\" & Filename
        Dim Audio = ProjFolderglobal & "\" & "Audio\" & Filename
        Dim Video = ProjFolderglobal & "\" & "Media\" & Filename
        Dim PSD = ProjFolderglobal & "\" & "Assets\PSD\" & Filename
        Dim Illustrator = ProjFolderglobal & "\" & "Assets\AI\" & Filename



        'Thread.Sleep(1000)
        If Filename.Contains("tmp") Then

            Console.WriteLine("Tmp:" & Filename)

        Else
            If Filename.Contains("jpg") Or Filename.Contains("png") Or Filename.Contains("tiff") Or Filename.Contains("tif") Or Filename.Contains("gif") Or Filename.Contains("bmp") Then
                Console.WriteLine("Images: " & Images)

                If IO.Directory.Exists(Path.GetDirectoryName(Images)) Then
                    File.Copy(Path.Combine(e.FullPath), Path.Combine(Images), True)
                    My.Computer.FileSystem.DeleteFile(e.FullPath)
                    Process.Start(Path.GetDirectoryName(Images))
                    'Thread.Sleep(1000)
                    'My.Computer.FileSystem.DeleteFile(e.FullPath)
                Else
                    CreateThisFolder = Path.GetDirectoryName(Images)
                    CreateFolderMissing.Show()
                    CreateFolderMissing.TopMost = True
                    Me.Hide()
                    CreateFolderMissing.Todaydate = Todaydate
                    CreateFolderMissing.Copyfile = True
                    CreateFolderMissing.Path1 = e.FullPath
                    CreateFolderMissing.Path2 = Images

                End If


                'File.Copy(Path.Combine(e.FullPath), Path.Combine(Images), True)
                Console.WriteLine("Succesfully cuppied to:" & Images)
                'Process.Start(Path.GetDirectoryName(Images))
            Else
                Console.WriteLine("Not a baked file yet:" & Filename)
            End If
            If Filename.Contains("mp4") Or Filename.Contains("mov") Or Filename.Contains("avi") Or Filename.Contains("mxf") Or Filename.Contains("R3D") Then
                Console.WriteLine("Video: " & Video)

                If IO.Directory.Exists(Path.GetDirectoryName(Video)) Then
                    File.Copy(Path.Combine(e.FullPath), Path.Combine(Video), True)
                    Process.Start(Path.GetDirectoryName(Video))
                Else
                    CreateThisFolder = Path.GetDirectoryName(Video)
                    CreateFolderMissing.Show()
                    CreateFolderMissing.TopMost = True
                    Me.Hide()
                    CreateFolderMissing.Copyfile = True
                    CreateFolderMissing.Path1 = e.FullPath
                    CreateFolderMissing.Path2 = Video

                End If


                'File.Copy(Path.Combine(e.FullPath), Path.Combine(Video), True)
                Console.WriteLine("Succesfully cuppied to:" & Video)
                Process.Start(Path.GetDirectoryName(Video))
            Else
                Console.WriteLine("Not a baked file yet:" & Filename)
            End If
            If Filename.Contains("mp3") Or Filename.Contains("wav") Or Filename.Contains("aif") Or Filename.Contains("vog") Or Filename.Contains("sound") Or Filename.Contains("flac") Then
                Console.WriteLine("Audio: " & Audio)

                If IO.Directory.Exists(Path.GetDirectoryName(Audio)) Then
                    File.Copy(Path.Combine(e.FullPath), Path.Combine(Audio), True)
                    Process.Start(Path.GetDirectoryName(Audio))
                Else
                    CreateThisFolder = Path.GetDirectoryName(Audio)
                    CreateFolderMissing.Show()
                    CreateFolderMissing.TopMost = True
                    Me.Hide()
                    CreateFolderMissing.Copyfile = True
                    CreateFolderMissing.Path1 = e.FullPath
                    CreateFolderMissing.Path2 = Audio

                End If


                'File.Copy(Path.Combine(e.FullPath), Path.Combine(Audio), True)
                Console.WriteLine("Succesfully cuppied to:" & Audio)
                'Process.Start(Path.GetDirectoryName(Audio))
            Else
                Console.WriteLine("Not a baked file yet:" & Filename)
            End If
            If Filename.Contains("psd") Then
                Console.WriteLine("PSD: " & PSD)

                If IO.Directory.Exists(Path.GetDirectoryName(PSD)) Then
                    File.Copy(Path.Combine(e.FullPath), Path.Combine(PSD), True)
                    Process.Start(Path.GetDirectoryName(Audio))
                Else
                    CreateThisFolder = Path.GetDirectoryName(PSD)
                    CreateFolderMissing.Show()
                    CreateFolderMissing.TopMost = True
                    Me.Hide()
                    CreateFolderMissing.Copyfile = True
                    CreateFolderMissing.Path1 = e.FullPath
                    CreateFolderMissing.Path2 = PSD

                End If


                'File.Copy(Path.Combine(e.FullPath), Path.Combine(PSD), True)
                Console.WriteLine("Succesfully cuppied to:" & PSD)
                Process.Start(Path.GetDirectoryName(PSD))
            Else
                Console.WriteLine("Not a baked file yet:" & Filename)
            End If
            If Filename.Contains("ai") Then
                Console.WriteLine("AI: " & Illustrator)

                If IO.Directory.Exists(Path.GetDirectoryName(Illustrator)) Then
                    File.Copy(Path.Combine(e.FullPath), Path.Combine(Illustrator), True)
                    Process.Start(Path.GetDirectoryName(Illustrator))
                Else
                    CreateThisFolder = Path.GetDirectoryName(Illustrator)
                    CreateFolderMissing.Show()
                    CreateFolderMissing.TopMost = True
                    Me.Hide()
                    CreateFolderMissing.Copyfile = True
                    CreateFolderMissing.Path1 = e.FullPath
                    CreateFolderMissing.Path2 = Illustrator

                End If


                'File.Copy(Path.Combine(e.FullPath), Path.Combine(Illustrator), True)
                Console.WriteLine("Succesfully cuppied to:" & Illustrator)
                Process.Start(Path.GetDirectoryName(Illustrator))
            Else
                Console.WriteLine("Not a baked file yet:" & Filename)
            End If
            If Filename.Contains("zip") Then
                Console.WriteLine("Zip: " & Zip)
                If IO.Directory.Exists(Path.GetDirectoryName(Zip)) Then
                    File.Copy(Path.Combine(e.FullPath), Path.Combine(Zip), True)
                    Process.Start(Path.GetDirectoryName(Illustrator))
                Else
                    CreateThisFolder = Path.GetDirectoryName(Zip)
                    CreateFolderMissing.Show()
                    CreateFolderMissing.TopMost = True
                    Me.Hide()
                    CreateFolderMissing.Copyfile = True
                    CreateFolderMissing.Path1 = e.FullPath
                    CreateFolderMissing.Path2 = Zip

                End If


                'File.Copy(Path.Combine(e.FullPath), Path.Combine(Zip), True)
                Console.WriteLine("Succesfully cuppied to:" & Zip)

                Process.Start(Path.GetDirectoryName(Zip))
            Else
                Console.WriteLine("Not a baked file yet:" & Filename)
            End If


        End If


        Console.WriteLine("Complete")

    End Sub

    Private Sub fswMonitor_Deleted(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles fswMonitor.Deleted
        Console.WriteLine("Deleted: " + e.FullPath)
    End Sub

    Private Sub fswMonitor_Error(ByVal sender As Object, ByVal e As System.IO.ErrorEventArgs) Handles fswMonitor.Error
        Console.WriteLine("ERROR: " + e.GetException.Message)
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
    End Sub

    Private Sub fswMonitor_Renamed(ByVal sender As Object, ByVal e As System.IO.RenamedEventArgs) Handles fswMonitor.Renamed
        Console.WriteLine("Renamed: " + e.OldFullPath + " - " + e.FullPath)
    End Sub

    Private Sub MonitorFolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Public Sub OnChanged(ByVal source As Object, ByVal e As FileSystemEventArgs)
        Console.WriteLine("File changed: " & e.FullPath & " change type: " & e.ChangeType)

    End Sub

    Public Sub OnRenamed(ByVal source As Object, ByVal e As RenamedEventArgs)
        Console.WriteLine("Renameddd")

    End Sub

    Private Sub MonitorFolder_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        fswMonitor.EnableRaisingEvents = False




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(1)
        If ProgressBar1.Value < 4 Then

            'Go()


        End If


    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Go()



    End Sub
End Class