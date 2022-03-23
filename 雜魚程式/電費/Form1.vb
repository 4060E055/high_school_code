Public Class Form1
    Dim a, b, c As Single
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = Val(T1.Text) : b = 0
        If R1.Checked = True Then

            Select Case a
                Case Is > 500
                    If C1.Checked = True Then
                        b += (a - 500) * 3.465
                    Else : b += (a - 500) * 2.73
                    End If
                    c = a - 500
                    GoTo 1
                Case 331 To 500
1:                  If C1.Checked = True Then
                        b += (a - c - 330) * 3.36
                    Else : b += (a - c - 330) * 2.73
                    End If
                    c = a - 330
                    GoTo 2
                Case 111 To 330
2:                  If C1.Checked = True Then
                        b += (a - c - 110) * 2.73
                    Else : b += (a - c - 110) * 2.415
                    End If
                    c = a - 110
                    GoTo 3
                Case 0 To 110
3:                  b += (a - c) * 2.1
            End Select

        ElseIf R2.Checked = True Then
            If C1.Checked = True Then
                b = a * 3.465
            Else : b = a * 2.73
            End If
        ElseIf R3.Checked = True Then
            b = a * 2.1
        End If
        L1.Text = "電費=" & b & "元"
    End Sub
End Class
