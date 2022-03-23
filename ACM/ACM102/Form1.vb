Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii As String
    Dim BGC() As String = {"B", "G", "C"}
    Dim a, b, ib(2), ib2(2), ib3(2), ib1(2), n, aa, bb As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ii = Trim(sr.ReadLine) & " "
        Do
1:          Dim ia(2, 2) As Integer
            a = 0 : b = 0
            For i = 1 To Len(ii)

                If Microsoft.VisualBasic.Mid(ii, i, 1) <> " " Then
                    ia(a, b) &= Microsoft.VisualBasic.Mid(ii, i, 1)

                Else : b += 1
                End If
                If b Mod 3 = 0 And b <> 0 Then
                    a += 1 : b = 0
                End If
            Next
            n = 0
            For i = 0 To 2
                For j = 0 To 2
                    For k = 0 To 2
                        If i <> j And j <> k And i <> k Then
                            ib(n) = ia(0, i) + ia(1, j) + ia(2, k)
                            ib1(n) = i : ib2(n) = j : ib3(n) = k
                            n += 1
                            ReDim Preserve ib(n), ib1(n), ib2(n), ib3(n)
                        End If
                    Next
                Next
            Next

            For i = 0 To n - 1
                For j = 0 To n - 1
                    If ib(i) > ib(j) Then
                        aa = ib(j) : ib(j) = ib(i) : ib(i) = aa
                        aa = ib1(j) : ib1(j) = ib1(i) : ib1(i) = aa
                        aa = ib2(j) : ib2(j) = ib2(i) : ib2(i) = aa
                        aa = ib3(j) : ib3(j) = ib3(i) : ib3(i) = aa
                    End If
                Next
            Next
            aa = 0:bb=0
            For i = 0 To 2
                For j = 0 To 2
                    bb += ia(i, j)
                Next
            Next

            bb -= ib(0)

            For i = 0 To n - 2
                If ib(i) <> ib(i + 1) Then
                    n = i + 1
                    ReDim Preserve ib(n), ib1(n), ib2(n), ib3(n)
                    Exit For
                End If
            Next

            For i = 0 To n - 1
                ib(i) = Asc(BGC(ib3(i))) - Asc(BGC(ib2(i))) - Asc(BGC(ib1(i)))
            Next

            For i = 0 To n - 1
                For j = 0 To n - 1
                    If ib(i) > ib(j) Then
                        aa = ib(j) : ib(j) = ib(i) : ib(i) = aa
                        aa = ib1(j) : ib1(j) = ib1(i) : ib1(i) = aa
                        aa = ib2(j) : ib2(j) = ib2(i) : ib2(i) = aa
                        aa = ib3(j) : ib3(j) = ib3(i) : ib3(i) = aa
                    End If
                Next
            Next

            sw.WriteLine(BGC(ib1(0)) & BGC(ib2(0)) & BGC(ib3(0)) & " " & bb)

            ii = Trim(sr.ReadLine) & " "
        Loop Until ii = " "
        sw.Flush() : sw.Close() : End
    End Sub
End Class
