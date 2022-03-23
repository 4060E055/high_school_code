Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim n, a, b, c, d, ini As Integer
    Dim ib(3), ii, mm As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ii = Trim(sr.ReadLine)
2:      Dim ia(Val(ii) - 1, Val(ii) - 1) As String
        ini = ii
        For i = 0 To Val(ii - 1)
            ia(i, 0) = i
        Next

        Do
            ii = Trim(sr.ReadLine) & " "
            If ii = "quit " Then Exit Do
            n = 0
            For j = 1 To Len(ii)
                If Microsoft.VisualBasic.Mid(ii, j, 1) = " " Then
                    ib(n) = mm
                    n += 1
                    mm = ""
                Else
                    mm &= Microsoft.VisualBasic.Mid(ii, j, 1)
                End If
            Next

            For i = 0 To ini - 1
                For j = 0 To ini - 1
                    If ia(i, j) = "" Then
                        Exit For
                    ElseIf CStr(ib(1)) = ia(i, j) Then
                        a = i : b = j
                    ElseIf CStr(ib(3)) = ia(i, j) Then
                        c = i : d = j
                    End If
                Next
            Next

            If a = c Or ib(1) = ib(3) Then GoTo 1

            If ib(0) = "move" And ib(2) = "onto" Then

                If ia(a, b + 1) <> "" Then
                    For i = b + 1 To ini - 1
                        If ia(a, i) = "" Then Exit For
                        ia(ia(a, i), 0) = ia(a, i) : ia(a, i) = ""
                    Next
                End If

                If ia(c, d + 1) <> "" Then
                    For i = d + 1 To ini - 1
                        If ia(c, i) = "" Then Exit For
                        ia(ia(c, i), 0) = ia(c, i) : ia(c, i) = ""
                    Next
                End If

                ia(c, d + 1) = ia(a, b) : ia(a, b) = ""

            ElseIf ib(0) = "move" And ib(2) = "over" Then

                If ia(a, b + 1) <> "" Then
                    For i = b + 1 To ini - 1
                        If ia(a, i) = "" Then Exit For
                        ia(ia(a, i), 0) = ia(a, i) : ia(a, i) = ""
                    Next
                End If


                For i = d + 1 To ini - 1
                    If ia(c, i) = "" Then
                        ia(c, i) = ia(a, b) : ia(a, b) = "" : Exit For
                    End If
                Next

            ElseIf ib(0) = "pile" And ib(2) = "onto" Then

                If ia(c, d + 1) <> "" Then
                    For i = d + 1 To ini - 1
                        If ia(c, i) = "" Then Exit For
                        ia(ia(c, i), 0) = ia(c, i) : ia(c, i) = ""
                    Next
                End If

                For i = b To ini - 1
                    If ia(a, i) = "" Then Exit For
                    d += 1 : ia(c, d) = ia(a, i) : ia(a, i) = ""
                Next

            ElseIf ib(0) = "pile" And ib(2) = "over" Then

                For i = d + 1 To ini - 1
                    If ia(a, b) = "" Then Exit For
                    If ia(c, i) = "" Then
                        ia(c, i) = ia(a, b) : ia(a, b) = "" : b += 1
                    End If
                Next

            End If
1:
        Loop

        For i = 0 To ini - 1
            sw.Write(i & ": ")
            For j = 0 To ini - 1
                If ia(i, j) = "" Then Exit For
                sw.Write(ia(i, j) & " ")
            Next
            sw.Write(vbNewLine)
        Next
        ii = Trim(sr.ReadLine)
        If ii <> "" Then GoTo 2

        sw.Flush() : sw.Close() : End
    End Sub
End Class
