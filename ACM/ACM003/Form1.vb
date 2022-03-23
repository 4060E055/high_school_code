Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia(2), b As String
    Dim a, x, n As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Do
            ia(a) = Trim(sr.ReadLine)
            If ia(a) = "0 0" Then Exit Do
            a += 1
            ReDim Preserve ia(a)
        Loop

        Dim ib(a - 1, 2) As Integer

        For i = 0 To a - 1
            For j = 1 To Len(ia(i))
                If Microsoft.VisualBasic.Mid(ia(i), j, 1) = " " Then
                    ib(i, 0) = Val(b)
                    b = ""
                Else
                    b &= Microsoft.VisualBasic.Mid(ia(i), j, 1)
                End If
            Next
            ib(i, 1) = Val(b)
            b = ""

            If ib(i, 1) > ib(i, 0) Then
                x = 1
            Else : x = -1
            End If

            For j = ib(i, 0) To ib(i, 1) Step x
                If j Mod 2 = 0 Or j Mod 3 = 0 Or j Mod 5 = 0 Then
                    ib(i, 2) += 1
                End If
            Next
            sw.WriteLine(ib(i, 2))
        Next


        sw.Flush() : sw.Close() : End
    End Sub
End Class
