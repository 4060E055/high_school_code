Public Class Form1
    Dim a As Short = 20
    Dim b As Short = 20
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        P1.Top += a
        P1.Left += b
        If P1.Top >= Me.Height - 170 OrElse P1.Top <= 0 Then
            If a = 20 Then
                a = -20
            ElseIf a = -20 Then
                a = 20
            End If
        End If
        If P1.Left >= Me.Width - 110 OrElse P1.Left <= 0 Then
            If b = 20 Then
                b = -20
            ElseIf b = -20 Then
                b = 20
            End If
        End If

    End Sub
End Class
