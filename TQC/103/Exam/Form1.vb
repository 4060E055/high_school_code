Public Class Form1
    Dim num As Integer = 1 '個人票數目
    Dim tickPrice, totalPrice As Integer
    Public Function checkDate() As Boolean
        If Format(tickDate.Value, "dddd") = "星期一" Then '判斷並處理週一不開館之情形
            MsgBox("週一不開館", , "日期錯誤")      '若有錯誤,以MessageBox回覆錯誤訊息，Return false
            Return False
        ElseIf Format(tickDate.Value, "dddd") = "星期日" And dayRB2.Checked = True Then        '判斷並處理週日不售二日券之情形
            MsgBox("週日不售二日券", , "日期錯誤")        '若有錯誤,以MessageBox回覆錯誤訊息，Return false
            Return False
        Else : Return True
        End If
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '預設參觀日期為今日
    End Sub

    Private Sub perCB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles perCB.CheckedChanged
        '依據CheckBox值，啟用或暫停相關控制項
        If perCB.Checked = False Then
            tickRB1.Enabled = False : tickRB2.Enabled = False : tickRB3.Enabled = False : tickRB4.Enabled = False
        ElseIf perCB.Checked = True Then
            tickRB1.Enabled = True : tickRB2.Enabled = True : tickRB3.Enabled = True : tickRB4.Enabled = True
        End If
    End Sub

    Private Sub grpCB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpCB.CheckedChanged
        '依據CheckBox值，啟用或暫停相關控制項
        If grpCB.Checked = False Then
            groupTB.Enabled = False
        ElseIf grpCB.Checked = True Then
            groupTB.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '設定以下控制項
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
        '檢查日期設定及開館與否
        If checkDate() = True Then

            tickPrice = 100 ' 每張個人票一日券票價
            If dayRB2.Checked = True Then tickPrice = 180 '判斷是否選購二日券，重新設定tickPrice
            If movieCB.Checked = True Then tickPrice += 50 '判斷是否加購3D電影及虛擬Golf，加計至tickPrice
            If vrCB.Checked = True Then tickPrice += 50
            totalPrice = 0

            If perCB.Checked = True Then

                If tickRB1.Checked = True Then : num = 1
                ElseIf tickRB2.Checked = True Then : num = 2
                ElseIf tickRB3.Checked = True Then : num = 3
                ElseIf tickRB4.Checked = True Then : num = 4
                End If

                '計算個人票應付金額
                totalPrice = num * tickPrice

            End If

            If grpCB.Checked = True And CheckPeople() = True Then '如果勾選團體票，則檢查團體票人數是否正確
                '加計團體票應付金額
                totalPrice += Val(groupTB.Text) * tickPrice * 0.8
                payPanel.Visible = True
                payLabel.Text = "NT$" & totalPrice
            ElseIf grpCB.Checked = False Then
                payPanel.Visible = True      '顯示應付金額
                payLabel.Text = "NT$" & totalPrice
            End If

        Else
            payPanel.Visible = False    '若日期檢查錯誤，不顯示應付金額
        End If
    End Sub

  
    Private Function CheckPeople()
        If groupTB.Text = "" Then '檢查團體票人數輸入正確與否
            MsgBox("請輸入數字", , "人數錯誤")
            Return False
        ElseIf Val(groupTB.Text) < 20 Then
            MsgBox("須至少20人，才能購買團體票", , "人數錯誤")
            Return False
        Else : Return True
        End If
    End Function
End Class
