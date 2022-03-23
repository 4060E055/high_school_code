Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, n, a, b As Integer 'ii=幣種  
    Dim aa, bb As String '取數用
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText


        ii = Val(Trim(sr.ReadLine))
1:      Dim ai(ii - 1, ii - 1), ss, s1 As Single '每個ㄉ匯率(包刮自己)  ss=%率

        For i = 0 To ii - 1 '取數
            n = 0 : bb = ""
            aa = Trim(sr.ReadLine) & " "
            ai(i, i) = 1 '把本身也帶入
            For j = 1 To Len(aa)
                If Microsoft.VisualBasic.Mid(aa, j, 1) <> " " Then
                    bb &= Microsoft.VisualBasic.Mid(aa, j, 1)
                Else
                    If i = n Then n += 1
                    ai(i, n) = Val(bb) : n += 1 : bb = ""
                End If
            Next
        Next

        b = 0 : ss = 1 : n = 0 : aa = 1 & " "

        Do
            n += 1
            s1 = 0
            For i = 0 To ii - 1 '找出該幣種中最大ㄉ換算匯率 b=目前換算到ㄉ幣種-1
                If s1 < ai(b, i) And ai(b, i) <> 1 Then s1 = ai(b, i) : bb = i
            Next
            b = Val(bb) : ss *= s1 : aa &= b + 1 & " "
            '如果轉換回一開始ㄉ幣值時獲利>1% 則輸出
            If ss * ai(b, 0) > 1.01 Then sw.WriteLine(aa & "1") : Exit Do

        Loop Until n = ii

        If n=ii then sw.WriteLine("no arbitrage sequence exists")
        ii = Val(Trim(sr.ReadLine))
        If ii <> 0 Then GoTo 1
        sw.Flush() : sw.Close() : End
    End Sub
End Class
