Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1.txt")
    Dim frr As New FileInfo("in2.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, n, a, nn(2), abc(2) As Integer 'ii=有多少節點 nn=每個樹葉有多少邊
    Dim ia As String ' ia = 每航輸入資料 abc=全部得樹葉的前一個
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Or frr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim srr As StreamReader = frr.OpenText

        For i = 0 To 1
            If i = 0 Then ii = sr.ReadLine
            If i = 1 Then ii = srr.ReadLine
            Dim ib(ii - 1, 1) As String 'ib=輸入資料分解
            n = 0 : a = 0
            For j = 1 To ii
                If i = 0 Then ia = sr.ReadLine
                If i = 1 Then ia = srr.ReadLine
                For k = 1 To Len(ia)
                    If Asc(Microsoft.VisualBasic.Mid(ia, k, 1)) >= 65 And Asc(Microsoft.VisualBasic.Mid(ia, k, 1)) <= 90 Then
                        ib(n, a) = Microsoft.VisualBasic.Mid(ia, k, 1)
                    ElseIf Microsoft.VisualBasic.Mid(ia, k, 1) = "," Then : a += 1
                    End If
                Next
                n += 1 : a = 0
            Next
            n = 0
            For k = 0 To ii - 1 '找出樹葉
                For l = 0 To ii - 1
                    If ib(k, 0) = ib(l, 1) Then : Exit For
                    ElseIf l = ii - 1 Then
                        abc(n) = k : n += 1 : ReDim Preserve abc(n)
                    End If
                Next
            Next
            n -= 1 : ReDim Preserve abc(n)
            ReDim nn(n)
            For k = 0 To n '每個樹葉
                ia = ib(abc(k), 1)
                For l = ii - 1 To 0 Step -1
                    If ia = ib(l, 0) Then '找出他在哪個數的後面
                        If ib(l, 1) = "" Then Exit For '如果到頂點則結束此計算
                        ia = ib(l, 1) : nn(k) += 1
                    End If
                Next
            Next
            For k = 0 To n
                sw.WriteLine(ib(abc(k), 0) & "　" & nn(k) + 1)
            Next
            sw.WriteLine()
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
