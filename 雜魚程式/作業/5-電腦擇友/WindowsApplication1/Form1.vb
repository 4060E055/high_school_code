Public Class Form1

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        If (Val(T2.Text) >= 25 And Val(T2.Text) <= 32) And (Val(T3.Text) >= 160 And Val(T3.Text) <= 178) And Val(T4.Text) >= 50000 Then
            L11.Text = "恭喜!" & (T1.Text) & "先生符合條件"
        ElseIf (Val(T2.Text) < 25 Or Val(T2.Text) > 32) Or (Val(T3.Text) < 160 Or Val(T3.Text) > 178) Or Val(T4.Text) < 50000 Then
            L11.Text = "抱歉!" & (T1.Text) & "先生不合條件"
        End If
    End Sub

   
    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        T1.Text = ""
        T2.Text = ""
        T3.Text = ""
        T4.Text = ""
    End Sub
End Class
