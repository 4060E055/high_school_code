Public Class Form1
    Dim filenum As String

    Private Sub btnPathBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPathBrowse.Click
        If OO1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtFilePath.Text = OO1.FileName
        End If

    End Sub

    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        If txtFilePath.Text = "" Then
            MsgBox("未輸入檔案路徑", , "提示")
        Else
            Try
                Dim Openfile As System.Diagnostics.Process
                Openfile = New System.Diagnostics.Process()
                Openfile.StartInfo.FileName = txtFilePath.Text
                Openfile.Start()
            Catch ex As Exception
                MsgBox("檔案路徑錯誤")
            End Try
        End If
    End Sub

    Private Sub btnSaveTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTo.Click
        If txtFilePath.Text = "" Then
            MsgBox("未輸入檔案路徑", , "提示")
        Else
            If SS1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(Mid(SS1.FileName, 1, Len(SS1.FileName) - 4) & ".txt", 1, False)
                txtFilePath.Text = SS1.FileName
                MsgBox("儲存成功...", , "訊息")
            End If
        End If
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
