Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in-4-2-1.txt")
    Dim fr2 As New FileInfo("in-4-2-2.txt")
    Dim fw As New FileInfo("out-4-2.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, mm As Integer
    Dim oo() As Integer = {50, 10, 5, 1}
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Or fr2.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim sr2 As StreamReader = fr2.OpenText
        For i = 0 To 1 '幾個輸入黨
            If i = 0 Then ii = sr.ReadLine
            If i = 1 Then ii = sr2.ReadLine
            For j = 1 To ii '每個輸入黨有多少資料
                If i = 0 Then mm = 100 - Val(sr.ReadLine) '總共找了多少錢
                If i = 1 Then mm = 100 - Val(sr2.ReadLine) '總共找了多少錢
                For k = 0 To 3
                    sw.Write(oo(k) & "," & Fix(mm / oo(k)) & " ")
                    mm = mm - Fix((mm / oo(k))) * oo(k)
                Next
                sw.WriteLine()
            Next
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
