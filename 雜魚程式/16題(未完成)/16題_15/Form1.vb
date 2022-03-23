Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim gg(9), n As Long
    Dim a, b As String


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        For i = 1 To 3
            a = sr.ReadLine & " "
            For j = 1 To Len(a)
                If Microsoft.VisualBasic.Mid(a, j, 1) <> " " Then
                    b &= Microsoft.VisualBasic.Mid(a, j, 1)
                ElseIf Microsoft.VisualBasic.Mid(a, j, 1) = " " Then
                    gg(n) = Val(b) : n += 1 : b = ""
                End If
            Next
        Next
        gg(n) = gg(0) + gg(2) + gg(4) * 2 + gg(6) + gg(8)
        sw.WriteLine(gg(n))

        sw.Flush() : sw.Close() : End
    End Sub
End Class
