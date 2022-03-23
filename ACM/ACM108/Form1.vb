Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, a, b, max As Integer
    Dim ia, ib As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ii = sr.ReadLine
        Dim oa(ii - 1, ii - 1) As Integer

        Do '取數
            ia = Trim(sr.ReadLine) & " "
            For i = 1 To Len(ia)
                If Microsoft.VisualBasic.Mid(ia, i, 1) <> " " Then
                    ib &= Microsoft.VisualBasic.Mid(ia, i, 1)
                Else
                    oa(a, b) = Val(ib) : ib = "":   b += 1
                    If b = ii Then
                        a += 1 : b = 0
                        If a = ii Then Exit Do
                    End If
                End If
            Next
        Loop

        Dim sum(ii * ii - 1, ii - 1, ii - 1) As Integer

        For i = 0 To ii * ii - 1  '計算從第i個數開始到第 (j,l)的矩形加總
            For j = i \ ii To ii - 1
                For l = i Mod ii To ii - 1
                    For o = i \ ii To j
                        For p = i Mod ii To l
                            sum(i, j, l) += oa(o, p)
                        Next
                    Next
                Next
            Next
        Next

        a = 0 : b = 0 : max = 0

        For i = 0 To ii * ii - 1  '輸出
            For j = i \ ii To ii - 1
                For l = i Mod ii To ii - 1
                    If sum(i, j, l) > max Then max = sum(i, j, l)
                Next
            Next
        Next
        
        sw.WriteLine(max)
        sw.Flush() : sw.Close() : End
    End Sub
End Class
