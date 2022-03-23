Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ix As Double
    Dim n, ii(1), b As Integer
    Dim a As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        a = sr.ReadLine
        For i = 1 To Len(a) '帶入數
            If Microsoft.VisualBasic.Mid(a, i, 1) <> "/" Then
                ii(n) &= Microsoft.VisualBasic.Mid(a, i, 1)
            Else : n += 1
            End If
        Next

        ix = ii(0) / ii(1)

        For i = 1 To Len(CStr(ix)) '找出她的小數有幾位
            If Microsoft.VisualBasic.Mid(ix, i, 1) = "." Then
                n = Len(CStr(ix)) - i : Exit For
            End If
        Next

        For i = 3 To Len(CStr(ix))
            If Microsoft.VisualBasic.Mid(ix, i, 1) = Microsoft.VisualBasic.Mid(ix, i + 1, 1) Then
                b += 1
                If b >= 6 Then
                    sw.Write(Microsoft.VisualBasic.Left(ix, 8))
                    GoTo 1
                End If
            End If
        Next



        If n > 6 Then
            a = Microsoft.VisualBasic.Mid(ix, Len(CStr(ix)) - n + 1, 2)
            For i = Len(CStr(ix)) - n + 3 To n
                If Microsoft.VisualBasic.Mid(ix, i, 2) = a Then
                    sw.Write(Microsoft.VisualBasic.Left(ix, i - 1))
                    Exit For
                End If
            Next

        ElseIf n <= 6 Then
            sw.Write(ix)
        End If

1:      sw.Flush() : sw.Close() : End
    End Sub
End Class
