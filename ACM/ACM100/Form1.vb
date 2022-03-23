Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia(3), b As String
    Dim a, aa, z, ic(), n As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        Do
            ia(a) = Trim(sr.ReadLine)
            If ia(a) = "" Then Exit Do
            a += 1
            ReDim Preserve ia(a)
        Loop
        Dim ib(a - 1, 1) As Integer

        For i = 0 To a - 1
            For j = 1 To Len(ia(i))
                If Microsoft.VisualBasic.Mid(ia(i), j, 1) = " " Then
                    ib(i, 0) = Val(b)
                    b = ""
                Else
                    b &= Microsoft.VisualBasic.Mid(ia(i), j, 1)
                End If
            Next
            ib(i, 1) = Val(b)
            b = ""

            If ib(i, 0) > ib(i, 1) Then
                z = -1
            Else
                z = 1
            End If

            ReDim ic(Math.Abs(ib(i, 0) - ib(i, 1)))
            n = 0

            For j = ib(i, 0) To ib(i, 1) Step z
                aa = j

                Do
                    ic(n) += 1
                    If aa Mod 2 = 1 Then
                        aa = 3 * aa + 1
                    Else
                        aa = aa / 2
                    End If
                Loop Until aa = 1
                ic(n) += 1
                n += 1

            Next
            Array.Sort(ic)

          

            sw.WriteLine(ib(i, 0) & " " & ib(i, 1) & " " & ic(n - 1))

        Next





        sw.Flush() : sw.Close() : End
    End Sub
End Class
