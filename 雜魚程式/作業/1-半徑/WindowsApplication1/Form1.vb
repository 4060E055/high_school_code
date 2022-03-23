Public Class F1

    Private Sub F1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub L22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L22.Click

    End Sub

    Private Sub T1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles T1.Click
        T1.Text = InputBox("無效使用者!!", "請勿惡搞", 0)
    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        L11.Text = Int(Val(T1.Text) * Val(2) * Val(3.141593)) & "公分"
        L22.Text = Int(Val(T1.Text) * Val(3.141593)) & "平方公分"

    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        End
    End Sub
End Class
