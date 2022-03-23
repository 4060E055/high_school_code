Public Class Form1

    Dim S() As String = {"S�ճ����D", "S�p������", "S�۷Q��", "S�R�R���ڹC�P��", "S����������", "S�p���H��"}
    Dim N() As String = {"N ���ϯ��t", "N �a���԰O", "N �ȷ檺�_�ۤ���", "N �L�񸦪���", "N ��Ф֦~�v", "N �c�F��ĵ", "N ���p��"}

    Private Sub SetN()
        ' /**  ��:���q�{���b �]�w�N����M�欰 N�����s�� ���v�� **/

        '�ŧi�}�C AryN,����:�v���M��]�A "N���ϯ��t", "N�a���԰O", "N�ȷ檺�_�ۤ���", "N�L�񸦪���", "N��Ф֦~�v", "N�c�F��ĵ", "N���p��"
      
        Me.LblTP.Text = "N�����s��"   '�ܧ�M����ܦW��
        Me.lbPrice.Text = 100         '����]��100

        lbItems.Items.Clear() '����M��M��

        Dim i As Integer '�ŧi��� i 
        lbItems.Items.AddRange(N)

        For i = 1 To lbAdd.Items.Count   '��ܰ}�C�����P�k��M�歫�Ф��v���W��,����:�ϥ� For ... Next
            If lbItems.Items.Contains(lbAdd.Items(i - 1)) = True Then
                lbItems.Items.Remove(lbAdd.Items(i - 1))
            End If
        Next
    End Sub

    Private Sub SetS()

        ' /**  ��:���q�{���b �]�w�N����M�欰 S�g��ʵe ���v�� **/
        '�ŧi�}�C AryS,����:�v���M��]�A "S�ճ����D", "S�p������", "S�۷Q��", "S�R�R���ڹC�P��", "S����������", "S�p���H��"

        Me.LblTP.Text = "S�g��ʵe"    '�ܧ�M����ܦW��
        Me.lbPrice.Text = 50           '����]��50

        lbItems.Items.Clear()  '����M��M��
        Dim i As Integer '�ŧi��� i 
        lbItems.Items.AddRange(S)

        For i = 1 To lbAdd.Items.Count   '��ܰ}�C�����P�k��M�歫�Ф��v���W��,����:�ϥ� For ... Next
            If lbItems.Items.Contains(lbAdd.Items(i - 1)) = True Then
                lbItems.Items.Remove(lbAdd.Items(i - 1))
            End If
        Next
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        ' /**  ��:���q�{���b�N����M��lbItems�I�ﶵ�إ[��k��M��lbAdd,�ýվ�ƶq�M�p�p  **/

        If Me.lbItems.SelectedItems.Count > 0 Then
            If Microsoft.VisualBasic.Left(lbItems.SelectedItem.ToString, 1) = "S" Then
                lblAmt.Text += 50
            Else
                lblAmt.Text += 100
            End If
            lbAdd.Items.Add(lbItems.SelectedItem.ToString)
            lbItems.Items.Remove(lbItems.SelectedItem.ToString)
            lblQty.Text += 1

            Call CalTotal()

        Else
            MsgBox("�п�ܭn�����v��!", MsgBoxStyle.Information)
        End If

    End Sub


    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        ' /**  ��:���q�{���b�N�k��M��lbAdd�I�ﶵ�ز���,�Y�P����M��P��,�h�[�J����M��,�ýվ�ƶq�M�p�p  **/

        If Me.lbAdd.SelectedItems.Count > 0 Then '���I��~����
            If Microsoft.VisualBasic.Left(lbAdd.SelectedItem.ToString, 1) = "S" Then
                lblAmt.Text -= 50
                If LblTP.Text = "S�g��ʵe" Then
                    lbItems.Items.Add(lbAdd.SelectedItem.ToString)
                End If
            Else
                lblAmt.Text -= 100
                If LblTP.Text = "N�����s��" Then
                    lbItems.Items.Add(lbAdd.SelectedItem.ToString)
                End If
            End If
            ' ���wi���I����ޭ�

            lbAdd.Items.Remove(lbAdd.SelectedItem.ToString)
            lblQty.Text -= 1 '�ƶq�� 1

            Call CalTotal()  '�p��X�p���B

        End If
    End Sub

    Private Sub CalTotal()
        ' /**  ��:���q�{���b �p��X�p���B **/

        '�X�p=�p�p+10*�ƶq*�Ѽ�
        lblTotal.Text = lblAmt.Text + 10 * lblQty.Text * lblDays.Text

    End Sub

    Private Sub tlsReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' /**  ��:���q�{���b ���s��� **/

        lbAdd.Items.Clear()  '�M�ťk��M��ﶵ
        If Me.LblTP.Text = "S�g��ʵe" Then    '�̥ثe�ҿ諸���ءA���� SetN() or SetS()
            lbItems.Items.AddRange(S)
        Else
            lbItems.Items.AddRange(N)
        End If
    End Sub

    Private Sub ����ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����ToolStripMenuItem.Click
        End
    End Sub

    Private Sub N�����s��ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N�����s��ToolStripMenuItem.Click
        Call SetN()
    End Sub

    Private Sub S�g��ʵeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S�g��ʵeToolStripMenuItem.Click
        Call SetS()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = Now

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        lblDays.Text = DateDiff(DateInterval.Day, Now, DateTimePicker1.Value) + 1
        If Format(DateTimePicker1.Value, "D") = Format(Now, "D") Then lblDays.Text = 0
        Call CalTotal()
    End Sub

    Private Sub ���s���ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ���s���ToolStripMenuItem.Click
        DateTimePicker1.MinDate = Now
        lblQty.Text = 0
        lblAmt.Text = 0
        lblDays.Text = 0
        lbAdd.Items.Clear()
        lblTotal.Text = 0
    End Sub
End Class
