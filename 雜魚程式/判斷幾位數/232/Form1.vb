Public Class Form1
    Dim a As String
    Dim b As Integer
    Dim c As String
    Dim d As String
    Dim aa As Integer
    Dim bb As Integer
    Dim cc As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        aa = 0
        bb = 0
        cc = 0


        Do While T1.Text = ""
            T1.Text = InputBox("請輸入", "注意")
        Loop
        a = T1.Text

        b = Len(a)


        For i = 1 To b

            c = Microsoft.VisualBasic.Right(a, i)
            d = Asc(c)

            If d >= 48 And d <= 57 Then
                aa = aa + 1
            ElseIf d >= 41 And d <= 90 Then
                bb = bb + 1
            ElseIf d >= 61 And d <= 122 Then
                cc = cc + 1

            End If

        Next i

        L1.Text = "數字" & aa & "個"
        L2.Text = "大英" & bb & "個"
        L3.Text = "小英" & cc & "個"


    End Sub


End Class
