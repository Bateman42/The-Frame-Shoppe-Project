<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCover
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCover))
        Me.label3 = New System.Windows.Forms.Label()
        Me.nonReflectiveGlass = New System.Windows.Forms.PictureBox()
        Me.lable2 = New System.Windows.Forms.Label()
        Me.clearGlass = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clearAcrylic = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.nonReflectiveGlass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clearGlass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clearAcrylic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(638, 355)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(174, 17)
        Me.label3.TabIndex = 13
        Me.label3.Text = "Non-reflective Glass ($$$)"
        '
        'nonReflectiveGlass
        '
        Me.nonReflectiveGlass.Image = CType(resources.GetObject("nonReflectiveGlass.Image"), System.Drawing.Image)
        Me.nonReflectiveGlass.Location = New System.Drawing.Point(627, 157)
        Me.nonReflectiveGlass.Name = "nonReflectiveGlass"
        Me.nonReflectiveGlass.Size = New System.Drawing.Size(190, 195)
        Me.nonReflectiveGlass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.nonReflectiveGlass.TabIndex = 12
        Me.nonReflectiveGlass.TabStop = False
        '
        'lable2
        '
        Me.lable2.AutoSize = True
        Me.lable2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable2.Location = New System.Drawing.Point(414, 355)
        Me.lable2.Name = "lable2"
        Me.lable2.Size = New System.Drawing.Size(115, 17)
        Me.lable2.TabIndex = 11
        Me.lable2.Text = "Clear Glass ($$) "
        '
        'clearGlass
        '
        Me.clearGlass.Image = CType(resources.GetObject("clearGlass.Image"), System.Drawing.Image)
        Me.clearGlass.Location = New System.Drawing.Point(366, 157)
        Me.clearGlass.Name = "clearGlass"
        Me.clearGlass.Size = New System.Drawing.Size(190, 195)
        Me.clearGlass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.clearGlass.TabIndex = 10
        Me.clearGlass.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 355)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Clear Acrylic ($) "
        '
        'clearAcrylic
        '
        Me.clearAcrylic.Image = CType(resources.GetObject("clearAcrylic.Image"), System.Drawing.Image)
        Me.clearAcrylic.Location = New System.Drawing.Point(105, 157)
        Me.clearAcrylic.Name = "clearAcrylic"
        Me.clearAcrylic.Size = New System.Drawing.Size(190, 195)
        Me.clearAcrylic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.clearAcrylic.TabIndex = 8
        Me.clearAcrylic.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Click on your choice."
        '
        'frmCover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 531)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.nonReflectiveGlass)
        Me.Controls.Add(Me.lable2)
        Me.Controls.Add(Me.clearGlass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.clearAcrylic)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCover"
        Me.Text = "Choose a Cover"
        CType(Me.nonReflectiveGlass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clearGlass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clearAcrylic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label3 As Label
    Friend WithEvents nonReflectiveGlass As PictureBox
    Friend WithEvents lable2 As Label
    Friend WithEvents clearGlass As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents clearAcrylic As PictureBox
    Friend WithEvents Label1 As Label
End Class
