Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim zz() As String = {"00--09 ", "10--19 ", "20--29 ", "30--39 ", "40--49 ", "50--59 ", "60--69 ", "70--79 ", "80--89 ", "90--100 "}
    Dim ii, bb(9), a As String
    Dim aa(9) As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ii = Trim(sr.ReadLine)
        Do
            For i = 1 To Len(ii)
                If Microsoft.VisualBasic.Mid(ii, i, 1) <> "," Then
                    a &= Microsoft.VisualBasic.Mid(ii, i, 1)
                ElseIf Microsoft.VisualBasic.Mid(ii, i, 1) = "," Or i = Len(ii) Then
                    If a = "999" Then Exit Do
                    Select Case Val(a)
                        Case 0 To 9
                            aa(0) += 1
                        Case 10 To 19
                            aa(1) += 1
                        Case 20 To 29
                            aa(2) += 1
                        Case 30 To 39
                            aa(3) += 1
                        Case 40 To 49
                            aa(4) += 1
                        Case 50 To 59
                            aa(5) += 1
                        Case 60 To 69
                            aa(6) += 1
                        Case 70 To 79
                            aa(7) += 1
                        Case 80 To 89
                            aa(8) += 1
                        Case 90 To 100
                            aa(9) += 1
                    End Select
                    a = ""
                End If
            Next
            ii = Trim(sr.ReadLine)
        Loop Until ii = ""

        For i = 0 To 9
            If aa(i) Mod 2 = 1 Then aa(i) += 1
        Next

        For i = 0 To 9
            For j = 1 To aa(i) / 2
                If j Mod 10 = 0 Then zz(i) &= "."
                zz(i) &= "*"
            Next
        Next

        For i = 0 To 9
            sw.WriteLine(zz(i))
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
