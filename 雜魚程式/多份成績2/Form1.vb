Public Class Form1
    Dim aa(,), b As Single ' aa=個人分數
    Dim bb() As String = {"國文", "英文", "數學"}
    Dim x As Byte ' 人數 
    Dim q, w, r As Integer '國 英 數
    Dim orz As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        q = 0 : w = 0 : r = 0 : orz = ""
        x = Val(T1.Text)
        Do Until x <> 0
            x = Val(InputBox("注意!!", "請輸入有多少份成績", 5))
        Loop

        ReDim aa(x, 5)

        '輸入成績
        For i = 1 To x
            For k = 1 To 3
                aa(i, 0) = i
                aa(i, k) = InputBox("第" & i & "位" & bb(k - 1) & "成績", "請輸入" & bb(k - 1) & "成績", 0)
            Next
        Next
        '計算個別平均  總分
        For i = 1 To x
            aa(i, 4) = (aa(i, 1) + aa(i, 2) + aa(i, 3))
            aa(i, 5) = Format((aa(i, 1) + aa(i, 2) + aa(i, 3)) / 3, "##.0")
        Next

        '計算名次
        For i = 1 To x
            For k = 1 To x
                If aa(i, 4) > aa(k, 4) Then
                    For z = 0 To 5
                        b = aa(i, z)
                        aa(i, z) = aa(k, z)
                        aa(k, z) = b
                    Next
                End If
            Next
        Next

        '計算 全部平均 總分  
        For i = 1 To x
            orz &= Space(5)
            For k = 0 To 5
                orz &= aa(i, k) & vbTab
            Next
            orz = orz & i & vbNewLine
            q += aa(i, 1) : w += aa(i, 2) : r += aa(i, 3)
        Next


        orz &= "總分" & vbTab & q & vbTab & w & vbTab & r & _
            vbNewLine & "平均" & vbTab & Format(q / x, "##.0") & vbTab & Format(w / x, "##.0") & vbTab & Format(r / x, "##.0")
                    L1.Text &= orz
                    Erase aa

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        L1.Text = "座號" & vbTab & bb(0) & vbTab & bb(1) & vbTab & bb(2) & vbTab & "總分" & vbTab & "平均" & Space(8) & "名次" & vbNewLine
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        L1.Text = "" : T1.Text = ""
        L1.Text = "座號" & vbTab & bb(0) & vbTab & bb(1) & vbTab & bb(2) & vbTab & "總分" & vbTab & "平均" & Space(8) & "名次" & vbNewLine
    End Sub
End Class
