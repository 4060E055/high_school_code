Public Class Form1
    Private Sub m2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m2.Click
        Dim intI, amount As Integer

        amount = CInt(txtAmount.Text)
        txt50.Text = "0"  ' �M����r������
        txt10.Text = "0"
        txt5.Text = "0"
        txt1.Text = "0"
        For intI = 1 To 4    ' �I���j��
            If chk50.Checked = True And intI = 1 Then  ' �O�_���Ŀ惡����
                txt50.Text = amount \ 50
                amount -= (amount \ 50) * 50

            ElseIf chk10.Checked = True And intI = 2 Then

                txt10.Text = amount \ 10
                amount -= (amount \ 10) * 10
            ElseIf chk5.Checked = True And intI = 3 Then

                txt5.Text = amount \ 5
                amount -= (amount \ 5) * 5
            ElseIf intI = 4 Then
                txt1.Text = amount
            End If

        Next intI
    End Sub

    Private Sub m3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m3.Click
        End
    End Sub
End Class
