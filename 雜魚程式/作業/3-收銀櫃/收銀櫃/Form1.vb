Public Class F3

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        L11.Text = Val(T1.Text) * Val(T2.Text) * 0.8
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        L11.Text = Val(T1.Text) * Val(T2.Text)
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        L22.Text = Val(T3.Text) - Val(L11.Text)
    End Sub


    Private Sub B4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B4.Click
        End
    End Sub

    Private Sub T1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T1.TextChanged

    End Sub
End Class
