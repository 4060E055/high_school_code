Imports System.IO
Public Class Form1
    Dim f1 As New FileInfo("C:\test6.txt")
    Dim g1 As New FileInfo("C:\result6.txt")
    Dim s1 As StreamReader = f1.OpenText
    Dim s2 As StreamWriter = g1.CreateText
    Dim aa As Byte '幾組父子
    Dim a(), b(), bb(3) As Single
    Dim c As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If f1.Exists Then

            If g1.Exists Then
                Call zxc()
            Else
                g1.Create()
                Call zxc()
            End If
        Else
            MsgBox("輸入檔不存在!", , "錯誤!!")
            End
        End If

    End Sub

    Sub zxc()
        aa = s1.ReadLine

        If aa > 10 Or aa < 5 Then
            MsgBox("父子數應介於5~10位", , "注意!!")
            End
        End If

        ReDim a(aa), b(aa)

        For i = 0 To aa - 1
            c = s1.ReadLine
            For j = 1 To Len(c) - 2

                If Asc(Mid(c, j, 1)) <> 32 Then
                    a(i) &= Mid(c, j, 1)
                ElseIf Asc(Mid(c, j, 1)) = 32 Then

                    For k = j + 1 To Len(c)

                        b(i) &= Mid(c, k, 1)

                    Next

                    Exit For
                End If
            Next
            a(aa) += a(i) : b(aa) += b(i)
        Next

        a(aa) = a(aa) / aa : b(aa) = b(aa) / aa

        For i = 0 To aa - 1
            bb(0) += ((a(i) - a(aa)) * (b(i) - b(aa)))  '分子
            bb(1) += (a(i) - a(aa)) ^ 2              '1分母
            bb(2) += (b(i) - b(aa)) ^ 2              '2分母
      
        Next
        bb(1) = bb(1) ^ 0.5
        bb(2) = bb(2) ^ 0.5
        bb(3) = Format(Val(bb(0) / (bb(1) * bb(2))), "0.###")
        s2.WriteLine(bb(3))

        For i = 0 To aa
            s2.WriteLine(a(i) & Space(4) & b(i))
        Next

        s2.Flush() : s2.Close() : Me.Close()
    End Sub
End Class
