Public Class Form1
    Dim ColorWhat As Color = PictureBox1.BackColor

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Sub TheColor()
        If RadioButton1.Checked = True Then
            ColorWhat = Color.Red
        ElseIf RadioButton2.Checked = True Then
            ColorWhat = Color.Yellow
        ElseIf RadioButton3.Checked = True Then
            ColorWhat = Color.Blue
        ElseIf RadioButton4.Checked = True Then
            ColorWhat = Color.Green
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        TheColor()
        If ColorWhat <> PictureBox2.BackColor And ColorWhat <> PictureBox9.BackColor And ColorWhat <> PictureBox8.BackColor Then
            PictureBox1.BackColor = ColorWhat
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        TheColor()
        If ColorWhat <> PictureBox3.BackColor And ColorWhat <> PictureBox9.BackColor And ColorWhat <> PictureBox1.BackColor Then
            PictureBox1.BackColor = ColorWhat
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        TheColor()
        If ColorWhat <> PictureBox2.BackColor And ColorWhat <> PictureBox9.BackColor And ColorWhat <> PictureBox4.BackColor Then
            PictureBox1.BackColor = ColorWhat
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        TheColor()
        If ColorWhat <> PictureBox3.BackColor And ColorWhat <> PictureBox9.BackColor And ColorWhat <> PictureBox5.BackColor Then
            PictureBox1.BackColor = ColorWhat
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        TheColor()
        If ColorWhat <> PictureBox4.BackColor And ColorWhat <> PictureBox9.BackColor And ColorWhat <> PictureBox6.BackColor Then
            PictureBox1.BackColor = ColorWhat
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        TheColor()
        If ColorWhat <> PictureBox5.BackColor And ColorWhat <> PictureBox9.BackColor And _
        ColorWhat <> PictureBox7.BackColor And ColorWhat <> PictureBox10.BackColor Then
            PictureBox1.BackColor = ColorWhat
        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        TheColor()
        If ColorWhat <> PictureBox6.BackColor And ColorWhat <> PictureBox10.BackColor And ColorWhat <> PictureBox8.BackColor Then
            PictureBox1.BackColor = ColorWhat
        End If
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        TheColor()
        If ColorWhat <> PictureBox1.BackColor And ColorWhat <> PictureBox2.BackColor And ColorWhat <> PictureBox3.BackColor _
        And ColorWhat <> PictureBox4.BackColor And ColorWhat <> PictureBox5.BackColor And ColorWhat <> PictureBox6.BackColor _
        And ColorWhat <> PictureBox8.BackColor And ColorWhat <> PictureBox10.BackColor Then
            PictureBox1.BackColor = ColorWhat
        End If
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        TheColor()
        If ColorWhat <> PictureBox7.BackColor And ColorWhat <> PictureBox9.BackColor And _
        ColorWhat <> PictureBox10.BackColor And ColorWhat <> PictureBox1.BackColor Then
            PictureBox1.BackColor = ColorWhat
        End If
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        TheColor()
        If ColorWhat <> PictureBox9.BackColor And ColorWhat <> PictureBox8.BackColor And _
        ColorWhat <> PictureBox7.BackColor And ColorWhat <> PictureBox6.BackColor Then
            PictureBox1.BackColor = ColorWhat
        End If
    End Sub
End Class
