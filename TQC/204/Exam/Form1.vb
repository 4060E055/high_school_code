Public Class Form1
    Public fileDir As String '�ثe�����s��Ҧb��Ƨ�
    Public fileName As String '�ثe�s�褧�����ɮצW��(�t���|)
    Public tempFile As String '�Ȧs�����ɮצW��(�t���|)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.fileDir = My.Computer.FileSystem.CurrentDirectory
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        delTempFile()
    End Sub
    Private Sub �s����ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �s����ToolStripMenuItem.Click
        fileName = ""
        fileDir = My.Computer.FileSystem.CurrentDirectory
        Me.TextBox1.Text = "<html>" & vbCrLf & "<head></head>" & vbCrLf & "<body></body>" & vbCrLf & "</html>"
        UpdateWebBrowser()
    End Sub
    Private Sub �}�Һ���ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �}�Һ���ToolStripMenuItem.Click
        If Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '��sfileName��fileDir
            fileName = Me.OpenFileDialog1.FileName
            UpdateDir(fileName)
            '�ɮפ��eŪ��TextBox1
            OpenWebPage(fileName)
            '��sWebBrowser1���
            UpdateWebBrowser()
            '�N�ɮצW�٥[��}�ҰO����
            AddFileRecord(fileName)
        End If
    End Sub
    Private Sub �s��ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �s��ToolStripMenuItem.Click
        Me.SaveFileDialog1.InitialDirectory = Me.fileDir
        Me.SaveFileDialog1.FileName = Me.fileName
        If Me.SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            fileName = SaveFileDialog1.FileName  '�NTextBox1���e�x�s���ɮ�
            Dim fwriter As System.IO.StreamWriter
            fwriter = My.Computer.FileSystem.OpenTextFileWriter(fileName, False, System.Text.Encoding.GetEncoding("Big5"))
            fwriter.WriteLine(TextBox1.Text)
            fwriter.Close()
            AddFileRecord(fileName) '�N���ɮצW�٥[��}�ҰO����
        End If
    End Sub
    Private Sub ����ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����ToolStripMenuItem.Click
        delTempFile()
        End
    End Sub
    Private Sub recMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '���X�ϥΪ̩�}�ҰO�����ҿ諸�ɮפ��ɮצW��
        fileName = sender.ToString
        UpdateDir(fileName) '��sfileDir
        OpenWebPage(fileName) '�ɮפ��eŪ��TextBox1
        UpdateWebBrowser()  '��sWebBrowser1���
    End Sub
    Private Sub TabControl1_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        UpdateWebBrowser()
    End Sub
    Public Sub OpenWebPage(ByVal fName As String)
        '�NfName�ҫ���������l�ɮפ��eŪ��TextBox1
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
        UpdateDir(tempFile) '�N�ثe��TextBox1���s�褧HTML���e�A�s��tempFile
        WebBrowser1.Navigate(fileName)  'WebBrowser1���tempFile������
    End Sub
    Public Sub UpdateDir(ByVal fName As String)
        '�q�]�t���|���ɮצW��fName�A���X��Ƨ��W�١A�N����Ƨ��W�٦s��fileDir
        Dim fi As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(fName)
        Me.fileDir = fi.DirectoryName
    End Sub
    Public Sub AddFileRecord(ByVal fName As String)
        Dim msi As ToolStripMenuItem
        Dim isInRecord As Boolean = False '�ΨӧP�_fName�O�_�w�b�}�ҰO����
        If �O��ToolStripMenuItem.DropDownItems.ContainsKey(fName) = False Then '�P�_fName�O�_�w�b�}�ҰO����
            '�p�GfName�|���b�}�ҰO����
            ' 1. �b"�O��ToolStripMenuItem"���s�W�@ToolStripMenuItem
            ' 2. �NrecMenuItem_Click�{�ǳ]���ҷs�W��ToolStripMenuItem��Click�ƥ�B�z�{��
            msi = New ToolStripMenuItem
            msi.Name = fName
            msi.Text = fName
            �O��ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {msi})
            AddHandler msi.Click, AddressOf recMenuItem_Click
        End If
    End Sub
    Public Sub delTempFile()
        '�p�G���e���x�s������tempFile�A�{�b�NtempFile�R��
        Try
            My.Computer.FileSystem.DeleteFile(fileDir & "\temp.html")
        Catch
        End Try
    End Sub
End Class
