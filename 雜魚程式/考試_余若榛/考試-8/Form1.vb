Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, n, zz(3), a, b As Integer
    Dim aa As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行。")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ii = sr.ReadLine
        Dim ee(ii * 4, ii - 1) As Integer

        For i = 1 To ii
            ee(a, i - 1) = 1
        Next
        zz(a) = ii
        a += 1

        For i = 2 To ii - 2


            ee(a, b) = i

            For j = 1 To ii - i
                b += 1
                ee(a, b) = 1
            Next

            ReDim Preserve zz(a)
            zz(a) = b + 1
            b = 0

            Do

                For j = 1 To zz(a) - 1

                    For l = zz(a) - 1 To 2 Step -1
                        If ee(a, l) < ee(a, 0) And ee(a, l) <> 0 Then
                            n = l : Exit For
                        End If
                    Next

                    If ee(a, n) + ee(a, j) <= ee(a, 0) And ee(a, j) <> 0 And j <> n Then
                        a += 1
                        For k = 0 To zz(a - 1)
                            If k <> n And k <> j Then
                                ee(a, k) = ee(a - 1, k)
                            ElseIf k = n Then
                                ee(a, k) = ee(a - 1, n) + ee(a - 1, j)
                            End If
                        Next
                        ReDim Preserve zz(a)
                        zz(a) = zz(a - 1)
                    End If
                Next

                For k = 1 To ii - 1  '判斷此算是裡面是否有1 
                    If ee(a, k) = 1 Then   '有的話則繼續該數運算
                        Exit For           '沒有的話則跳至下一數
                    ElseIf k = ii - 1 And ee(a, k) <> 1 Then
                        Exit Do
                    End If
                Next

            Loop
            a += 1


        Next

        ReDim Preserve zz(a + 1):zz(a) = 2
        ee(a, 0) = ii - 1 : ee(a, 1) = 1
        a += 1:ee(a, 0) = ii:zz(a) = 1
      
        For i = 0 To a
            For j = 0 To ii - 1
                For k = 0 To ii - 1
                    If ee(i, j) > ee(i, k) Then
                        n = ee(i, j)
                        ee(i, j) = ee(i, k)
                        ee(i, k) = n
                    End If
                Next
            Next
        Next

        For i = a To 0 Step -1
            sw.Write(vbCrLf & ii & "=")
            For j = 0 To zz(i) - 1
                If ee(i, j) <> 0 Then
                    If j <> 0 And ee(i, j) <> 0 Then
                        sw.Write("+")
                    End If
                    sw.Write(ee(i, j))
                End If
            Next
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
