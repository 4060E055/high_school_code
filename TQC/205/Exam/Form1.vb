Public Class Form1
    Dim theDate As Date '月曆目前所在日期
    Dim memo(31) As String '存放月曆目前此月份每天的memo
    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim newDate As Date '使用者點選的月曆新日期
        newDate = MonthCalendar1.SelectionRange.Start()
        ' 如果新日期與theDate不同月份
        Dim data As String = getYearMonth(theDate)
        theDate = newDate
        If getYearMonth(newDate) <> data Then
            ' 呼叫UpdateMemo()，將新日期所在月份之memo從檔案讀至memo()陣列
            UpdateMemo()
        End If
        tbMemo.Text = memo(Val(newDate.Day)) '便條紙顯示新日期的memo
        MonthCalendar1.UpdateBoldedDates()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        theDate = Today
        '利用UpdateMemo()，更新這個月的備忘資料
        UpdateMemo()
        '顯示今日之備忘資料
        tbMemo.Text = memo(theDate.Day)
        MonthCalendar1.UpdateBoldedDates()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        memo(theDate.Day) = tbMemo.Text '將便條紙區域之文字資料存至memo陣列
        If tbMemo.Text <> "" Then
            MonthCalendar1.AddBoldedDate(MonthCalendar1.SelectionRange.Start) '如果有備忘資料，將此日期加到MonthCalendar1之BoldedDate，使此日期以粗體字顯示
        End If
        Call SaveMemo()     '利用SaveMemo()，將備忘資料存至memo檔
    End Sub
    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        tbMemo.Text = ""    '清除便條紙區域之文字資料
        memo(theDate.Day) = ""  '清除memo陣列對應元素
        MonthCalendar1.RemoveBoldedDate(theDate) '將此日期從MonthCalendar1之BoldedDate集移除
        Call SaveMemo() '利用SaveMemo()，將備忘資料存至memo檔
    End Sub
    Function getYearMonth(ByVal date1 As Date) As String
        Return date1.Year & "-" & date1.Month
    End Function
    Sub UpdateMemo()
        Dim i As Integer
        For i = 0 To 31
            memo(i) = ""
        Next
        '依據theDate之年月值，讀取對應的memo檔
        If My.Computer.FileSystem.FileExists(getYearMonth(theDate) & ".memo") Then
            Dim sr As String
            Dim dat As Integer
            Dim datafile As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader _
            (getYearMonth(theDate) & ".memo", System.Text.Encoding.GetEncoding("Big5"))


            Do While Not datafile.EndOfStream
                sr = datafile.ReadLine()  '逐行讀入一天之備忘資料
                If sr <> "" Then
                    dat = Val(sr.Substring(0, sr.IndexOf(":")))    '取得此行所對應之日期
                    sr = sr.Replace("||", vbCrLf)  ' 取代||成vbCrLf
                    memo(dat) = sr.Substring(sr.IndexOf(":") + 1, sr.Length - sr.IndexOf(":") - 1) '存至memo陣列'取得此行之備忘文字資料
                    '將此日期加到MonthCalendar1之BoldedDate，使此日期以粗體字顯示
                    MonthCalendar1.AddBoldedDate(New Date(theDate.Year, theDate.Month, dat))
                End If
            Loop
            datafile.Close()
        End If
    End Sub
    Sub SaveMemo()
        Dim datafilesw As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(getYearMonth(theDate) _
     & ".memo", False, System.Text.Encoding.GetEncoding("Big5")) '依據theDate之年月值，將memo陣列之資料儲存至對應的memo檔
        Dim i As Integer
        For i = 0 To 31   '依序取出memo陣列
            '取代vbCrLf成||
            If memo(i) <> "" Then
                datafilesw.WriteLine(i & ":" & memo(i).Replace(vbCrLf, "||"))   '依memo檔格式寫入資料
            End If
        Next
        datafilesw.Close()
    End Sub
End Class
