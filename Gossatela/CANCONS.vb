Public Class CANCONS
    Dim Archivo As String
    Dim Carpeta As String

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

        RichTextBox1.Text = ("")
        RichTextBox2.Text = ("")
        RichTextBox3.Text = ("")

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