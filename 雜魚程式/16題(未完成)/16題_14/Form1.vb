Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii(9) As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        For i = 0 To 9
            ii(i) = sr.ReadLine
        Next
        Array.Sort(ii)
        For i = 0 To 9
            sw.WriteLine(ii(i))
        Next

        sw.Flush() : sw.Close()
        End
    End Sub
End Class
