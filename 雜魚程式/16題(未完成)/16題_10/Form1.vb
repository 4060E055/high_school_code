Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim i1, i2, ii, ans(1) As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        i1 = sr.ReadLine
        i2 = sr.ReadLine
        If i1 < i2 Then
            ii = i1
            i1 = i2
            i2 = ii
        End If
        ii = 0
        For i = i2 To 1 Step -1
            If i1 Mod i = 0 And i2 Mod i = 0 Then
                ans(ii) = i
                i1 /= i : i2 /= i : ii += 1
                ReDim Preserve ans(ii)
            End If
        Next
        ans(ii) = 1
        For i = 0 To ii - 1
            ans(ii) *= ans(i)
        Next
        sw.WriteLine("最大公因數：" & ans(ii))
        sw.WriteLine("最小公倍數：" & ans(ii) * i1 * i2)
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
