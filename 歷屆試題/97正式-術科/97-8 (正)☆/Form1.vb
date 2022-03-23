Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("test.txt")
    Dim fw As New FileInfo("result.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As String '輸入資料
    Dim n, x(3), a As Integer '        x=上下左右
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        Do
            ia = Trim(sr.ReadLine)
            If ia = "" Then Exit Do


            Dim oa(Math.Ceiling(Len(ia) ^ 0.5) - 1, Math.Ceiling(Len(ia) ^ 0.5) - 1) As String
            x(1) = 0 : x(0) = 0
            x(2) = Math.Ceiling(Len(ia) ^ 0.5) - 1
            x(3) = 0
            n = 0

            For i = 1 To Len(ia)

                Select Case n
                    Case 0 '往右

                        oa(x(0), x(1)) = Microsoft.VisualBasic.Mid(ia, i, 1)
                        x(1) += 1
                        If x(1) = x(2) Then
                            n += 1

                        End If
                    Case 1 '往下

                        oa(x(0), x(1)) = Microsoft.VisualBasic.Mid(ia, i, 1)
                        x(0) += 1
                        If x(0) = x(2) Then
                            n += 1

                        End If
                    Case 2 '往左

                        oa(x(0), x(1)) = Microsoft.VisualBasic.Mid(ia, i, 1)
                        x(1) -= 1
                        If x(1) = x(3) Then
                            n += 1

                        End If
                    Case 3 '往上

                        oa(x(0), x(1)) = Microsoft.VisualBasic.Mid(ia, i, 1)
                        x(0) -= 1
                        If x(0) = x(3) Then
                            x(0) += 1
                            n = 0 : x(2) -= 1 : x(3) += 1
                        End If
                End Select
            Next

            For i = 1 To Math.Ceiling(Len(ia) ^ 0.5)
                For j = 1 To Math.Ceiling(Len(ia) ^ 0.5)
                    If oa(i - 1, j - 1) = "" Then
                        sw.Write("  ")
                    Else : sw.Write(oa(i - 1, j - 1))
                    End If
                Next
                sw.WriteLine()
            Next

            Erase oa
            ia = Trim(sr.ReadLine)
        Loop


        sw.Flush() : sw.Close() : End
    End Sub
End Class
