Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, n, x, a, b As Integer
    Dim ib, aa As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ia = 0
        Do '取合
2:          If aa = " " Then
                Exit Do
            Else : ia &= Val(aa)
            End If
            aa = Chr(sr.Read)
        Loop

        ib = Trim(sr.ReadLine)
1:      n = 0 : a = 0 : b = 0
        Dim ic(2) As String
        For i = 1 To Len(ib) '分解輸入
            n += 1 : ReDim Preserve ic(n)
            If (Asc(Microsoft.VisualBasic.Mid(ib, i, 1)) > 47 And Asc(Microsoft.VisualBasic.Mid(ib, i, 1)) < 58) Then
                Do
                    If Asc(Microsoft.VisualBasic.Mid(ib, i, 1)) < 48 Or Asc(Microsoft.VisualBasic.Mid(ib, i, 1)) > 57 Then i -= 1 : Exit Do
                    ic(n) &= Microsoft.VisualBasic.Mid(ib, i, 1)
                    If i = Len(ib) Then GoTo 4
                    i += 1
                Loop
            ElseIf Microsoft.VisualBasic.Mid(ib, i, 1) = "(" Then
                ic(n) = Microsoft.VisualBasic.Mid(ib, i, 1) : a += 1
            ElseIf Microsoft.VisualBasic.Mid(ib, i, 1) = ")" Then
                ic(n) = Microsoft.VisualBasic.Mid(ib, i, 1) : b += 1
            End If
4:          If i = Len(ib) And a <> b Then
                ib &= Trim(sr.ReadLine) : GoTo 1
            End If
        Next
        Dim oa(2), ob(2) As Integer : x = 0
        For i = 0 To n - 4 '找出最尾端的數在哪
            aa = ""
            For j = i To i + 4
                aa &= ic(j)
                If aa = "()()" Then
                    oa(x) += ic(i - 1) : ob(x) = i - 1
                    x += 1 : ReDim Preserve oa(x), ob(x)
                End If
            Next
        Next

        For i = 0 To x - 1 '從尾端往回找出數來加
            a = 0 : b = 0
            For j = ob(i) - 1 To 1 Step -1
                If Asc(ic(j)) > 47 And Asc(ic(j)) < 58 And a > b Then
                    oa(i) += ic(j)
                ElseIf ic(j) = "(" Then
                    a += 1
                ElseIf ic(j) = ")" Then
                    b += 1
                End If
            Next
            If oa(i) = ia Then sw.WriteLine("yes") : GoTo 3 : Exit For
        Next
        sw.WriteLine("no")
3:      aa = Trim(Chr(sr.Read)) '若還有  則從頭開始繼續運算
        If Val(aa) <> 0 Then ia = 0 : GoTo 2

        sw.Flush() : sw.Close() : End
    End Sub
End Class
