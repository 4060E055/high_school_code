Public Class Form2
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fileName As String 'fileName�����x�s��dat.�ɮץ��W(�]�A���|)
        Dim in1, in2 As Integer
        If gradeTB.Text <> "" And classTB.Text <> "" Then
            If Integer.TryParse(gradeTB.Text, in1) And Integer.TryParse(classTB.Text, in2) Then


                Try
                    fileName = Form1.pathTB.Text & "\" & gradeTB.Text & "�~" & classTB.Text & "�Z.dat"
                    Dim sw As System.IO.StreamWriter = _
                    My.Computer.FileSystem.OpenTextFileWriter(fileName, False, System.Text.Encoding.GetEncoding("Big5"))
                    sw.WriteLine("Grade" & vbTab & gradeTB.Text) '��Ƽg�J.dat�ɮ�
                    sw.WriteLine("Class" & vbTab & classTB.Text)
                    sw.WriteLine("Teacher" & vbTab & teacherTB.Text)
                    sw.WriteLine("StudentNo" & vbTab & studNumTB.Text)
                    sw.WriteLine("Location" & vbTab & locTB.Text)
                    sw.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Return
                End Try
                MessageBox.Show("�w�s��" & fileName, "�s�ɧ���", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form1.lvList(Form1.pathTB.Text) '��sForm1��ListView1
            Else
                MsgBox("�~�Z�Ÿ�ƿ�J���~�I", MsgBoxStyle.Critical, "�ާ@���~")
            End If
        Else
            MsgBox("�ʤ֦~�Z�Ÿ�ơA�L�k�s�ɡI", MsgBoxStyle.Critical, "�ާ@���~")   '
        End If
    End Sub

End Class