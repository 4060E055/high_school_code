Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii As String
    Dim a(1), n, b, c As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ii = Trim(sr.ReadLine)
        For i = 1 To Len(ii) '取範圍
            If Microsoft.VisualBasic.Mid(ii, i, 1) <> " " Then
                a(n) &= Microsoft.VisualBasic.Mid(ii, i, 1)
            Else
                n += 1
            End If
        Next

        Dim ia(a(0) - 1, a(1) - 1) As Integer
        b = 0 : c = 0
        Do '取數
            ii = Trim(sr.ReadLine) & " "

            For i = 1 To Len(ii)
                If Microsoft.VisualBasic.Mid(ii, i, 1) <> " " Then
                    ia(b, c) &= Microsoft.VisualBasic.Mid(ii, i, 1)
                Else
                    c += 1
                    If c = a(1) Then
                        b += 1 : c = 0
                        If b = a(0) Then Exit Do
                    End If
                End If
            Next
        Loop
        b = ia(0, 0)
        For i = 1 To a(0) - 1
            If b > ia(i, 0) Then b = ia(i, 0) : c = i
        Next





        sw.Flush() : sw.Close() : End
    End Sub
End Class
