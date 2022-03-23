Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim st1() As String = {"I", "V", "X", "L", "C", "D", "M"}
    Dim st2() As Integer = {1, 5, 10, 50, 100, 500, 1000}

    Dim ss, a As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行。")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ss = sr.ReadLine
        For i = 6 To 0 Step -1
            a = ss \ st2(i)
            For j = 1 To a
                sw.Write(st1(i))
            Next
            ss = ss - a * st2(i)
        Next

        sw.Flush() : sw.Close() : End

    End Sub
End Class
