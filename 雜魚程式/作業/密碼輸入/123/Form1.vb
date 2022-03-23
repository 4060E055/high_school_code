Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click

        If T1.Text = "533098" Then
            L1.Text = "恭喜你（妳），可以登入了！"
        ElseIf L1.Text = "很抱歉，密碼錯誤1次" Then
            L1.Text = "很抱歉，密碼錯誤2次"
        ElseIf L1.Text = "很抱歉，密碼錯誤2次" Then
            L1.Text = "很抱歉，密碼錯誤3次"
        ElseIf L1.Text = "很抱歉，密碼錯誤3次" Then
            L1.Text = "錯誤已超過3次，無法登入"
            T1.Enabled = False
            B1.Enabled = False
        ElseIf T1.Text > 533098 Or T1.Text < 533098 Then
            L1.Text = "很抱歉，密碼錯誤1次"
        End If
    End Sub
End Class
