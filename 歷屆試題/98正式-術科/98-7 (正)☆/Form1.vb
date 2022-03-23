Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, n As Byte
    Dim ib As String
    Dim su, ic(2), a, b As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ia = sr.ReadLine

        For i = 1 To ia
            ib = Trim(sr.ReadLine)
            ReDim ic(2) : n = 0 : su = 0
            For j = 1 To Len(ib) '帶入該行資料
                If Microsoft.VisualBasic.Mid(ib, j, 1) <> " " Then
                    ic(n) &= Microsoft.VisualBasic.Mid(ib, j, 1)
                ElseIf Microsoft.VisualBasic.Mid(ib, j, 1) = " " Then
                    n += 1 : ReDim Preserve ic(n)
                    su += ic(n - 1)
                End If
            Next
            su += ic(n)
            If su Mod 4 <> 0 Then sw.WriteLine(0) : GoTo 1
            b = 4
            su = su / 4

            For j = 0 To n
                For k = 0 To n
                    If ic(j) + ic(k) = su And k <> j And ic(j) <= su And ic(k) <= su Then
                        ic(j) = -1 : ic(k) = -1 : b -= 1
                    ElseIf ic(j) = -1 Then : Exit For
                    End If
                Next
            Next


            Array.Sort(ic)

            a = 0
            For j = 0 To n
                If ic(j) <> -1 Then
                    For k = 0 To n
                        If ic(k) <> -1 Then a += ic(k)
                    Next
                    If a Mod b = 0 And a Mod su = 0 Then
                       



                        sw.WriteLine(1) : Exit For
                    Else : sw.WriteLine(0) : Exit For
                    End If
                End If

                If j = n Then sw.WriteLine(1)
            Next




1:      Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
