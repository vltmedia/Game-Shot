<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProject
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
        Me.txtProjname = New System.Windows.Forms.TextBox()
        Me.btnNewProject = New System.Windows.Forms.Button()
        Me.ChckAll = New System.Windows.Forms.CheckBox()
        Me.chkVideo = New System.Windows.Forms.CheckBox()
        Me.chkAudio = New System.Windows.Forms.CheckBox()
        Me.Chk3D = New System.Windows.Forms.CheckBox()
        Me.chkDesign = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtProjname
        '
        Me.txtProjname.Location = New System.Drawing.Point(34, 12)
        Me.txtProjname.Name = "txtProjname"
        Me.txtProjname.Size = New System.Drawing.Size(126, 20)
        Me.txtProjname.TabIndex = 0
        Me.txtProjname.Text = "Enter Project Name"
        '
        'btnNewProject
        '
        Me.btnNewProject.Location = New System.Drawing.Point(34, 151)
        Me.btnNewProject.Name = "btnNewProject"
        Me.btnNewProject.Size = New System.Drawing.Size(126, 23)
        Me.btnNewProject.TabIndex = 1
        Me.btnNewProject.Text = "+ Project"
        Me.btnNewProject.UseVisualStyleBackColor = True
        '
        'ChckAll
        '
        Me.ChckAll.AutoSize = True
        Me.ChckAll.Location = New System.Drawing.Point(33, 118)
        Me.ChckAll.Name = "ChckAll"
        Me.ChckAll.Size = New System.Drawing.Size(37, 17)
        Me.ChckAll.TabIndex = 2
        Me.ChckAll.Text = "All"
        Me.ChckAll.UseVisualStyleBackColor = True
        '
        'chkVideo
        '
        Me.chkVideo.AutoSize = True
        Me.chkVideo.Location = New System.Drawing.Point(33, 93)
        Me.chkVideo.Name = "chkVideo"
        Me.chkVideo.Size = New System.Drawing.Size(53, 17)
        Me.chkVideo.TabIndex = 2
        Me.chkVideo.Text = "Video"
        Me.chkVideo.UseVisualStyleBackColor = True
        '
        'chkAudio
        '
        Me.chkAudio.AutoSize = True
        Me.chkAudio.Location = New System.Drawing.Point(120, 70)
        Me.chkAudio.Name = "chkAudio"
        Me.chkAudio.Size = New System.Drawing.Size(53, 17)
        Me.chkAudio.TabIndex = 2
        Me.chkAudio.Text = "Audio"
        Me.chkAudio.UseVisualStyleBackColor = True
        '
        'Chk3D
        '
        Me.Chk3D.AutoSize = True
        Me.Chk3D.Location = New System.Drawing.Point(120, 93)
        Me.Chk3D.Name = "Chk3D"
        Me.Chk3D.Size = New System.Drawing.Size(40, 17)
        Me.Chk3D.TabIndex = 2
        Me.Chk3D.Text = "3D"
        Me.Chk3D.UseVisualStyleBackColor = True
        '
        'chkDesign
        '
        Me.chkDesign.AutoSize = True
        Me.chkDesign.Location = New System.Drawing.Point(33, 70)
        Me.chkDesign.Name = "chkDesign"
        Me.chkDesign.Size = New System.Drawing.Size(59, 17)
        Me.chkDesign.TabIndex = 2
        Me.chkDesign.Text = "Design"
        Me.chkDesign.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Project Type"
        '
        'AddProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(190, 186)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chk3D)
        Me.Controls.Add(Me.chkAudio)
        Me.Controls.Add(Me.chkVideo)
        Me.Controls.Add(Me.chkDesign)
        Me.Controls.Add(Me.ChckAll)
        Me.Controls.Add(Me.btnNewProject)
        Me.Controls.Add(Me.txtProjname)
        Me.Name = "AddProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddProject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtProjname As TextBox
    Friend WithEvents btnNewProject As Button
    Friend WithEvents ChckAll As CheckBox
    Friend WithEvents chkVideo As CheckBox
    Friend WithEvents chkAudio As CheckBox
    Friend WithEvents Chk3D As CheckBox
    Friend WithEvents chkDesign As CheckBox
    Friend WithEvents Label1 As Label
End Class
