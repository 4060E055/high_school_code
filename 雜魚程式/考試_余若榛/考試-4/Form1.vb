
Public Class Form1
    Dim i1, n, aa, a, b As Integer
    Dim i2, bb As Single
    Dim s1, e1(), e2() As String
    Dim z() As Byte = {2, 8, 16}
    Dim v() As String = {"A", "B", "C", "D", "E", "F"}

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Tii.Text = "" : i1 = Fix(Val(T1.Text)) '取數
        If Val(T1.Text) > i1 Then
            For i = 1 To Len(T1.Text)
                If Microsoft.VisualBasic.Mid(T1.Text, i, 1) = "." Then
                    i2 = "0." & Microsoft.VisualBasic.Mid(T1.Text, i + 1, Len(T1.Text))
                    Exit For
                End If
            Next
        End If

        For j = 0 To 2  '2、8、16進位
            aa = i1 : s1 = ""   '(整數部分)
            Tii.Text &= vbCrLf & z(j) & "進位："
            If i1 > z(j) - 1 Then
                Do
                    If aa Mod z(j) > 9 Then
                        s1 &= v(aa Mod z(j) - 10)
                    Else
                        s1 &= aa Mod z(j)
                    End If
                    aa = aa \ z(j)
                Loop Until aa = 0

                For i = Len(s1) To 1 Step -1
                    Tii.Text &= Microsoft.VisualBasic.Mid(s1, i, 1)
                Next
            Else
                Tii.Text &= i1
            End If
            '(小數部分)
            If i2 > 0 Then
                bb = i2 : Tii.Text &= "."
                Do
                    If Fix(bb * z(j)) > 9 Then
                        Tii.Text &= v(Fix(bb * z(j)) - 10)
                    Else
                        Tii.Text &= Fix(bb * z(j))
                    End If
                    bb = bb * z(j)
                    For i = 1 To Len(CStr(bb))
                        If Microsoft.VisualBasic.Mid(CStr(bb), i, 1) = "." Then
                            bb = "0." & Microsoft.VisualBasic.Mid(CStr(bb), i + 1, Len(CStr(bb)))
                            Exit For
                        End If
                    Next
                Loop Until bb = Fix(bb)
            End If
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        i1 = Fix(Val(T2.Text)) : i2 = 0 : n = Len(CStr(i1)) - 1 : aa = 0    '取數

        '十進位
        For i = 1 To Len(CStr(i1))
            aa += Val(Microsoft.VisualBasic.Mid(CStr(i1), i, 1)) * 2 ^ n
            n -= 1
        Next
        i1 = aa
        If Val(T2.Text) > i1 Then
            For i = 1 To Len(T2.Text)
                If Microsoft.VisualBasic.Mid(T2.Text, i, 1) = "." Then
                    For j = i + 1 To Len(T2.Text)
                        i2 += Val(Microsoft.VisualBasic.Mid(T2.Text, j, 1)) * 2 ^ n
                        n -= 1
                    Next
                    Exit For
                End If
            Next
        End If
        Tii.Text = vbCrLf & "10進位：" & i1 + i2

        For j = 1 To 2 '8、16進位
            aa = i1 : s1 = "" '(整數部分)
            Tii.Text &= vbCrLf & z(j) & "進位："
            If i1 > z(j) - 1 Then
                Do
                    If aa Mod z(j) > 9 Then
                        s1 &= v(aa Mod z(j) - 10)
                    Else
                        s1 &= aa Mod z(j)
                    End If
                    aa = aa \ z(j)
                Loop Until aa = 0

                For i = Len(s1) To 1 Step -1
                    Tii.Text &= Microsoft.VisualBasic.Mid(s1, i, 1)
                Next
            Else
                Tii.Text &= i1
            End If
            '(小數部分)
            If i2 > 0 Then
                bb = i2 : Tii.Text &= "."
                Do
                    If Fix(bb * z(j)) > 9 Then
                        Tii.Text &= v(Fix(bb * z(j)) - 10)
                    Else
                        Tii.Text &= Fix(bb * z(j))
                    End If
                    bb = bb * z(j)
                    For i = 1 To Len(CStr(bb))
                        If Microsoft.VisualBasic.Mid(CStr(bb), i, 1) = "." Then
                            bb = "0." & Microsoft.VisualBasic.Mid(CStr(bb), i + 1, Len(CStr(bb)))
                            Exit For
                        End If
                    Next
                Loop Until bb = Fix(bb)
            End If
        Next

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '取數+轉十進位
        i1 = 0 : n = 0 : a = 0 : i2 = 0 : b = 0
        For i = 1 To Len(T3.Text) '計算整數部分有幾位
            If Microsoft.VisualBasic.Mid(T3.Text, i, 1) = "." Then
                Exit For
            End If
            n += 1
        Next
        If n = Len(T3.Text) Then
            ReDim e1(n - 1)
            For i = 1 To n '整數部分(16進位)帶入陣列
                e1(i - 1) = Microsoft.VisualBasic.Mid(T3.Text, i, 1)
            Next
            For i = 1 To n '整數部分轉阿拉伯數字
                For j = 0 To 5
                    If e1(i - 1) = v(j) Then
                        e1(i - 1) = j + 10
                    End If
                Next
            Next

        Else
            ReDim e1(n - 1), e2(Len(T3.Text) - n - 2)
            For i = 1 To n '整數部分(16進位)帶入陣列
                e1(i - 1) = Microsoft.VisualBasic.Mid(T3.Text, i, 1)
            Next
            For i = n + 2 To Len(T3.Text) '小數部分(16進位)帶入陣列
                e2(a) = Microsoft.VisualBasic.Mid(T3.Text, i, 1)
                a += 1
            Next
            For i = 1 To n '整數部分轉阿拉伯數字
                For j = 0 To 5
                    If e1(i - 1) = v(j) Then
                        e1(i - 1) = j + 10
                    End If
                Next
            Next

            For i = 1 To a '小數部分轉阿拉伯數字
                For j = 0 To 5
                    If e2(i - 1) = v(j) Then
                        e2(i - 1) = j + 10
                    End If
                Next
            Next

        End If


        '轉10進位
        For i = n - 1 To 0 Step -1
            i1 += e1(i) * 16 ^ b
            b += 1
        Next

        If a > 0 Then
            b = -1
            For i = 0 To a - 1
                i2 += e2(i) * 16 ^ b
                b -= 1
            Next
        End If

        Tii.Text = vbCrLf & "10進位：" & i1 + i2

        For j = 0 To 1  '2、8進位
            aa = i1 : s1 = ""   '(整數部分)
            Tii.Text &= vbCrLf & z(j) & "進位："
            If i1 > z(j) - 1 Then
                Do
                    s1 &= aa Mod z(j)
                    aa = aa \ z(j)
                Loop Until aa = 0

                For i = Len(s1) To 1 Step -1
                    Tii.Text &= Microsoft.VisualBasic.Mid(s1, i, 1)
                Next
            Else
                Tii.Text &= i1
            End If
            '(小數部分)
            If i2 > 0 Then
                bb = i2 : Tii.Text &= "."
                Do
                        Tii.Text &= Fix(bb * z(j))
                    bb = bb * z(j)
                    For i = 1 To Len(CStr(bb))
                        If Microsoft.VisualBasic.Mid(CStr(bb), i, 1) = "." Then
                            bb = "0." & Microsoft.VisualBasic.Mid(CStr(bb), i + 1, Len(CStr(bb)))
                            Exit For
                        End If
                    Next
                Loop Until bb = Fix(bb)
            End If
        Next


    End Sub
End Class
