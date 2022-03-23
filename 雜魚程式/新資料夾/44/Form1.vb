Public Class Form1
    Dim a
    Dim b
    Dim aa
    Dim n
    Dim m

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        a = 1
        b = 2
        aa = 1 / 2
        For i = 1 To 49 Step 1

            a = a + 2 * i
            b = b + 2
            aa = aa + a / b
        Next

        L1.Text = aa

        a = 0
        b = 0
        aa = 0

    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        n = 0
        For w = 0 To 4
            n = n - (1 / 2 ^ w) * (-1) ^ (w + 1)
        Next
        L2.Text = n
    End Sub

   

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        L1.Text = ""
        L2.Text = ""
    End Sub
End Class
