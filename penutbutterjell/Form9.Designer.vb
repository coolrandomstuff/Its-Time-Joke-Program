<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form9
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.Pictureframe1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pictureframe2 = New System.Windows.Forms.Timer(Me.components)
        Me.Pictureframe3 = New System.Windows.Forms.Timer(Me.components)
        Me.Pictureframe4 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'Timer2
        '
        Me.Timer2.Interval = 50
        '
        'Timer3
        '
        Me.Timer3.Interval = 50
        '
        'Timer4
        '
        Me.Timer4.Interval = 50
        '
        'Timer5
        '
        Me.Timer5.Interval = 50
        '
        'Timer6
        '
        Me.Timer6.Interval = 50
        '
        'Timer7
        '
        Me.Timer7.Interval = 50
        '
        'Timer8
        '
        Me.Timer8.Interval = 50
        '
        'Timer9
        '
        Me.Timer9.Interval = 50
        '
        'Pictureframe1
        '
        Me.Pictureframe1.Enabled = True
        Me.Pictureframe1.Interval = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.penutbutterjell.My.Resources.Resources.Annoy1
        Me.PictureBox1.Location = New System.Drawing.Point(-53, -29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1006, 323)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Pictureframe2
        '
        Me.Pictureframe2.Interval = 10
        '
        'Pictureframe3
        '
        Me.Pictureframe3.Interval = 10
        '
        'Pictureframe4
        '
        Me.Pictureframe4.Interval = 10
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 243)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form9"
        Me.Text = "PEE PEE POO POO"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Timer9 As Timer
    Friend WithEvents Pictureframe1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pictureframe2 As Timer
    Friend WithEvents Pictureframe3 As Timer
    Friend WithEvents Pictureframe4 As Timer
End Class
