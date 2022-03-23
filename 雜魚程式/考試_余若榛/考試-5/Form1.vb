Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim st1() As String = {"I", "V", "X", "L", "C", "D", "M"}
    Dim st2() As Integer = {1, 5, 10, 50, 100, 500, 1000}
    Dim ss As String
    Dim aa As integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行。")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ss = sr.ReadLine
        For i = 1 To Len(ss)
            For j = 1 To 7
                If Microsoft.VisualBasic.Mid(ss, i, 1) = st1(j - 1) Then
                    sw.WriteLine(st1(j - 1) & " = " & st2(j - 1))
                    aa += st2(j - 1)
                End If
            Next
        Next
        sw.Write(ss & " = " & aa)
        sw.Flush() : sw.Close() : End
    End Sub
End Class
