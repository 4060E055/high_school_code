Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, n, a As Byte
    Dim ib(3) As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ia = Trim(sr.ReadLine)


        Do '取數
            ib(n) = Trim(sr.ReadLine)
            If ib(n) = "" Then Exit Do
            n += 1
            ReDim Preserve ib(n)
        Loop

        Dim oa(n - 1, ia) As Integer '每列答案and成績

        For i = 0 To n - 1 '分解數
            a = 0
            For j = 1 To Len(ib(i))
                If Microsoft.VisualBasic.Mid(ib(i), j, 1) <> " " Then
                    oa(i, a) &= Microsoft.VisualBasic.Mid(ib(i), j, 1)
                Else
                    a += 1
                End If
            Next
        Next

        For i = 0 To ia - 1
            For j = 1 To n - 1
                For k = 0 To ia - 1
                    If oa(0, i) = oa(j, k) Then oa(j, k) = (i + 1) * 100 : Exit For
                Next
            Next

        Next
        For i = 0 To ia - 1
            oa(0, i) = (i + 1) * 100
        Next


        For i = 0 To n - 1
            sw.WriteLine()
            For j = 0 To ia - 1
                sw.Write(oa(i, j) / 100 & " ")
            Next
        Next





        sw.Flush() : sw.Close() : End
    End Sub
End Class
