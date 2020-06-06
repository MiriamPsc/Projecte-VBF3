Public Class OtroTraductor
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Process.Start("https://www.bing.com/translator")
    End Sub

    Private Sub BtnVolver2_Click(sender As Object, e As EventArgs) Handles btnVolver2.Click
        Form1.Show()
        Hide()
    End Sub

    Private Sub OtroTraductor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim S As New Salir()
        S.Salida()
    End Sub
End Class