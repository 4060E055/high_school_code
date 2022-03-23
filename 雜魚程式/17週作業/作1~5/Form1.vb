Public Class Form1
    Dim a, b, c As Single
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = 0
        For i = 1 To Val(T1.Text)
            a += i
        Next
        l1.text = a
    End Sub
   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        a = 0 : b = 0
        For i = 1 To Val(T2.Text) Step 2
            a += i
        Next
        For i = 2 To Val(T2.Text) Step 2
            b -= i
        Next
        L2.Text = a + b

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        a = 1
        For i = 2 To Val(T3.Text)
            a += (i - 1) / i
        Next
        L3.Text = a
    End Sub

  
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        a = 0
        For i = 1 To Val(T3.Text)
            a += 1 / i
        Next
        l4.text = a
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        a = 0 : b = 0
        For i = 1 To Val(T2.Text) Step 2
            a += 1 / i
        Next
        For i = 2 To Val(T2.Text) Step 2
            b -= 1 / i
        Next
        L5.Text = a + b
    End Sub
End Class
