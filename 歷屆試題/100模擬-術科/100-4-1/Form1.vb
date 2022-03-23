Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in4-1-1.txt")
    Dim fr2 As New FileInfo("in4-1-2.txt")
    Dim fw As New FileInfo("out4-1.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii(1), a, b As Integer
    Dim ib, aa As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False And fr2.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim sr2 As StreamReader = fr2.OpenText

        ii(0) = Trim(sr.ReadLine)
        ii(1) = Trim(sr2.ReadLine)
        Dim ia(ii(0) + ii(1) - 1, 9) As String '輸入每組資料排的花色與數字
        For l = 0 To 1 '2個輸入檔
            For i = 0 To ii(l) - 1
                If l = 0 Then ib = Trim(sr.ReadLine)
                If l = 1 Then ib = Trim(sr2.ReadLine)
                For j = 1 To Len(ib)
                    If Microsoft.VisualBasic.Mid(ib, j, 1) <> " " Then '0,2,4,6,8為花色  1,3,5,7,9為數字
                        ia(a, b) = Microsoft.VisualBasic.Mid(ib, j, 1)
                        If j <> Len(ib) Then
                            If Microsoft.VisualBasic.Mid(ib, j, 1) = "1" And _
                                Asc(Microsoft.VisualBasic.Mid(ib, j + 1, 1)) >= 48 And _
                                Asc(Microsoft.VisualBasic.Mid(ib, j + 1, 1)) <= 57 Then
                                ia(a, b) &= Microsoft.VisualBasic.Mid(ib, j + 1, 1) : j += 2
                            End If
                        End If
                        b += 1
                        If b = 10 Then b = 0 : a += 1
                    End If
                Next
            Next
        Next


        For i = 0 To ii(0) + ii(1) - 1 '第n組資料
            For k = 1 To 7 Step 2 '按照數字由小排到大
                For j = k + 2 To 9 Step 2
                    If ia(i, k) > ia(i, j) Then
                        a = ia(i, k) : ia(i, k) = ia(i, j) : ia(i, j) = a '交換數字
                        aa = ia(i, k - 1) : ia(i, k - 1) = ia(i, j - 1) : ia(i, j - 1) = aa '交換花色
                    End If
                Next
            Next
        Next

        For i = 0 To ii(0) + ii(1) - 1 '第n組資料

            a = 0
            '(此組迴圈判斷是否為桐花順)
            For j = 0 To 6 Step 2 '判斷是不是皆為同花色
                If ia(i, j) = ia(i, j + 2) Then a += 1
                If a = 4 Then '為同花色後再判斷是否為連續數字
                    For k = 1 To 7 Step 2
                        If ia(i, k) + 1 = ia(i, k + 2) Then a += 1
                        If k = 7 And a = 3 And ia(i, 1) = 1 And ia(i, 9) = 13 Then a += 1 '13連接1
                    Next
                    If a = 4 Then sw.WriteLine("123456") : GoTo 1

                End If
            Next


            a = 0  '此組迴圈判斷是否為順子
            For k = 1 To 7 Step 2
                If ia(i, k) + 1 = ia(i, k + 2) Then a += 1
                If k = 7 And a = 3 And ia(i, 1) = 1 And ia(i, 9) = 13 Then a += 1 '13連接1
            Next
            If a = 4 Then sw.WriteLine("12345") : GoTo 1


            '此組迴圈判斷是否為4條
            For j = 1 To 9 Step 2
                a = 0
                For k = 1 To 9 Step 2
                    If ia(i, j) = ia(i, k) And j <> k Then a += 1
                Next
                If a = 3 Then sw.WriteLine("4") : GoTo 1
            Next


            a = 0 : b = 0 '此組迴圈判斷是否為葫蘆
            For k = 3 To 9 Step 2
                If ia(i, 1) = ia(i, k) Then a += 1
            Next
            For k = 1 To 7 Step 2
                If ia(i, 9) = ia(i, k) Then b += 1
            Next
            If (a = 1 And b = 2) Or (a = 2 And b = 1) Then sw.WriteLine("32") : GoTo 1


            For j = 1 To 9 Step 2 '此組迴圈判斷是否為3條
                a = 0
                For k = 1 To 9 Step 2
                    If ia(i, j) = ia(i, k) And j <> k Then a += 1
                    If a = 2 Then sw.WriteLine("3") : GoTo 1
                Next
            Next


            a = 0 '此組迴圈判斷是否為2對
            For j = 1 To 7 Step 2
                If ia(i, j) = ia(i, j + 2) Then a += 1
                If j = 7 And a = 2 Then sw.WriteLine("22") : GoTo 1
            Next


            a = 0 '此組迴圈判斷是否為1對
            For j = 1 To 7 Step 2
                If ia(i, j) = ia(i, j + 2) Then a += 1
                If j = 7 And a = 1 Then sw.WriteLine("1") : GoTo 1
            Next

            sw.WriteLine("0") '若不屬於以上幾種排  則輸出0
1:      Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
