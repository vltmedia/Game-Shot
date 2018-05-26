<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExtensionsAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.TxtExt = New System.Windows.Forms.TextBox()
        Me.ListExt = New System.Windows.Forms.ListView()
        Me.ClmnExt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ExtType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblExtension = New System.Windows.Forms.Label()
        Me.ChckImage = New System.Windows.Forms.CheckBox()
        Me.ChckVideo = New System.Windows.Forms.CheckBox()
        Me.ChckAudio = New System.Windows.Forms.CheckBox()
        Me.Chck3d = New System.Windows.Forms.CheckBox()
        Me.ChckDoc = New System.Windows.Forms.CheckBox()
        Me.ChckMisc = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("DIN", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(114, 291)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 31)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'TxtExt
        '
        Me.TxtExt.Font = New System.Drawing.Font("DIN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExt.Location = New System.Drawing.Point(114, 259)
        Me.TxtExt.Name = "TxtExt"
        Me.TxtExt.Size = New System.Drawing.Size(75, 26)
        Me.TxtExt.TabIndex = 1
        Me.TxtExt.Text = "mp4"
        '
        'ListExt
        '
        Me.ListExt.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClmnExt, Me.ExtType})
        Me.ListExt.Font = New System.Drawing.Font("DIN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListExt.Location = New System.Drawing.Point(28, 61)
        Me.ListExt.Name = "ListExt"
        Me.ListExt.Size = New System.Drawing.Size(427, 110)
        Me.ListExt.TabIndex = 2
        Me.ListExt.UseCompatibleStateImageBehavior = False
        Me.ListExt.View = System.Windows.Forms.View.Details
        '
        'ClmnExt
        '
        Me.ClmnExt.Text = "Extension"
        Me.ClmnExt.Width = 172
        '
        'ExtType
        '
        Me.ExtType.Text = "Type"
        Me.ExtType.Width = 234
        '
        'lblExtension
        '
        Me.lblExtension.AutoSize = True
        Me.lblExtension.Font = New System.Drawing.Font("Bebas Neue", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtension.Location = New System.Drawing.Point(150, 16)
        Me.lblExtension.Name = "lblExtension"
        Me.lblExtension.Size = New System.Drawing.Size(131, 29)
        Me.lblExtension.TabIndex = 3
        Me.lblExtension.Text = "Add Extension"
        '
        'ChckImage
        '
        Me.ChckImage.AutoSize = True
        Me.ChckImage.Font = New System.Drawing.Font("DIN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckImage.Location = New System.Drawing.Point(28, 186)
        Me.ChckImage.Name = "ChckImage"
        Me.ChckImage.Size = New System.Drawing.Size(69, 23)
        Me.ChckImage.TabIndex = 4
        Me.ChckImage.Text = "Image"
        Me.ChckImage.UseVisualStyleBackColor = True
        '
        'ChckVideo
        '
        Me.ChckVideo.AutoSize = True
        Me.ChckVideo.Font = New System.Drawing.Font("DIN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckVideo.Location = New System.Drawing.Point(28, 209)
        Me.ChckVideo.Name = "ChckVideo"
        Me.ChckVideo.Size = New System.Drawing.Size(64, 23)
        Me.ChckVideo.TabIndex = 4
        Me.ChckVideo.Text = "Video"
        Me.ChckVideo.UseVisualStyleBackColor = True
        '
        'ChckAudio
        '
        Me.ChckAudio.AutoSize = True
        Me.ChckAudio.Font = New System.Drawing.Font("DIN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckAudio.Location = New System.Drawing.Point(28, 232)
        Me.ChckAudio.Name = "ChckAudio"
        Me.ChckAudio.Size = New System.Drawing.Size(65, 23)
        Me.ChckAudio.TabIndex = 4
        Me.ChckAudio.Text = "Audio"
        Me.ChckAudio.UseVisualStyleBackColor = True
        '
        'Chck3d
        '
        Me.Chck3d.AutoSize = True
        Me.Chck3d.Font = New System.Drawing.Font("DIN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chck3d.Location = New System.Drawing.Point(28, 255)
        Me.Chck3d.Name = "Chck3d"
        Me.Chck3d.Size = New System.Drawing.Size(46, 23)
        Me.Chck3d.TabIndex = 4
        Me.Chck3d.Text = "3D"
        Me.Chck3d.UseVisualStyleBackColor = True
        '
        'ChckDoc
        '
        Me.ChckDoc.AutoSize = True
        Me.ChckDoc.Font = New System.Drawing.Font("DIN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckDoc.Location = New System.Drawing.Point(28, 278)
        Me.ChckDoc.Name = "ChckDoc"
        Me.ChckDoc.Size = New System.Drawing.Size(53, 23)
        Me.ChckDoc.TabIndex = 4
        Me.ChckDoc.Text = "Doc"
        Me.ChckDoc.UseVisualStyleBackColor = True
        '
        'ChckMisc
        '
        Me.ChckMisc.AutoSize = True
        Me.ChckMisc.Font = New System.Drawing.Font("DIN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckMisc.Location = New System.Drawing.Point(28, 307)
        Me.ChckMisc.Name = "ChckMisc"
        Me.ChckMisc.Size = New System.Drawing.Size(58, 23)
        Me.ChckMisc.TabIndex = 4
        Me.ChckMisc.Text = "Misc"
        Me.ChckMisc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("DIN", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(225, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Here you can add new extensions"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("DIN", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(225, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "that you can search for per type."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("DIN", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(225, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "1. Select a TYPE based on usage"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("DIN", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(226, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "2. Type the EXTENSION in the text field"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("DIN", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(226, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "3. Go, duh"
        '
        'ExtensionsAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 345)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChckMisc)
        Me.Controls.Add(Me.ChckDoc)
        Me.Controls.Add(Me.Chck3d)
        Me.Controls.Add(Me.ChckAudio)
        Me.Controls.Add(Me.ChckVideo)
        Me.Controls.Add(Me.ChckImage)
        Me.Controls.Add(Me.lblExtension)
        Me.Controls.Add(Me.ListExt)
        Me.Controls.Add(Me.TxtExt)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "ExtensionsAdd"
        Me.Text = "ExtensionsAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents TxtExt As TextBox
    Friend WithEvents ListExt As ListView
    Friend WithEvents lblExtension As Label
    Friend WithEvents ChckImage As CheckBox
    Friend WithEvents ChckVideo As CheckBox
    Friend WithEvents ChckAudio As CheckBox
    Friend WithEvents Chck3d As CheckBox
    Friend WithEvents ChckDoc As CheckBox
    Friend WithEvents ChckMisc As CheckBox
    Friend WithEvents ClmnExt As ColumnHeader
    Friend WithEvents ExtType As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
