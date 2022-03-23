Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1.txt")
    Dim frr As New FileInfo("in2.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As Byte 'ia=每篇有多少行
    Dim x, nn(2) As Integer   'ic=統計各字的數目
    Dim ic(2), ib, a As String 'ib=每篇的每航

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Or frr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim srr As StreamReader = frr.OpenText

        For i = 0 To 1
            If i = 0 Then ia = sr.ReadLine
            If i = 1 Then ia = srr.ReadLine
            x = 0 : ReDim ic(2), nn(2)
            For j = 1 To ia '一行一行的判斷
          
                For k = 1 To 50 '每行的每個字
                    If i = 0 Then ib = sr.ReadLine
                    If i = 1 Then ib = srr.ReadLine

                    For l = 1 To Len(ib) '判斷該字是否有重複
                        For m = 0 To x
                            If Asc(Microsoft.VisualBasic.Mid(ib, l, 1)) > -24000 And Microsoft.VisualBasic.Mid(ib, l, 1) = ic(m) Then
                                nn(m) += 1 : Exit For
                            ElseIf m = x And Asc(Microsoft.VisualBasic.Mid(ib, l, 1)) > -24000 Then
                                ic(x) = Microsoft.VisualBasic.Mid(ib, l, 1)
                                x += 1 : ReDim Preserve ic(x), nn(x)
                            End If
                        Next

                    Next
                Next
            Next

            For k = 0 To x - 1 '依各字數量由大排到小
                For l = 0 To x - 1
                    If nn(k) > nn(l) Then
                        a = nn(k) : nn(k) = nn(l) : nn(l) = a
                        a = ic(k) : ic(k) = ic(l) : ic(l) = a
                    End If
                Next
            Next

            For l = 0 To x - 1
                sw.WriteLine(ic(l) & " " & nn(l) + 1)
                If nn(l) <> nn(l + 1) Then Exit For
            Next
            sw.WriteLine()
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
