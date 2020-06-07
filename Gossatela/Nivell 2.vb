Public Class Nivell_2
    Dim Cali1 As Integer
    Dim Cali2 As Integer
    Dim Cali3 As Integer
    Dim Cali As Integer

    Private Sub Nivell_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TL(4) As ToolTip
        TL(0) = New ToolTip
        TL(0).SetToolTip(Label1, "COLORES, NÚMEROS Y TIEMPO")
        TL(1) = New ToolTip
        TL(1).SetToolTip(Me.btnVolver2, "VOLVER")
        TL(2) = New ToolTip
        TL(2).SetToolTip(btnCali2, "CALIFICAR")
        TL(3) = New ToolTip
        TL(3).SetToolTip(btnSig, "SIGUIENTE")

    End Sub

    Private Sub Nivell_2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim S As New Salir()
        S.Salida()
    End Sub

    Private Sub BtnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click
        OtroTraductor.Show()
        Hide()
    End Sub

    Private Sub tb2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb6.KeyPress,
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnCali2_Click(sender As Object, e As EventArgs) Handles btnCali2.Click

        Colores()
        Numeros()
        Fechas()
        Calif()

    End Sub

    Public Sub Colores()

        If tb1.Text = "5" And
           tb2.Text = "1" And
           tb3.Text = "3" And
           tb4.Text = "6" And
           tb5.Text = "4" And
           tb6.Text = "2" Then
            Cali1 = 3
        End If
    End Sub
    Public Sub Numeros()
        If rbP1.Checked = True And
            rbP4.Checked = True And
            rbP5.Checked = True And
            rbp8.Checked = True Then
            Cali2 = 3
        End If
    End Sub

    Public Sub Fechas()
        If tbP3.Text = "Dimarts, 28 de gener va ser el meu aniversari." And tbP31.Text = "Com seria anar ahir?" Then
            Cali3 = 4
        End If
    End Sub
    Public Sub Calif()
        Cali = Cali1 + Cali2 + Cali3
        lblC.Text = (Cali)
    End Sub

End Class