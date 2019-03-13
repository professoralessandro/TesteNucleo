

Public Class Form1
    Private dados As New ControleBanco

    Private Sub ButtonLogarTexto_Click(sender As Object, e As EventArgs) Handles ButtonLogarTexto.Click

        Me.TabelaRegistrosTableAdapter.InserirDados(TextBoxTextoLog.Text, System.DateTime.Now())

        TextBoxTextoLog.Clear()

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

        TextBoxTextoLog.Clear()

        TextBoxTextoLog.Text = Me.TabelaRegistrosTableAdapter.BuscarDados()

        'Me.TabelaRegistrosTableAdapter.Fill(Me.TesteNucleo2DataSet.TabelaRegistros).ToString()

    End Sub

    Private Sub TextBoxTextoLog_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTextoLog.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'TesteNucleo2DataSet.TabelaRegistros'. Você pode movê-la ou removê-la conforme necessário.
        'Me.TabelaRegistrosTableAdapter.Fill(Me.TesteNucleo2DataSet.TabelaRegistros)

    End Sub
End Class
