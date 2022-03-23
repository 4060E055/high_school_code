Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("test.txt")
    Dim fw As New FileInfo("result.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, oo(2) As String
    Dim a1() As String = {"零", "壹", "貳", "參", "肆", "伍", "陸", "柒", "捌", "玖"}
    Dim a2() As String = {"", "拾", "佰", "仟"}
    Dim a3() As String = {"萬", "億"}
    Dim n, x, a, b As Integer
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
            n = 0 : x = 0 : ReDim oo(2) : a = 0
            For i = Len(ia) To 1 Step -1

                If Val(Microsoft.VisualBasic.Mid(ia, i, 1)) <> 0 Then
                    oo(a) = a2(n)
                    a += 1 : ReDim Preserve oo(a)
                End If

                oo(a) = a1(Val(Microsoft.VisualBasic.Mid(ia, i, 1)))
                a += 1 : ReDim Preserve oo(a)
                n += 1
                If n = 4 And i <> 1 Then
                    x += 1 : n = 0
                    oo(a) = a3(x - 1)
                    a += 1 : ReDim Preserve oo(a)
                End If

                If i = 1 Then

                    For j = 0 To a - 2
                        If oo(j) = "零" Or oo(j) = "" Then
                            oo(j) = ""
                        Else : Exit For
                        End If
                    Next

                    For j = 1 To 0 Step -1
                        x = 0 : n = 0
                        For k = 0 To a - 2
                            If x >= 1 And oo(k) <> "零" Then Exit For
                            If oo(k) = a3(j) Then x += 1 : b = k
                            If x >= 1 And oo(k) = "零" Then oo(k) = "" : n += 1
                            If n = 4 Then oo(b) = ""
                        Next
                    Next

                    For j = 0 To a - 2
                        If oo(j) = "零" And oo(j + 1) = "零" Then oo(j) = ""
                    Next
                End If
            Next

            For j = a To 0 Step -1
                sw.Write(oo(j))
            Next
            sw.WriteLine()
        Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
