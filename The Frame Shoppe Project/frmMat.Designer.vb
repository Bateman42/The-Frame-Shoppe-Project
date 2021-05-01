<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMat))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.singleMatBlue = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.singleMatBlack = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.doubleMatBlakWhite = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.doubleMatBlueWhite = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.doubleMatWhiteBlack = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.doubleMatDarkBlue = New System.Windows.Forms.PictureBox()
        CType(Me.singleMatBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.singleMatBlack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubleMatBlakWhite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubleMatBlueWhite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubleMatWhiteBlack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubleMatDarkBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click on your choice."
        '
        'singleMatBlue
        '
        Me.singleMatBlue.Image = CType(resources.GetObject("singleMatBlue.Image"), System.Drawing.Image)
        Me.singleMatBlue.Location = New System.Drawing.Point(62, 75)
        Me.singleMatBlue.Name = "singleMatBlue"
        Me.singleMatBlue.Size = New System.Drawing.Size(190, 195)
        Me.singleMatBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.singleMatBlue.TabIndex = 1
        Me.singleMatBlue.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Single Mat – Blue ($) "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(349, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Single Mat – Black ($)"
        '
        'singleMatBlack
        '
        Me.singleMatBlack.Image = CType(resources.GetObject("singleMatBlack.Image"), System.Drawing.Image)
        Me.singleMatBlack.Location = New System.Drawing.Point(323, 75)
        Me.singleMatBlack.Name = "singleMatBlack"
        Me.singleMatBlack.Size = New System.Drawing.Size(190, 195)
        Me.singleMatBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.singleMatBlack.TabIndex = 3
        Me.singleMatBlack.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(581, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Double Mat – Black, White ($$)"
        '
        'doubleMatBlakWhite
        '
        Me.doubleMatBlakWhite.Image = CType(resources.GetObject("doubleMatBlakWhite.Image"), System.Drawing.Image)
        Me.doubleMatBlakWhite.Location = New System.Drawing.Point(584, 75)
        Me.doubleMatBlakWhite.Name = "doubleMatBlakWhite"
        Me.doubleMatBlakWhite.Size = New System.Drawing.Size(190, 195)
        Me.doubleMatBlakWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.doubleMatBlakWhite.TabIndex = 5
        Me.doubleMatBlakWhite.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 529)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Double Mat – Blue, White ($$)"
        '
        'doubleMatBlueWhite
        '
        Me.doubleMatBlueWhite.Image = CType(resources.GetObject("doubleMatBlueWhite.Image"), System.Drawing.Image)
        Me.doubleMatBlueWhite.Location = New System.Drawing.Point(62, 331)
        Me.doubleMatBlueWhite.Name = "doubleMatBlueWhite"
        Me.doubleMatBlueWhite.Size = New System.Drawing.Size(190, 195)
        Me.doubleMatBlueWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.doubleMatBlueWhite.TabIndex = 7
        Me.doubleMatBlueWhite.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(320, 529)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Double Mat – White, Black ($$) "
        '
        'doubleMatWhiteBlack
        '
        Me.doubleMatWhiteBlack.Image = CType(resources.GetObject("doubleMatWhiteBlack.Image"), System.Drawing.Image)
        Me.doubleMatWhiteBlack.Location = New System.Drawing.Point(323, 331)
        Me.doubleMatWhiteBlack.Name = "doubleMatWhiteBlack"
        Me.doubleMatWhiteBlack.Size = New System.Drawing.Size(190, 195)
        Me.doubleMatWhiteBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.doubleMatWhiteBlack.TabIndex = 9
        Me.doubleMatWhiteBlack.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(555, 529)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(255, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Double Mat – Dark Blue, Light Blue ($$)"
        '
        'doubleMatDarkBlue
        '
        Me.doubleMatDarkBlue.Image = CType(resources.GetObject("doubleMatDarkBlue.Image"), System.Drawing.Image)
        Me.doubleMatDarkBlue.Location = New System.Drawing.Point(584, 331)
        Me.doubleMatDarkBlue.Name = "doubleMatDarkBlue"
        Me.doubleMatDarkBlue.Size = New System.Drawing.Size(190, 195)
        Me.doubleMatDarkBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.doubleMatDarkBlue.TabIndex = 11
        Me.doubleMatDarkBlue.TabStop = False
        '
        'frmMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 587)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.doubleMatDarkBlue)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.doubleMatWhiteBlack)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.doubleMatBlueWhite)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.doubleMatBlakWhite)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.singleMatBlack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.singleMatBlue)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMat"
        Me.Text = "Choose a Mat"
        CType(Me.singleMatBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.singleMatBlack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubleMatBlakWhite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubleMatBlueWhite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubleMatWhiteBlack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubleMatDarkBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents singleMatBlue As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents singleMatBlack As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents doubleMatBlakWhite As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents doubleMatBlueWhite As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents doubleMatWhiteBlack As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents doubleMatDarkBlue As PictureBox
End Class
