Public Class Form1
    Dim item1() As String = {"甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬", "癸"}
    Dim item2() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}
    Dim item3() As String = {"鼠", "牛", "虎", "兔", "龍", "蛇", "馬", "羊", "猴", "雞", "狗", "豬"}
    Dim a, b, n As Integer
    Dim strr As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 1 To 99
            Combo1.Items.Add(i)
        Next
        List1.Items.AddRange(item1)
        List2.Items.AddRange(item2)
        List3.Items.AddRange(item3)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        List5.Items.Clear()

        Dim i As Integer
        For i = 1 To n
            strr = ""
            Randomize()
            a = Rnd() * (9 - 1 + 1) + 1
            strr &= item1(a - 1)
            a = Rnd() * (11 - 1 + 1) + 1
            strr &= item2(a - 1)
            a = Rnd() * (11 - 1 + 1) + 1
            strr &= item3(a - 1)
            If List5.Items.Contains(strr) = False Then
                List5.Items.Add(strr)
            Else
                i -= 1
            End If
        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To 9
            Do
                Randomize()
                a = Rnd() * (9 - 1 + 1) + 1
                b = Rnd() * (9 - 1 + 1) + 1
            Loop Until a <> b
            strr = item1(a - 1) : item1(a - 1) = item1(b - 1) : item1(b - 1) = strr
        Next
        List1.Items.Clear()
        List1.Items.AddRange(item1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        For i = 0 To 9
            Do
                Randomize()
                a = Rnd() * (11 - 1 + 1) + 1
                b = Rnd() * (11 - 1 + 1) + 1
            Loop Until a <> b
            strr = item2(a - 1) : item2(a - 1) = item2(b - 1) : item2(b - 1) = strr
        Next
        List2.Items.Clear()
        List2.Items.AddRange(item2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer
        For i = 0 To 9
            Do
                Randomize()
                a = Rnd() * (11 - 1 + 1) + 1
                b = Rnd() * (11 - 1 + 1) + 1
            Loop Until a <> b
            strr = item3(a - 1) : item3(a - 1) = item3(b - 1) : item3(b - 1) = strr
        Next
        List3.Items.Clear()
        List3.Items.AddRange(item3)
    End Sub

    Private Sub Combo1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo1.SelectedIndexChanged
        n = Combo1.SelectedItem

    End Sub
End Class
