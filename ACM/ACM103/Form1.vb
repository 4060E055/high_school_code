Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, a2 As String
    Dim aa, bb As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText



        ii = Trim(sr.ReadLine)
1:      Dim a1(1), n, x As Byte 'a1=盒子的各數與維度 x=組合多少個
        n = 0
        For i = 1 To Len(ii) '取第一行數
            If Microsoft.VisualBasic.Mid(ii, i, 1) = " " Then
                n += 1
            Else
                a1(n) &= Microsoft.VisualBasic.Mid(ii, i, 1)
            End If

        Next

        Dim ia(a1(0) - 1, a1(1) + 1)  '盒子各數,邊長and邊長加總and編號

        For i = 0 To a1(0) - 1 '取數
            ii = Trim(sr.ReadLine) : n = 0
            For j = 1 To Len(ii)
                If Microsoft.VisualBasic.Mid(ii, j, 1) = " " Then
                    n += 1
                Else
                    ia(i, n) &= Microsoft.VisualBasic.Mid(ii, j, 1)
                End If
            Next
        Next

        For i = 0 To a1(0) - 1
            For j = 0 To a1(1) - 1
                For k = 0 To a1(1) - 1 '將每個盒子個別邊長排序
                    If ia(i, j) > ia(i, k) Then
                        aa = ia(i, j) : ia(i, j) = ia(i, k) : ia(i, k) = aa
                    End If
                Next
            Next
            ia(i, a1(1) + 1) = i + 1 '帶入編號

            For j = 0 To a1(1) - 1
                ia(i, a1(1)) += ia(i, j) '計算每個的個別加總 
            Next

        Next


        For i = 0 To a1(0) - 1
            For j = 0 To a1(0) - 1
                If ia(i, a1(1)) > ia(j, a1(1)) Then '依加總  由大到小排序
                    For k = 0 To a1(1) + 1
                        aa = ia(i, k) : ia(i, k) = ia(j, k) : ia(j, k) = aa
                    Next
                End If
            Next
        Next

        x = 0
        Dim a3(a1(0) - 1, 1) As Integer '輸出編號順序  差
        a2 = ia(0, a1(1) + 1)
        x += 1

        bb = 0
        Do
            For j = bb + 1 To a1(0) - 1
                For k = 0 To a1(1) - 1
                    If ia(bb, k) < ia(j, k) Then '若邊長大於i盒  則跳出
                        Exit For
                    ElseIf k = a1(1) - 1 Then
                        a2 &= ia(j, a1(1) + 1) : x += 1
                        bb = j
                    End If
                Next
                If bb = j Then Exit For
            Next
        Loop Until bb = a1(0) - 1

        sw.WriteLine(x)

        For i = x To 1 Step -1
            sw.Write(Microsoft.VisualBasic.Mid(a2, i, 1) & " ")
        Next
        sw.WriteLine()
        ii = Trim(sr.ReadLine)

        If ii <> "" Then GoTo 1


        sw.Flush() : sw.Close() : End
    End Sub
End Class
