Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1.txt")
    Dim frr As New FileInfo("in2.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim abc() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", _
            "M", "N", "P", "Q", "R", "S", "T", "U", "V", "X", "Y", "W", "Z", "I", "O"}
    Dim num(8), inn, x As Byte 'num=輸入資料  inn=該黨有多少筆輸入資料
    Dim imm As String 'imm=每航輸入資料
    Dim sum, n, xx(2), ouu(2), p As Integer 'sum=資料加總 xx=計算加總後再找出家那些數可以被10整除

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Or frr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim srr As StreamReader = frr.OpenText


        For i = 0 To 1 '兩個檔案
            If i = 0 Then inn = sr.ReadLine
            If i = 1 Then inn = srr.ReadLine
            For j = 1 To inn '每個檔案有多少筆資料
                If i = 0 Then imm = Trim(sr.ReadLine)
                If i = 1 Then imm = Trim(srr.ReadLine)
                ReDim num(8)
                n = 8 : sum = 0
                For k = 0 To 8
                    num(k) = Microsoft.VisualBasic.Mid(imm, k + 1, 1)
                    If k <> 8 Then '計算加總
                        sum += num(k) * n : n -= 1
                    Else
                        n += 1 : sum += num(k) * n
                    End If
                Next

                ReDim xx(2) : n = 0

                For l = 1 To 100
                    If (sum + l) Mod 10 = 0 Then
                        xx(n) = l : n += 1 : ReDim Preserve xx(n)
                    End If
                Next

                ReDim ouu(2) : x = 0

                For l = 0 To n - 1
                    p = xx(l) \ 9
                    p = (xx(l) - (xx(l) \ 9) * 9) & p

                    If p <= 35 And p > 9 And xx(l) - (xx(l) \ 9) * 9 <> 0 Then
                        ouu(x) = Asc(abc(p - 10))
                        x += 1 : ReDim Preserve ouu(x)
                    End If
                Next

                ReDim Preserve ouu(x - 1)
                Array.Sort(ouu)
                For l = 0 To x - 1 '照字母順序輸出
                    sw.Write(Chr(ouu(l)))
                Next
                sw.WriteLine()
            Next
            sw.WriteLine()
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
