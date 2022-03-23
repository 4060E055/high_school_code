Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii(1), nn(), a, x, z As Short '輸入數 多少數 
    Dim inn, aa As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("input.txt不存在，程式即將結束執行。")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        inn = sr.ReadLine
        For i = 1 To Len(inn) '取數
            If Microsoft.VisualBasic.Mid(inn, i, 1) = "," Then
                If aa = "0" Then Exit For
                ii(a) = Val(aa)
                aa = ""
                a += 1
                ReDim Preserve ii(a)
            ElseIf Microsoft.VisualBasic.Mid(inn, i, 1) <> "," Then
                aa &= Microsoft.VisualBasic.Mid(inn, i, 1)
            End If
        Next

        For i = 0 To a - 1 '計算平均數
            x += ii(i)
        Next
        sw.WriteLine("平均數：" & Format(x / a), "###.0#")


        For i = 0 To a - 1 '計算變異數
            z += (ii(i) - (x / a)) ^ 2
        Next
        sw.WriteLine("變異數：" & Microsoft.VisualBasic.Left(z / (a - 1), 4))


        If a Mod 2 = 1 Then '計算中位數
            sw.WriteLine("中位數：" & ii(a \ 2 + 1))
        ElseIf a Mod 2 = 0 Then
            sw.WriteLine("中位數：" & (ii(a / 2) + ii(a / 2 + 1)) / 2)
        End If
        ReDim Preserve nn(a - 1)

        For i = 0 To a - 1 '計算眾數
            For j = 0 To a - 1
                If ii(i) = ii(j) Then
                    nn(i) += 1
                End If
            Next
        Next
        sw.Write("眾　數：")

        For i = 0 To a - 1
            For j = 0 To a - 1
                If i <> j And ii(i) = ii(j) Then
                    ii(j) = 0
                    nn(j) = 0
                End If
            Next
        Next

        For i = 0 To a - 1
            For j = 0 To a - 1
                If nn(i) < nn(j) Then
                    Exit For
                ElseIf j = a - 1 Then
                    sw.Write(ii(i) & Space(2))
                End If
            Next
        Next
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
