Public Class Form1
    Dim ia, ib As String

    Private Sub rbA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbA.CheckedChanged
        If rbA.Checked Then Me.lblOP.Text = "+" : Me.lblAns.Text = ""
    End Sub

    Private Sub rbS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbS.CheckedChanged
        If rbS.Checked Then Me.lblOP.Text = "-" : Me.lblAns.Text = ""
    End Sub

    Private Sub rbM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbM.CheckedChanged
        If rbM.Checked Then Me.lblOP.Text = "×" : Me.lblAns.Text = ""
    End Sub

    Private Sub rbD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbD.CheckedChanged
        If rbD.Checked Then Me.lblOP.Text = "÷" : Me.lblAns.Text = ""
    End Sub

    Private Sub rbC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbC.CheckedChanged
        If rbC.Checked Then Me.lblOP.Text = "+...+" : Me.lblAns.Text = ""
    End Sub

    '請於以下填入四則運算程式

    Function zxc()

        Dim i As Integer
        Dim aa As String = ia & ib

        For i = 1 To Len(aa)
            If Asc(Microsoft.VisualBasic.Mid(aa, i, 1)) > 57 Or Asc(Microsoft.VisualBasic.Mid(aa, i, 1)) < 48 Then
                zxc = False
                MsgBox("請輸入數值", 16, "錯誤訊息")
                Exit Function
            End If
        Next
        zxc = True

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ia = T1.Text : ib = T2.Text
        If zxc() = True Then
            If rbA.Checked = True Then
                lblAns.Text = Val(T1.Text) + Val(T2.Text)
            ElseIf rbS.Checked = True Then
                lblAns.Text = Val(T1.Text) - Val(T2.Text)
            ElseIf rbM.Checked = True Then
                lblAns.Text = Val(T1.Text) * Val(T2.Text)
            ElseIf rbD.Checked = True Then
                lblAns.Text = Val(T1.Text) / Val(T2.Text)
            ElseIf rbC.Checked = True Then
                If Val(T2.Text) < Val(T1.Text) Then
                    MsgBox("連加數字請由小至大！")
                Else
                    Dim i, sum As Single

                    For i = Val(T1.Text) To Val(T2.Text)
                        sum += i
                    Next
                    lblAns.Text = sum
                End If
            End If
        End If
    End Sub
End Class
