Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim c As String = 0
    Dim d As Integer
    Dim f As String
    Dim g As Integer

    Dim x As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Do While T1.Text = ""
            T1.Text = InputBox("請輸入數字", "注意", 0)
        Loop

        g = 0

        a = Val(T1.Text)

        If a = 0 Then
            L1.Text = "不是質數" & vbNewLine & "質數共" & c & "個"
        ElseIf a = 1 Then
            L1.Text = "是質數" & vbNewLine & "質數共" & c & "個"
        ElseIf a = 2 Then
            L1.Text = "是質數" & vbNewLine & "質數共" & c & "個"
        End If



        If a > 1 Then

            For i = 2 To (a - 1) Step 1

                b = a Mod i
                If b = 0 Then
                    L1.Text = a & "非質數" & vbNewLine & "質數共" & c & "個"
                    Exit For
                End If
            Next



            If b <> 0 Then
                c = c + 1
                L1.Text = a & "為質數" & vbNewLine & "質數共" & c & "個"


            End If


        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        T1.Text = ""
        L1.Text = ""
        c = 0
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        T2.Text = ""
        c = ""
        L2.Text = ""
        L3.Text = ""
        g = 0
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        L2.Text = ""
        d = Val(T2.Text)
        g = 2
        If d = 0 Then
            f = f
        ElseIf d = 1 Then
            f = f & "0001"
            L2.Text = f
            x += 1
        End If

        If d > 1 Then
            x = 2
            For j = 2 To d Step 1
                For i = 2 To (j - 1) Step 1

                    b = j Mod i
                    If b = 0 Then
                        f = f
                        Exit For
                    End If

                Next

                If b <> 0 Then
                    f = f & Format(Val(j), "##0000") & "，"
                    g += 1
                    x += 1

                End If


                If g > 9 Then
                    f &= vbNewLine
                    g = 0
                End If
            Next
            L2.Text = "0001" & "，" & "0002" & "，" & f

        End If
        d = 0
        L3.Text = x

        f = ""
        x = 0
        g = 0

    End Sub
End Class
