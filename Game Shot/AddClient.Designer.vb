<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddClient
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
        Me.btnNewProject = New System.Windows.Forms.Button()
        Me.txtClientjname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnNewProject
        '
        Me.btnNewProject.Location = New System.Drawing.Point(12, 40)
        Me.btnNewProject.Name = "btnNewProject"
        Me.btnNewProject.Size = New System.Drawing.Size(126, 25)
        Me.btnNewProject.TabIndex = 3
        Me.btnNewProject.Text = "+ Game"
        Me.btnNewProject.UseVisualStyleBackColor = True
        '
        'txtClientjname
        '
        Me.txtClientjname.Location = New System.Drawing.Point(12, 12)
        Me.txtClientjname.Name = "txtClientjname"
        Me.txtClientjname.Size = New System.Drawing.Size(126, 21)
        Me.txtClientjname.TabIndex = 2
        Me.txtClientjname.Text = "Enter Game Name"
        Me.txtClientjname.UseWaitCursor = True
        '
        'AddClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(156, 87)
        Me.Controls.Add(Me.btnNewProject)
        Me.Controls.Add(Me.txtClientjname)
        Me.Font = New System.Drawing.Font("DIN", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AddClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddClient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNewProject As Button
    Friend WithEvents txtClientjname As TextBox
End Class
