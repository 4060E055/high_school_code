Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii(2) As String
    Dim n, ia(2), x, aa, z, oo(2) As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Do
            ii(n) = Trim(sr.ReadLine)
            If ii(n) = "#" Then Exit Do
            ReDim ia(Len(ii(n))) : x = 0
            For i = 1 To Len(ii(n)) '分解變數，並把變數轉換成ASC值
                ia(i - 1) = Asc(Microsoft.VisualBasic.Mid(ii(n), i, 1))     
            Next
            For i = 1 To Len(ii(n)) '檢測是否還有能交換的
                If i <> Len(ii(n)) Then
                    If ia(i - 1) < ia(i) Then
                        x += 1
                    End If
                End If
            Next
            If x = 0 Then sw.WriteLine("No Successor") : GoTo 0 '若是完全不能排  則直接輸出
           
            For i = Len(ii(n)) To 2 Step -1 '從後往前判斷
                If ia(i - 1) > ia(i - 2) Then
                    If i = Len(ii(n)) Then
                        aa = ia(i - 1) : ia(i - 1) = ia(i - 2) : ia(i - 2) = aa

                        GoTo 1
                    Else
                        ReDim oo(2) : z = 0
                        ia(i - 2) = ia(i - 2) + 1 : x = 0 '交換單一變數
                        For j = i - 1 To Len(ii(n)) - 1
                            If ia(j) = ia(i - 2) And x = 0 Then ia(j) -= 1 : x += 1 '找出被交換的變數，並將它改成已經交換的變數
                            oo(z) = ia(j) : z += 1 : ReDim Preserve oo(z) '將要排序的變數丟到oo
                        Next

                        ReDim Preserve oo(z - 1)
                        Array.Sort(oo) : z = 0
                        For j = i - 1 To Len(ii(n)) - 1 '將排好的變數丟到原序列裡
                            ia(j) = oo(z) : z += 1
                        Next
                        GoTo 1
                    End If
                End If
            Next
1:          For i = 1 To Len(ii(n)) '輸出結果
                sw.Write(Chr(ia(i - 1)))
            Next
            sw.WriteLine()
0:          n += 1 : ReDim Preserve ii(n)
        Loop
        sw.Flush() : sw.Close() : End
    End Sub
End Class
