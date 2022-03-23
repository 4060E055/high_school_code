Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim abc(0), ii, aa, bb As String
    Dim a111(0), n, a As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ii = Trim(sr.ReadLine)
        Do
            For i = 1 To Len(ii) - 1 '取頭尾
                aa = "" : bb = ""
                If i = 1 Then
                    aa = "@" & Microsoft.VisualBasic.Mid(ii, i, 1) & ":"
                ElseIf i = Len(ii) - 1 Then
                    If Asc(Microsoft.VisualBasic.Mid(ii, i + 1, 1)) <= 90 And Asc(Microsoft.VisualBasic.Mid(ii, i + 1, 1)) >= 65 Then
                        bb = Microsoft.VisualBasic.Mid(ii, i + 1, 1) & "@" & ":"
                    Else : bb = Microsoft.VisualBasic.Mid(ii, i, 1) & "@" & ":"
                    End If
                ElseIf Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) > 90 Or Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) < 65 Then
                    aa = "@" & Microsoft.VisualBasic.Mid(ii, i + 1, 1) & ":"
                    bb = Microsoft.VisualBasic.Mid(ii, i - 1, 1) & "@" & ":"
                End If
                For j = 0 To n
                    If aa = abc(j) And aa <> "" Then
                        a111(j) += 1 : Exit For
                    ElseIf j = n And aa <> "" Then
                        n += 1
                        ReDim Preserve abc(n), a111(n)
                        abc(n) = aa : a111(n) += 1
                    End If
                Next
                For j = 0 To n
                    If bb = abc(j) And bb <> "" Then
                        a111(j) += 1 : Exit For
                    ElseIf j = n And bb <> "" Then
                        n += 1
                        ReDim Preserve abc(n), a111(n)
                        abc(n) = bb : a111(n) += 1
                    End If
                Next
            Next


            For i = 1 To Len(ii) - 1 '取任兩個
                aa = "" : bb = ""
                If (Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) <= 90 And Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) >= 65) _
                 And (Asc(Microsoft.VisualBasic.Mid(ii, i + 1, 1)) <= 90 And Asc(Microsoft.VisualBasic.Mid(ii, i + 1, 1)) >= 65) Then
                    aa = Microsoft.VisualBasic.Mid(ii, i, 2) & ":"
                    For j = 0 To n
                        If aa = abc(j) And aa <> "" Then
                            a111(j) += 1 : Exit For
                        ElseIf j = n And aa <> "" Then
                            n += 1
                            ReDim Preserve abc(n), a111(n)
                            abc(n) = aa : a111(n) += 1
                        End If
                    Next
                End If
            Next
            ii = Trim(sr.ReadLine)
        Loop Until ii = ""

        For i = 0 To n
            For j = 0 To n
                If a111(i) > a111(j) Then
                    a = a111(i) : a111(i) = a111(j) : a111(j) = a
                    bb = abc(i) : abc(i) = abc(j) : abc(j) = bb
                End If
            Next
        Next

        For i = 1 To n
            sw.Write(abc(i - 1) & a111(i - 1) & vbTab)
            If i Mod 4 = 0 Then sw.Write(vbCrLf)
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
