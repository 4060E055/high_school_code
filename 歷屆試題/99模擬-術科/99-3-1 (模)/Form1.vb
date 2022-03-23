Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in-3-1.txt")
    Dim fw As New FileInfo("out-3-1.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As String
    Dim n As Byte

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
            n = 0
            For i = 1 To Len(ia) - 1
                '判斷是否是數字接大寫英文
                If Asc(Microsoft.VisualBasic.Mid(ia, i, 1)) >= 48 And _
                   Asc(Microsoft.VisualBasic.Mid(ia, i, 1)) <= 57 And _
                Asc(Microsoft.VisualBasic.Mid(ia, i + 1, 1)) >= 65 And _
                Asc(Microsoft.VisualBasic.Mid(ia, i + 1, 1)) <= 90 Then
                    For j = i + 1 To Len(ia)
                        If n = 3 Then '判斷接下來的是否為數字(因最多中間只有3個大寫英文)
                            If Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) >= 48 And _
                               Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) <= 57 Then
                                sw.WriteLine("有") : Exit For
                            Else : sw.WriteLine("沒有") : Exit For
                            End If
                        ElseIf Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) >= 65 And _
                               Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) <= 90 Then
                            n += 1
                        Else '若以上皆無 則可能為數字or小寫英文
                            If Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) >= 48 And _
                             Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) <= 57 Then
                                sw.WriteLine("有") : Exit For
                            Else : sw.WriteLine("沒有") : Exit For
                            End If
                        End If
                    Next
                    Exit For
                ElseIf i = Len(ia) - 1 Then : sw.WriteLine("沒有")
                End If
            Next
        Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
