Public Class Form1
    Dim ii(1), n, a As Long
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a = 1
        Do
            ii(n) = Val(InputBox("請輸入任意[數]，輸入0即結束輸入。" & vbNewLine & "目前輸入" & n + 1 & "個數"))
            n += 1
            ReDim Preserve ii(n)
        Loop Until ii(n - 1) = 0
        For i = 0 To n - 2
            a *= ii(i)
        Next
        TextBox1.Text = a
    End Sub
End Class
