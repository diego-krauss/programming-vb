Imports System.IO
Public Class Form1
    Private strImagens() As String
    Private intContador As Integer = 0

    Sub CarregaImagens(ByVal pasta As String)
        strImagens = Directory.GetFiles(pasta, "*.png")
        Timer1.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim open As New FolderBrowserDialog
        open.Description = "Selecionar pasta de imagens"
        'open.RootFolder = Environment.SpecialFolder.CommonPictures
        If open.ShowDialog = DialogResult.OK Then
            CarregaImagens(open.SelectedPath)

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        picImage.Image = Image.FromFile(strImagens(intContador))
        If intContador = strImagens.Length - 1 Then
            intContador = 0
        End If
        intContador += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class
