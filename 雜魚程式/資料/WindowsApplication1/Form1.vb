Public Class Form1
    Dim a As String
    Dim b As String : Dim bb As Integer : Dim bbb As Integer
    Dim c As String : Dim cc As Integer
    Dim d As String : Dim dd As Integer : Dim ddd As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        T1.Font = New Font("標楷體", 12)
        T1.Text = Space(6) & "VB俱樂部會員名冊" & Format(Now(), "   d-m-yyyy h:m:s") & _
         vbNewLine & vbCrLf & "姓名" & vbTab & "電話" & vbTab & vbTab & "生日" & vbTab & vbTab & "消費金額" & vbCrLf & _
        "----" & vbTab & "----" & vbTab & vbTab & "----" & vbTab & vbTab & "--------" & vbCrLf & _
        "楚留香" & vbTab & "(09)12345678" & vbTab & Format(#10/17/2011#, "m") & vbTab & Format(782601, "$000000")
    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click

        a = InputBox("姓名", "請輸入")

        Do While a = ""
            a = InputBox("姓名", "請輸入")
        Loop



        b = InputBox("手機號碼" & vbNewLine & vbNewLine & "P.S:限10位數", "請輸入", "09")
        bb = Len(b)

        Do
            b = InputBox("手機號碼" & vbNewLine & vbNewLine & "P.S:限10位數", "請輸入", "09")

            bb = Len(b)
            bbb = Microsoft.VisualBasic.Left(b, 2)
            Do While b = "" Or bb <> 10 Or bbb <> "09"
                MsgBox("請輸入十位數字" & vbNewLine & "且前兩位數必須是 09 ", MsgBoxStyle.Exclamation, "注意!!")
                b = InputBox("手機號碼" & vbNewLine & vbNewLine & "P.S:限10位數", "請輸入", "09")
                bb = Len(b)
                bbb = Microsoft.VisualBasic.Left(b, 2)
            Loop

            For i = 1 To bb Step 1
                bbb = Asc(Microsoft.VisualBasic.Left(b, i))
                Do While (bbb < 48 Or bbb > 57)
                    MsgBox("請輸入數字", MsgBoxStyle.Exclamation, "注意!!")
                    b = InputBox("手機號碼" & vbNewLine & vbNewLine & "P.S:限10位數", "請輸入", "09")
                    bb = Len(b)
                    bbb = Microsoft.VisualBasic.Left(b, 2)
                Loop
            Next

        Loop While bbb = "09" And bb = 10




        c = InputBox("請輸入生日" & vbNewLine & vbNewLine & "例：4月5日" & vbCrLf & vbNewLine & "  請輸入0405", "請輸入")
        cc = Len(c)
        Do While cc <> 4
            MsgBox("請輸入4位數", MsgBoxStyle.Exclamation, "注意!!")
            c = InputBox("請輸入生日" & vbNewLine & vbNewLine & "例：4月5日" & vbCrLf & vbNewLine & "  請輸入0405", "請輸入")
            cc = Len(c)
        Loop



        d = InputBox("消費金額" & vbCrLf & "P.S:最高限6位數", "請輸入")
        dd = Len(d)


        Do While dd > 6 Or d = ""
            MsgBox("請輸入1~6位阿拉伯數字", MsgBoxStyle.Exclamation, "注意!!")
            d = InputBox("消費金額" & vbCrLf & "P.S:最高限6位數", "請輸入")
            dd = Len(d)
        Loop
        ddd = Asc(Microsoft.VisualBasic.Left(d, 1))
        Do While (ddd < 48 Or ddd > 57) And d <> 0
            MsgBox("請輸入數字", MsgBoxStyle.Exclamation, "注意!!")
            d = InputBox("消費金額" & vbCrLf & "P.S:最高限6位數", "請輸入")
            ddd = Asc(Microsoft.VisualBasic.Left(d, 1))
        Loop


        b = Format(Val(b), "(##)########")
        c = Format(Val(c), "##月##日")


        T1.Text = T1.Text & vbCrLf & a & vbTab & b & vbTab & c & vbTab & "$" & d
    End Sub
End Class
