Public Class Form1
    Private Sub ����Ĥ@�~�PToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����Ĥ@�~�PToolStripMenuItem.Click
        If txt01.Text > txt02.Text Then
            If txt01.Text < txt03.Text Then
                MsgBox("�Ĥ@�~�P�ONokia!", , "�T��")
            ElseIf txt01.Text > txt03.Text Then
                MsgBox("�Ĥ@�~�P�OMotorola!", , "�T��")
            ElseIf txt01.Text = txt03.Text Then
                MsgBox("�Ĥ@�~�P�OMotorola �M Nokia!", , "�T��")
            End If
        ElseIf txt02.Text > txt03.Text Then
            If txt01.Text < txt02.Text Then
                MsgBox("�Ĥ@�~�P�OSonyErricsson!", , "�T��")
            ElseIf txt01.Text > txt02.Text Then
                MsgBox("�Ĥ@�~�P�OMotorola", , "�T��")
            ElseIf txt01.Text = txt02.Text Then
                MsgBox("�Ĥ@�~�P�OMotorola �M SonyErricsson!", , "�T��")
            End If
        ElseIf txt03.Text > txt01.Text Then
            If txt02.Text < txt03.Text Then
                MsgBox("�Ĥ@�~�P�ONokia!", , "�T��")
            ElseIf txt02.Text > txt03.Text Then
                MsgBox("�Ĥ@�~�P�OSonyErricsson!", , "�T��")
            ElseIf txt02.Text = txt03.Text Then
                MsgBox("�Ĥ@�~�P�OSonyErricsson �M Nokia!", , "�T��")
            End If
        ElseIf txt01.Text = txt03.Text And txt02.Text = txt03.Text Then
            MsgBox("���ƬۦP", , "�T��")
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
            MsgBox("�S���������t�P...", , "���~")
        End If
    End Sub

    Private Sub ���}ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ���}ToolStripMenuItem.Click
        End
    End Sub
End Class
