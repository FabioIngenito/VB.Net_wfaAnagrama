<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadeado
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
        Me.lblSeraAbertoEm = New System.Windows.Forms.Label()
        Me.lblSeraAbertoEmLabel = New System.Windows.Forms.Label()
        Me.lblQuantidadeChavesSeletoras = New System.Windows.Forms.Label()
        Me.nudChavesSeletoras = New System.Windows.Forms.NumericUpDown()
        Me.txtOpcoesLetras = New System.Windows.Forms.TextBox()
        Me.lblOpcoesLetras = New System.Windows.Forms.Label()
        Me.lblListaCompletaOpcoes = New System.Windows.Forms.Label()
        Me.txtSequenciaAberto = New System.Windows.Forms.TextBox()
        Me.lstCadeado = New System.Windows.Forms.ListBox()
        Me.lblSequenciaAberto = New System.Windows.Forms.Label()
        Me.btnCalcule = New System.Windows.Forms.Button()
        CType(Me.nudChavesSeletoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSeraAbertoEm
        '
        Me.lblSeraAbertoEm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeraAbertoEm.Location = New System.Drawing.Point(156, 125)
        Me.lblSeraAbertoEm.Name = "lblSeraAbertoEm"
        Me.lblSeraAbertoEm.Size = New System.Drawing.Size(261, 18)
        Me.lblSeraAbertoEm.TabIndex = 7
        '
        'lblSeraAbertoEmLabel
        '
        Me.lblSeraAbertoEmLabel.AutoSize = True
        Me.lblSeraAbertoEmLabel.Location = New System.Drawing.Point(11, 125)
        Me.lblSeraAbertoEmLabel.Name = "lblSeraAbertoEmLabel"
        Me.lblSeraAbertoEmLabel.Size = New System.Drawing.Size(83, 13)
        Me.lblSeraAbertoEmLabel.TabIndex = 6
        Me.lblSeraAbertoEmLabel.Text = "Será Aberto em:"
        '
        'lblQuantidadeChavesSeletoras
        '
        Me.lblQuantidadeChavesSeletoras.AutoSize = True
        Me.lblQuantidadeChavesSeletoras.Location = New System.Drawing.Point(11, 99)
        Me.lblQuantidadeChavesSeletoras.Name = "lblQuantidadeChavesSeletoras"
        Me.lblQuantidadeChavesSeletoras.Size = New System.Drawing.Size(119, 13)
        Me.lblQuantidadeChavesSeletoras.TabIndex = 4
        Me.lblQuantidadeChavesSeletoras.Text = "QTD Chaves Seletoras:"
        '
        'nudChavesSeletoras
        '
        Me.nudChavesSeletoras.Location = New System.Drawing.Point(156, 97)
        Me.nudChavesSeletoras.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudChavesSeletoras.Name = "nudChavesSeletoras"
        Me.nudChavesSeletoras.Size = New System.Drawing.Size(74, 20)
        Me.nudChavesSeletoras.TabIndex = 5
        Me.nudChavesSeletoras.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'txtOpcoesLetras
        '
        Me.txtOpcoesLetras.Location = New System.Drawing.Point(156, 71)
        Me.txtOpcoesLetras.Name = "txtOpcoesLetras"
        Me.txtOpcoesLetras.Size = New System.Drawing.Size(261, 20)
        Me.txtOpcoesLetras.TabIndex = 3
        Me.txtOpcoesLetras.Text = "A B"
        '
        'lblOpcoesLetras
        '
        Me.lblOpcoesLetras.AutoSize = True
        Me.lblOpcoesLetras.Location = New System.Drawing.Point(11, 74)
        Me.lblOpcoesLetras.Name = "lblOpcoesLetras"
        Me.lblOpcoesLetras.Size = New System.Drawing.Size(138, 13)
        Me.lblOpcoesLetras.TabIndex = 2
        Me.lblOpcoesLetras.Text = "Opções de Letras (espaço):"
        '
        'lblListaCompletaOpcoes
        '
        Me.lblListaCompletaOpcoes.AutoSize = True
        Me.lblListaCompletaOpcoes.Location = New System.Drawing.Point(443, 11)
        Me.lblListaCompletaOpcoes.Name = "lblListaCompletaOpcoes"
        Me.lblListaCompletaOpcoes.Size = New System.Drawing.Size(134, 13)
        Me.lblListaCompletaOpcoes.TabIndex = 9
        Me.lblListaCompletaOpcoes.Text = "Lista Completa de Opções:"
        '
        'txtSequenciaAberto
        '
        Me.txtSequenciaAberto.Location = New System.Drawing.Point(156, 45)
        Me.txtSequenciaAberto.Name = "txtSequenciaAberto"
        Me.txtSequenciaAberto.Size = New System.Drawing.Size(261, 20)
        Me.txtSequenciaAberto.TabIndex = 1
        Me.txtSequenciaAberto.Text = "A B A A B B A B A B"
        '
        'lstCadeado
        '
        Me.lstCadeado.FormattingEnabled = True
        Me.lstCadeado.Location = New System.Drawing.Point(446, 36)
        Me.lstCadeado.Name = "lstCadeado"
        Me.lstCadeado.Size = New System.Drawing.Size(341, 524)
        Me.lstCadeado.TabIndex = 10
        '
        'lblSequenciaAberto
        '
        Me.lblSequenciaAberto.AutoSize = True
        Me.lblSequenciaAberto.Location = New System.Drawing.Point(11, 48)
        Me.lblSequenciaAberto.Name = "lblSequenciaAberto"
        Me.lblSequenciaAberto.Size = New System.Drawing.Size(139, 13)
        Me.lblSequenciaAberto.TabIndex = 0
        Me.lblSequenciaAberto.Text = "Sequência Aberto (espaço):"
        '
        'btnCalcule
        '
        Me.btnCalcule.Location = New System.Drawing.Point(14, 182)
        Me.btnCalcule.Name = "btnCalcule"
        Me.btnCalcule.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcule.TabIndex = 8
        Me.btnCalcule.Text = "&Calcule"
        Me.btnCalcule.UseVisualStyleBackColor = True
        '
        'frmCadeado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 571)
        Me.Controls.Add(Me.lblSeraAbertoEm)
        Me.Controls.Add(Me.lblSeraAbertoEmLabel)
        Me.Controls.Add(Me.lblQuantidadeChavesSeletoras)
        Me.Controls.Add(Me.nudChavesSeletoras)
        Me.Controls.Add(Me.txtOpcoesLetras)
        Me.Controls.Add(Me.lblOpcoesLetras)
        Me.Controls.Add(Me.lblListaCompletaOpcoes)
        Me.Controls.Add(Me.txtSequenciaAberto)
        Me.Controls.Add(Me.lstCadeado)
        Me.Controls.Add(Me.lblSequenciaAberto)
        Me.Controls.Add(Me.btnCalcule)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadeado"
        Me.ShowIcon = False
        Me.Text = "CADEADO VB.Net"
        CType(Me.nudChavesSeletoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblSeraAbertoEm As Label
    Private WithEvents lblSeraAbertoEmLabel As Label
    Private WithEvents lblQuantidadeChavesSeletoras As Label
    Private WithEvents nudChavesSeletoras As NumericUpDown
    Private WithEvents txtOpcoesLetras As TextBox
    Private WithEvents lblOpcoesLetras As Label
    Private WithEvents lblListaCompletaOpcoes As Label
    Private WithEvents txtSequenciaAberto As TextBox
    Private WithEvents lstCadeado As ListBox
    Private WithEvents lblSequenciaAberto As Label
    Private WithEvents btnCalcule As Button
End Class
