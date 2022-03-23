Public Class Form1
    Dim a(2), s As Single

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a(0) = txtEdgeA.Text
        a(1) = txtEdgeB.Text
        a(2) = txtEdgeC.Text
        lblKind.Text = ""
        lblLength.Text = ""
        lblArea.Text = ""
        lblYN.Text = ""
        If a(0) + a(1) > a(2) And a(0) + a(2) > a(1) And a(2) + a(1) > a(0) And a(0) <> 0 And a(1) <> 0 And a(2) <> 0 Then
            lblYN.Text = "是"
            Array.Sort(a)
            If a(0) ^ 2 + a(1) ^ 2 = a(2) ^ 2 Then
                lblKind.Text = "直角三角形"
            ElseIf a(0) ^ 2 + a(1) ^ 2 < a(2) ^ 2 Then
                lblKind.Text = "鈍角三角形"
            Else
                lblKind.Text = "銳角三角形"
            End If

            lblLength.Text = Format(a(0) + a(1) + a(2), "#######.##")
            s = Val(lblLength.Text) / 2
            lblArea.Text = Format((s * (s - a(0)) * (s - a(1)) * (s - a(2))) ^ 0.5, "#######.##")
        Else
            lblYN.Text = "否"
        End If
    End Sub
End Class
