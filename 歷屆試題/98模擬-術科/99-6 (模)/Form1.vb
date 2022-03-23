Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As Byte
    Dim ib As Double
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ia = sr.ReadLine

        For i = 1 To ia
            ib = sr.ReadLine
            If ib Mod 11 = 0 Then : sw.WriteLine("1")
            Else : sw.WriteLine("0")
            End If
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
