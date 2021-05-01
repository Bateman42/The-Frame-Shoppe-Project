<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblHeightInches = New System.Windows.Forms.Label()
        Me.lblWidthInches = New System.Windows.Forms.Label()
        Me.btnHeight = New System.Windows.Forms.Button()
        Me.btnSetWidth = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPriceCover = New System.Windows.Forms.Label()
        Me.lblPriceMat = New System.Windows.Forms.Label()
        Me.lblPriceFrame = New System.Windows.Forms.Label()
        Me.lblCoverName = New System.Windows.Forms.Label()
        Me.lblMatName = New System.Windows.Forms.Label()
        Me.lblFrameName = New System.Windows.Forms.Label()
        Me.btnCover = New System.Windows.Forms.Button()
        Me.btnMat = New System.Windows.Forms.Button()
        Me.btnPickFrame = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblHeightInches)
        Me.GroupBox1.Controls.Add(Me.lblWidthInches)
        Me.GroupBox1.Controls.Add(Me.btnHeight)
        Me.GroupBox1.Controls.Add(Me.btnSetWidth)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 233)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Size"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(165, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 25)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "inches"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(165, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 25)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "inches"
        '
        'lblHeightInches
        '
        Me.lblHeightInches.AutoSize = True
        Me.lblHeightInches.Enabled = False
        Me.lblHeightInches.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeightInches.Location = New System.Drawing.Point(136, 155)
        Me.lblHeightInches.Name = "lblHeightInches"
        Me.lblHeightInches.Size = New System.Drawing.Size(23, 25)
        Me.lblHeightInches.TabIndex = 4
        Me.lblHeightInches.Text = "0"
        '
        'lblWidthInches
        '
        Me.lblWidthInches.AutoSize = True
        Me.lblWidthInches.Enabled = False
        Me.lblWidthInches.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWidthInches.Location = New System.Drawing.Point(136, 100)
        Me.lblWidthInches.Name = "lblWidthInches"
        Me.lblWidthInches.Size = New System.Drawing.Size(23, 25)
        Me.lblWidthInches.TabIndex = 2
        Me.lblWidthInches.Text = "0"
        '
        'btnHeight
        '
        Me.btnHeight.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHeight.Location = New System.Drawing.Point(281, 155)
        Me.btnHeight.Name = "btnHeight"
        Me.btnHeight.Size = New System.Drawing.Size(114, 29)
        Me.btnHeight.TabIndex = 1
        Me.btnHeight.Text = "Set Height"
        Me.btnHeight.UseVisualStyleBackColor = False
        '
        'btnSetWidth
        '
        Me.btnSetWidth.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSetWidth.Location = New System.Drawing.Point(281, 96)
        Me.btnSetWidth.Name = "btnSetWidth"
        Me.btnSetWidth.Size = New System.Drawing.Size(114, 29)
        Me.btnSetWidth.TabIndex = 0
        Me.btnSetWidth.Text = "Set Width"
        Me.btnSetWidth.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Height:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Width:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 32)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Enter the size of your art:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.lblPriceCover)
        Me.GroupBox2.Controls.Add(Me.lblPriceMat)
        Me.GroupBox2.Controls.Add(Me.lblPriceFrame)
        Me.GroupBox2.Controls.Add(Me.lblCoverName)
        Me.GroupBox2.Controls.Add(Me.lblMatName)
        Me.GroupBox2.Controls.Add(Me.lblFrameName)
        Me.GroupBox2.Controls.Add(Me.btnCover)
        Me.GroupBox2.Controls.Add(Me.btnMat)
        Me.GroupBox2.Controls.Add(Me.btnPickFrame)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(507, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(557, 362)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Style"
        '
        'lblPriceCover
        '
        Me.lblPriceCover.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPriceCover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriceCover.Enabled = False
        Me.lblPriceCover.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceCover.Location = New System.Drawing.Point(198, 269)
        Me.lblPriceCover.Name = "lblPriceCover"
        Me.lblPriceCover.Size = New System.Drawing.Size(141, 31)
        Me.lblPriceCover.TabIndex = 5
        Me.lblPriceCover.Text = "0"
        Me.lblPriceCover.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPriceMat
        '
        Me.lblPriceMat.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPriceMat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriceMat.Enabled = False
        Me.lblPriceMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceMat.Location = New System.Drawing.Point(198, 163)
        Me.lblPriceMat.Name = "lblPriceMat"
        Me.lblPriceMat.Size = New System.Drawing.Size(141, 31)
        Me.lblPriceMat.TabIndex = 4
        Me.lblPriceMat.Text = "0"
        Me.lblPriceMat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPriceFrame
        '
        Me.lblPriceFrame.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPriceFrame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriceFrame.Enabled = False
        Me.lblPriceFrame.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceFrame.Location = New System.Drawing.Point(198, 55)
        Me.lblPriceFrame.Name = "lblPriceFrame"
        Me.lblPriceFrame.Size = New System.Drawing.Size(141, 31)
        Me.lblPriceFrame.TabIndex = 3
        Me.lblPriceFrame.Text = "0"
        Me.lblPriceFrame.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCoverName
        '
        Me.lblCoverName.AutoSize = True
        Me.lblCoverName.Enabled = False
        Me.lblCoverName.Location = New System.Drawing.Point(200, 304)
        Me.lblCoverName.Name = "lblCoverName"
        Me.lblCoverName.Size = New System.Drawing.Size(48, 20)
        Me.lblCoverName.TabIndex = 11
        Me.lblCoverName.Text = "None"
        '
        'lblMatName
        '
        Me.lblMatName.AutoSize = True
        Me.lblMatName.Enabled = False
        Me.lblMatName.Location = New System.Drawing.Point(200, 198)
        Me.lblMatName.Name = "lblMatName"
        Me.lblMatName.Size = New System.Drawing.Size(48, 20)
        Me.lblMatName.TabIndex = 10
        Me.lblMatName.Text = "None"
        '
        'lblFrameName
        '
        Me.lblFrameName.AutoSize = True
        Me.lblFrameName.Enabled = False
        Me.lblFrameName.Location = New System.Drawing.Point(200, 90)
        Me.lblFrameName.Name = "lblFrameName"
        Me.lblFrameName.Size = New System.Drawing.Size(48, 20)
        Me.lblFrameName.TabIndex = 9
        Me.lblFrameName.Text = "None"
        '
        'btnCover
        '
        Me.btnCover.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCover.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCover.Location = New System.Drawing.Point(363, 269)
        Me.btnCover.Name = "btnCover"
        Me.btnCover.Size = New System.Drawing.Size(158, 29)
        Me.btnCover.TabIndex = 2
        Me.btnCover.Text = "Pick Cover"
        Me.btnCover.UseVisualStyleBackColor = False
        '
        'btnMat
        '
        Me.btnMat.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMat.Location = New System.Drawing.Point(363, 163)
        Me.btnMat.Name = "btnMat"
        Me.btnMat.Size = New System.Drawing.Size(158, 29)
        Me.btnMat.TabIndex = 1
        Me.btnMat.Text = "Pick Mat"
        Me.btnMat.UseVisualStyleBackColor = False
        '
        'btnPickFrame
        '
        Me.btnPickFrame.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPickFrame.Location = New System.Drawing.Point(363, 55)
        Me.btnPickFrame.Name = "btnPickFrame"
        Me.btnPickFrame.Size = New System.Drawing.Size(158, 29)
        Me.btnPickFrame.TabIndex = 0
        Me.btnPickFrame.Text = "Pick Frame"
        Me.btnPickFrame.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(83, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 29)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Frame:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 29)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Matting:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cover:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Harrington", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(299, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(432, 56)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "The Frame Shoppe"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.lblSubtotal)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(506, 513)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(557, 191)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Price"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Enabled = False
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTotal.Location = New System.Drawing.Point(275, 127)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(150, 37)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "$0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Enabled = False
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTax.Location = New System.Drawing.Point(275, 81)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(150, 37)
        Me.lblTax.TabIndex = 1
        Me.lblTax.Text = "$0.00"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Enabled = False
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblSubtotal.Location = New System.Drawing.Point(275, 31)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(150, 37)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "$0.00"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(108, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 29)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Subtotal:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(156, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 29)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Tax:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(141, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 29)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Total:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 727)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "Price Estimator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblHeightInches As Label
    Friend WithEvents lblWidthInches As Label
    Friend WithEvents btnHeight As Button
    Friend WithEvents btnSetWidth As Button
    Friend WithEvents lblCoverName As Label
    Friend WithEvents lblMatName As Label
    Friend WithEvents lblFrameName As Label
    Friend WithEvents btnCover As Button
    Friend WithEvents btnMat As Button
    Friend WithEvents btnPickFrame As Button
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblPriceCover As Label
    Friend WithEvents lblPriceMat As Label
    Friend WithEvents lblPriceFrame As Label
End Class
