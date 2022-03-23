Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1-2.txt")
    Dim fw As New FileInfo("out1-2.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, aa, bb, cc, a As String
    Dim n, x As Integer

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

            For i = 1 To Len(ii)      
                If Microsoft.VisualBasic.Mid(ii, i + 2, 1) = "a" Or Microsoft.VisualBasic.Mid(ii, i, 1) = "a" Then : x = i : Exit For
                ElseIf Microsoft.VisualBasic.Mid(ii, i, 2) <> "!=" And Microsoft.VisualBasic.Mid(ii, i, 2) <> "==" And i <= 5 Then
                    aa &= Microsoft.VisualBasic.Mid(ii, i, 1)
                ElseIf Microsoft.VisualBasic.Mid(ii, i, 2) = "!=" Or Microsoft.VisualBasic.Mid(ii, i, 2) = "==" Then
                    bb = ""
                    For j = i + 2 To Len(ii)
                        If Microsoft.VisualBasic.Mid(ii, j, 1) = "!" Or Microsoft.VisualBasic.Mid(ii, j, 1) = "=" Then Exit For
                        bb &= Microsoft.VisualBasic.Mid(ii, j, 1) : i += 1
                    Next
                    i += 1
                    If Microsoft.VisualBasic.Mid(ii, i + 1, 2) = "!=" Then
                        If aa <> bb Then : aa = "true"
                        ElseIf aa = bb Then : aa = "false"
                        End If
                    ElseIf Microsoft.VisualBasic.Mid(ii, i + 1, 2) = "==" Then
                        If aa = bb Then : aa = "true"
                        ElseIf aa <> bb Then : aa = "false"
                        End If
                    End If
                End If
            Next
            bb = "true"
1:          For i = Len(ii) To x - 3 Step -1
                If ii = "a" Then
                    a = bb: Exit For
                ElseIf Microsoft.VisualBasic.Mid(ii, i, 2) = "=a" Then
                    If Microsoft.VisualBasic.Mid(ii, i - 1, 2) = "==" Then
                        If aa = "true" Then
                            If bb = "true" Then : a = "true"
                            ElseIf bb = "false" Then : a = "false"
                            End If
                        ElseIf aa = "false" Then
                            If bb = "true" Then : a = "false"
                            ElseIf bb = "false" Then : a = "true"
                            End If
                        End If
                    ElseIf Microsoft.VisualBasic.Mid(ii, i - 1, 2) = "!=" Then
                        If aa = "true" Then
                            If bb = "true" Then : a = "false"
                            ElseIf bb = "false" Then : a = "true"
                            End If
                        ElseIf aa = "false" Then
                            If bb = "true" Then : a = "true"
                            ElseIf bb = "false" Then : a = "false"
                            End If
                        End If
                    End If
                    Exit For
                ElseIf Microsoft.VisualBasic.Mid(ii, i, 1) = "=" Or Microsoft.VisualBasic.Mid(ii, i, 1) = "!" Then
                    cc = ""
                    For j = i + 1 To Len(ii)
                        cc &= Microsoft.VisualBasic.Mid(ii, j, 1)
                    Next
                    If Microsoft.VisualBasic.Mid(ii, i - 1, 2) = "==" Then

                        If bb = "true" Then : bb = cc
                        ElseIf bb = "false" Then
                            If cc = "true" Then : bb = "false"
                            ElseIf cc = "false" Then : bb = "true"
                            End If
                        End If

                    ElseIf Microsoft.VisualBasic.Mid(ii, i - 1, 2) = "!=" Then
                        If cc = "true" Then
                            If bb = "true" Then : bb = "false"
                            ElseIf bb = "false" Then : bb = "true"
                            End If
                        ElseIf cc = "false" Then

                            If bb = "true" Then : bb = "true"
                            ElseIf bb = "false" Then : bb = "false"
                            End If
                        End If
                    End If
                    ii = Microsoft.VisualBasic.Left(ii, i - 2) : GoTo 1
                End If
            Next
            
            For i = 1 To Len(a)
                sw.Write(Chr(Asc(Microsoft.VisualBasic.Mid(a, i, 1)) - 32))
            Next
            sw.WriteLine()
        Loop




        sw.Flush() : sw.Close() : End
    End Sub
End Class
