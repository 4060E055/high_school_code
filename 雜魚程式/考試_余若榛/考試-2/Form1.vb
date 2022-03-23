Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 4 To 2 Step -1
            For j = 1 To i * 2
                T1.Text &= "*"
                If i = j Then
                    T1.Text &= Space((4 - i) * 4)
                End If
            Next
            T1.Text &= vbCrLf
        Next
        For i = 3 To 4
            For j = 1 To i * 2
                T1.Text &= "*"
                If i = j Then
                    T1.Text &= Space((4 - i) * 4)
                End If
            Next
            T1.Text &= vbCrLf
        Next
    End Sub
End Class
