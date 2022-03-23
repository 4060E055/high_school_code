Public Class Form1
    Dim sr1() As String = {"紅豆", "綠豆", "薏仁", "珍珠", "芋頭"}
    Dim sr2() As String = {"西瓜", "香蕉", "草莓", "芒果"}
  
  
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        End
    End Sub

    Private Sub 八寶冰ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 八寶冰ToolStripMenuItem.Click
        lbItems.Items.Clear()
        lbAdd.Items.Clear()
        LblTP.Text = "八寶冰"
        lbItems.Items.AddRange(sr1)  
        lbPrice.Text = 25
    End Sub

    Private Sub 水果冰ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 水果冰ToolStripMenuItem.Click
        lbItems.Items.Clear()
        lbAdd.Items.Clear()
        LblTP.Text = "水果冰"
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
            MsgBox("請選擇加入項目!")
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
            MsgBox("請選擇移除項目!")
        End If
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        Call zxc()
    End Sub

    Private Sub 重選ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 重選ToolStripMenuItem.Click
        lbItems.Items.Clear()
        lbAdd.Items.Clear()
        If LblTP.Text = "八寶冰" Then
            lbPrice.Text = 25
            lbItems.Items.AddRange(sr1)
        ElseIf LblTP.Text = "水果冰" Then
            lbPrice.Text = 35
            lbItems.Items.AddRange(sr2)
        End If
        txtQty.Text = 1
    End Sub
End Class
