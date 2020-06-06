Public Class OtroTraductor
    Private Sub OtroTraductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TL(3) As ToolTip
        TL(0) = New ToolTip
        TL(0).SetToolTip(Me.Label1, "EXPRESIONES BÁSICAS")
        TL(1) = New ToolTip
        TL(1).SetToolTip(Me.btnVolver2, "VOLVER")
        TL(2) = New ToolTip
        TL(2).SetToolTip(Label10, "ABRIR")
    End Sub

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