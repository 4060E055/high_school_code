Public Class Form1
    Public fileDir As String '目前網頁編輯所在資料夾
    Public fileName As String '目前編輯之網頁檔案名稱(含路徑)
    Public tempFile As String '暫存網頁檔案名稱(含路徑)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.fileDir = My.Computer.FileSystem.CurrentDirectory
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        delTempFile()
    End Sub
    Private Sub 新網頁ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新網頁ToolStripMenuItem.Click
        fileName = ""
        fileDir = My.Computer.FileSystem.CurrentDirectory
        Me.TextBox1.Text = "<html>" & vbCrLf & "<head></head>" & vbCrLf & "<body></body>" & vbCrLf & "</html>"
        UpdateWebBrowser()
    End Sub
    Private Sub 開啟網頁ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 開啟網頁ToolStripMenuItem.Click
        If Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '更新fileName及fileDir
            fileName = Me.OpenFileDialog1.FileName
            UpdateDir(fileName)
            '檔案內容讀至TextBox1
            OpenWebPage(fileName)
            '更新WebBrowser1顯示
            UpdateWebBrowser()
            '將檔案名稱加到開啟記錄中
            AddFileRecord(fileName)
        End If
    End Sub
    Private Sub 存檔ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 存檔ToolStripMenuItem.Click
        Me.SaveFileDialog1.InitialDirectory = Me.fileDir
        Me.SaveFileDialog1.FileName = Me.fileName
        If Me.SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            fileName = SaveFileDialog1.FileName  '將TextBox1內容儲存至檔案
            Dim fwriter As System.IO.StreamWriter
            fwriter = My.Computer.FileSystem.OpenTextFileWriter(fileName, False, System.Text.Encoding.GetEncoding("Big5"))
            fwriter.WriteLine(TextBox1.Text)
            fwriter.Close()
            AddFileRecord(fileName) '將此檔案名稱加到開啟記錄中
        End If
    End Sub
    Private Sub 結束ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 結束ToolStripMenuItem.Click
        delTempFile()
        End
    End Sub
    Private Sub recMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '取出使用者於開啟記錄中所選的檔案之檔案名稱
        fileName = sender.ToString
        UpdateDir(fileName) '更新fileDir
        OpenWebPage(fileName) '檔案內容讀至TextBox1
        UpdateWebBrowser()  '更新WebBrowser1顯示
    End Sub
    Private Sub TabControl1_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        UpdateWebBrowser()
    End Sub
    Public Sub OpenWebPage(ByVal fName As String)
        '將fName所指之網頁原始檔案內容讀至TextBox1
        Try
            Dim freader As System.IO.StreamReader
            freader = My.Computer.FileSystem.OpenTextFileReader(fName, System.Text.Encoding.GetEncoding("Big5"))
            While Not freader.EndOfStream
                TextBox1.Text = freader.ReadToEnd
            End While
            freader.Close()
        Catch
        End Try

    End Sub
    Public Sub UpdateWebBrowser()  

        tempFile = Me.fileDir & "\temp.html"
        UpdateDir(tempFile) '將目前於TextBox1中編輯之HTML內容，存至tempFile
        WebBrowser1.Navigate(fileName)  'WebBrowser1顯示tempFile之網頁
    End Sub
    Public Sub UpdateDir(ByVal fName As String)
        '從包含路徑之檔案名稱fName，取出資料夾名稱，將此資料夾名稱存至fileDir
        Dim fi As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(fName)
        Me.fileDir = fi.DirectoryName
    End Sub
    Public Sub AddFileRecord(ByVal fName As String)
        Dim msi As ToolStripMenuItem
        Dim isInRecord As Boolean = False '用來判斷fName是否已在開啟記錄中
        If 記錄ToolStripMenuItem.DropDownItems.ContainsKey(fName) = False Then '判斷fName是否已在開啟記錄中
            '如果fName尚未在開啟記錄中
            ' 1. 在"記錄ToolStripMenuItem"中新增一ToolStripMenuItem
            ' 2. 將recMenuItem_Click程序設為所新增之ToolStripMenuItem之Click事件處理程序
            msi = New ToolStripMenuItem
            msi.Name = fName
            msi.Text = fName
            記錄ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {msi})
            AddHandler msi.Click, AddressOf recMenuItem_Click
        End If
    End Sub
    Public Sub delTempFile()
        '如果之前有儲存網頁至tempFile，現在將tempFile刪除
        Try
            My.Computer.FileSystem.DeleteFile(fileDir & "\temp.html")
        Catch
        End Try
    End Sub
End Class
