Public Class Form1
    '宣告userDict為一個以String型態為Key，UserRec為值之Dictionary
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
        rec = userdict    '從userDict取出帳號資料

        If rec.passwd = pwdTB.Text And rec.username = userTB.Text And pwdTB.Text <> "" And userTB.Text <> "" Then  '檢查帳號是否存在，密碼是否正確
            TabControl1.SelectedTab = TabUserData
            '將帳號資料顯示於基本資料TabPage
            nameTB2.Text = userdict.username
            pwdTB2.Text = userdict.passwd
            emailLabel.Text = userdict.email
            If userdict.sex = True Then
                sexFRB2.Checked = True
            Else : sexMRB2.Checked = True
            End If

            userTypeCB.Text = userdict.userType

        ElseIf rec.passwd <> pwdTB.Text And rec.username = userTB.Text Then
            MessageBox.Show("密碼錯誤!", "密碼錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            pwdTB.Text = ""

        Else
            '若帳號不存在，顯示警告訊息，並跳至"新增"TabPage
            Dim msg As String
            msg = "使用者 " & Me.userTB.Text & "不存在!" & vbCrLf & "請新增使用者資料"
            MessageBox.Show(msg, "登入錯誤!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TabControl1.SelectedTab = TabNewUser
        End If
     
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim rec As New UserRec
        rec = userdict  '檢查使用者是否已存在
        If rec.username = nameTB1.Text Then
            MessageBox.Show("使用者 " & Me.nameTB1.Text & "已存在!", "查詢結果", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("使用者 " & Me.nameTB1.Text & "不存在!" & vbCrLf & "可以繼續輸入資料", "查詢結果", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim rec As New UserRec
        rec = userdict
        If nameTB1.Text <> "" And pwdTB1.Text <> "" And pwdCTB1.Text <> "" Then  '檢查是否輸入使用者名稱與密碼

            '檢查使用者是否已存在
            If rec.username = nameTB1.Text Then
                MessageBox.Show("使用者 " & Me.nameTB1.Text & "已存在!", "查詢結果", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                '檢查密碼是否一致
                If pwdTB1.Text = pwdCTB1.Text Then
                    userdict.username = nameTB1.Text '若不存在，使用者帳號資料存入userDict
                    userdict.email = emailTB1.Text
                    userdict.passwd = pwdTB1.Text
                    userdict.userType = userTypeCB1.SelectedItem.ToString
                    If sexMRB1.Checked = True Then
                        rec.sex = True
                    End If
                    MsgBox("新增完成，請重新登錄!", , "新增完成")
                    TabControl1.SelectedTab = TabLogin        '跳至"登入"TabPage
                    userTB.Text = userdict.username
                    pwdTB.Text = ""
                Else
                    MsgBox("密碼不一致!", MessageBoxIcon.Warning, "輸入錯誤")
                End If
            End If
        ElseIf nameTB1.Text = "" Or pwdTB1.Text = "" Or pwdCTB1.Text = "" Then
            MsgBox("資料不齊全!", MessageBoxIcon.Warning, "輸入錯誤")
        End If

    End Sub

    Private Sub TabControl1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Enter
        Me.userTypeCB1.SelectedText = "系統管理者"
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
