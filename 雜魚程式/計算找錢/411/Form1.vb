Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Dim d As Integer
    Dim f As Integer
    Dim g As Integer
    Dim h As Integer
    Dim i As Integer
    Dim j As Integer
    Dim k As Integer
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Do While T1.Text = ""
            T1.Text = InputBox("請輸入收多少錢", "注意")

        Loop
        Do While T2.Text = ""
            T2.Text = InputBox("請輸入合計售價", "注意")
        Loop

        a = Val(T1.Text)
        b = Val(T2.Text)

        If b > a Then
            MsgBox("售價不可大於收錢", MsgBoxStyle.Critical, AcceptButton)
        ElseIf a > b And a <> 0 And b <> 0 Then
            L11.Text = a - b
        End If

        c = Val(L11.Text)
       

        d = c \ 1000

        f = (c - d * 1000) \ 500
        g = (c - d * 1000 - f * 500) \ 100
        h = (c - d * 1000 - f * 500 - g * 100) \ 50
        i = (c - d * 1000 - f * 500 - g * 100 - h * 50) \ 10
        j = (c - d * 1000 - f * 500 - g * 100 - h * 50 - i * 10) \ 5
        k = (c - d * 1000 - f * 500 - g * 100 - h * 50 - i * 10 - j * 5)

        L1.Text = d
        L2.Text = f
        L3.Text = g
        L4.Text = h
        L5.Text = i
        L6.Text = j
        L7.Text = k


    End Sub
End Class
