<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Set_Project_Location
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnNewRoot = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNewRoot
        '
        Me.btnNewRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewRoot.Font = New System.Drawing.Font("DIN", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRoot.Location = New System.Drawing.Point(121, 103)
        Me.btnNewRoot.Name = "btnNewRoot"
        Me.btnNewRoot.Size = New System.Drawing.Size(125, 27)
        Me.btnNewRoot.TabIndex = 3
        Me.btnNewRoot.Text = "Set Projects Root Folder"
        Me.btnNewRoot.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("DIN", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 62)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please set your Project Root Folder. This is the main folder where everything liv" &
    "es, and the Game Screenshots folders will be made to keep you organized. Your Ex" &
    "ports folder will be here also."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("DIN", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 62)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Example:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("DIN", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(294, 62)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ProjectFolder / RocketLeague / 052818"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Set_Project_Location
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(367, 230)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNewRoot)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Set_Project_Location"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set_Project_Location"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNewRoot As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
