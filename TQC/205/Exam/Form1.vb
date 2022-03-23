Public Class Form1
    Dim theDate As Date '���ثe�Ҧb���
    Dim memo(31) As String '�s����ثe������C�Ѫ�memo
    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim newDate As Date '�ϥΪ��I�諸���s���
        newDate = MonthCalendar1.SelectionRange.Start()
        ' �p�G�s����PtheDate���P���
        Dim data As String = getYearMonth(theDate)
        theDate = newDate
        If getYearMonth(newDate) <> data Then
            ' �I�sUpdateMemo()�A�N�s����Ҧb�����memo�q�ɮ�Ū��memo()�}�C
            UpdateMemo()
        End If
        tbMemo.Text = memo(Val(newDate.Day)) '�K������ܷs�����memo
        MonthCalendar1.UpdateBoldedDates()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        theDate = Today
        '�Q��UpdateMemo()�A��s�o�Ӥ몺�ƧѸ��
        UpdateMemo()
        '��ܤ��餧�ƧѸ��
        tbMemo.Text = memo(theDate.Day)
        MonthCalendar1.UpdateBoldedDates()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        memo(theDate.Day) = tbMemo.Text '�N�K���Ȱϰ줧��r��Ʀs��memo�}�C
        If tbMemo.Text <> "" Then
            MonthCalendar1.AddBoldedDate(MonthCalendar1.SelectionRange.Start) '�p�G���ƧѸ�ơA�N������[��MonthCalendar1��BoldedDate�A�Ϧ�����H����r���
        End If
        Call SaveMemo()     '�Q��SaveMemo()�A�N�ƧѸ�Ʀs��memo��
    End Sub
    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        tbMemo.Text = ""    '�M���K���Ȱϰ줧��r���
        memo(theDate.Day) = ""  '�M��memo�}�C��������
        MonthCalendar1.RemoveBoldedDate(theDate) '�N������qMonthCalendar1��BoldedDate������
        Call SaveMemo() '�Q��SaveMemo()�A�N�ƧѸ�Ʀs��memo��
    End Sub
    Function getYearMonth(ByVal date1 As Date) As String
        Return date1.Year & "-" & date1.Month
    End Function
    Sub UpdateMemo()
        Dim i As Integer
        For i = 0 To 31
            memo(i) = ""
        Next
        '�̾�theDate���~��ȡAŪ��������memo��
        If My.Computer.FileSystem.FileExists(getYearMonth(theDate) & ".memo") Then
            Dim sr As String
            Dim dat As Integer
            Dim datafile As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader _
            (getYearMonth(theDate) & ".memo", System.Text.Encoding.GetEncoding("Big5"))


            Do While Not datafile.EndOfStream
                sr = datafile.ReadLine()  '�v��Ū�J�@�Ѥ��ƧѸ��
                If sr <> "" Then
                    dat = Val(sr.Substring(0, sr.IndexOf(":")))    '���o����ҹ��������
                    sr = sr.Replace("||", vbCrLf)  ' ���N||��vbCrLf
                    memo(dat) = sr.Substring(sr.IndexOf(":") + 1, sr.Length - sr.IndexOf(":") - 1) '�s��memo�}�C'���o���椧�ƧѤ�r���
                    '�N������[��MonthCalendar1��BoldedDate�A�Ϧ�����H����r���
                    MonthCalendar1.AddBoldedDate(New Date(theDate.Year, theDate.Month, dat))
                End If
            Loop
            datafile.Close()
        End If
    End Sub
    Sub SaveMemo()
        Dim datafilesw As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(getYearMonth(theDate) _
     & ".memo", False, System.Text.Encoding.GetEncoding("Big5")) '�̾�theDate���~��ȡA�Nmemo�}�C������x�s�ܹ�����memo��
        Dim i As Integer
        For i = 0 To 31   '�̧Ǩ��Xmemo�}�C
            '���NvbCrLf��||
            If memo(i) <> "" Then
                datafilesw.WriteLine(i & ":" & memo(i).Replace(vbCrLf, "||"))   '��memo�ɮ榡�g�J���
            End If
        Next
        datafilesw.Close()
    End Sub
End Class
