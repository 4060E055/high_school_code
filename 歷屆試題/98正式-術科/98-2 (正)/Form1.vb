Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, n, nn As Byte
    Dim ic(2), x, qq(2) As Integer
    Dim ib As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ia = sr.ReadLine
        For i = 1 To ia
            ib = Trim(sr.ReadLine)
            ReDim ic(2), qq(2) : n = 0
            For j = 1 To Len(ib)
                If Microsoft.VisualBasic.Mid(ib, j, 1) <> " " Then
                    ic(n) &= Microsoft.VisualBasic.Mid(ib, j, 1)
                Else : n += 1
                End If
            Next

            n = 0 : x = 0 : nn = 0
            For j = 1 To ic(1) '找出循環餘數
                qq(n) = ic(0) ^ j Mod ic(2)
                If qq(n) = qq(nn) And n <> nn Then
                    x += 1 : nn += 1
                    If x = 4 Then
                        ReDim Preserve qq(n - 4) : n -= 3 : Exit For
                    End If
                Else : nn = 0 : x = 0
                End If
                If j = ic(1) Then sw.WriteLine(ic(0) ^ j Mod ic(2)) : GoTo 1
                n += 1 : ReDim Preserve qq(n)
            Next
            x = ic(1) Mod n
            If x = 0 Then x = n
            sw.WriteLine(qq(x - 1))
1:      Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
