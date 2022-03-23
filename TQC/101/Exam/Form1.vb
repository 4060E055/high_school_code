Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If C1.Checked = True Then
            L1.Text = "NT$" & 250 * Val(T1.Text)
        ElseIf C2.Checked = True Then
            L1.Text = "NT$" & 275 * Val(T1.Text)
        ElseIf C3.Checked = True Then
            L1.Text = "NT$" & 350 * Val(T1.Text)
        End If
    End Sub

    Private Sub C1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1.CheckedChanged
        If C1.Checked = True Then C2.Checked = False : C3.Checked = False
    End Sub

    Private Sub C2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C2.CheckedChanged
        If C2.Checked = True Then C1.Checked = False : C3.Checked = False
    End Sub

    Private Sub C3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C3.CheckedChanged
        If C3.Checked = True Then C2.Checked = False : C1.Checked = False
    End Sub
End Class
