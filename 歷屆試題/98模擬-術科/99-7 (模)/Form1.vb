Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, n As Byte
    Dim ib(1), num(2), oa(2), ob(2) As Integer
    Dim ic As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ia = sr.ReadLine
        For i = 1 To ia
            ic = Trim(sr.ReadLine) : ReDim ib(2) : n = 0
            For j = 1 To Len(ic) '帶入美行數 並分解
                If Microsoft.VisualBasic.Mid(ic, j, 1) <> " " Then
                    oa(n) = Microsoft.VisualBasic.Mid(ic, j, 1) : n += 1
                Else
                    n = 0
                    For k = j + 1 To Len(ic)
                        ob(n) = Microsoft.VisualBasic.Mid(ic, k, 1) : n += 1
                    Next
                    GoTo 1
                End If
            Next
1:
            For j = 1 To 2 Step 1 '若該數未為3未  則須調整個數到相對位置
                If oa(j) = 0 Then '第一個數檢查
                    For k = j To 1 Step -1
                        oa(k) = oa(k - 1) : oa(k - 1) = 0
                    Next
                End If
                If ob(j) = 0 Then '第二個數檢查
                    For k = j To 1 Step -1
                        ob(k) = ob(k - 1) : ob(k - 1) = 0
                    Next
                End If
            Next
            n = 0
            For j = 2 To 0 Step -1 '判斷有多少進未
                If oa(j) + ob(j) > 9 And j <> 0 Then
                    oa(j - 1) += 1 : n += 1
                ElseIf oa(j) + ob(j) > 9 And j = 0 Then
                    n += 1
                End If
            Next
            sw.WriteLine(n)
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
