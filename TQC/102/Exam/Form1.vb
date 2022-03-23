Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        l1.Text = Format(Val(T1.Text) * (1 + Val(T2.Text) / 100) ^ Val(T3.Text), "###,###,###,###,###,###.#")
    End Sub
End Class
