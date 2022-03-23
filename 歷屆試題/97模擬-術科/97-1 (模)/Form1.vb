Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("test.txt")
    Dim fw As New FileInfo("result.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As Byte
    Dim ib As String
    Dim oa(2) As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ia = sr.ReadLine
        For i = 1 To ia
            ReDim oa(2)
            Do
                ib = Trim(sr.ReadLine)

                If ib = "=====" Then

                    For j = 0 To 2
                        sw.Write(oa(j) & " ")
                    Next

                    sw.WriteLine()
                    Exit Do
                ElseIf ib = "" Then

                    ib = Trim(sr.ReadLine)
                    If ib = "" Then
                        For j = 0 To 2
                            sw.Write(oa(j) & " ")
                        Next
                        sw.WriteLine()
                        Exit Do
                    End If

                    oa(0) += 1
                End If

                oa(2) += Len(ib)
                oa(0) += 1

                For j = 1 To Len(ib)
                    If Microsoft.VisualBasic.Mid(ib, j, 1) = " " Then
                        oa(1) += 1
                    End If
                Next
                oa(1) += 1
            Loop
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
