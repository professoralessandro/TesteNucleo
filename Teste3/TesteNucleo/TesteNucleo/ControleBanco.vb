Imports System.Data.OleDb


Public Class ControleBanco
    Private DBcon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; DATA SOURCE = TESTE_NET")

    Private DBcmd As OleDbCommand

    Private DBDA As OleDbDataAdapter

    Public DBDT As DataTable

    Public Sub ExecuteQuery(ByVal Query As String)

        Try
            DBcon.Open()

            DBcmd = New OleDbCommand(Query, DBcon)

            DBDT = New DataTable

            DBDA = New OleDbDataAdapter(DBcmd)

            DBDA.Fill(DBDT)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

End Class
