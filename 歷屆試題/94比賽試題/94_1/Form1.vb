Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim str As String
    Dim io(,), n(), a As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行。")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        str = sr.ReadLine
        ReDim io(Len(str) - 1, 8), n(7)
        For i = 0 To Len(str) - 1
            io(i, 0) = Asc(Microsoft.VisualBasic.Mid(str, i + 1, 1))
            Do
                n(i) += 1
                If n(i) > 3 Then
                    If io(i, 0) Mod 2 = 0 Then
                        io(i, n(i)) = 0
                    Else : io(i, n(i)) = 1
                    End If

                ElseIf n(i) <= 3 Then
                    If io(i, 0) Mod 2 = 1 Then
                        io(i, n(i)) = 0
                    Else : io(i, n(i)) = 1
                    End If
                End If
                io(i, 0) = io(i, 0) \ 2
            Loop Until io(i, 0) = 1
            io(i, n(i) + 1) = 1
            io(i, 0) = 0
        Next

        For i = 0 To Len(str) - 1

            For k = 1 To n(i) + 1
                io(i, 0) += 2 ^ (k - 1) * io(i, k)

            Next
            sw.Write(Chr(io(i, 0)))
        Next

        sw.Flush() : sw.Close()
        End
    End Sub
End Class
