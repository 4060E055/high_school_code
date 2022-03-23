Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1.txt")
    Dim frr As New FileInfo("in2.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As String
    Dim bu(7, 7), ass(3, 1), s1(2), a As Byte

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Or frr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim srr As StreamReader = frr.OpenText

        For i = 0 To 1
            ReDim bu(7, 7)
            For j = 0 To 7 '帶入1-8
                If i = 0 Then ia = sr.ReadLine
                If i = 1 Then ia = srr.ReadLine
                a = 0
                For k = 1 To Len(ia)
                    If Microsoft.VisualBasic.Mid(ia, k, 1) = "0" Or _
                        Microsoft.VisualBasic.Mid(ia, k, 1) = "1" Then
                        bu(j, a) = Microsoft.VisualBasic.Mid(ia, k, 1) : a += 1
                    End If
                Next
            Next
            ReDim ass(3, 1)

            For j = 0 To 3 '帶入起始與終點
                If i = 0 Then ia = sr.ReadLine
                If i = 1 Then ia = srr.ReadLine
                : a = 0
                For k = 1 To Len(ia)
                    If Asc(Microsoft.VisualBasic.Mid(ia, k, 1)) >= 48 And _
                        Asc(Microsoft.VisualBasic.Mid(ia, k, 1)) <= 57 Then
                        ass(j, a) = Microsoft.VisualBasic.Mid(ia, k, 1) : a += 1
                    End If
                Next
            Next
            ReDim s1(2) : a = 0

            For h = 0 To 3 '4個要計算的資料
                For j = 0 To 7 '第一次路徑
                    If bu(ass(h, 0) - 1, j) = 1 Then
                        For k = 0 To 7 '第二次路徑
                            If bu(j, k) = 1 Then
                                For l = 0 To 7 '第三次路徑
                                    If bu(k, l) = 1 And l = ass(h, 1) - 1 Then
                                        sw.WriteLine("有路徑") : GoTo 1
                                    ElseIf j = 7 And l = 7 And k = 7 Then : sw.WriteLine("沒路徑") : GoTo 1
                                    End If
                                Next
                            ElseIf j = 7 And k = 7 Then : sw.WriteLine("沒路徑") : GoTo 1
                            End If
                        Next
                    ElseIf j = 7 Then : sw.WriteLine("沒路徑") : GoTo 1
                    End If
                Next
1:
            Next
            sw.WriteLine()
        Next



        sw.Flush() : sw.Close() : End
    End Sub
End Class
