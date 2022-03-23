Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim x(5) As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        x(0) = sr.ReadLine
        For i = 1 To 5
            x(i) = Microsoft.VisualBasic.Mid(x(0), i, 1)
        Next
        If x(1) = x(5) And x(2) = x(4) Then
            sw.WriteLine("是")
        Else
            sw.WriteLine("否")
        End If

        sw.Flush() : sw.Close()
        End
    End Sub
End Class
