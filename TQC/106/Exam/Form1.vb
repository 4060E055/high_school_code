
Public Class Form1

    Dim n As Integer

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        picView.Image = VBD01.My.Resources.Resources.img01 : n = 1
        btnFirst.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = True
        btnLast.Enabled = True
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        picView.Image = VBD01.My.Resources.Resources.img05 : n = 5
        btnNext.Enabled = False
        btnLast.Enabled = False
        btnFirst.Enabled = True
        btnPrevious.Enabled = True
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        btnNext.Enabled = True
        btnLast.Enabled = True

        Select Case n
            Case 2
                picView.Image = VBD01.My.Resources.Resources.img01 : n = 1
            Case 3
                picView.Image = VBD01.My.Resources.Resources.img02 : n = 2
            Case 4
                picView.Image = VBD01.My.Resources.Resources.img03 : n = 3
            Case 5
                picView.Image = VBD01.My.Resources.Resources.img04 : n = 4
        End Select

        If n = 1 Then
            btnFirst.Enabled = False
            btnPrevious.Enabled = False
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        btnFirst.Enabled = True
        btnPrevious.Enabled = True

        Select Case n
            Case 2
                picView.Image = VBD01.My.Resources.Resources.img03 : n = 3
            Case 3
                picView.Image = VBD01.My.Resources.Resources.img04 : n = 4
            Case 4
                picView.Image = VBD01.My.Resources.Resources.img05 : n = 5
            Case 1
                picView.Image = VBD01.My.Resources.Resources.img02 : n = 2
        End Select
        If n = 5 Then
            btnNext.Enabled = False
            btnLast.Enabled = False
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        n = 1
    End Sub

    Private Sub btnSmall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSmall.Click
        If picView.Height * 95 / 100 >= Me.Height * 40 / 100 And picView.Width * 95 / 100 >= Me.Width * 40 / 100 Then
            picView.Size = New Size(picView.Width * 95 / 100, picView.Height * 95 / 100)
        End If
    End Sub

    Private Sub btnLarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLarge.Click
        If picView.Height * 105 / 100 <= Me.Height * 90 / 100 And picView.Width * 105 / 100 <= Me.Width * 90 / 100 Then
            picView.Size = New Size(picView.Width * 105 / 100, picView.Height * 105 / 100)
        End If
    End Sub
End Class
