Public Class Form1
    Dim sr1() As String = {"����", "��", "����", "�ï]", "���Y"}
    Dim sr2() As String = {"���", "����", "���", "�~�G"}
  
  
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        End
    End Sub

    Private Sub �K�_�BToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �K�_�BToolStripMenuItem.Click
        lbItems.Items.Clear()
        lbAdd.Items.Clear()
        LblTP.Text = "�K�_�B"
        lbItems.Items.AddRange(sr1)  
        lbPrice.Text = 25
    End Sub

    Private Sub ���G�BToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ���G�BToolStripMenuItem.Click
        lbItems.Items.Clear()
        lbAdd.Items.Clear()
        LblTP.Text = "���G�B"
        lbItems.Items.AddRange(sr2) 
        lbPrice.Text = 35
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If lbItems.SelectedItem <> "" Then
            lbAdd.Items.Add(lbItems.SelectedItem.ToString)
            lbItems.Items.Remove(lbItems.SelectedItem.ToString)
            lbPrice.Text += 5
            Call zxc()
        Else
            MsgBox("�п�ܥ[�J����!")
        End If
    End Sub

    Sub zxc()
        lblTotal.Text = Val(txtQty.Text) * Val(lbPrice.Text)
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If lbAdd.SelectedItem <> "" Then
            lbItems.Items.Add(lbAdd.SelectedItem.ToString)
            lbAdd.Items.Remove(lbAdd.SelectedItem.ToString)
            lbPrice.Text -= 5
            Call zxc()
        Else
            MsgBox("�п�ܲ�������!")
        End If
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        Call zxc()
    End Sub

    Private Sub ����ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����ToolStripMenuItem.Click
        lbItems.Items.Clear()
        lbAdd.Items.Clear()
        If LblTP.Text = "�K�_�B" Then
            lbPrice.Text = 25
            lbItems.Items.AddRange(sr1)
        ElseIf LblTP.Text = "���G�B" Then
            lbPrice.Text = 35
            lbItems.Items.AddRange(sr2)
        End If
        txtQty.Text = 1
    End Sub
End Class
