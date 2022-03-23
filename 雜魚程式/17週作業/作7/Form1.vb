Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 1 To 10000
            If i Mod 7 = 2 And i Mod 11 = 2 And i Mod 3 = 2 Then
                Label1.Text &= i & "  "
            End If
        Next
    End Sub
End Class
