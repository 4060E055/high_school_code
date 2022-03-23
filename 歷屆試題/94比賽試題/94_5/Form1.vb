Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim a, aa(2), bb(7), ans As String
    Dim n As Byte


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        a = sr.ReadLine
        For i = 0 To 2
            aa(i) = Microsoft.VisualBasic.Mid(a, i + 1, 1)
            ans &= aa(i)
        Next
        For i = Len(a) - 7 To Len(a)
            bb(i + 7 - Len(a)) = Microsoft.VisualBasic.Mid(a, i, 1)
        Next
        For i = 1 To 8
            For j = 1 To 3
                If bb(i - 1) = aa(j - 1) Then Exit For
                If j = 3 Then
                    ans &= bb(i - 1)
                    n += 1
                    If n >= 5 Then GoTo 1
                End If
            Next
        Next
1:      sw.WriteLine(ans)
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
