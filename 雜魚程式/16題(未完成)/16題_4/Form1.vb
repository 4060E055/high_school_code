Imports System.IO
Public Class Form1
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim aa(1), a, n, a123(3) As Integer ' a = 幾種 aa()=答案  a123=分解數

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fw.Exists = False Then
            fw.Create()
        End If
        a = 1
        For j = 4 To 2 Step -1
            a *= j
        Next
        sw.WriteLine(a)

        For i = 1234 To 4321
            For j = 0 To 3
                If Microsoft.VisualBasic.Mid(CStr(i), j + 1, 1) = 0 Or Microsoft.VisualBasic.Mid(CStr(i), j + 1, 1) > 4 Then
                    Exit For
                ElseIf j = 3 Then
                    aa(n) = i
                    n += 1
                    ReDim Preserve aa(n)
                End If
            Next
        Next

        For i = 1 To n
            For j = 0 To 3
                a123(j) = Val(Microsoft.VisualBasic.Mid(CStr(aa(i - 1)), j + 1, 1))
            Next

            For j = 0 To 3
                For k = 0 To 3
                    If j <> k And a123(j) = a123(k) Then aa(i - 1) = 0
                Next
            Next
        Next

        For i = 0 To n - 1
            For j = 0 To n - 1
                If i <> j And aa(i) = aa(j) Then aa(i) = 0
            Next
        Next

        For i = 0 To n - 1
            If aa(i) <> 0 Then sw.WriteLine(aa(i))
        Next

        sw.Flush() : sw.Close()
        End
    End Sub
End Class
