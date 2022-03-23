Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1.txt")
    Dim frr As New FileInfo("in2.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, qq(2), oo(4), a As Integer 'ii=有幾筆資料  qq=每筆交易金額  oo=計算總共找多少零錢
    Dim xx() As Integer = {50, 20, 10, 5, 1}
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Or frr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim srr As StreamReader = frr.OpenText

        For i = 0 To 1
            If i = 0 Then ii = sr.ReadLine
            If i = 1 Then ii = srr.ReadLine
            ReDim qq(ii - 1), oo(4)
            For j = 1 To ii '帶入每筆交易金額
                If i = 0 Then qq(j - 1) = sr.ReadLine
                If i = 1 Then qq(j - 1) = srr.ReadLine
            Next

            For j = 0 To ii - 1
                a = 100 - qq(j)
                For k = 0 To 4 '計算最少找回的零錢
                    If a >= xx(k) Then
                        oo(k) += a \ xx(k)
                        a = a - (a \ xx(k)) * xx(k)
                    End If
                Next
            Next
            For j = 0 To 4
                sw.Write(xx(j) & "," & oo(j) & " ")
            Next
            sw.WriteLine(vbNewLine)
        Next
        sw.Flush() : sw.Close() : End
    End Sub
End Class
