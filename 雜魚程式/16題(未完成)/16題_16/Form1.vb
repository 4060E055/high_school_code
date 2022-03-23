Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("Input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim inn, ii(), n, x As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If

        Dim sr As StreamReader = fr.OpenText
        inn = Val(sr.ReadLine)
        ReDim ii(inn)

        For i = 1 To inn
            ii(i) = i
        Next

        Do
            For i = 1 To inn
                If ii(i) <> 0 Then
                    x += 1
                End If
                If x = 3 Then
                    ii(i) = 0
                    n += 1
                    x = 0
                End If
                If n = inn - 1 Then Exit Do
            Next
        Loop

        For i = 1 To inn
            If ii(i) <> 0 Then sw.WriteLine(ii(i))
        Next


        sw.Flush() : sw.Close()
        End
    End Sub
End Class
