Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, a, b As Integer '結果  輸入數
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行。")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ii = Val(sr.ReadLine)
        a = 1
        For i = 1 To ii
            a *= i
        Next

        For i = 0 To ii
            b = 1
            For j = 1 To i
                b *= j
            Next
            For k = 1 To ii - i
                b *= k
            Next

            sw.Write(a / b & " ")
        Next
     
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
