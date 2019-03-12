Imports System.IO

Public NotInheritable Class Logger

    Private Sub New()
    End Sub

    ' Calcula o nome do arquivo de log
    Private Shared LogArquivo As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\TesteNucleo\TesteNucleo\Log_AAAAMMDD.txt"

    ' Escreve a data e hora atual mais a linha de texto no arquivo de log
    Public Shared Sub RegistraEvento(texto As String)
        File.AppendAllText(LogArquivo, (Convert.ToString(DateTime.Now.ToString() + ": ") & texto) + vbCrLf)
    End Sub

    Public Shared Sub RecuperarLog()
        File.OpenText(LogArquivo)
    End Sub

    ' Deleta o arquivo de log
    Public Shared Sub DeletaLog()
        Console.Out.Close()
    End Sub

    Private Shared Sub OpenFileDialog(v As String)
        Throw New NotImplementedException()
    End Sub
End Class
