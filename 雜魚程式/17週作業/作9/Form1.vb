Imports System.IO
Public Class Form1
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim a, n As Long
    Dim ss As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fw.Exists = False Then
            fw.Create()
        End If
        n = 1
        For i = -9990 To 9000
            a = 0 : ss = ""
            For j = 1 To 4
                If i < 0 And Len(CStr(i)) = 5 Then
                    If j = 1 Then
                        ss &= Microsoft.VisualBasic.Mid(i, j, 2)
                        a += Val(ss)
                    Else
                        a += Microsoft.VisualBasic.Mid(i, j + 1, 1)
                    End If
                ElseIf i >= 0 And Len(CStr(i)) = 4 Then
                    a += Microsoft.VisualBasic.Mid(i, j, 1)
                End If
            Next
            If a = 9 Then sw.Write(i & " ") : n += 1
            If n Mod 10 = 0 Then sw.Write(vbCrLf) : n = 1
        Next
        sw.Flush() : sw.Close() : End
    End Sub
End Class
