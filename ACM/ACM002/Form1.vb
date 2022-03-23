Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia(2), b As String
    Dim a, x As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        Do
            ia(a) = Trim(sr.ReadLine)
            If ia(a) = "0 0 0" Then Exit Do
            a += 1
            ReDim Preserve ia(a)
        Loop
        Dim ib(a - 1, 2) As Integer

        For i = 0 To a - 1
            x = 0
            For j = 1 To Len(ia(i))
                If Microsoft.VisualBasic.Mid(ia(i), j, 1) = " " Then
                    ib(i, x) = Val(b)
                    b = ""
                    x += 1
                Else
                    b &= Microsoft.VisualBasic.Mid(ia(i), j, 1)
                End If
            Next

            ib(i, x) = Val(b)
            b = ""

            For j = 0 To 2
                For k = 0 To 2
                    If ib(i, j) < ib(i, k) Then
                        x = ib(i, j)
                        ib(i, j) = ib(i, k)
                        ib(i, k) = x
                    End If
                Next
            Next
        Next

        For i = 0 To a - 1
            sw.WriteLine(ib(i, 0) & " " & ib(i, 1) & " " & ib(i, 2))
        Next


        sw.Flush() : sw.Close() : End
    End Sub
End Class
