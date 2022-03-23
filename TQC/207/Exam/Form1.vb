Public Class Form1


    Private Sub btnMusicBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMusicBrowse.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtMusicPath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        If txtMusicPath.Text = "" Then
            MsgBox("未輸入檔案路徑", , "提示")
        Else
            Try
                My.Computer.Audio.Play(txtMusicPath.Text)
            Catch ex As Exception
                MsgBox("錯誤")
            End Try
        End If
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
