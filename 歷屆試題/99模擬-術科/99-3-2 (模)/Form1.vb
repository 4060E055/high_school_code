Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in-3-2.txt")
    Dim fw As New FileInfo("out-3-2.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As String
    Dim num(10), n As Byte
    Dim sum As Integer
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

            For i = 1 To Len(ia) - 5
2:              n = 0 : ReDim num(10)
                If Asc(Microsoft.VisualBasic.Mid(ia, i, 1)) >= 65 And _
                    Asc(Microsoft.VisualBasic.Mid(ia, i, 1)) <= 90 And _
                    (Microsoft.VisualBasic.Mid(ia, i + 1, 1) = "2" Or _
                     Microsoft.VisualBasic.Mid(ia, i + 1, 1) = "1") Then
                    num(n) = Microsoft.VisualBasic.Left(Asc(Microsoft.VisualBasic.Mid(ia, i, 1)) - 55, 1)
                    num(n + 1) = Microsoft.VisualBasic.Right(Asc(Microsoft.VisualBasic.Mid(ia, i, 1)) - 55, 1)
                    n += 2
                    For j = i + 1 To i + 9
                        num(n) = Microsoft.VisualBasic.Mid(ia, j, 1) : n += 1
                    Next
                    i += 10 : sum = 0
                    sum += num(0) + num(10)
                    n = 1
                    For j = 9 To 1 Step -1
                        sum += num(n) * j : n += 1
                    Next
                    If sum Mod 10 = 0 Then
                        sw.WriteLine("有") : Exit For
                    Else
                        If Microsoft.VisualBasic.Mid(ia, i, 1) = "," Then : GoTo 2
                        Else : sw.WriteLine("沒有") : Exit For
                        End If
                    End If
                End If
            Next
        Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
