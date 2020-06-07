Public Class CANCONS
    Dim Archivo As String
    Dim Carpeta As String
    Dim B As New Limpiando()
    Private Sub CANCONS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TL(9) As ToolTip
        TL(0) = New ToolTip
        TL(0).SetToolTip(Me.Label1, "CANCIONES")
        TL(1) = New ToolTip
        TL(1).SetToolTip(Me.btnVolver2, "VOLVER")
        TL(2) = New ToolTip
        TL(2).SetToolTip(Button2, "STOP")
        TL(3) = New ToolTip
        TL(3).SetToolTip(Me.GroupBox1, "ESCRIBIR")
        TL(4) = New ToolTip
        TL(4).SetToolTip(Me.GroupBox2, "CABRONA DE MI")
        TL(5) = New ToolTip
        TL(5).SetToolTip(GroupBox3, "QUIERO VERTE")
        TL(3) = New ToolTip
        TL(3).SetToolTip(Me.Button1, "PLAY")
        TL(4) = New ToolTip
        TL(4).SetToolTip(Me.Button4, "PLAY")
        TL(5) = New ToolTip
        TL(5).SetToolTip(Button6, "PLAY")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play("C:\Users\miria\Downloads\alfred-garcia-canta-et-vull-veure.wav", AudioPlayMode.Background)
        Carpeta = ("C:\Users\miria\Desktop\EtVullVeure.txt")
        Archivo = My.Computer.FileSystem.ReadAllText(Carpeta)
        RichTextBox1.Text = Archivo
        Button1.BackColor = Color.Red
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.Audio.Play("C:\Users\miria\Downloads\miki-nunez-escriurem-lyric-video.wav", AudioPlayMode.Background)
        Carpeta = ("C:\Users\miria\Desktop\Escriurem.txt")
        Archivo = My.Computer.FileSystem.ReadAllText(Carpeta)
        RichTextBox2.Text = Archivo
        Button4.BackColor = Color.Red
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Computer.Audio.Play("C:\Users\miria\Downloads\cactus-07-cabrona-de-mi.wav", AudioPlayMode.Background)
        Carpeta = ("C:\Users\miria\Desktop\CabronaDeMi.txt")
        Archivo = My.Computer.FileSystem.ReadAllText(Carpeta)
        RichTextBox3.Text = Archivo
        Button6.BackColor = Color.Red
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Stop()

        Button1.BackColor = Color.Gold
        Button4.BackColor = Color.Gold
        Button6.BackColor = Color.Gold

        RichTextBox1.Text = (B.Limpiar())
        RichTextBox2.Text = (B.Limpiar())
        RichTextBox3.Text = (B.Limpiar())

    End Sub

    Private Sub Canciones_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim S As New Salir()
        S.Salida()
    End Sub

    Private Sub BtnVolver2_Click(sender As Object, e As EventArgs) Handles btnVolver2.Click
        Form1.Show()
        Hide()
    End Sub



End Class