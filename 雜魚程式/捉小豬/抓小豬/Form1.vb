Public Class Form1
    Dim a As String

    Private Property Random As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a = Now()
        a = Microsoft.VisualBasic.Right(a, 1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click

        If a = 1 Or a = 6 Then
            B6.Visible = False : B2.Visible = False : B3.Visible = False : B4.Visible = False : B5.Visible = False
            L1.Text = "恭喜!!抓到小笨豬了 XD"
            B1.Text = "小笨豬"
        Else
            B1.Enabled = False
            L1.Text = "小心大野狼!!"
            B1.Text = "大野狼"
        End If
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click

        If a = 2 Or a = 6 Then
            B6.Visible = False : B1.Visible = False : B3.Visible = False : B4.Visible = False : B5.Visible = False
            L1.Text = "恭喜!!抓到小笨豬了 XD"
            B2.Text = "小笨豬"

        Else
            B2.Enabled = False
            L1.Text = "小心大野狼!!"
            B2.Text = "大野狼"
        End If
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click

        If a = 3 Or a = 7 Then
            B6.Visible = False : B1.Visible = False : B2.Visible = False : B4.Visible = False : B5.Visible = False
            L1.Text = "恭喜!!抓到小笨豬了 XD"
            B3.Text = "小笨豬"
           
        Else
            B3.Enabled = False
            L1.Text = "小心大野狼!!"
            B3.Text = "大野狼"
        End If
    End Sub

    Private Sub B4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B4.Click

        If a = 4 Or a = 0 Then
            B6.Visible = False : B1.Visible = False : B2.Visible = False : B3.Visible = False : B5.Visible = False
            L1.Text = "恭喜!!抓到小笨豬了 XD"
            B4.Text = "小笨豬"

        Else
            B4.Enabled = False
            L1.Text = "小心大野狼!!"
            B4.Text = "大野狼"
        End If
    End Sub

    Private Sub B5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B5.Click

        If a = 5 Or a = 8 Then
            B6.Visible = False : B1.Visible = False : B2.Visible = False : B3.Visible = False : B4.Visible = False
            L1.Text = "恭喜!!抓到小笨豬了 XD"
            B5.Text = "小笨豬"

        Else
            B5.Enabled = False
            L1.Text = "小心大野狼!!"
            B5.Text = "大野狼"
        End If
    End Sub

    Private Sub B6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B6.Click

        If a = 9 Or a = 7 Then
            B5.Visible = False : B1.Visible = False : B2.Visible = False : B3.Visible = False : B4.Visible = False
            L1.Text = "恭喜!!抓到小笨豬了 XD"
            B6.Text = "小笨豬"

        Else
            B6.Enabled = False
            L1.Text = "小心大野狼!!"
            B6.Text = "大野狼"
        End If
    End Sub

  
    Private Sub BB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BB.Click

        a = Fix(Rnd() * (9 - 1))

        B1.Visible = True : B2.Visible = True : B3.Visible = True : B4.Visible = True : B5.Visible = True : B6.Visible = True
        B1.Enabled = True : B2.Enabled = True : B3.Enabled = True : B4.Enabled = True : B5.Enabled = True : B6.Enabled = True
        B1.Text = "稻草堆"
        B2.Text = "垃圾堆"
        B3.Text = "小木屋"
        B4.Text = "廚餘桶"
        B5.Text = "爛泥巴"
        B6.Text = "矮牆間"
        L1.Text = "猜猜小笨豬在哪裡!!"
    End Sub

    

End Class
