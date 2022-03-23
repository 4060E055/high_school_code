Public Class Form2
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fileName As String 'fileName為欲儲存的dat.檔案全名(包括路徑)
        Dim in1, in2 As Integer
        If gradeTB.Text <> "" And classTB.Text <> "" Then
            If Integer.TryParse(gradeTB.Text, in1) And Integer.TryParse(classTB.Text, in2) Then


                Try
                    fileName = Form1.pathTB.Text & "\" & gradeTB.Text & "年" & classTB.Text & "班.dat"
                    Dim sw As System.IO.StreamWriter = _
                    My.Computer.FileSystem.OpenTextFileWriter(fileName, False, System.Text.Encoding.GetEncoding("Big5"))
                    sw.WriteLine("Grade" & vbTab & gradeTB.Text) '資料寫入.dat檔案
                    sw.WriteLine("Class" & vbTab & classTB.Text)
                    sw.WriteLine("Teacher" & vbTab & teacherTB.Text)
                    sw.WriteLine("StudentNo" & vbTab & studNumTB.Text)
                    sw.WriteLine("Location" & vbTab & locTB.Text)
                    sw.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Return
                End Try
                MessageBox.Show("已存於" & fileName, "存檔完成", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form1.lvList(Form1.pathTB.Text) '更新Form1之ListView1
            Else
                MsgBox("年班級資料輸入錯誤！", MsgBoxStyle.Critical, "操作錯誤")
            End If
        Else
            MsgBox("缺少年班級資料，無法存檔！", MsgBoxStyle.Critical, "操作錯誤")   '
        End If
    End Sub

End Class