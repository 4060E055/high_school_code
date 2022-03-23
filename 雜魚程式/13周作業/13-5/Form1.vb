Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim n As Integer
    Dim ans As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        n = sr.ReadLine
        For i = 1 To n
            For k = 1 To i
                ans &= k
            Next
            For z = 1 To n - i
                ans &= i
            Next
            For z = n - i To 1 Step -1
                ans &= i
            Next
            For k = i To 1 Step -1
                ans &= k
            Next
            ans &= vbCrLf
        Next
        For i = n To 1 Step -1
            For k = 1 To i
                ans &= k
            Next
            For z = 1 To n - i
                ans &= i
            Next
            For z = n - i To 1 Step -1
                ans &= i
            Next
            For k = i To 1 Step -1
                ans &= k
            Next
            ans &= vbCrLf
        Next

        sw.WriteLine(ans)
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
