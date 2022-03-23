Public Class Form1
    Dim down As Boolean = False
    Dim a, b As Single
    Private Sub form1_mousemove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        P1.Top = e.Y + 20
        P1.Left = e.X + 10
    End Sub
    Private Sub p2_mousedown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles P2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            down = True
            a = e.X
            b = e.Y
        End If

    End Sub
    Private Sub p2_mousemove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles P2.MouseMove
        If down = True Then
            P2.Top += e.Y - b
            P2.Left += e.X - a
        End If
    End Sub

    Private Sub p2_mouseup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles P2.MouseUp
        down = False
        If P2.Left > Me.Width OrElse P2.Top > Me.Height OrElse P2.Left < 0 OrElse P2.Top < 0 Then
            P2.Left = Me.Width / 2
            P2.Top = Me.Height / 2
        End If
    End Sub

   
End Class
