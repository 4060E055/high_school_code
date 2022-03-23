Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ii = sr.ReadLine
        sw.WriteLine(Len(ii))
        For i = Len(ii) To 1 Step -1
            sw.Write(Microsoft.VisualBasic.Mid(ii, i, 1))
        Next
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
