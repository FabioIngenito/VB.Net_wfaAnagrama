Public Class frmCadeado

    Private Sub btnCalcule_Click(sender As Object, e As EventArgs) Handles btnCalcule.Click
        Dim lstStrLetras As List(Of String) = New List(Of String)()
        Dim arrStrSequenciaAberto As String()
        Dim arrStrOpcoesLetras As String()
        Dim strSequenciaAberto As String = String.Empty
        Dim intTamanhoSequenciaAberto As Integer
        lblSeraAbertoEm.Text = ""
        arrStrSequenciaAberto = txtSequenciaAberto.Text.Split()
        arrStrOpcoesLetras = txtOpcoesLetras.Text.Split()

        For Each str As String In arrStrSequenciaAberto
            strSequenciaAberto = strSequenciaAberto & str
        Next

        intTamanhoSequenciaAberto = CInt(nudChavesSeletoras.Value)
        GeraNovaPalavra(lstStrLetras, arrStrOpcoesLetras, intTamanhoSequenciaAberto, String.Empty)
        lstCadeado.Items.Clear()

        For Each letra As String In lstStrLetras
            lstCadeado.Items.Add(String.Format("{0}", letra))

            If letra = strSequenciaAberto Then
                lstCadeado.SetSelected(lstCadeado.Items.Count - 1, True)
                lblSeraAbertoEm.Text = letra
            End If
        Next

    End Sub

    Private Sub GeraNovaPalavra(ByVal lista As List(Of String), ByVal array As String(), ByVal tamanho As Integer, ByVal palavraAtual As String)
        Dim palavraCorrente As String = palavraAtual

        For i As Integer = 0 To array.Length - 1
            palavraCorrente += array(i)

            If palavraCorrente.Length >= tamanho Then
                lista.Add(palavraCorrente)
                palavraCorrente = palavraAtual
            Else
                GeraNovaPalavra(lista, array, tamanho, palavraCorrente)
                palavraCorrente = palavraAtual
            End If

        Next

    End Sub

End Class