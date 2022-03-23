Public Class Form1
    Dim a As String
    Dim b As String
    Dim c As String
    Dim d As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        T1.Text = Space(6) & "成績單" & vbTab & Format(Now(), "D") & vbNewLine & vbNewLine _
            & "姓名" & vbTab & "國文 " & vbTab & "數學" & vbTab & "平均" & vbNewLine & _
        "---------------------------------------------" & vbNewLine & "周傑倫" & vbTab & 78 & vbTab & 95 & vbTab & Format(86.5, "##.0") _
            & vbNewLine & "蔡依琳" & vbTab & 86 & vbTab & 56 & vbTab & Format(71, "##.0")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = InputBox(vbCrLf & "請輸入姓名", "請輸入")
        Do While a = ""
            MsgBox("請從新輸入", MsgBoxStyle.Exclamation, "注意")
            a = InputBox(vbCrLf & "請輸入姓名", "請輸入")
        Loop

        b = InputBox(vbCrLf & "請輸入國文成績", "請輸入")
        Do While b = "" Or Len(b) > 2 Or Val(b) < 0
            MsgBox("輸入錯誤，請從新輸入", MsgBoxStyle.Exclamation, "注意")
            b = InputBox(vbCrLf & "請輸入國文成績", "請輸入")
        Loop

        c = InputBox(vbCrLf & "請輸入數學成績", "請輸入")
        Do While c = "" Or Len(c) > 2 Or Val(c) < 0
            MsgBox("輸入錯誤，請從新輸入", MsgBoxStyle.Exclamation, "注意")
            c = InputBox(vbCrLf & "請輸入數學成績", "請輸入")
        Loop

        d = (Val(b) + Val(c)) / 2

        T1.Text &= vbNewLine & a & vbTab & b & vbTab & c & vbTab & d
    End Sub
End Class
