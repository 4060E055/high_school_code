Public Class Form1
    Dim a As Byte
    Dim b As Short
    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Randomize()
        a = Rnd() * (3 - 1 + 1) + 1
        P2.Image = Image.FromFile("C:/1.jpg")
        If a = 2 Then
            P1.Image = Image.FromFile("C:/2.jpg")
            T1.Text = "對不起!你輸了XD"
            b -= 100
        ElseIf a = 3 Then
            P1.Image = Image.FromFile("C:/3.jpg")
            T1.Text = "你贏了耶((嚇到"
            b += 100
        ElseIf a = 1 Then
            P1.Image = Image.FromFile("C:/1.jpg")
            T1.Text = "平手~再來一次~"
        End If

        T2.Text = "目前分數：" & b
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        Randomize()
        a = Rnd() * (3 - 1 + 1) + 1
        P2.Image = Image.FromFile("C:/2.jpg")
        If a = 3 Then
            P1.Image = Image.FromFile("C:/3.jpg")
            T1.Text = "對不起!你輸了XD"
            b -= 100
        ElseIf a = 1 Then
            P1.Image = Image.FromFile("C:/1.jpg")
            T1.Text = "你贏了耶((嚇到"
            b += 100
        ElseIf a = 2 Then
            P1.Image = Image.FromFile("C:/2.jpg")
            T1.Text = "平手~再來一次~"

        End If
        T2.Text = "目前分數：" & b
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        Randomize()
        a = Rnd() * (3 - 1 + 1) + 1
        P2.Image = Image.FromFile("C:/3.jpg")
        If a = 1 Then
            P1.Image = Image.FromFile("C:/1.jpg")
            T1.Text = "對不起!你輸了XD"
            b -= 100
        ElseIf a = 2 Then
            P1.Image = Image.FromFile("C:/2.jpg")
            T1.Text = "你贏了耶((嚇到"
            b += 100
        ElseIf a = 3 Then
            P1.Image = Image.FromFile("C:/3.jpg")
            T1.Text = "平手~再來一次~"
        End If
        T2.Text = "目前分數：" & b
    End Sub

   
End Class
