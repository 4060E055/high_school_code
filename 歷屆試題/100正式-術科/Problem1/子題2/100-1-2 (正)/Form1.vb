Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1.txt")
    Dim frr As New FileInfo("in2.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim n1(2), n2(2), ii As String
    Dim n11, n22, n As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Or frr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim srr As StreamReader = frr.OpenText
        ii = sr.ReadLine
        Do
            n11 = 0 : n22 = 0 : ReDim n1(2), n2(2) '帶入數
            For i = 1 To Len(ii)
                If Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) >= 48 And Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) <= 57 Then
                    n1(n11) &= Microsoft.VisualBasic.Mid(ii, i, 1)
                ElseIf Microsoft.VisualBasic.Mid(ii, i, 1) = "=" Then
                    For j = i + 2 To Len(ii)
                        If Asc(Microsoft.VisualBasic.Mid(ii, j, 1)) >= 48 And Asc(Microsoft.VisualBasic.Mid(ii, j, 1)) <= 57 Then
                            n2(n22) &= Microsoft.VisualBasic.Mid(ii, j, 1)
                        Else
                            n22 += 2 : ReDim Preserve n2(n22)
                            n2(n22 - 1) = Microsoft.VisualBasic.Mid(ii, j, 1)
                        End If
                    Next
                    Exit For
                Else
                    n11 += 2 : ReDim Preserve n1(n11)
                    n1(n11 - 1) = Microsoft.VisualBasic.Mid(ii, i, 1)
                End If
            Next

            For i = 1 To n11 Step 2
                If n1(i) = "*" Then
                    n1(i - 1) = Val(n1(i - 1)) * Val(n1(i + 1))
                    n1(i + 1) = 0 : n1(i) = "+"
                End If

            Next

            For i = 1 To n22 Step 2
                If n2(i) = "*" Then
                    n2(i - 1) = Val(n2(i - 1)) * Val(n2(i + 1))
                    n2(i + 1) = 0 : n2(i) = "+"
                End If
            Next

            For i = 1 To n11 Step 2 '計算前算是結果
                If n1(i) = "+" Then
                    n1(0) = Val(n1(0)) + Val(n1(i + 1))
                ElseIf n1(i) = "-" Then
                    n1(0) = Val(n1(0)) - Val(n1(i + 1))
                End If
            Next

            For i = 1 To n22 Step 2 '計算後算是結果
                If n2(i) = "+" Then
                    n2(0) = Val(n2(0)) + Val(n2(i + 1))
                ElseIf n2(i) = "-" Then
                    n2(0) = Val(n2(0)) - Val(n2(i + 1))
                End If
            Next

            If n1(0) = n2(0) Then '比對前後是否相等
                sw.WriteLine("TRUE")
            Else : sw.WriteLine("FALSE")
            End If
            ii = sr.ReadLine
            If ii = "" Then
                ii = srr.ReadLine
                If ii = "" Then Exit Do
                If n = 0 Then sw.WriteLine()
                n += 1
            End If
        Loop
        sw.Flush() : sw.Close() : End
    End Sub
End Class
