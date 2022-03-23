Public Class Form1
    '�ŧiuserDict���@�ӥHString���A��Key�AUserRec���Ȥ�Dictionary
    Dim userdict As UserRec

    Public Structure UserRec
        Public username As String
        Public passwd As String
        Public sex As Boolean
        Public userType As String
        Public email As String
    End Structure
    Public Sub ClearUserData()
        Me.userTypeCB1.SelectedIndex = 0
        Me.nameTB1.Text = ""
        Me.pwdTB1.Text = ""
        Me.pwdCTB1.Text = ""
        Me.sexMRB1.Checked = True
        Me.emailTB1.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rec As New UserRec
        rec = userdict    '�quserDict���X�b�����

        If rec.passwd = pwdTB.Text And rec.username = userTB.Text And pwdTB.Text <> "" And userTB.Text <> "" Then  '�ˬd�b���O�_�s�b�A�K�X�O�_���T
            TabControl1.SelectedTab = TabUserData
            '�N�b�������ܩ�򥻸��TabPage
            nameTB2.Text = userdict.username
            pwdTB2.Text = userdict.passwd
            emailLabel.Text = userdict.email
            If userdict.sex = True Then
                sexFRB2.Checked = True
            Else : sexMRB2.Checked = True
            End If

            userTypeCB.Text = userdict.userType

        ElseIf rec.passwd <> pwdTB.Text And rec.username = userTB.Text Then
            MessageBox.Show("�K�X���~!", "�K�X���~", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            pwdTB.Text = ""

        Else
            '�Y�b�����s�b�A���ĵ�i�T���A�ø���"�s�W"TabPage
            Dim msg As String
            msg = "�ϥΪ� " & Me.userTB.Text & "���s�b!" & vbCrLf & "�зs�W�ϥΪ̸��"
            MessageBox.Show(msg, "�n�J���~!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TabControl1.SelectedTab = TabNewUser
        End If
     
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim rec As New UserRec
        rec = userdict  '�ˬd�ϥΪ̬O�_�w�s�b
        If rec.username = nameTB1.Text Then
            MessageBox.Show("�ϥΪ� " & Me.nameTB1.Text & "�w�s�b!", "�d�ߵ��G", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("�ϥΪ� " & Me.nameTB1.Text & "���s�b!" & vbCrLf & "�i�H�~���J���", "�d�ߵ��G", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim rec As New UserRec
        rec = userdict
        If nameTB1.Text <> "" And pwdTB1.Text <> "" And pwdCTB1.Text <> "" Then  '�ˬd�O�_��J�ϥΪ̦W�ٻP�K�X

            '�ˬd�ϥΪ̬O�_�w�s�b
            If rec.username = nameTB1.Text Then
                MessageBox.Show("�ϥΪ� " & Me.nameTB1.Text & "�w�s�b!", "�d�ߵ��G", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                '�ˬd�K�X�O�_�@�P
                If pwdTB1.Text = pwdCTB1.Text Then
                    userdict.username = nameTB1.Text '�Y���s�b�A�ϥΪ̱b����Ʀs�JuserDict
                    userdict.email = emailTB1.Text
                    userdict.passwd = pwdTB1.Text
                    userdict.userType = userTypeCB1.SelectedItem.ToString
                    If sexMRB1.Checked = True Then
                        rec.sex = True
                    End If
                    MsgBox("�s�W�����A�Э��s�n��!", , "�s�W����")
                    TabControl1.SelectedTab = TabLogin        '����"�n�J"TabPage
                    userTB.Text = userdict.username
                    pwdTB.Text = ""
                Else
                    MsgBox("�K�X���@�P!", MessageBoxIcon.Warning, "��J���~")
                End If
            End If
        ElseIf nameTB1.Text = "" Or pwdTB1.Text = "" Or pwdCTB1.Text = "" Then
            MsgBox("��Ƥ�����!", MessageBoxIcon.Warning, "��J���~")
        End If

    End Sub

    Private Sub TabControl1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Enter
        Me.userTypeCB1.SelectedText = "�t�κ޲z��"
    End Sub

    Private Sub TabControl1_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        ClearUserData()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ClearUserData()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.userTB.Text = ""
        Me.pwdTB.Text = ""
    End Sub
End Class
