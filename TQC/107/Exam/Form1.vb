Public Class Form1
    Dim m_num As Integer
   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        genNumber()
    End Sub
    Private Sub btnAgain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgain.Click
        genNumber()
        lblSmall.Text = "100"
        lblLarge.Text = "999"
        txtGuess.Text = ""
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub genNumber()
        Randomize()
        m_num = Rnd() * (Val(lblLarge.Text) - Val(lblSmall.Text) + 1) + Val(lblSmall.Text)
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If txtGuess.Text = "" Then
            MsgBox("請輸入一個三位數！", , "提示")
        ElseIf Val(txtGuess.Text) > Val(lblLarge.Text) Then
            MsgBox("請輸入介於" & lblSmall.Text & "到" & lblLarge.Text & "之間的數！", , "提示")
        ElseIf Val(txtGuess.Text) < Val(lblSmall.Text) Then
            MsgBox("請輸入介於" & lblSmall.Text & "到" & lblLarge.Text & "之間的數！", , "提示")
        ElseIf Val(txtGuess.Text) < m_num Then
            MsgBox("請輸入大一點的數！", , "提示")
            lblSmall.Text = txtGuess.Text
        ElseIf Val(txtGuess.Text) > m_num Then
            MsgBox("請輸入小一點的數！", , "提示")
            lblLarge.Text = txtGuess.Text
        ElseIf Val(txtGuess.Text) = m_num Then
            MsgBox("恭喜你答對了！", , "提示")
        End If

    End Sub

    Private Sub txtGuess_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuess.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> vbBack Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
End Class
