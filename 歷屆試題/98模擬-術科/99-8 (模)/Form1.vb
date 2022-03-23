Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As Byte 'ia=第一航資料
    Dim ib, ic(11), aa, bb As String 'ib=每航資料  
    Dim sum(11), x, n As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ia = sr.ReadLine

        For i = 1 To ia
            ib = Trim(sr.ReadLine) : ReDim ic(10) : n = 0 : ReDim sum(11) : x = 0
            For j = 1 To Len(ib) '分別帶入剛行的10格代表字
                If Microsoft.VisualBasic.Mid(ib, j, 1) <> " " Then
                    ic(n) &= Microsoft.VisualBasic.Mid(ib, j, 1) : x += 1
                Else : n += 1
                End If
            Next

            For j = 0 To 9
                For k = 1 To Len(ic(j)) '先計算該局時得分數(並未+前後得分)
                    aa = Microsoft.VisualBasic.Mid(ic(j), k, 1)
                    Select Case aa
                        Case 1 To 9
                            If (Len(ic(j)) = 3 Or Microsoft.VisualBasic.Mid(ic(j), 1, 1) = "X") And k = Len(ic(j)) And j = 9 Then
                                sum(j + 1) = Val(aa)
                            Else : sum(j) = Val(aa)
                            End If
                        Case "/", "X"
                            If (Len(ic(j)) = 3 Or Microsoft.VisualBasic.Mid(ic(j), 1, 1) = "X") And k = Len(ic(j)) And j = 9 Then
                                sum(j + 1) = 10
                            Else : sum(j) = 10
                            End If
                    End Select
                Next
                If ic(j) = "XXX" Then sum(j) += 10
            Next

            n = 0
            For j = 0 To 10 '計算總分數(並未+前後得分)
                n += sum(j)
            Next

            For j = 0 To 8
                For k = 1 To Len(ic(j)) '計算而外加分
                    aa = Microsoft.VisualBasic.Mid(ic(j), k, 1)
                    Select Case aa
                        Case "X"
                            bb = ic(j + 1) : x = 0
                            If Len(bb) = 1 Then bb &= ic(j + 2)
                            For l = 1 To 2
                                aa = Microsoft.VisualBasic.Mid(bb, l, 1)
                                Select Case aa
                                    Case 1 To 9
                                        n += Val(aa) : x = Val(aa)
                                    Case "X"
                                        n += 10
                                    Case "/"
                                        n += 10 - x
                                End Select
                            Next
                        Case "/"
                            bb = ic(j + 1)
                            aa = Microsoft.VisualBasic.Mid(bb, 1, 1)
                            Select Case aa
                                Case 1 To 9
                                    n += Val(aa) : x = Val(aa)
                                Case "X"
                                    n += 10
                            End Select
                    End Select
                Next
            Next
            sw.WriteLine(n)
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
