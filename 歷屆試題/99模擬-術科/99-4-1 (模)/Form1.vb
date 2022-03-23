Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in-4-1.txt")
    Dim fw As New FileInfo("out-4-1.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia(3), ib(3), n, ob(2), b As Integer 'ia=肉菜蛋果每公斤的利潤 ib=由左至右各類商品出售之公斤數
    Dim aa() As String = {"肉", "菜", "蛋", "果"}
    Dim ii, oa(2), a As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ii = Trim(sr.ReadLine) '每公斤的利潤

        For i = 1 To Len(ii)
            If Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) >= 48 And Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) <= 57 Then
                ia(n) &= Microsoft.VisualBasic.Mid(ii, i, 1)
            ElseIf Microsoft.VisualBasic.Mid(ii, i, 1) = "," Then : n += 1
            End If
        Next

        ii = Trim(sr.ReadLine) '今天菜攤由左至右出售之公斤數
        n = 0
        For i = 1 To Len(ii)
            If Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) >= 48 And Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) <= 57 Then
                ib(n) &= Microsoft.VisualBasic.Mid(ii, i, 1)
            ElseIf Microsoft.VisualBasic.Mid(ii, i, 1) = "," Then : n += 1
            End If
        Next

        n = 0
        For i = 0 To 3
            For j = 0 To 3
                For k = 0 To 3
                    For l = 0 To 3
                        If i <> j And j <> k And k <> l And l <> i And i <> k And j <> l Then

                            ob(n) = ob(n) + ia(i) * ib(0) + ia(j) * ib(1) + ia(k) * ib(2) + ia(l) * ib(3)
                            oa(n) &= aa(i) & aa(j) & aa(k) & aa(l)
                            n += 1 : ReDim Preserve ob(n), oa(n)
                        End If
                    Next
                Next
            Next
        Next

        For i = 0 To n - 1
            For j = 0 To n - 1
                If ob(i) > ob(j) Then
                    b = ob(j) : ob(j) = ob(i) : ob(i) = b
                    a = oa(j) : oa(j) = oa(i) : oa(i) = a
                End If
            Next
        Next
        For i = 0 To n - 1
            sw.WriteLine(oa(i) & "　" & ob(i))
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
