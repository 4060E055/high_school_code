Imports System.IO
Public Class Form1
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim b, c, d As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      If fw.Exists = False Then
            fw.Create()
        End If
        b = 1
        For i = 1 To 12
            sw.Write(b & " ")
            d = b
            b = c + b
            c = d
        Next
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
