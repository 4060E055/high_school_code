Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim c As String
    Dim d As Integer
    Dim f As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        c = 0

        a = Val(T1.Text)

        If a = 0 Then
            L1.Text = "不是質數"
        ElseIf a = 1 Then
            L1.Text = "是質數"
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

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        d = Val(T2.Text)

        If d = 0 Then
            f = f
        ElseIf d = 1 Then
            f = f & "1"
        End If



        If d > 1 Then
            For j = 2 To d Step 1
                For i = 2 To (j - 1) Step 1

                    b = j Mod i
                    If b = 0 Then
                        f = f
                        Exit For
                    End If

                Next

                If b <> 0 Then
                    f = f & j & Space(3)

                End If


            Next
            L2.Text = "1" & Space(3) & "2" & Space(3) & f

        End If



    End Sub
End Class
