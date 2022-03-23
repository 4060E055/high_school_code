Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii(9), a, b As Long
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行。")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        For i = 0 To 9
            ii(i) = sr.ReadLine
            If ii(i) >= 0 Then
                a += 1
            ElseIf ii(i) < 0 Then
                b += 1
            End If
        Next
        sw.WriteLine("正值個數：" & a)
        sw.WriteLine("負值個數：" & b)
        If a > b Then
            MsgBox("正值多")
        ElseIf a < b Then
            MsgBox("負值多")
        ElseIf a = b Then
            MsgBox("正負一值樣多")
        End If
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
