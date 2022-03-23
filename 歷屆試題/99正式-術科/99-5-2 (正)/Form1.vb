Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1.txt")
    Dim frr As New FileInfo("in2.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As String
    Dim ib(4), ic(4), a, n As Byte 'ic=目的排 ib=初始排
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Or frr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim srr As StreamReader = frr.OpenText

        For i = 0 To 1
            If i = 0 Then ia = sr.ReadLine
            If i = 1 Then ia = srr.ReadLine

            For j = 1 To Len(ia)
                ib(j - 1) = j
                ic(j - 1) = Microsoft.VisualBasic.Mid(ia, j, 1)
            Next
1:          n = 5
            Do
                n -= 1
                If ib(n) <> ic(n) Then
                    For k = 0 To 4
                        sw.Write(ib(k))
                    Next
                    sw.WriteLine()
                    For k = 0 To 4
                        If ib(k) = ic(n) Then
                            a = ib(k) : ib(k) = ib(n) : ib(n) = a
                        End If
                    Next
                End If

                If n = 0 Then
                    For k = 0 To 4
                        If ib(n) <> ic(n) Then GoTo 1
                        If k = 4 Then
                            For l = 0 To 4
                                sw.Write(ib(l))
                            Next
                            sw.WriteLine()
                            Exit Do
                        End If
                    Next
                End If
            Loop
            sw.WriteLine()
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
