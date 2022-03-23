Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("test.txt")
    Dim fw As New FileInfo("result.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, ic(1), n, x, a2(2), oa, ob As Integer 'ia=幾組資料 ic=題數,時間 n and x(用來計數)
    Dim ib As String 'ib(用來取每行資料方便分解)
    Dim a1(2), min As Double

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ia = sr.ReadLine

        For i = 1 To ia
            ib = Trim(sr.ReadLine)
            ReDim ic(1) : n = 0
            For j = 1 To Len(ib) '取題數and時間
                If Microsoft.VisualBasic.Mid(ib, j, 1) <> " " Then
                    ic(n) &= Microsoft.VisualBasic.Mid(ib, j, 1)
                Else : n += 1
                End If
            Next

            ReDim a1(ic(0) - 1), a2(ic(0) - 1)
            Dim id(ic(0) - 1, 1) As Integer : n = 0
            For j = 1 To ic(0) '取寫正解時間and寫奧步時間
                ib = Trim(sr.ReadLine) : n = 0
                For k = 1 To Len(ib)
                    If Microsoft.VisualBasic.Mid(ib, k, 1) <> " " Then
                        id(j - 1, n) &= Microsoft.VisualBasic.Mid(ib, k, 1)
                    Else : n += 1
                    End If
                Next
            Next

            oa = 0 : ob = 0
            min = id(0, 0) / 2
            For j = 0 To ic(0) - 1
                a1(j) = id(j, 0) / 2
                If a1(j) < min Then min = a1(j)
            Next

            For j = 0 To ic(0) - 1
                a2(j) = id(j, 1)
                If a2(j) < min Then min = a2(j)
            Next

2:          For j = 0 To ic(0) - 1
                If a1(j) = min Then
                    oa += 2 : ob += a1(j) * 2
                    If ob = ic(1) Then : GoTo 1
                    ElseIf ob > ic(1) Then
                        ob -= a1(j) * 2 : GoTo 1
                    End If
                    a1(j) = -1 : a2(j) = -1
                End If
            Next

            For j = 0 To ic(0) - 1
                If a2(j) = min Then
                    oa += 1 : ob += a2(j)
                    If ob = ic(1) Then : GoTo 1
                    ElseIf ob > ic(1) Then
                        ob -= a2(j) : GoTo 1
                    End If
                    a1(j) = -1 : a2(j) = -1
                End If
            Next
            If ob < ic(1) Then min += 0.5 : GoTo 2
1:          sw.WriteLine(oa)
        Next
        sw.Flush() : sw.Close() : End
    End Sub
End Class
