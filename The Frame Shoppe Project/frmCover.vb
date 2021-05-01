Public Class frmCover


    Private Sub clearAcrylic_Click(sender As Object, e As EventArgs) Handles clearAcrylic.Click
        'Set cover price
        frmMain.dblPriceCover = dblCover1

        ' Display the name cover1
        frmMain.lblCoverName.Text = strCover1Name.ToString()

        'Update view
        frmMain.updateField()

        'Close frmCover
        Me.Close()
    End Sub

    Private Sub clearGlass_Click(sender As Object, e As EventArgs) Handles clearGlass.Click

        'Set cover price
        frmMain.dblPriceCover = dblCover2

        ' Display the name cover2
        frmMain.lblCoverName.Text = strCover2Name.ToString()

        'Update view
        frmMain.updateField()

        'Close frmCover
        Me.Close()
    End Sub

    Private Sub nonReflectiveGlass_Click(sender As Object, e As EventArgs) Handles nonReflectiveGlass.Click

        'Set cover price
        frmMain.dblPriceCover = dblCover3

        ' Display the name cover3
        frmMain.lblCoverName.Text = strCover3Name.ToString()

        'Update view
        frmMain.updateField()

        'Close frmCover
        Me.Close()
    End Sub
End Class