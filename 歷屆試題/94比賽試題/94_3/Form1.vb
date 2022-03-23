Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii(1, 2), a, b As Short
    Dim inn, aa As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("input.txt不存在，程式即將結束執行。")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        inn = sr.ReadLine
        For i = 1 To Len(inn)
            If Microsoft.VisualBasic.Mid(inn, i, 1) <> "," Then
                aa &= Microsoft.VisualBasic.Mid(inn, i, 1)
            Else
                ii(a, b) = Val(aa)
                aa = ""
                b += 1
                If b = 3 Then a += 1 : b = 0
            End If
        Next
        ii(1, 2) = Val(aa)
        a = ii(0, 0) : b = ii(1, 0)

        If ii(0, 0) * b = ii(1, 0) * a Then
            b = -((ii(0, 2) * b - ii(1, 2) * a) / (ii(0, 1) * b - ii(1, 1) * a))
        ElseIf ii(0, 0) * b <> ii(1, 0) * a Then
            b = -((ii(0, 2) * b + ii(1, 2) * a) / (ii(0, 1) * b + ii(1, 1) * a))
        End If
        a = -((ii(0, 2) + b * ii(0, 1)) / ii(0, 0))
        sw.WriteLine("X=" & a & vbNewLine & "Y=" & b)
        sw.Flush() : sw.Close()
        End

    End Sub
End Class
