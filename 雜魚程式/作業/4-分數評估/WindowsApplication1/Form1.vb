Public Class F1

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Dim a As Double
        a = Val(T1.Text)

        If Val(T1.Text) = 100 Then
            L1.Text = "滿分"
        ElseIf T1.Text = "" Then
            L1.Text = "至少給我輸入分數吧..."
        ElseIf Val(T1.Text) > 100 Then
            L1.Text = "畏!!請勿造假!!"
        ElseIf Val(T1.Text) > 89 Then
            L1.Text = "優等"
        ElseIf Val(T1.Text) > 79 Then
            L1.Text = "甲等"
        ElseIf Val(T1.Text) > 69 Then
            L1.Text = "乙等"
        ElseIf Val(T1.Text) > 59 Then
            L1.Text = "丙等"
        ElseIf Val(T1.Text) >= 0 Then
            L1.Text = "等著被當吧!!"
        Else : L1.Text = "原來你的分數如此的悲慘....哀.....(搖頭嘆氣)"

        End If
    End Sub

  
    
    Private Sub F1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    
End Class
