Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, c As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText


        Do
            Dim oa(2), ob(2) As String
            Dim x, a, b As Integer

            Do '帶入數
                ii = Trim(sr.ReadLine) & " "
2:              c = ""
                For i = 1 To Len(ii)
                    If Microsoft.VisualBasic.Mid(ii, i + 1, 2) = ",)" Then
                        c = Microsoft.VisualBasic.Mid(ii, i, 1) : x -= 1
                    ElseIf Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) > 48 And Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) < 58 Then
                        oa(x) &= Microsoft.VisualBasic.Mid(ii, i, 1)
                    ElseIf Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) > 64 And Asc(Microsoft.VisualBasic.Mid(ii, i, 1)) < 91 Then
                        ob(x) &= Microsoft.VisualBasic.Mid(ii, i, 1)
                    ElseIf Microsoft.VisualBasic.Mid(ii, i, 1) = " " Then
                        x += 1 : ReDim Preserve oa(x), ob(x)
                    ElseIf Microsoft.VisualBasic.Mid(ii, i, 2) = "()" Then
                        Exit Do
                    End If
                Next
            Loop
            If c = "" Then sw.WriteLine("not complete") : GoTo 1 '該有的節點沒有給折結束此次
            Dim oc(x, x) As Integer
            oc(0, x \ 2) = Val(c)

            For i = 0 To x - 1
                a = 0 : b = 0
                For j = 1 To Len(ob(i)) '求位置
                    If Microsoft.VisualBasic.Mid(ob(i), j, 1) = "R" Then ' R+
                        a += 1
                    ElseIf Microsoft.VisualBasic.Mid(ob(i), j, 1) = "L" Then 'L-
                        b += 1
                    End If
                Next
                If oc(Len(ob(i)), (x \ 2) + a - b) <> 0 Then sw.WriteLine("not complete") : GoTo 1 '重覆及跳出
                oc(Len(ob(i)), (x \ 2) + a - b) = oa(i) '帶入該位置的數
            Next

            For i = 0 To x
                For j = 0 To x '輸出
                    If oc(i, j) <> 0 Then sw.Write(oc(i, j) & " ")
                Next
            Next
            sw.WriteLine()
1:          ii = Trim(sr.ReadLine) & " "
            If ii = " " Then '如果沒了則結束執行
                Exit Do
            Else '如果還有則再執行一次
                ReDim oa(2), ob(2)
                x = 0 : GoTo 2
            End If
        Loop


        sw.Flush() : sw.Close() : End
    End Sub
End Class
