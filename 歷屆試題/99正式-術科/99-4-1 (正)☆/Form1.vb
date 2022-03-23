Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1.txt")
    Dim frr As New FileInfo("in2.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As Byte
    Dim a1() As String = {"肉", "菜", "蛋", "果", "魚", "蝦", "豆", "菇"}
    Dim a2() As String = {"肉果", "肉豆", "肉菇", "菜蛋", "菜魚", "菜豆", "菜菇", "蛋果", "蛋蝦",
                          "蛋菇", "果魚", "果豆", "果菇", "魚蝦", "魚豆", "魚菇", "蝦豆", "豆菇"}
    Dim aa(), bb As String
    Dim x, c As Integer
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
            ReDim aa(ia - 1)
            For j = 0 To ia - 1
                aa(j) = 1
            Next
            x = ia - 1 : c = ia - 2
            Do
                For j = ia - 1 To c Step -1
                    If aa(x) = ia + 1 Then

                        aa(x) = 1 : aa(x - 1) += 1
                    Else

                    End If

                Next
                For k = 0 To ia - 1 '檢驗是否每個數皆不同
                    For l = 0 To ia - 1
                        If aa(k) = aa(l) And k <> l Then : GoTo 1
                        ElseIf k = ia - 1 Then '若每個數皆不同
                            bb = ""
                            For m = 0 To ia - 1 '形成1個字串
                                bb &= a1(aa(m))
                            Next
                            For o = 1 To Len(bb) '檢驗字串是否符合條件
                                For m = 0 To 17
                                    If Microsoft.VisualBasic.Mid(bb, o, 2) = a1(m) Then : GoTo 1
                                    ElseIf o = Len(bb) Then : sw.WriteLine(bb) : GoTo 1
                                    End If
                                Next
                            Next
                        End If
                    Next
                Next
1:


            Loop
        Next

        sw.Flush() : sw.Close() : End
    End Sub
   

End Class


