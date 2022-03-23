Imports System.IO
Public Class Form1
    Dim a As String
    Dim c() As Integer
    Dim d As Short
    Dim aa As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        T1.Text = ""
        Dim s1 As New FileInfo("123.txt")
        Dim s2 As StreamReader = s1.OpenText
        a = s2.ReadLine
        d = 0
        ReDim c(Len(a) / 2 - 1)
        For i = 0 To Len(a) - 1
            If Asc(Mid(a, i + 1, 1)) <> 32 Then
                c(d) &= Mid(a, i + 1, 1)
            ElseIf Asc(Mid(a, i + 1, 1)) = 32 Then
                d += 1
            End If

        Next
        s2.Close()
        For i = 0 To d - 1
            T1.Text &= c(i) & vbCrLf
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        T2.Text = ""
        Dim s11 As New FileInfo("456.txt")
        Dim s22 As StreamReader = s11.OpenText
        Do
            aa = s22.ReadLine
            T2.Text &= aa & Space(2)
        Loop While aa <> ""
        s2.Close()
    End Sub
End Class
