Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1.txt")
    Dim frr As New FileInfo("in2.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As String
    Dim yy() As String = {"年", "月", "日"}
    Dim n, x, mm(2) As Integer 'mm=年月日的數
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Or frr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim srr As StreamReader = frr.OpenText

        For i = 0 To 1
            Do
                If i = 0 Then ia = Trim(sr.ReadLine)
                If i = 1 Then ia = Trim(srr.ReadLine)
                If ia = "" Then Exit Do
                n = 0 : x = 0
                For j = 1 To Len(ia) '判斷年 月 日 順序是否正確
                    If Asc(yy(n)) = Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) Then
                        n += 1 : x += 1 : If n = 3 Then Exit For
                    End If
                    If j = Len(ia) And x <> 3 Then
                        sw.WriteLine("不符合") : GoTo 1
                    End If
                Next

                n = 0 : x = 0 : ReDim mm(2)
                For j = 1 To Len(ia) ' 取 年 月 日 的數
                    If Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) >= 48 And _
                        Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) <= 57 Then
                        mm(n) &= Microsoft.VisualBasic.Mid(ia, j, 1)
                    ElseIf Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) = Asc(yy(x)) Then '判斷是否為年 月 日
                        n += 1 : x += 1 : If x = 3 Then Exit For
                    End If
                Next
                If mm(0) > 999 Or mm(0) < 0 Then sw.WriteLine("不符合") : GoTo 1
                If mm(1) > 12 Or mm(0) < 0 Then sw.WriteLine("不符合") : GoTo 1
                If mm(1) = 1 Or mm(1) = 3 Or mm(1) = 5 Or mm(1) = 7 Or mm(1) = 8 Or mm(1) = 10 Or mm(1) = 12 Then
                    If mm(2) > 31 Or mm(0) < 0 Then sw.WriteLine("不符合") : GoTo 1
                ElseIf mm(1) = 2 Then
                    mm(0) += 1911
                    If (mm(0) Mod 4 = 0 And mm(0) Mod 100 <> 0) Or (mm(0) Mod 400 = 0) Then
                        If mm(2) > 29 Or mm(2) < 0 Then sw.WriteLine("不符合") : GoTo 1
                    Else : If mm(2) > 28 Or mm(2) < 0 Then sw.WriteLine("不符合") : GoTo 1
                    End If
                Else : If mm(2) > 30 Or mm(0) < 0 Then sw.WriteLine("不符合") : GoTo 1
                End If
                sw.WriteLine("符合")
1:          Loop
            sw.WriteLine()
        Next



        sw.Flush() : sw.Close() : End
    End Sub
End Class
