Imports System.IO
Public Class Form1
    Dim fw As New FileInfo("output.txt") '宣告輸出檔在執行程式的旁邊
    Dim sw As StreamWriter = fw.CreateText
    Dim a(8, 8) As String '輸出檔(2維陣列)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fw.Exists = False Then '如果輸出檔不存在則..
            fw.Create()     '創建輸出檔
        End If
   
        For i = 1 To 9 '建立99乘法表到陣列裡
            For j = 1 To 9
                a(i - 1, j - 1) = i * j & vbTab
            Next
        Next

        For i = 1 To 4 '把上半部三角形原有的字以空白代替
            For j = 5 - i To 3 + i
                a(i, j) = "" & vbTab
            Next
        Next

        For i = 5 To 8 '把下半部三角形原有的字以空白代替
            For j = i - 3 To 11 - i
                a(i, j) = "" & vbTab
            Next
        Next

        For i = 1 To 9 '輸出結果
            For j = 1 To 9
                sw.Write(a(i - 1, j - 1))
            Next
            sw.Write(vbNewLine)
        Next
        sw.Flush() : sw.Close() '檔案存檔  關閉
        End '程式結束執行
    End Sub
End Class
