Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.ListView1.SelectedItems.Count <> 0 Then
            Dim fullName As String 'fullName為目前欲開啟的dat.檔案全名(包括路徑)
            fullName = pathTB.Text & "\" & ListView1.FocusedItem.Text
            Form2.FileNameLabel.Text = pathTB.Text & "\" & ListView1.FocusedItem.Text
            Dim fReader As System.IO.StreamReader
            fReader = My.Computer.FileSystem.OpenTextFileReader(fullName, System.Text.Encoding.GetEncoding("Big5"))
            Dim sr, array() As String

            While Not fReader.EndOfStream
                sr = fReader.ReadLine  '逐列讀取欄位，並將資料顯示於Form2中
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
            MsgBox("請先選擇資料夾", 48, "操作錯誤")
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
            Dim fullName As String 'fullName為欲刪除的dat.檔案全名(包括路徑)
            fullName = pathTB.Text & "\" & ListView1.FocusedItem.Text
            My.Computer.FileSystem.DeleteFile(fullName) '刪除檔案
            lvList(pathTB.Text) '更新ListView1
        Else
            MsgBox("請先選擇資料檔", 48, "操作錯誤")
        End If
    End Sub
    Sub lvList(ByVal dir As String)
        ' 從資料夾dir找出.dat檔案，更新ListView1，新增ListViewItem
        Dim fCols As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        ' fCols為一包含所有.dat檔案之名稱的Collection
        Dim fn As String
        ' 使用My.Computer.FileSystem
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
            MsgBox("資料夾讀取錯誤！", 48, "操作錯誤") '
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.pathTB.Text <> "" Then
            Form2.FileNameLabel.Text = ""
            Form2.Show()
        Else
            MsgBox("請先選擇資料夾", 48, "操作錯誤")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        lvList(pathTB.Text) '更新ListView1
    End Sub
End Class
