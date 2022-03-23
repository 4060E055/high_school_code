Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, a, b, n As Integer
    Dim abc(15), ans(1) As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行。")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ii = Val(sr.ReadLine)
        b = ii
        Do '轉8進位

            ReDim Preserve ans(n)
            n += 1
            a = ii \ 8
            ans(n - 1) = ii Mod 8
            ii = a
        Loop Until a = 0

        For i = n - 1 To 0 Step -1
            sw.Write(ans(i))
        Next
        sw.Write(vbNewLine)
        For i = 0 To 9 '輸入0-9
            abc(i) = i
        Next

        For i = 10 To 15 '輸入A-F
            abc(i) = Chr(i + 55)
        Next
        n = 0
        Do '轉16進位
            ReDim Preserve ans(n)
            n += 1
            a = b \ 16

            ans(n - 1) = abc(b Mod 16)

            b = a
        Loop Until a = 0
        For i = n - 1 To 0 Step -1
            sw.Write(ans(i))
        Next



        sw.Flush() : sw.Close()
        End
    End Sub
End Class
