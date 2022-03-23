Public Class Form1
 
    Private Sub GetAmt()
        If RadioButton2.Checked = True Then
            txtPrice.Text = 129
        Else : txtPrice.Text = 99
        End If

        If cbUPF.Checked = True And cbUPF.Enabled = True Then txtPrice.Text += 5
        If cbUPD.Checked = True And cbUPD.Enabled = True Then txtPrice.Text += 5

        txtAmt.Text = Val(txtPrice.Text) * Val(txtQty.Text)
    End Sub
   
    Private Sub btnGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGO.Click

        MsgBox("ÁÂÁÂ¥úÁ{¡I")
        RadioButton2.Checked = True
        rbB1.Checked = True
        rbC1.Checked = True
        cbUPD.Checked = False
        cbUPF.Checked = False
        txtQty.Text = 1
        txtPrice.Text = 129
    End Sub

    Private Sub rbB1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbB1.CheckedChanged
        If rbB1.Checked = True Then cbUPF.Enabled = True
        If rbB1.Checked = False Then cbUPF.Enabled = False
        GetAmt()
    End Sub

    Private Sub rbC1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbC1.CheckedChanged
        If rbC1.Checked = True Then cbUPD.Enabled = True
        If rbC1.Checked = False Then cbUPD.Enabled = False
        GetAmt()
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        GetAmt()
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        GetAmt()
    End Sub

    Private Sub cbUPD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbUPD.Click
        GetAmt()
    End Sub

    Private Sub cbUPF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbUPF.Click
        GetAmt()
    End Sub

    Private Sub rbB2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbB2.Click
        GetAmt()
    End Sub

    Private Sub rbB3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbB3.Click
        GetAmt()
    End Sub

    Private Sub rbC2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbC2.Click
        GetAmt()
    End Sub

    Private Sub rbC3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbC3.Click
        GetAmt()
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        GetAmt()
    End Sub
End Class
