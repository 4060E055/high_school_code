Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1.txt")
    Dim frr As New FileInfo("in2.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, gg(21, 4), iaa(3), ibb(20), x, n, o1(4) As Byte

    Dim ib As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Or frr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim srr As StreamReader = frr.OpenText

        gg(1, 4) = 1
        For i = 1 To 20 '照順序輸入5位元的碼
            For j = 0 To 4
                If gg(i, j) = 1 Then
                    For k = 4 To 0 Step -1
                        If gg(i, k) = 0 And k > j Then
                            For l = 0 To 4
                                gg(i + 1, l) = gg(i, l)
                            Next
                            For l = k + 1 To 4
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
  
        For i = 0 To 1 '2個輸入黨
            If i = 0 Then ia = sr.ReadLine
            If i = 1 Then ia = srr.ReadLine
            For j = 1 To ia '每個輸入黨有多少筆資料
                If i = 0 Then ib = Trim(sr.ReadLine)
                If i = 1 Then ib = Trim(srr.ReadLine)
                ReDim iaa(3)

                For k = 0 To 3 '分解每航輸入資料
                    If Asc(Microsoft.VisualBasic.Mid(ib, k + 1, 1)) > 64 And Asc(Microsoft.VisualBasic.Mid(ib, k + 1, 1)) < 91 Then
                        iaa(k) = Val(Asc(Microsoft.VisualBasic.Mid(ib, k + 1, 1))) - 55
                    Else
                        iaa(k) = Microsoft.VisualBasic.Mid(ib, k + 1, 1)
                    End If
                Next

                n = 0 : x = 0 : ReDim o1(4)
                For k = 0 To 3 '轉換為2進為
                    For l = 1 To 4
                        n += 1
                        If n <> 2 ^ x Then
                            ibb(n - 1) = gg(iaa(k), l)
                        Else
                            ibb(n - 1) = 0 : x += 1 : l -= 1
                        End If

                        If ibb(n - 1) = 1 Then '如果該數為1 
                            For m = 0 To 4
                                If gg(n, m) = 1 Then o1(m) += 1
                            Next
                        End If
                    Next
                Next
                For k = 4 To 0 Step -1
                    If o1(k) Mod 2 = 1 Then : sw.Write(1)
                    Else : sw.Write(0)
                    End If
                Next
                sw.WriteLine()
            Next
            sw.WriteLine()
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
