Public Class Form1
    Dim aa1, aa2, aa3, aa4, aa5 As String
    Dim b4 As Byte
    Dim x As Byte
    Dim a5(10), a1(10) As Byte

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        aa1 = ""
        For i = 1 To 5
            For k = 1 To i
                aa1 &= k
            Next
            aa1 &= vbCrLf
        Next
        L1.Text = aa1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        aa2 = ""
        For z = 5 To 1 Step -1
            For k = 5 To z Step -1
                aa2 &= k
            Next
            aa2 &= vbCrLf
        Next
        L2.Text = aa2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        L1.Text = ""
        L2.Text = ""
        L3.Text = ""
        L4.Text = ""
        L5.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        aa3 = ""
        For z = 5 To 1 Step -1
            For k = 1 To z
                aa3 &= k
            Next
            aa3 &= vbCrLf
        Next
        L3.Text = aa3
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Do While T4.Text = ""
            T4.Text = Val(InputBox("注意", "一定要入數字", 5))
        Loop

        aa4 = ""

        b4 = Val(T4.Text)
       
            For i = 1 To b4

                For k = 1 To i
                    aa4 &= k
                    If k = i Then
                        For z = (i - 1) To 1 Step -1
                            aa4 &= z
                        Next
                    End If
                Next
                aa4 = aa4 & vbCrLf

            Next
            L4.Text = aa4

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Do While T5.Text = ""
            T5.Text = Val(InputBox("注意", "一定要入數字", 5))
        Loop

        aa5 = ""
        x = Val(T5.Text)
      
            a1(1) = 1
            a5(1) = 1
            For i = 1 To x

                For k = 1 To i
                    aa5 &= (a1(k - 1) + a1(k))
                    If k <> i Then aa5 &= "_"
                Next

                aa5 = aa5 & vbCrLf

                For k = 1 To i
                    a5(k) = (a1(k - 1) + a1(k))
                Next

                For k = 1 To i
                    a1(k) = a5(k)
                Next

            Next
        For k = 0 To x      '把陣列中的數全部歸0
            a5(k) = 0 : a1(k) = 0
        Next

        L5.Text = aa5
    End Sub

  
End Class
