Imports System.IO
Public Class Form1
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fw.Exists = False Then fw.Create()



        sw.Flush() : sw.Close() : End
    End Sub
End Class
