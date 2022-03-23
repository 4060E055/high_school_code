Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim strr(2), ib As String
    Dim inte(2), n As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        Do
            ib = Trim(sr.ReadLine)
            If ib = "right on" Then
                strr(n) = ib
                For i = 0 To n - 1 '判斷是否正確or錯誤
                    If inte(i) > inte(n) And strr(i) = "too low" Then
                        sw.WriteLine(0) : Exit For
                    ElseIf inte(i) < inte(n) And strr(i) = "too high" Then
                        sw.WriteLine(0) : Exit For
                    ElseIf inte(i) = inte(n) And strr(i) <> "right on" Then
                        sw.WriteLine(0) : Exit For
                    ElseIf i = n - 1 Then : sw.WriteLine(1) : Exit For
                    End If
                Next
                ib = Trim(sr.ReadLine)
                If ib <> "0" Then
                    ReDim inte(2), strr(2) : n = 0 : GoTo 1
                Else : Exit Do
                End If
            End If

1:          If Asc(ib) >= 48 And Asc(ib) <= 57 Then '帶入美行
                inte(n) = ib
            Else
                strr(n) = ib
                n += 1 : ReDim Preserve strr(n), inte(n)
            End If
        Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
