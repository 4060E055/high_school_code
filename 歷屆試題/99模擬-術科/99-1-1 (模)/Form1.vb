Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in-1-1.txt")
    Dim fw As New FileInfo("out-1-1.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, abc(25) As Integer
    Dim ia As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ii = sr.ReadLine
        For i = 1 To ii '每行每行檢查
            ia = Trim(sr.ReadLine)
            For j = 1 To Len(ia) '判斷是大寫還小寫在計數
                If Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) >= 65 And Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) <= 90 Then
                    abc(Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) - 65) += 1
                ElseIf Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) >= 97 And Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) <= 122 Then
                    abc(Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) - 97) += 1
                End If
            Next
        Next

        For i = 0 To 25
            sw.Write("(" & Chr(i + 65) & "," & abc(i) & ")" & " ")
            If (i + 1) Mod 5 = 0 Then sw.WriteLine()
        Next
        sw.Flush() : sw.Close() : End
    End Sub
End Class
