<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculaAnagrama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCalculaAnagrama = New System.Windows.Forms.Button()
        Me.txtPalavra = New System.Windows.Forms.TextBox()
        Me.lblDigitePalavra = New System.Windows.Forms.Label()
        Me.lstAnagrama = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculaAnagrama
        '
        Me.btnCalculaAnagrama.Location = New System.Drawing.Point(15, 32)
        Me.btnCalculaAnagrama.Name = "btnCalculaAnagrama"
        Me.btnCalculaAnagrama.Size = New System.Drawing.Size(75, 49)
        Me.btnCalculaAnagrama.TabIndex = 2
        Me.btnCalculaAnagrama.Text = "Calcula &Anagrama"
        Me.btnCalculaAnagrama.UseVisualStyleBackColor = True
        '
        'txtPalavra
        '
        Me.txtPalavra.Location = New System.Drawing.Point(103, 6)
        Me.txtPalavra.Name = "txtPalavra"
        Me.txtPalavra.Size = New System.Drawing.Size(128, 20)
        Me.txtPalavra.TabIndex = 1
        Me.txtPalavra.Text = "123"
        '
        'lblDigitePalavra
        '
        Me.lblDigitePalavra.AutoSize = True
        Me.lblDigitePalavra.Location = New System.Drawing.Point(12, 9)
        Me.lblDigitePalavra.Name = "lblDigitePalavra"
        Me.lblDigitePalavra.Size = New System.Drawing.Size(85, 13)
        Me.lblDigitePalavra.TabIndex = 0
        Me.lblDigitePalavra.Text = "Digite a Palavra:"
        '
        'lstAnagrama
        '
        Me.lstAnagrama.FormattingEnabled = True
        Me.lstAnagrama.Location = New System.Drawing.Point(103, 32)
        Me.lstAnagrama.Name = "lstAnagrama"
        Me.lstAnagrama.Size = New System.Drawing.Size(128, 472)
        Me.lstAnagrama.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(12, 98)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(15, 114)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(75, 20)
        Me.txtTotal.TabIndex = 5
        '
        'frmCalculaAnagrama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 506)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lstAnagrama)
        Me.Controls.Add(Me.lblDigitePalavra)
        Me.Controls.Add(Me.txtPalavra)
        Me.Controls.Add(Me.btnCalculaAnagrama)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCalculaAnagrama"
        Me.ShowIcon = False
        Me.Text = "Calcula Anagrama VB.Net"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculaAnagrama As System.Windows.Forms.Button
    Friend WithEvents txtPalavra As System.Windows.Forms.TextBox
    Friend WithEvents lblDigitePalavra As System.Windows.Forms.Label
    Friend WithEvents lstAnagrama As System.Windows.Forms.ListBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox

End Class
