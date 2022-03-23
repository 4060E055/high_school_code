Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, ib As String
    Dim ii(100, 2), a, x As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()

        End If
        Dim sr As StreamReader = fr.OpenText
        Do
            ia = sr.ReadLine
            If ia = "0 0" Then Exit Do

            For i = 1 To Len(ia)
                If Microsoft.VisualBasic.Mid(ia, i, 1) = " " Then
                    ii(a, 0) = Val(ib)
                    ib = ""
                Else
                    ib &= Microsoft.VisualBasic.Mid(ia, i, 1)
                End If
            Next

            ii(a, 1) = Val(ib)
            ib = ""
            a += 1
            'ReDim Preserve ii(a, 2)
        Loop

        For i = 0 To a - 1
            If ii(i, 0) > ii(i, 1) Then
                x = ii(i, 1)
            Else
                x = ii(i, 0)
            End If

            For j = x To 1 Step -1
                If ii(i, 0) Mod j = 0 And ii(i, 1) Mod j = 0 Then
                    ii(i, 2) = j : Exit For
                End If
            Next
        Next


        For i = 0 To a - 1
            sw.WriteLine("GCD(" & ii(i, 0) & "," & ii(i, 1) & ")=" & ii(i, 2))
        Next





        sw.Flush() : sw.Close() : End
    End Sub
End Class
