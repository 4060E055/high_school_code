Public Class Form1
    Dim a As Integer = 0 '分數
    Dim b As Integer = 0 '及格
    Dim c As Integer = 0 '不及格
    Dim d As Integer = 0 '總分
    Dim f As Integer = 0 '人數
    Dim aa As Integer = 0 '按鈕
    'Dim bb As Integer = 0
  


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Do While aa < 5

            Do While T1.Text = ""
                T1.Text = InputBox("請輸入第" & f + 1 & "位數", "注意", 0)

            Loop
            '-----------------------------------------執行到這裡T1一定會有數
            a = Val(T1.Text)

            Do While a < 0 Or a > 100
                T1.Text = InputBox("輸入錯誤,請從新輸入", "注意", 0)
                a = Val(T1.Text)
            Loop


            If a >= 60 Then
                b = b + 1
            Else : c = c + 1
            End If


            d = d + a
            f = f + 1
            aa = aa + 1

            L1.Text = d
            L2.Text = d / f
            L3.Text = b
            L4.Text = c

            T1.Text = ""

        Loop

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        L1.Text = ""
        L2.Text = ""
        L3.Text = ""
        L4.Text = ""
        aa = 0
        b = 0
        c = 0
    End Sub
End Class
