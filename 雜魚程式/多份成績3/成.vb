Public Class 成
    Public aa(,) As Single '1開始
    Dim bb() As String = {"國文", "英文", "數學"}
    Public x As Byte '人數
    Dim a, b, z As Byte '修改第幾 ,目前輸入到幾

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        x = Val(T4.Text)
        If T1.Text = "" OrElse T2.Text = "" OrElse T3.Text = "" OrElse T4.Text = "" Then
            MsgBox("資料未輸入完整", MsgBoxStyle.Critical, "注意!!")

            '輸入成績
        ElseIf T1.Text <> "" AndAlso T2.Text <> "" AndAlso T3.Text Then

            aa(b, 1) = Val(T1.Text) : aa(b, 2) = Val(T2.Text) : aa(b, 3) = Val(T3.Text) : aa(b, 0) = b

            If b = x Then '自動確認是否輸入完資料
                L1.Text = "目前輸入的成績已達指定份數"
                T1.Enabled = False : T2.Enabled = False : T3.Enabled = False
                z = MsgBox("是否進到下一步?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "注意!!")

                If z = 6 Then
                    L1.Text = ""
                    Me.Hide() : 成績單.Show()
                End If

            ElseIf b <> x Then '顯示輸入到第幾分
                L1.Text = "目前輸入第" & b & "份成績"
                b += 1
            End If
            T4.ReadOnly = True
        End If
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        T1.Text = "" : T2.Text = "" : T3.Text = ""
        T1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If L1.Text <> "目前輸入的成績已達指定份數" Then
            MsgBox("還未輸入到指定份數", MsgBoxStyle.Critical, "注意!!")
        ElseIf L1.Text = "目前輸入的成績已達指定份數" Then
            Me.Hide() : 成績單.Show()
            '能關閉表單ㄉ話這段就刪除..................
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '修改成績
        Do
            a = Val(InputBox("請輸入要修改第幾份成績", "請勿亂輸入!!", b - 1))
        Loop While a > (b - 1) Or a = 0

        For i = 1 To 3
            aa(a, i) = InputBox("請輸入新的第" & a & "份" & bb(i - 1) & "成績" & vbNewLine & "此成績原分數為" & aa(a, i) & "分", "成績輸入", 0)
        Next
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '重新輸入
        b = 1 : L1.Text = ""
        Do
            x = Val(InputBox("請輸入共有多少份資料", "請勿亂輸入!!", 5))
        Loop While x <= 0
        T4.Text = x
        ReDim aa(x, 5)
        Button2.Enabled = False : Button3.Enabled = False : Button4.Enabled = False
        T1.Enabled = True : T2.Enabled = True : T3.Enabled = True
        T1.Focus()
    End Sub

    Private Sub T4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T4.TextChanged
        If Val(T4.Text) <= 0 Then
            MsgBox("請輸入正確", MsgBoxStyle.Critical, "注意!!")
        ElseIf T4.Text <> "" Then
            x = Val(T4.Text)
            b = 1
            ReDim aa(x, 5)
        End If

    End Sub

    Private Sub 成_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '能關閉表單時用
        ' T1.Enabled = True : T2.Enabled = True : T3.Enabled = True
    End Sub
End Class