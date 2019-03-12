<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonLogarTexto = New System.Windows.Forms.Button()
        Me.TextBoxTextoLog = New System.Windows.Forms.TextBox()
        Me.ButtonAbrirArquivoLog = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'ButtonLogarTexto
        '
        Me.ButtonLogarTexto.Location = New System.Drawing.Point(52, 198)
        Me.ButtonLogarTexto.Name = "ButtonLogarTexto"
        Me.ButtonLogarTexto.Size = New System.Drawing.Size(230, 63)
        Me.ButtonLogarTexto.TabIndex = 0
        Me.ButtonLogarTexto.Text = "Logar texto"
        Me.ButtonLogarTexto.UseVisualStyleBackColor = True
        '
        'TextBoxTextoLog
        '
        Me.TextBoxTextoLog.Location = New System.Drawing.Point(28, 63)
        Me.TextBoxTextoLog.Multiline = True
        Me.TextBoxTextoLog.Name = "TextBoxTextoLog"
        Me.TextBoxTextoLog.Size = New System.Drawing.Size(738, 96)
        Me.TextBoxTextoLog.TabIndex = 1
        '
        'ButtonAbrirArquivoLog
        '
        Me.ButtonAbrirArquivoLog.Location = New System.Drawing.Point(288, 198)
        Me.ButtonAbrirArquivoLog.Name = "ButtonAbrirArquivoLog"
        Me.ButtonAbrirArquivoLog.Size = New System.Drawing.Size(230, 63)
        Me.ButtonAbrirArquivoLog.TabIndex = 2
        Me.ButtonAbrirArquivoLog.Text = "Abrir arquivo de log"
        Me.ButtonAbrirArquivoLog.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(524, 198)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(230, 63)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Sair"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 319)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ButtonAbrirArquivoLog)
        Me.Controls.Add(Me.TextBoxTextoLog)
        Me.Controls.Add(Me.ButtonLogarTexto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonLogarTexto As Button
    Friend WithEvents TextBoxTextoLog As TextBox
    Friend WithEvents ButtonAbrirArquivoLog As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
End Class
