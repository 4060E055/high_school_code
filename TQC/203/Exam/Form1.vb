Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.ListView1.SelectedItems.Count <> 0 Then
            Dim fullName As String 'fullName���ثe���}�Ҫ�dat.�ɮץ��W(�]�A���|)
            fullName = pathTB.Text & "\" & ListView1.FocusedItem.Text
            Form2.FileNameLabel.Text = pathTB.Text & "\" & ListView1.FocusedItem.Text
            Dim fReader As System.IO.StreamReader
            fReader = My.Computer.FileSystem.OpenTextFileReader(fullName, System.Text.Encoding.GetEncoding("Big5"))
            Dim sr, array() As String

            While Not fReader.EndOfStream
                sr = fReader.ReadLine  '�v�CŪ�����A�ñN�����ܩ�Form2��
                array = sr.Split(vbTab)
                Select Case array(0)
                    Case "Grade":Form2.gradeTB.Text = array(1)
                    Case "Class" : Form2.classTB.Text = array(1)
                    Case "Teacher" : Form2.teacherTB.Text = array(1)
                    Case "StudentNo" : Form2.studNumTB.Text = array(1)
                    Case "Location" : Form2.locTB.Text = array(1)
                End Select
            End While
            fReader.Close()
            Form2.Show()
        Else
            MsgBox("�Х���ܸ�Ƨ�", 48, "�ާ@���~")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.pathTB.Text = Me.FolderBrowserDialog1.SelectedPath
            lvList(Me.pathTB.Text)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FolderBrowserDialog1.SelectedPath = My.Computer.FileSystem.CurrentDirectory
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.ListView1.SelectedItems.Count <> 0 Then
            Dim fullName As String 'fullName�����R����dat.�ɮץ��W(�]�A���|)
            fullName = pathTB.Text & "\" & ListView1.FocusedItem.Text
            My.Computer.FileSystem.DeleteFile(fullName) '�R���ɮ�
            lvList(pathTB.Text) '��sListView1
        Else
            MsgBox("�Х���ܸ����", 48, "�ާ@���~")
        End If
    End Sub
    Sub lvList(ByVal dir As String)
        ' �q��Ƨ�dir��X.dat�ɮסA��sListView1�A�s�WListViewItem
        Dim fCols As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        ' fCols���@�]�t�Ҧ�.dat�ɮפ��W�٪�Collection
        Dim fn As String
        ' �ϥ�My.Computer.FileSystem
        ListView1.Clear()
        Try
            fCols = My.Computer.FileSystem.GetFiles(dir, FileIO.SearchOption.SearchTopLevelOnly, "*.dat")

            For Each fn In fCols
                Dim fname As String
                fname = System.IO.Path.GetFileName(fn)
                Dim lvltem As ListViewItem
                lvltem = ListView1.Items.Add(fname)
                lvltem.ImageIndex = 0
            Next

        Catch ex As Exception
            MsgBox("��Ƨ�Ū�����~�I", 48, "�ާ@���~") '
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.pathTB.Text <> "" Then
            Form2.FileNameLabel.Text = ""
            Form2.Show()
        Else
            MsgBox("�Х���ܸ�Ƨ�", 48, "�ާ@���~")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        lvList(pathTB.Text) '��sListView1
    End Sub
End Class
