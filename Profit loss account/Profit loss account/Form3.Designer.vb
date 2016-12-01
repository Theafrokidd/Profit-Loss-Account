<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.userlbl = New System.Windows.Forms.Label()
        Me.passlbl = New System.Windows.Forms.Label()
        Me.lgnbtn = New System.Windows.Forms.Button()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.usertxt = New System.Windows.Forms.TextBox()
        Me.Helpbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'userlbl
        '
        Me.userlbl.AutoSize = True
        Me.userlbl.Location = New System.Drawing.Point(35, 32)
        Me.userlbl.Name = "userlbl"
        Me.userlbl.Size = New System.Drawing.Size(55, 13)
        Me.userlbl.TabIndex = 0
        Me.userlbl.Text = "Username"
        '
        'passlbl
        '
        Me.passlbl.AutoSize = True
        Me.passlbl.Location = New System.Drawing.Point(36, 95)
        Me.passlbl.Name = "passlbl"
        Me.passlbl.Size = New System.Drawing.Size(53, 13)
        Me.passlbl.TabIndex = 1
        Me.passlbl.Text = "Password"
        '
        'lgnbtn
        '
        Me.lgnbtn.Location = New System.Drawing.Point(118, 137)
        Me.lgnbtn.Name = "lgnbtn"
        Me.lgnbtn.Size = New System.Drawing.Size(79, 23)
        Me.lgnbtn.TabIndex = 2
        Me.lgnbtn.Text = "Login"
        Me.lgnbtn.UseVisualStyleBackColor = True
        '
        'passtxt
        '
        Me.passtxt.Location = New System.Drawing.Point(12, 111)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passtxt.Size = New System.Drawing.Size(100, 20)
        Me.passtxt.TabIndex = 3
        '
        'usertxt
        '
        Me.usertxt.Location = New System.Drawing.Point(12, 49)
        Me.usertxt.Name = "usertxt"
        Me.usertxt.Size = New System.Drawing.Size(100, 20)
        Me.usertxt.TabIndex = 4
        '
        'Helpbtn
        '
        Me.Helpbtn.Location = New System.Drawing.Point(118, 108)
        Me.Helpbtn.Name = "Helpbtn"
        Me.Helpbtn.Size = New System.Drawing.Size(79, 23)
        Me.Helpbtn.TabIndex = 35
        Me.Helpbtn.Text = "Help"
        Me.Helpbtn.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(199, 171)
        Me.Controls.Add(Me.Helpbtn)
        Me.Controls.Add(Me.usertxt)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.lgnbtn)
        Me.Controls.Add(Me.passlbl)
        Me.Controls.Add(Me.userlbl)
        Me.Name = "Form3"
        Me.Text = "Login Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents userlbl As Label
    Friend WithEvents passlbl As Label
    Friend WithEvents lgnbtn As Button
    Friend WithEvents passtxt As TextBox
    Friend WithEvents usertxt As TextBox
    Friend WithEvents Helpbtn As Button
End Class
