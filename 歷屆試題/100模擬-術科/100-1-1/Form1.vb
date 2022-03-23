Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1-1.txt")
    Dim fw As New FileInfo("out1-1.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, aa, bb, cc As String
    Dim n As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        Do
            ii = sr.ReadLine
            If ii = "" Then Exit Do
            aa = ""
            For i = 1 To Len(ii)

                If Microsoft.VisualBasic.Mid(ii, i, 2) <> "!=" And Microsoft.VisualBasic.Mid(ii, i, 2) <> "==" And i <= 5 Then
                    aa &= Microsoft.VisualBasic.Mid(ii, i, 1)
                Else
                    bb = ""
                    For j = i + 2 To Len(ii)
                        If Microsoft.VisualBasic.Mid(ii, j, 1) = "!" Or Microsoft.VisualBasic.Mid(ii, j, 1) = "=" Then Exit For
                        bb &= Microsoft.VisualBasic.Mid(ii, j, 1)
                    Next
                    If Microsoft.VisualBasic.Mid(ii, i, 2) = "!=" Then
                        If aa <> bb Then : aa = "true"
                        ElseIf aa = bb Then : aa = "false"
                        End If
                    ElseIf Microsoft.VisualBasic.Mid(ii, i, 2) = "==" Then
                        If aa = bb Then : aa = "true"
                        ElseIf aa <> bb Then : aa = "false"
                        End If
                    End If

                End If
            Next
            For i = 1 To Len(aa)
                sw.Write(Chr(Asc(Microsoft.VisualBasic.Mid(aa, i, 1)) - 32))
            Next
            sw.WriteLine()

        Loop




        sw.Flush() : sw.Close() : End
    End Sub
End Class
