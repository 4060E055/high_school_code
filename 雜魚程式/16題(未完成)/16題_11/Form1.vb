Imports System.IO
Public Class Form1
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ee(1), n, aa As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fw.Exists = False Then
            fw.Create()
        End If

        For i = 2 To 1000

            For j = i - 1 To 2 Step -1
                If i Mod j = 0 Then
                    ee(n) = j
                    n += 1

                    ReDim Preserve ee(n)
                End If
            Next

            For k = 0 To n - 1
                ee(n) += ee(k)
            Next

            If ee(n) + 1 = i Then sw.WriteLine(i)

            ReDim ee(1)
            n = 0
        Next
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
