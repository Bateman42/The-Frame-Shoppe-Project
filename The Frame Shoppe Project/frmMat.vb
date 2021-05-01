Public Class frmMat

    Private Sub singleMatBlue_Click(sender As Object, e As EventArgs) Handles singleMatBlue.Click

        'Set mat price
        frmMain.dblPriceMat = dblMat1


        ' Display the name mat1
        frmMain.lblMatName.Text = strMat1Name.ToString()

        'Update view
        frmMain.updateField()

        'Close frmMat
        Me.Close()
    End Sub

    Private Sub singleMatBlack_Click(sender As Object, e As EventArgs) Handles singleMatBlack.Click
        'Set mat price
        frmMain.dblPriceMat = dblMat2
        ' Display the name mat2
        frmMain.lblMatName.Text = strMat2Name.ToString()

        'Update view
        frmMain.updateField()

        'Close frmMat
        Me.Close()
    End Sub

    Private Sub doubleMatBlakWhite_Click(sender As Object, e As EventArgs) Handles doubleMatBlakWhite.Click

        'Set mat price
        frmMain.dblPriceMat = dblMat3

        ' Display the name mat3
        frmMain.lblMatName.Text = strMat3Name.ToString()

        'Update view
        frmMain.updateField()

        'Close frmMat
        Me.Close()
    End Sub

    Private Sub doubleMatBlueWhite_Click(sender As Object, e As EventArgs) Handles doubleMatBlueWhite.Click

        'Set mat price
        frmMain.dblPriceMat = dblMat4

        ' Display the name mat4
        frmMain.lblMatName.Text = strMat4Name.ToString()

        'Update view
        frmMain.updateField()

        'Close frmMat
        Me.Close()
    End Sub

    Private Sub doubleMatWhiteBlack_Click(sender As Object, e As EventArgs) Handles doubleMatWhiteBlack.Click

        'Set mat price
        frmMain.dblPriceMat = dblMat5

        ' Display the name mat5
        frmMain.lblMatName.Text = strMat5Name.ToString()

        'Update view
        frmMain.updateField()

        'Close frmMat
        Me.Close()
    End Sub

    Private Sub doubleMatDarkBlue_Click(sender As Object, e As EventArgs) Handles doubleMatDarkBlue.Click

        'Set mat price
        frmMain.dblPriceMat = dblMat6

        ' Display the name mat6
        frmMain.lblMatName.Text = strMat6Name.ToString()

        'Update view
        frmMain.updateField()

        'Close frmMat
        Me.Close()
    End Sub
End Class