Public Class Form1
    Dim num As Integer = 1 '�ӤH���ƥ�
    Dim tickPrice, totalPrice As Integer
    Public Function checkDate() As Boolean
        If Format(tickDate.Value, "dddd") = "�P���@" Then '�P�_�óB�z�g�@���}�]������
            MsgBox("�g�@���}�]", , "������~")      '�Y�����~,�HMessageBox�^�п��~�T���AReturn false
            Return False
        ElseIf Format(tickDate.Value, "dddd") = "�P����" And dayRB2.Checked = True Then        '�P�_�óB�z�g�餣��G��餧����
            MsgBox("�g�餣��G���", , "������~")        '�Y�����~,�HMessageBox�^�п��~�T���AReturn false
            Return False
        Else : Return True
        End If
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '�w�]���[���������
    End Sub

    Private Sub perCB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles perCB.CheckedChanged
        '�̾�CheckBox�ȡA�ҥΩμȰ��������
        If perCB.Checked = False Then
            tickRB1.Enabled = False : tickRB2.Enabled = False : tickRB3.Enabled = False : tickRB4.Enabled = False
        ElseIf perCB.Checked = True Then
            tickRB1.Enabled = True : tickRB2.Enabled = True : tickRB3.Enabled = True : tickRB4.Enabled = True
        End If
    End Sub

    Private Sub grpCB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpCB.CheckedChanged
        '�̾�CheckBox�ȡA�ҥΩμȰ��������
        If grpCB.Checked = False Then
            groupTB.Enabled = False
        ElseIf grpCB.Checked = True Then
            groupTB.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '�]�w�H�U���
        Me.dayRB1.Checked = True
        Me.tickDate.Value = Now
        Me.perCB.Checked = True
        Me.tickPanel.Enabled = True
        Me.tickRB1.Checked = True
        Me.num = 1
        Me.grpCB.Checked = False
        Me.groupTB.Text = "20"
        Me.groupTB.Enabled = False
        Me.movieCB.Checked = False
        Me.vrCB.Checked = False
        Me.payPanel.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '�ˬd����]�w�ζ}�]�P�_
        If checkDate() = True Then

            tickPrice = 100 ' �C�i�ӤH���@��鲼��
            If dayRB2.Checked = True Then tickPrice = 180 '�P�_�O�_���ʤG���A���s�]�wtickPrice
            If movieCB.Checked = True Then tickPrice += 50 '�P�_�O�_�[��3D�q�v�ε���Golf�A�[�p��tickPrice
            If vrCB.Checked = True Then tickPrice += 50
            totalPrice = 0

            If perCB.Checked = True Then

                If tickRB1.Checked = True Then : num = 1
                ElseIf tickRB2.Checked = True Then : num = 2
                ElseIf tickRB3.Checked = True Then : num = 3
                ElseIf tickRB4.Checked = True Then : num = 4
                End If

                '�p��ӤH�����I���B
                totalPrice = num * tickPrice

            End If

            If grpCB.Checked = True And CheckPeople() = True Then '�p�G�Ŀ���鲼�A�h�ˬd���鲼�H�ƬO�_���T
                '�[�p���鲼���I���B
                totalPrice += Val(groupTB.Text) * tickPrice * 0.8
                payPanel.Visible = True
                payLabel.Text = "NT$" & totalPrice
            ElseIf grpCB.Checked = False Then
                payPanel.Visible = True      '������I���B
                payLabel.Text = "NT$" & totalPrice
            End If

        Else
            payPanel.Visible = False    '�Y����ˬd���~�A��������I���B
        End If
    End Sub

  
    Private Function CheckPeople()
        If groupTB.Text = "" Then '�ˬd���鲼�H�ƿ�J���T�P�_
            MsgBox("�п�J�Ʀr", , "�H�ƿ��~")
            Return False
        ElseIf Val(groupTB.Text) < 20 Then
            MsgBox("���ܤ�20�H�A�~���ʶR���鲼", , "�H�ƿ��~")
            Return False
        Else : Return True
        End If
    End Function
End Class
