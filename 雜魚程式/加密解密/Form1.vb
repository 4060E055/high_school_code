Imports System.IO
Public Class Form1
    Dim f1 As New FileInfo("解密檔.txt")
    Dim a, aaa As Integer '解碼解到第幾位數 ' 加密後總共有幾位數
    Dim c, b, z, d As String '輸入之字串'4讀取字串
    Dim x1() As Integer '每字亂數加密多少'每個亂數有多少字
    Dim m As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        T2.Text = ""
        If T1.Text = "" Then
            MsgBox("請輸入任何字以供檢測", MsgBoxStyle.Critical, "注意!!")
        ElseIf T1.Text <> "" Then
            c = T1.Text
            m = Len(T1.Text)
            ReDim x1(m - 1)
            For i = 1 To m
                x1(i - 1) = Rnd() * (6855 - 456) + 455
                T2.Text &= Asc(Microsoft.VisualBasic.Mid(c, i, 1)) + x1(i - 1) & "，"
            Next

            Dim sw As StreamWriter = f1.CreateText '寫入不規則的解密資料
            If f1.Exists Then '檢驗密碼黨是否存在
                For i = 1 To m
                    sw.WriteLine(x1(i - 1))
                Next
                sw.Flush()
                sw.Close()
            Else
                f1.Create()
                For i = 1 To m
                    sw.WriteLine(x1(i - 1))
                Next
                sw.Flush()
                sw.Close()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        T1.Text = "" : T2.Text = ""
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        T3.Text = ""
        a = 0
        aaa = Len(T2.Text)

        If T2.Text = "" Then
            MsgBox("請輸入要解密的字串", , "錯誤!")
        ElseIf T2.Text <> "" Then
            If Microsoft.VisualBasic.Right(T2.Text, 1) <> "，" Then
                T2.Text &= "，"
                aaa += 1
            End If
            If f1.Exists Then '檢驗密碼黨是否存在

                Dim sr As StreamReader = f1.OpenText

                Do
                    Do
                        a += 1
                        b = Microsoft.VisualBasic.Mid(T2.Text, a, 1)
                        If b = "，" Then
                            Exit Do
                        ElseIf b <> "，" Then
                            z &= b
                        End If
                    Loop
                    d = sr.ReadLine
                    If d = "" Then
                        MsgBox("解密檔錯誤，結束執行", , "錯誤!")
                        End
                    End If
                    z = Str(Val(z) - Val(d))
                    If z < -32768 Or z > 65535 Then
                        MsgBox("解密檔錯誤", , "錯誤!")
                        T2.Text = ""
                        Exit Do
                    End If
                    T3.Text &= Chr(Val(z))
                    z = ""
                Loop Until aaa = a
                sr.Close()
            Else
                MsgBox("找不到解密檔，程式即將結束執行", , "笨蛋")
                End
            End If
        End If
    End Sub
End Class
