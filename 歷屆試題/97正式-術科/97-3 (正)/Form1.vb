Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("test.txt")
    Dim fw As New FileInfo("result.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, ib(2), a As String
    Dim ic(2), n, oo(2), x As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        Do
            ia = Trim(sr.ReadLine)
            If ia = "END" Then Exit Do

            For i = 1 To Len(ia)
                If Microsoft.VisualBasic.Mid(ia, i, 1) <> " " Then
                    ib(n) &= Microsoft.VisualBasic.Mid(ia, i, 1)
                ElseIf Microsoft.VisualBasic.Mid(ia, i, 1) = " " Then
                    a = ""
                    For j = i + 1 To Len(ia)
                        a &= Microsoft.VisualBasic.Mid(ia, j, 1)
                    Next
                    ic(n) = Val(a)
                    i = Len(ia) + 1
                End If
            Next

            Select Case ib(n)
                Case "Insert"
                    oo(x) = ic(n) : x += 1 : ReDim Preserve oo(x)
                Case "Inquire"
                    Array.Sort(oo) : Array.Reverse(oo)
                    If ic(n) <= x Then
                        sw.WriteLine(oo(ic(n) - 1))
                    End If
                Case "Clean"
                    ReDim oo(2) : x = 0
            End Select
            n += 1 : ReDim Preserve ib(n), ic(n)
        Loop


        sw.Flush() : sw.Close() : End
    End Sub
End Class
