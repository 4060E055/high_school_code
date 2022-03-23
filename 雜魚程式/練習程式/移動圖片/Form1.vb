Public Class Form1

    Private Sub p1_KeyDOWN(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown


        If e.KeyCode = Keys.Down Then
            P1.Top += 50
        ElseIf e.KeyCode = Keys.Up Then
            P1.Top -= 50
        ElseIf e.KeyCode = Keys.Left Then
            P1.Left -= 50
        ElseIf e.KeyCode = Keys.Right Then
            P1.Left += 50
        End If

        If P1.Left > Me.Width Then
            P1.Left = 0
        ElseIf P1.Left < 0 Then
            P1.Left = Me.Width
        ElseIf P1.Top > Me.Height Then
            P1.Top = 0
        ElseIf P1.Top < 0 Then
            P1.Top = Me.Height
        End If

    End Sub
   
   
End Class
