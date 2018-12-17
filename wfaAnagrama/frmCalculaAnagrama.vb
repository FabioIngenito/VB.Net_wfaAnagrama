Public Class frmCalculaAnagrama
    '
    ' Created by SharpDevelop.
    ' User: TriW
    ' Date: 2012-02-23
    ' Time: 09:01
    ' 
    ' To change this template use Tools | Options | Coding | Edit Standard Headers.
    '
    ' Anagrama 
    ' https://social.msdn.microsoft.com/Forums/pt-BR/2aeeca51-e09a-4334-8b4f-891584504769/anagramas?forum=504

    Private anagramas As New List(Of String)()

    Public Sub New()
        Me.InitializeComponent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculaAnagrama.Click
        anagramas.Clear()
        Anagrama(txtPalavra.Text)
        lstAnagrama.Items.Clear()
        txtTotal.Clear()

        For Each anagrama__1 As [String] In anagramas
            lstAnagrama.Items.Add(anagrama__1)
        Next

        txtTotal.Text = lstAnagrama.Items.Count.ToString()

    End Sub

    ' cria todos os anagramas da palavra envia em STR
    Public Sub Anagrama(Str As String)
        Anagrama(Str, Str.Length)
    End Sub

    ' Metodo recuricivo de permutaçoes circulares
    Public Sub Anagrama(ByRef Str As String, Lg As Integer)

        If Lg = 1 Then

            If Not anagramas.Contains(Str) Then
                anagramas.Add(Str)
            End If

        Else
            Dim strTmp As String = Str

            For i As Integer = 0 To Lg - 1
                strTmp = strTmp.Substring(1, Lg - 1) & strTmp(0) & strTmp.Substring(Lg)
                Anagrama(strTmp, Lg - 1)
            Next

        End If

    End Sub

End Class
