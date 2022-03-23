Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim n, a, b, a2, b2 As Integer
    Dim ia, ib1(2), ib2(2), ic1(2), ic2(2), aa(2), bb(2) As String
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

            ReDim ib1(2), ib2(2) : a = 0 : b = 0

            For i = 0 To 1
                For j = 1 To Len(ia) '帶入每航資料
                    If i = 0 Then
                        ib1(j - 1) = Microsoft.VisualBasic.Mid(ia, j, 1) : a += 1 : ReDim Preserve ib1(a)
                    Else
                        ib2(j - 1) = Microsoft.VisualBasic.Mid(ia, j, 1) : b += 1 : ReDim Preserve ib2(b)
                    End If
                Next
                If i = 0 Then ia = Trim(sr.ReadLine)
            Next

            ReDim ic1(2), ic2(2) : a2 = 0 : b2 = 0
            ReDim Preserve ib1(a - 1), ib2(b - 1)

            For i = 1 To a '找出第一航資料中的字是否也存在第二航資料中 若存在則另外取出
                For j = 1 To b
                    If ib1(i - 1) = ib2(j - 1) Then
                        ic1(a2) = ib1(i - 1) : a2 += 1 : ReDim Preserve ic1(a2)
                    End If
                Next
            Next

            For i = 1 To b '找出第二航資料中的字是否也存在第一航資料中 若存在則另外取出
                For j = 1 To a
                    If ib1(j - 1) = ib2(i - 1) Then
                        ic2(b2) = ib2(i - 1) : b2 += 1 : ReDim Preserve ic2(b2)
                    End If
                Next
            Next

            Erase ib1, ib2 '清除原有2航資料的分解

            For i = a2 To 1 Step -1 'a2,a2-1,a2-2 找出最長串列
                ReDim aa(2), bb(2) : a = 0
                For j = 1 To a2
                    If j + i - 1 <= a2 Then
                        For k = j To j + i - 1
                            aa(a) &= ic1(k - 1)
                            bb(a) &= ic2(k - 1)
                        Next
                    Else : Exit For
                    End If
                    a += 1
                    ReDim Preserve aa(a), bb(a)
                Next
                For j = 1 To a
                    For k = 1 To a
                        If aa(j - 1) = bb(k - 1) Then sw.WriteLine(Len(aa(j - 1))) : GoTo 1
                    Next
                Next
            Next
1:      Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
