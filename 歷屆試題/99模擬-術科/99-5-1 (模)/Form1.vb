Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in-5-1.txt")
    Dim fw As New FileInfo("out-5-1.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ib, n, x, a As Integer ' ib=從哪個開始點名 n=有多少被點名的數 x and a =計數變數
    Dim ii, ia(2) As String 'ia=被點名的數 

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ii = Trim(sr.ReadLine)
        For i = 1 To Len(ii) '帶入要被點名的數
            If Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) >= 48 And Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) <= 57 Then
                ia(n) &= Microsoft.VisualBasic.Mid(ii, i, 1)
            ElseIf Microsoft.VisualBasic.Mid(ii, i, 1) = "," Then
                n += 1 : ReDim Preserve ia(n)
            End If
        Next
        ib = sr.ReadLine
        For i = 0 To n '找出開始的數在陣列中哪個位置
            If Val(ia(i)) = ib Then x = i : ia(i) = ""
        Next

        a = n
        Do
            x += 1
            If ia(x) <> "" Then '找出中間間格的那個數
                For i = 0 To n
                    x = (x + 1) Mod (n + 1)
                    If ia(x) <> "" Then '找出下個為被點名的數再點他
                        ia(x) = "" : a -= 1 : GoTo 1
                    End If
                Next
            End If

1:          If a = 1 Then '如果只剩最後一個數時
                For i = 0 To n  '找出最後沒被點到的數
                    If ia(i) <> "" Then sw.Write(ia(i))
                Next
                Exit Do
            End If
        Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
