Public Class 開

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        登.b = 0
        登.L1.Text = ""
        Me.Hide() : 登.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide() : 辦.Show()
        辦.B1.Text = "帳號驗證"
        辦.x += 1
        '     ReDim Preserve 辦.aa(辦.x, 1)

    End Sub
End Class
