Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("test.txt")
    Dim fw As New FileInfo("result.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As String
    Dim ib(1), n, alu(2), x As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        Do
            ia = Trim(sr.ReadLine)
            If ia = "" Then Exit Do
            ReDim ib(1) : n = 0
            For i = 1 To Len(ia)
                If Microsoft.VisualBasic.Mid(ia, i, 1) <> " " Then
                    ib(n) &= Microsoft.VisualBasic.Mid(ia, i, 1)
                Else : n += 1
                End If
            Next

            ReDim alu(2) : n = 0

            For i = 2 To ib(0)
                If ib(0) Mod i = 0 Then alu(n) = i : n += 1 : ReDim Preserve alu(n)
            Next
            x = 0
            For i = 0 To n - 1
                If alu(i) Mod ib(1) = 0 Then x += 1
            Next

            sw.WriteLine(x)

        Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
