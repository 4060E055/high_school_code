Public Class Form1

    Private Sub me_keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.Q Then
            P1.Visible = False
        ElseIf e.Shift = True And e.KeyCode = Keys.W Then
            Process.Start("http://www.yahoo.com.tw")
        ElseIf e.Alt = True And e.KeyCode = Keys.E Then
            P1.Visible = True
        ElseIf e.Control = True And e.Alt = True And e.KeyCode = Keys.R Then
            Process.Start("蠢蛋猜拳")
        ElseIf e.KeyCode.ToString = "Z" Then
            Process.Start("123\1.jpg")
        ElseIf e.KeyCode.ToString = "X" Then
            Process.Start("123\2.jpg")
        ElseIf e.KeyCode.ToString = "C" Then
            Process.Start("123\3.jpg")
        ElseIf e.KeyCode.ToString = "V" Then
            Process.Start("123\4.jpg")
        End If
    End Sub

   
End Class
