Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("test.txt")
    Dim fw As New FileInfo("result.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As String '每航輸入
    Dim ib(1), ic(2), icc(2), oo(2), n, a As Integer 'ib=n位,刪除k個 ic=個別帶入數 icc=用來找出大到小 oo=輸出資料 n=計數用
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
            ReDim ib(1), ic(2) : n = 0

            For i = 1 To Len(ia)
                If Microsoft.VisualBasic.Mid(ia, i, 1) <> " " Then
                    ib(n) &= Microsoft.VisualBasic.Mid(ia, i, 1)
                Else : n += 1
                End If
            Next

            ia = Trim(sr.ReadLine)
            ReDim ic(Len(ia - 1) - 1), icc(Len(ia - 1) - 1), oo(ib(0) - ib(1) - 1) : n = 0
            For i = 1 To Len(ia)
                ic(i - 1) = Microsoft.VisualBasic.Mid(ia, i, 1)
                icc(i - 1) = ic(i - 1)
            Next

            Array.Sort(icc)
            Array.Reverse(icc) : Array.Reverse(ic)
            n = ib(0) - ib(1) - 1
            For i = 0 To ib(0) - 1
                For j = 0 To ib(0) - 1
                    If icc(i) = ic(j) Then
                        If j > ib(0) - ib(1) - 1 Then
                            oo(n) = ic(j) : n -= 1
                            If n = -1 Then GoTo 1
                        ElseIf j = ib(0) - ib(1) - 1 Then
                            For k = j To ib(0) - 1
                                oo(k - j) = ic(k)
                            Next
                            GoTo 1
                        Else
                            a = ib(0) - ib(1) - 1
                            For k = j To ib(0) - 1
                                oo(a - 1) = ic(k) : a += 1
                            Next
                            If a = ib(0) - ib(1) Then GoTo 1
                        End If
                    End If
                Next
            Next
1:
            For i = 0 To ib(0) - ib(1) - 1
                sw.Write(oo(i))
            Next

            sw.WriteLine()
        Loop
        sw.Flush() : sw.Close() : End
    End Sub
End Class
