Public Class 辦
    Public aa(5, 1) As String '帳密
    Public x As Byte   '有多少帳密
    Dim a As Byte

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If T1.Text = "" OrElse T2.Text = "" OrElse T3.Text = "" Then
            MsgBox("資料未輸入完整", MsgBoxStyle.Critical, "注意!!")
        ElseIf T2.Text <> T3.Text Then
            MsgBox("兩次密碼不一樣" & vbNewLine & "請重新輸入", MsgBoxStyle.Critical, "錯誤!!")
            T2.Text = "" : T3.Text = ""
        Else  '把帳密丟入陣列
            aa(x, 0) = T1.Text
            aa(x, 1) = T2.Text
            Me.Hide() : 開.Show()
            T1.Text = "" : T2.Text = "" : T3.Text = ""
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        T1.Text = "" : T2.Text = "" : T3.Text = ""
        Me.Hide() : 開.Show()
    End Sub

    Private Sub T1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T1.TextChanged
        Button1.Enabled = False
        If T1.Text <> "" Then
            B1.Enabled = True : B1.Text = "帳號驗證"
        ElseIf T1.Text = "" Then
            B1.Enabled = False
        End If
    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        a = 0      '驗證帳號是否有重複
        For i = 1 To x
            If T1.Text = aa(i, 0) Then
                B1.Text = "帳號重複"

                Exit For
            ElseIf T1.Text <> aa(i, 0) Then
                a += 1
                If a = x Then
                    B1.Text = "ok" : B1.Enabled = False
                    Button1.Enabled = True
                End If


            End If

        Next

    End Sub

    
  
End Class