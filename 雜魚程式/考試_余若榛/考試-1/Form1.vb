Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For j = 1 To 5 Step 2
            T1.Text &= Space((5 - j) * 2)
            For i = 1 To j
                T1.Text &= "＊"
            Next
            T1.Text &= vbNewLine
        Next
        For j = 3 To 1 Step -2
            T1.Text &= Space((5 - j) * 2)
            For i = 1 To j
                T1.Text &= "＊"
            Next
            T1.Text &= vbNewLine
        Next
    End Sub
End Class
