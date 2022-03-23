Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1.txt")
    Dim frr As New FileInfo("in2.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, o2(2), x As Integer
    Dim ib, o1(2) As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Or frr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim srr As StreamReader = frr.OpenText

        For i = 0 To 1
            If i = 0 Then ia = sr.ReadLine
            If i = 1 Then ia = srr.ReadLine
            ReDim o1(2), o2(2) : x = 0 : ib = ""
            For j = 1 To ia '將分段的文章全部變成同一行
                If i = 0 Then ib &= sr.ReadLine
                If i = 1 Then ib &= srr.ReadLine
            Next

            For j = 1 To Len(ib) - 1
                If Asc(Microsoft.VisualBasic.Mid(ib, j, 1)) > -24000 And _
                    Asc(Microsoft.VisualBasic.Mid(ib, j + 1, 1)) > -24000 Then '判斷兩個是否皆為中文字
                    For k = 0 To x  '判斷是否有重複詞的
                        If Microsoft.VisualBasic.Mid(ib, j, 2) = o1(k) Then
                            o2(k) += 1 : Exit For
                        ElseIf k = x Then
                            o1(x) = Microsoft.VisualBasic.Mid(ib, j, 2)
                            x += 1 : ReDim Preserve o1(x), o2(x)
                        End If
                    Next
                End If
            Next

            For k = 0 To x
                For l = 0 To x '按數量大到小排序
                    If o2(k) > o2(l) Then
                        ib = o1(k) : o1(k) = o1(l) : o1(l) = ib
                        ib = o2(k) : o2(k) = o2(l) : o2(l) = ib
                    End If
                Next
            Next

            For k = 0 To x
                sw.WriteLine(o1(k) & "　" & o2(k) + 1)
                If o2(k) <> o2(k + 1) Then Exit For
            Next
            sw.WriteLine()
        Next
        sw.Flush() : sw.Close() : End
    End Sub
End Class
