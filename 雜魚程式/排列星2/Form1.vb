Public Class Form1
    Dim a1 As Byte
    Dim a2, b2 As Byte
    Dim a3, b3 As Byte
    Dim a4, b4 As Byte
    Dim aa1, aa2, aa3, aa4, aa6 As String
    Dim a6, b6, c6 As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        aa1 = ""
        a1 = 0

        Do
            For i = 1 To 5
                aa1 &= "*"
            Next
            aa1 &= vbCrLf
            a1 += 1
        Loop Until a1 >= 3
        L1.Text = aa1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        aa2 = ""
        a2 = 10
        b2 = 1
        Do
            a2 -= 2
            aa2 &= Space(a2)

            For j = 1 To b2
                aa2 &= "*"
            Next
            b2 += 1
            aa2 &= vbNewLine

        Loop Until b2 >= 5

        L2.Text = aa2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        aa3 = ""
        a3 = 10
        b3 = 1
        Do

            aa3 &= Space(a3)
            a3 -= 2
            For k = 1 To b3
                aa3 &= "*"
            Next
            b3 += 2
            aa3 &= vbCrLf

        Loop Until b3 >= 9
        L3.Text = aa3
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        aa4 = ""
        a4 = 2
        b4 = 7

        Do
            aa4 &= Space(a4)
            a4 += 2

            For z = 1 To b4
                aa4 &= "*"
            Next

            b4 -= 2
            aa4 &= vbCrLf

        Loop Until b4 = 1

        Do
            aa4 &= Space(a4)
            a4 -= 2

            For x = 1 To b4
                aa4 &= "*"
            Next

            b4 += 2
            aa4 &= vbCrLf

            L4.Text = aa4
        Loop Until b4 >= 9

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        L1.Text = ""
        L2.Text = ""
        L3.Text = ""
        L4.Text = ""
        L6.Text = ""
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        aa6 = vbNewLine & Space(6) & "＊＊" & Space(4) & "＊＊" & vbNewLine
        a6 = 2
        b6 = 9
        Do
            b6 -= 2

            aa6 &= Space(a6)
            a6 += 4
            For l = 1 To b6
                aa6 &= "＊"
            Next
            aa6 &= vbCrLf
        Loop Until b6 <= 1

        L6.Text = aa6
    End Sub
End Class
