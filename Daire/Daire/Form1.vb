Public Class Form1

    Private Sub HesaplaButton_Click(sender As Object, e As EventArgs) Handles HesaplaButton.Click
        Dim r, Alan As Decimal
        r = rTextBox.Text
        Alan = Math.PI * r ^ 2 'Alan = Math.PI * r *r
        AlanTextBox.Text = Alan
    End Sub
End Class
