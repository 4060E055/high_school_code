Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, ib As String
    Dim n, x, a, b As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ia = Trim(sr.ReadLine) : ib = Trim(sr.ReadLine)

        Dim oa((Len(ia) - 1) / 2), ob((Len(ib) + 1) \ 4, 1), oc(2) As String
        a = 0
        For i = 1 To Len(ia) '取未知數
            If Microsoft.VisualBasic.Mid(ia, i, 1) <> " " Then
                oa(a) &= Microsoft.VisualBasic.Mid(ia, i, 1)
            Else
                a += 1
            End If
        Next
        x = a
        a = 0 : b = 0
        For i = 1 To Len(ib) '取條件
            If Microsoft.VisualBasic.Mid(ib, i, 1) <> " " Then
                ob(a, b) &= Microsoft.VisualBasic.Mid(ib, i, 1)
            Else
                b += 1
                If b = 2 Then a += 1 : b = 0
            End If
        Next
        n = 0
        

            sw.Flush() : sw.Close() : End
    End Sub
End Class
