Public Class 登
    Dim a As Byte
    Public b As Byte
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        T1.Text = "" : T2.Text = "" : T3.Text = ""
        Me.Hide() : 開.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If T1.Text = "" OrElse T2.Text = "" OrElse T3.Text = "" Then
            MsgBox("資料未輸入完整", MsgBoxStyle.Critical, "注意!!")
        ElseIf T2.Text <> T3.Text Then
            MsgBox("兩次密碼不一樣" & vbNewLine & "請重新輸入", MsgBoxStyle.Critical, "錯誤!!")
            T2.Text = "" : T3.Text = ""
        Else

            For i = 1 To 辦.x
                If T1.Text = 辦.aa(i, 0) AndAlso T2.Text = 辦.aa(i, 1) Then
                    L1.Text = "成功登入"
                    T1.Text = "" : T2.Text = "" : T3.Text = ""
                    Exit For
                ElseIf T1.Text <> 辦.aa(i, 0) OrElse T2.Text <> 辦.aa(i, 1) Then
                    a += 1
                    If a = 辦.x Then
                        b += 1
                        L1.Text = "帳號或密碼輸入錯誤" & b & "次" & vbNewLine & "請重新輸入"
                        T1.Text = "" : T2.Text = "" : T3.Text = ""
                        If b = 4 Then End
                    End If
                End If
            Next
        End If
        If 辦.aa(1, 0) = "" Then
            b += 1
            L1.Text = "帳號或密碼輸入錯誤" & b & "次" & vbNewLine & "請重新輸入"
            T1.Text = "" : T2.Text = "" : T3.Text = ""
            If b = 4 Then End
        End If


    End Sub
End Class