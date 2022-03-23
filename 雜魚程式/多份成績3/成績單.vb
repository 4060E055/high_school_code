Public Class 成績單
    Dim b As Single
    Dim q, w, r As Integer '國 英 數總分
    Dim orz As String

    Private Sub 成績單_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Tbshow.Text = "座號" & vbTab & "國文" & vbTab & "英文" & vbTab & "數學" & vbTab & "總分" & vbTab & "平均" & vbTab & "名次" & vbNewLine
        If 成.x <> 0 Then
            q = 0 : w = 0 : r = 0 : orz = ""

            '計算個別平均  個別總分
            For i = 1 To 成.x
                成.aa(i, 4) = (成.aa(i, 1) + 成.aa(i, 2) + 成.aa(i, 3))
                成.aa(i, 5) = Format((成.aa(i, 1) + 成.aa(i, 2) + 成.aa(i, 3)) / 3, "##.0")
            Next

            '計算名次
            For i = 1 To 成.x
                For k = 1 To 成.x
                    If 成.aa(i, 4) > 成.aa(k, 4) Then
                        For z = 0 To 5
                            b = 成.aa(i, z)
                            成.aa(i, z) = 成.aa(k, z)
                            成.aa(k, z) = b
                        Next
                    End If
                Next
            Next

            '計算 全部平均 全部總分  科目總分
            For i = 1 To 成.x
                orz &= Space(5)
                For k = 0 To 5
                    orz &= 成.aa(i, k) & vbTab
                Next
                orz = orz & i & vbNewLine
                q += 成.aa(i, 1) : w += 成.aa(i, 2) : r += 成.aa(i, 3)
            Next

            orz &= "總分" & vbTab & q & vbTab & w & vbTab & r & _
                vbNewLine & "平均" & vbTab & Format(q / 成.x, "##.0") & vbTab & Format(w / 成.x, "##.0") & vbTab & Format(r / 成.x, "##.0")
            Tbshow.Text &= orz
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide() : 成.Show()
        成.x = 0
        成.T4.ReadOnly = False
        成.T4.Text = ""
        成.T1.Enabled = True : 成.T2.Enabled = True : 成.T3.Enabled = True
        Button2.Enabled = True : Button3.Enabled = True : Button4.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        國.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        英.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        數.Show()
    End Sub

   
End Class
