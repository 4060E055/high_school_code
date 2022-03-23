Public Class Form1
    Private Sub 票選第一品牌ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 票選第一品牌ToolStripMenuItem.Click
        If txt01.Text > txt02.Text Then
            If txt01.Text < txt03.Text Then
                MsgBox("第一品牌是Nokia!", , "訊息")
            ElseIf txt01.Text > txt03.Text Then
                MsgBox("第一品牌是Motorola!", , "訊息")
            ElseIf txt01.Text = txt03.Text Then
                MsgBox("第一品牌是Motorola 和 Nokia!", , "訊息")
            End If
        ElseIf txt02.Text > txt03.Text Then
            If txt01.Text < txt02.Text Then
                MsgBox("第一品牌是SonyErricsson!", , "訊息")
            ElseIf txt01.Text > txt02.Text Then
                MsgBox("第一品牌是Motorola", , "訊息")
            ElseIf txt01.Text = txt02.Text Then
                MsgBox("第一品牌是Motorola 和 SonyErricsson!", , "訊息")
            End If
        ElseIf txt03.Text > txt01.Text Then
            If txt02.Text < txt03.Text Then
                MsgBox("第一品牌是Nokia!", , "訊息")
            ElseIf txt02.Text > txt03.Text Then
                MsgBox("第一品牌是SonyErricsson!", , "訊息")
            ElseIf txt02.Text = txt03.Text Then
                MsgBox("第一品牌是SonyErricsson 和 Nokia!", , "訊息")
            End If
        ElseIf txt01.Text = txt03.Text And txt02.Text = txt03.Text Then
            MsgBox("票數相同", , "訊息")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If rdb01.Checked = True Then
            txtTotal.Text = Val(txtTotal.Text) + 1
            txt01.Text = Val(txt01.Text) + 1
        ElseIf rdb02.Checked = True Then
            txtTotal.Text = Val(txtTotal.Text) + 1
            txt02.Text = Val(txt02.Text) + 1
        ElseIf rdb03.Checked = True Then
            txtTotal.Text = Val(txtTotal.Text) + 1
            txt03.Text = Val(txt03.Text) + 1
        Else
            MsgBox("沒有選取手機廠牌...", , "錯誤")
        End If
    End Sub

    Private Sub 離開ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 離開ToolStripMenuItem.Click
        End
    End Sub
End Class
