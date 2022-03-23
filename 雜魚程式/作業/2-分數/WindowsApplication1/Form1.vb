Public Class F2

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        L11.Text = Val(T1.Text) + Val(T2.Text) + Val(T3.Text)
        L22.Text = Val(L11.Text) / 3

    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        End
    End Sub

    Private Sub L22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L22.Click

    End Sub

    Private Sub T1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles T1.Click
        T1.Text = InputBox("不及格者!! 打100大板!!", "教師專案,學生遊戲~XD", -100)

    End Sub

    Private Sub T2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles T2.Click
        T2.Text = InputBox("當你ㄉ會計你就笑~當你的計概你睡不著~~~     我想對你說,卻害怕都說錯,好想當你,你知~不知道~~", "林俊x 的 ㄉㄤˋ 你", 0)
    End Sub

    Private Sub T3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles T3.Click
        T3.Text = InputBox("請輸入x字", "請勿惡搞", 1950)
    End Sub

    Private Sub T1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T1.TextChanged

    End Sub
End Class
