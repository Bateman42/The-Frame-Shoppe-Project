Public Class frmMain

    Public dblHeight As Double
    Public dblWidth As Double
    Public dblPriceFrame As Double = 0
    Public dblPriceMat As Double = 0
    Public dblPriceCover As Double = 0

    Public Sub updateField()
        ' Calculate And set the frame price.
        Dim tempFramePrice As Double
        tempFramePrice = (dblWidth + dblHeight) * 2 * dblPriceFrame
        lblPriceFrame.Text = tempFramePrice.ToString("c")

        'Mat
        lblPriceMat.Text = dblPriceMat.ToString("c")

        'Calculate and Set Cover Price
        Dim tempCoverPrice As Double
        tempCoverPrice = dblWidth * dblHeight * dblPriceCover
        lblPriceCover.Text = tempCoverPrice.ToString("c")

        'Calculate and Set Subtotal
        Dim dblSubtotal As Double
        dblSubtotal = tempCoverPrice + tempFramePrice + dblPriceMat
        lblSubtotal.Text = dblSubtotal.ToString("c")

        'Calculate and Set Tax
        lblTax.Text = (dblSubtotal * 0.07).ToString("c")

        'Calculate and Set Total
        lblTotal.Text = (dblSubtotal + (dblSubtotal * 0.07)).ToString("c")

    End Sub



    Private Sub btnSetWidth_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSetWidth.Click

        Try
            dblWidth = InputBox("Enter Width")
            lblWidthInches.Text = dblWidth

            dblWidth = dblWidth
            'Update view
            updateField()

        Catch ex As Exception
            ' Display an error message for invalid input.
            MessageBox.Show("Error: Make sure the value is 0 or greater.")
        End Try
    End Sub

    Private Sub btnHeight_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHeight.Click

        Try
            dblHeight = InputBox("Enter Width")
            lblHeightInches.Text = dblHeight

            'Update view
            updateField()

        Catch ex As Exception
            ' Display an error message for invalid input.
            MessageBox.Show("Error: Make sure the value is 0 or greater.")
        End Try
    End Sub

    Private Sub btnPickFrame_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPickFrame.Click
        'Create an instance of the frmFrame form
        Dim frmFrame As New frmFrame

        ' Display the form in modal style.
        frmFrame.ShowDialog()
    End Sub

    Private Sub btnMat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMat.Click
        'Create an instance of the frmMat form
        Dim frmMat As New frmMat

        ' Display the form in modal style.
        frmMat.ShowDialog()
    End Sub

    Private Sub btnCover_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCover.Click
        'Create an instance of the frmCover form
        Dim frmCover As New frmCover

        ' Display the form in modal style.
        frmCover.ShowDialog()
    End Sub

End Class
