Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim mm(3) As Long
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        For i = 0 To 2
            mm(i) = sr.ReadLine
        Next

        If mm(0) >= 100 Then
            If mm(0) Mod 4 = 0 And mm(0) Mod 100 <> 0 Then
                mm(3) += 1
            ElseIf mm(0) Mod 400 = 0 Then
                mm(3) += 1
            End If
        ElseIf mm(0) < 100 Then
            If mm(0) Mod 4 = 0 Then
                mm(3) += 1
            End If
        End If
        Select Case mm(1) - 1
            Case 1
                mm(3) += 31
            Case 2
                mm(3) += 59
            Case 3
                mm(3) += 90
            Case 4
                mm(3) += 120
            Case 5
                mm(3) += 151
            Case 6
                mm(3) += 181
            Case 7
                mm(3) += 212
            Case 8
                mm(3) += 243
            Case 9
                mm(3) += 273
            Case 10
                mm(3) += 304
            Case 11
                mm(3) += 334
        End Select
        mm(3) += mm(2)


        sw.WriteLine("第" & mm(3) & "天")
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
