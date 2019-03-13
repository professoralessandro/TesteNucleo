Imports System.IO
Imports System.Windows.Forms

Public Class Form1
    Dim ARQUIVO As String

    Private Sub ButtonLogarTexto_Click(sender As Object, e As EventArgs) Handles ButtonLogarTexto.Click
        Logger.RegistraEvento(TextBoxTextoLog.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dialog As DialogResult

        dialog = MessageBox.Show("Tem certeza que deseja fechar a aplicação ?", "Exit", MessageBoxButtons.YesNo)

        If dialog = DialogResult.No Then

        Else
            Application.Exit()
        End If
    End Sub

    Private Sub ButtonAbrirArquivoLog_Click(sender As Object, e As EventArgs) Handles ButtonAbrirArquivoLog.Click

        Using sr As New StreamReader("C:\Users\Alessandro\Desktop\TesteNucleo\Teste1\TesteNucleo\Log_AAAAMMDD.txt")
            Do While sr.Peek <> -1
                TextBoxTextoLog.Text = TextBoxTextoLog.Text & sr.ReadLine & vbNewLine
            Loop
        End Using
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
