Public Class Form1
    Dim a, b As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer2.Enabled = False
        OvalShape2.Size = New Size(100, 100)
        OvalShape2.Top = 45
        OvalShape2.Left = 155
        b = 155
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer2.Enabled = False
        OvalShape2.Size = New Size(70, 70)
        OvalShape2.Top = 47
        OvalShape2.Left = 155
        b = 155
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer2.Enabled = False
        OvalShape2.Size = New Size(75, 75)
        OvalShape2.Top = 60
        OvalShape2.Left = 155
        b = 155
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        OvalShape2.Left -= (b - OvalShape1.Left) / 10
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub
End Class
