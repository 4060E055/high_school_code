Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("test.txt")
    Dim fw As New FileInfo("result.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As Byte 'ia=幾組資料
    Dim ib, cc(2), bb(2), n, su(2), a As Integer 'ib=購買的金額  cc=咚咚零錢量
    Dim ic As String 'ic=每航書輸入
    Dim a1() As Byte = {1, 5, 10, 20, 50}

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ia = sr.ReadLine

        For i = 1 To ia

            ib = sr.ReadLine
            ReDim cc(5), bb(4), su(5)
            ic = Trim(sr.ReadLine) : n = 0

            For j = 1 To Len(ic) '取咚咚硬幣總數 與總金額
                If Microsoft.VisualBasic.Mid(ic, j, 1) <> " " Then
                    cc(n) &= Microsoft.VisualBasic.Mid(ic, j, 1)

                Else : cc(5) += cc(n) * a1(n) : n += 1
                End If
            Next

            cc(5) += cc(n) * a1(n)
            ic = Trim(sr.ReadLine) : n = 0
            For j = 1 To Len(ic) '取老闆硬幣總數 與總金額
                If Microsoft.VisualBasic.Mid(ic, j, 1) <> " " Then
                    bb(n) &= Microsoft.VisualBasic.Mid(ic, j, 1)
                Else : n += 1
                End If
            Next

            cc(5) -= ib
            For j = 0 To 4 '計算硬幣個別加總
                su(j) = bb(j) + cc(j)
            Next

            su(5) = cc(5)
            Erase bb, cc
            n = 0
            For j = 4 To 0 Step -1
                If su(5) >= a1(j) Then
                    a = su(5) \ a1(j)
                    If a > su(j) Then
                        su(5) -= a1(j) * su(j)
                        n += su(j)
                    Else
                        su(5) -= a1(j) * (su(5) \ a1(j))
                        n += a
                    End If

                ElseIf su(5) = 0 Then : Exit For
                End If
            Next
            sw.WriteLine(n)
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
