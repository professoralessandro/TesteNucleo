

Public Class Form1
    Dim ARQUIVO As String

    Private Sub ButtonLogarTexto_Click(sender As Object, e As EventArgs) Handles ButtonLogarTexto.Click
        Logger.RegistraEvento(TextBoxTextoLog.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub ButtonAbrirArquivoLog_Click(sender As Object, e As EventArgs) Handles ButtonAbrirArquivoLog.Click

        TextBoxTextoLog.Text = Ler_Arquivo(ARQUIVO, 1)

    End Sub

    Function Ler_Arquivo(ByRef ARQUIVO As String, ByRef LINHA As Integer) As String

        Dim COUNT As Integer

        With CreateObject("Scripting.FileSystemObject").OpenTextFile("\TesteNucleo\TesteNucleo\Log_AAAAMMDD.txt")

            If LINHA < 1 Then LINHA = 1
            COUNT = 1

            Do While Not .AtEndOfStream

                If COUNT = LINHA Then
                    Ler_Arquivo = .ReadLine
                    Exit Do
                Else
                    .SkipLine
                End If
                COUNT = COUNT + 1
            Loop
            .Close
        End With

    End Function
End Class
