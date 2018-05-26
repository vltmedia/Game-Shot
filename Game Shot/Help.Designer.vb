<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("DIN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(457, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Set your ""Root Project"" folder, either in the settings, or by resetting the appli" &
    "cation (Settings, or PERIOD at the bottom LEFT of main screen."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("DIN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(457, 75)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Add or select a game. This creates a folder in your ""Root Project"" folder automat" &
    "ically."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("DIN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 456)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(457, 75)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "When ready, click on ""Start Monitor"" if you want to utilize your old ""Print to De" &
    "sktop"" way. If so, please set that folder in the Settings where it says ""Monitor" &
    " Folder""."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("DIN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(457, 75)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "While running the game, hit Alt + V or if you changed the shortcut, whatever you " &
    "set it to. This captures the screen and saves it to ""Root Folder / Game Folder /" &
    " DATE"""
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("DIN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(99, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(457, 75)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "While running the game, hit Alt + V or if you changed the shortcut, whatever you " &
    "set it to. This captures the screen and saves it to ""Root Folder / Game Folder /" &
    " DATE"""
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 608)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Help"
        Me.Text = "Help"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
