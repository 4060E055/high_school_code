Imports System.IO
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        Me.Text = "簡易編輯器-(NewFile)"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = "RTF文件|*.rtf|純文字檔(*.txt)|*.txt"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim filepath As String = OpenFileDialog1.FileName
            Dim filesr As New FileInfo(filepath)
            Dim sr As StreamReader = filesr.OpenText
            TextBox1.Text = sr.ReadToEnd
            Me.Text = "簡易編輯器-" & filepath
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SaveFileDialog1.Filter = "RTF文件|*.rtf|純文字檔(*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim filepath As String = SaveFileDialog1.FileName
            Dim fw As System.IO.StreamWriter
            fw = My.Computer.FileSystem.OpenTextFileWriter(filepath, False, System.Text.Encoding.GetEncoding("Big5"))
            fw.Write(TextBox1.Text)
            fw.Close()
            Me.Text = "簡易編輯器-" & filepath
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            CheckBox1.Text = "全部尋找"
            TextBox3.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            CheckBox1.Text = "全部取代"
            TextBox3.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If RadioButton1.Checked = True Then '搜尋

            If CheckBox1.Checked = True Then '全部


            Else


            End If

        Else '取代


            If CheckBox1.Checked = True Then '全部
                TextBox1.Text = TextBox1.Text.Replace(TextBox2.Text, TextBox3.Text)
                Button4.Enabled = True
            Else

                Button4.Enabled = True
            End If

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Button4.Enabled = False
    End Sub
End Class
