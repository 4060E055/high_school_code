Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in-3-2-1.txt")
    Dim fr2 As New FileInfo("in-3-2-2.txt")
    Dim fw As New FileInfo("out-3-2.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, x, ia, n As Integer
    Dim ia2(10), gg(10, 3), oa(11, 3) As Byte

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Or fr2.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim sr2 As StreamReader = fr2.OpenText

        gg(0, 3) = 1
        For i = 0 To 9 '照順序輸入4位元的碼
            For j = 0 To 3
                If gg(i, j) = 1 Then
                    For k = 3 To 0 Step -1
                        If gg(i, k) = 0 And k > j Then
                            For l = 0 To 3
                                gg(i + 1, l) = gg(i, l)
                            Next
                            For l = k + 1 To 3
                                gg(i + 1, l) = 0
                            Next
                            gg(i + 1, k) = 1 : Exit For
                        ElseIf gg(i, k) = 0 And k < j Then
                            gg(i + 1, k) = 1
                            Exit For
                        End If
                    Next
                End If
            Next
        Next

        For i = 0 To 1 '2個輸入檔
            If i = 0 Then ii = sr.ReadLine
            If i = 1 Then ii = sr2.ReadLine
            For j = 1 To ii '每個輸入檔有幾筆資料要運算
                If i = 0 Then ia = Asc(Trim(sr.ReadLine))
                If i = 1 Then ia = Asc(Trim(sr2.ReadLine))
                n = 10 : x = 0
                Do '將asc碼轉換成2進位資料   
                    ia2(n) = ia Mod 2
                    If ia Mod 2 = 1 Then x += 1
                    ia \= 2 : n -= 1
                    If n = 0 Or n = 1 Or n = 3 Or n = 7 Then '除掉1 2 4 8 的位置
                        n -= 1
                    End If
                    If ia = 1 Then
                        ia2(n) = 1 : Exit Do
                    End If
                Loop


                ReDim oa(11, 3)
                For k = 0 To 10
                    If ia2(k) = 1 Then
                        For l = 0 To 3
                            oa(k, l) = gg(k, l)
                        Next
                    End If
                Next

                x = 0
                For k = 0 To 3
                    For l = 0 To 10 '算出第k處有幾個1
                        If oa(l, k) = 1 Then x += 1
                    Next
                    If x Mod 2 = 1 Then : oa(11, k) = 1 '檢查是偶數個1還是基數個1
                    Else : oa(11, k) = 0
                    End If
                    x = 0
                Next

                For k = 3 To 0 Step -1
                    sw.Write(oa(11, k))
                Next
                sw.WriteLine()
            Next
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
