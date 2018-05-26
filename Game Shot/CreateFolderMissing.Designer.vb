<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateFolderMissing
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnyes = New System.Windows.Forms.Button()
        Me.btnno = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The folder you are looking for does not exist. Would you like to create it?"
        '
        'btnyes
        '
        Me.btnyes.Location = New System.Drawing.Point(78, 72)
        Me.btnyes.Name = "btnyes"
        Me.btnyes.Size = New System.Drawing.Size(75, 23)
        Me.btnyes.TabIndex = 1
        Me.btnyes.Text = "Yes"
        Me.btnyes.UseVisualStyleBackColor = True
        '
        'btnno
        '
        Me.btnno.Location = New System.Drawing.Point(246, 72)
        Me.btnno.Name = "btnno"
        Me.btnno.Size = New System.Drawing.Size(75, 23)
        Me.btnno.TabIndex = 1
        Me.btnno.Text = "No"
        Me.btnno.UseVisualStyleBackColor = True
        '
        'CreateFolderMissing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 134)
        Me.Controls.Add(Me.btnno)
        Me.Controls.Add(Me.btnyes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CreateFolderMissing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CreateFolderMissing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnyes As Button
    Friend WithEvents btnno As Button
End Class
