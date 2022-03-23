Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii(1), n, a, b As Integer
    Dim iii As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        iii = sr.ReadLine
        Do While iii <> ""
            ii(n) = Val(iii)
            If ii(n) Mod 2 = 1 Then a += 1
            If ii(n) Mod 2 = 0 Then b += 1
            n += 1
            ReDim Preserve ii(n)
            iii = sr.ReadLine
        Loop
        sw.WriteLine("奇數：" & a & "個")
        sw.WriteLine("偶數：" & b & "個")

        For i = 0 To n - 1
            a = 0 : b = 0
            If ii(i) Mod 2 = 0 Then
                For j = ii(i) - 1 To ii(i) / 2 Step -1
                    For jj = 2 To j - 1
                        If j Mod jj = 0 Then
                            Exit For
                        ElseIf jj = j - 1 And a = 0 Then
                            a = j
                        ElseIf jj = j - 1 And b = 0 Then
                            b = j
                        End If
                    Next
                    If a <> 0 And b <> 0 Then Exit For
                Next
                For k = 1 To 7 Step 2
                    If ii(i) = a + k Then
                        sw.WriteLine(ii(i) & " = " & a & " + " & k)
                    End If
                Next
            End If
        Next

        sw.Flush() : sw.Close()
        End
    End Sub
End Class
