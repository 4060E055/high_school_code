Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1.txt")
    Dim frr As New FileInfo("in2.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As String
    Dim ic(7), ib(7), a As Byte 'ic=1-8 ib=目的
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Or frr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim srr As StreamReader = frr.OpenText

        For i = 0 To 1
            If i = 0 Then ia = Trim(sr.ReadLine)
            If i = 1 Then ia = Trim(srr.ReadLine)

            For j = 1 To Len(ia) '分解排
                ib(j - 1) = j
                ic(j - 1) = Microsoft.VisualBasic.Mid(ia, j, 1)
            Next
1:
            For j = 7 To 0 Step -1
                If ic(j) <> ib(j) Then
                    For k = 0 To 7
                        sw.Write(ib(k))
                    Next
                    sw.WriteLine()
                    For k = 0 To 7
                        If ib(k) = ic(j) Then
                            a = ib(k)
                            For l = k To j - 1
                                ib(l) = ib(l + 1)
                            Next
                            ib(j) = a
                        End If
                    Next
                End If
                If j = 0 Then '檢查是否排玩了
                    For k = 0 To 7
                        If ic(k) <> ib(k) Then GoTo 1
                        If k = 7 Then
                            For l = 0 To 7
                                sw.Write(ib(l))
                            Next
                            sw.WriteLine()
                        End If
                    Next
                End If
            Next
            sw.WriteLine()
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
