Public Class Form1
    Dim A As Integer = 1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        If T1.Text = Val(533098) Then
            L2.Text = "恭喜你!可以登入了!"
        ElseIf A > 3 Then
            L2.Text = "密碼輸入超過3次，無法登入"
            T1.Enabled = False
            B1.Enabled = False
        ElseIf T1.Text > 533098 Or T1.Text < 533098 Then
            L2.Text = "密碼輸入錯誤" & A & "次"
            A = A + 1
        End If
    End Sub
End Class
