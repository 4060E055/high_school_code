Public Class K1
    Dim 姓名 As String
    Dim 雌雄 As String
    Dim 血 As String
    Dim 形貌 As String
    Dim 高度 As String
    Dim 重量 As String
    Dim 髮 As String
    Dim 興趣 As String
    

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click

        興趣 = ""

        姓名 = T1.Text

        If P1.Checked = True Then
            雌雄 = "先生"
        ElseIf P2.Checked = True Then
            雌雄 = "小姐"
        End If

        If O1.Checked = True Then
            血 = "A"
        ElseIf O2.Checked = True Then
            血 = "B"
        ElseIf O3.Checked = True Then
            血 = "AB"
        ElseIf O4.Checked = True Then
            血 = "O"
        End If

        If H1.Checked = True Then
            髮 = "自然捲"
        ElseIf H2.Checked = True Then
            髮 = "燙壞捲"
        ElseIf H3.Checked = True Then
            髮 = "塌直髮"
        End If

        If G1.Checked = True AndAlso 雌雄 = "先生" Then
            形貌 = "帥哥"
        ElseIf G1.Checked = True AndAlso 雌雄 = "小姐" Then
            形貌 = "正咩"
        ElseIf G2.Checked = True Then
            形貌 = "普通"
        ElseIf G3.Checked = True AndAlso 雌雄 = "先生" Then
            形貌 = "醜男"
        ElseIf G3.Checked = True AndAlso 雌雄 = "小姐" Then
            形貌 = "醜女"
        End If

        If I1.Checked = True Then
            高度 = "180cm以上"
        ElseIf I2.Checked = True Then
            高度 = "170~179cm"
        ElseIf I3.Checked = True Then
            高度 = "160~169cm"
        ElseIf I4.Checked = True Then
            高度 = "150~159cm"
        ElseIf I5.Checked = True Then
            高度 = "149cm以下"
        End If

        If K11.Checked = True Then
            重量 = "70kg以上"
        ElseIf K2.Checked = True Then
            重量 = "60~69kg"
        ElseIf K3.Checked = True Then
            重量 = "50~59kg"
        ElseIf K4.Checked = True Then
            重量 = "40~49kg"
        ElseIf K5.Checked = True Then
            重量 = "39kg以下"

        End If

        If C1.Checked = True Then 興趣 = 興趣 & Space(2) & C1.Text
        If C2.Checked = True Then 興趣 = 興趣 & Space(4) & C2.Text
        If C3.Checked = True Then 興趣 = 興趣 & Space(4) & C3.Text
        If C4.Checked = True Then 興趣 = 興趣 & Space(4) & C4.Text
        If C5.Checked = True Then 興趣 = 興趣 & Space(4) & C5.Text
        If C6.Checked = True Then 興趣 = 興趣 & Space(4) & C6.Text

      
        If 姓名 = "" OrElse 雌雄 = "" OrElse 血 = "" OrElse 髮 = "" OrElse 高度 = "" OrElse 重量 = "" OrElse 形貌 = "" OrElse 興趣 = "" Then
            L1.Text = ""
            MsgBox("未輸入完整!!", MsgBoxStyle.ApplicationModal, AcceptButton)
        Else : L1.Text = 姓名 & 雌雄 & "以下幫您確認一下您的資料:" & vbNewLine & "血型為" & 血 & vbNewLine & "髮型為" & 髮 & vbNewLine & "形貌為" & 形貌 & vbNewLine & "身高為" & 高度 & vbNewLine & "體重為" & 重量 & vbNewLine & "興趣為" & 興趣
        End If

    End Sub

   
End Class
