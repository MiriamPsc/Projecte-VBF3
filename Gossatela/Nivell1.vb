Public Class Nivell1
    Dim S As New Salir()
    Dim Calificacion As Integer
    Dim Calificacion2 As Integer
    Dim Calificacion3 As Integer

    Private Sub Nivell_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TL(2) As ToolTip
        TL(0) = New ToolTip
        TL(0).SetToolTip(Me.Label1, "EXPRESIONES BÁSICAS")
        TL(1) = New ToolTip
        TL(1).SetToolTip(Me.btnVolver, "VOLVER")
        TL(2) = New ToolTip
        TL(2).SetToolTip(btnCali, "CALIFICAR")

    End Sub

    Sub Preguntas()
        If rbP1.Checked = True And rbP4.Checked = True Then
            Calificacion3 = 8
        End If
        If rbP1.Checked = False And rbP4.Checked = False Then
            Calificacion3 = 0
        End If
        If rbP1.Checked = True And rbP4.Checked = False Then
            Calificacion3 = 4
        End If
        If rbP4.Checked = True And rbP1.Checked = False Then
            Calificacion3 = 4
        End If
    End Sub

    Sub Preguntas3()
        If cbR1.Text = "Soy mexicano" And
            cbR2.Text = "Cómo te llamas?" And
            cbR3.Text = "Me llamo Samantha" And
            cbR4.Text = "Quiero comer" And
            cbR5.Text = "Estamos de vacaciones" Then
            Calificacion2 = 2
        End If
    End Sub

    Private Sub Nivell_1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        S.Salida()
    End Sub

    Private Sub BtnCali_Click(sender As Object, e As EventArgs) Handles btnCali.Click
        Preguntas()
        Preguntas3()
        Calificacion = Calificacion2 + Calificacion3
        lblC.Text = (Calificacion)
    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click
        Nivell_2.Show()
        Hide()
    End Sub
End Class