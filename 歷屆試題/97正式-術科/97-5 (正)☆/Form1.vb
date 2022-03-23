Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("test.txt")
    Dim fw As New FileInfo("result.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As String
    Dim ib(1, 1), n, x As Integer

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
            ReDim ib(1, 1) : n = 0 : x = 0
            For i = 1 To Len(ia)
                If Microsoft.VisualBasic.Mid(ia, i, 1) <> " " Then
                    ib(n, x) = Microsoft.VisualBasic.Mid(ia, i, 1)
                Else
                    x += 1 : If x = 2 Then x = 0 : n += 1
                End If
            Next




        Loop




        sw.Flush() : sw.Close() : End
    End Sub
End Class
