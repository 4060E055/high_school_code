Public Class Form1
    Dim a As Single
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        '判斷是否為三角形

        If Val(T1.Text) + Val(T2.Text) > Val(T3.Text) And Val(T2.Text) + Val(T3.Text) > Val(T1.Text) _
            And Val(T1.Text) + Val(T3.Text) > Val(T2.Text) Then
            L1.Text = "是"
            If Val(T1.Text) ^ 2 + Val(T2.Text) ^ 2 = Val(T3.Text) ^ 2 Or Val(T2.Text) ^ 2 + Val(T3.Text) ^ 2 = Val(T1.Text) ^ 2 _
               Or Val(T1.Text) ^ 2 + Val(T3.Text) ^ 2 = Val(T2.Text) ^ 2 Then
                L2.Text = "直角三角形"
            ElseIf Val(T1.Text) ^ 2 + Val(T2.Text) ^ 2 > Val(T3.Text) ^ 2 And Val(T2.Text) ^ 2 + Val(T3.Text) ^ 2 > Val(T1.Text) ^ 2 _
                   And Val(T1.Text) ^ 2 + Val(T3.Text) ^ 2 > Val(T2.Text) ^ 2 Then
                L2.Text = "銳角三角形"
            Else : L2.Text = "鈍角三角形"
            End If
            a = Format(Val(T1.Text) + Val(T2.Text) + Val(T3.Text), "#######.##")
            L3.Text = a
            a = a / 2
            L4.Text = Format((a * (a - Val(T1.Text)) * (a - Val(T2.Text)) * (a - Val(T3.Text))) ^ (1 / 2), "#######.##")
        Else
            L1.Text = "否" : L2.Text = "" : L3.Text = "" : L4.Text = ""
        End If
    End Sub
End Class
