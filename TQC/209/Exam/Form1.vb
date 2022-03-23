Public Class Form1

    Dim S() As String = {"S白雪公主", "S小鹿斑比", "S幻想曲", "S愛麗絲夢遊仙境", "S１０１忠狗", "S小美人魚"}
    Dim N() As String = {"N 鬼使神差", "N 地海戰記", "N 亞瑟的奇幻王國", "N 夏綠蒂的網", "N 花田少年史", "N 惡靈戰警", "N 血鑽石"}

    Private Sub SetN()
        ' /**  註:此段程式在 設定將左邊清單為 N熱門新片 之影片 **/

        '宣告陣列 AryN,提示:影片清單包括 "N鬼使神差", "N地海戰記", "N亞瑟的奇幻王國", "N夏綠蒂的網", "N花田少年史", "N惡靈戰警", "N血鑽石"
      
        Me.LblTP.Text = "N熱門新片"   '變更清單顯示名稱
        Me.lbPrice.Text = 100         '單價設為100

        lbItems.Items.Clear() '左邊清單清空

        Dim i As Integer '宣告整數 i 
        lbItems.Items.AddRange(N)

        For i = 1 To lbAdd.Items.Count   '顯示陣列中未與右邊清單重覆之影片名稱,提示:使用 For ... Next
            If lbItems.Items.Contains(lbAdd.Items(i - 1)) = True Then
                lbItems.Items.Remove(lbAdd.Items(i - 1))
            End If
        Next
    End Sub

    Private Sub SetS()

        ' /**  註:此段程式在 設定將左邊清單為 S經典動畫 之影片 **/
        '宣告陣列 AryS,提示:影片清單包括 "S白雪公主", "S小鹿斑比", "S幻想曲", "S愛麗絲夢遊仙境", "S１０１忠狗", "S小美人魚"

        Me.LblTP.Text = "S經典動畫"    '變更清單顯示名稱
        Me.lbPrice.Text = 50           '單價設為50

        lbItems.Items.Clear()  '左邊清單清空
        Dim i As Integer '宣告整數 i 
        lbItems.Items.AddRange(S)

        For i = 1 To lbAdd.Items.Count   '顯示陣列中未與右邊清單重覆之影片名稱,提示:使用 For ... Next
            If lbItems.Items.Contains(lbAdd.Items(i - 1)) = True Then
                lbItems.Items.Remove(lbAdd.Items(i - 1))
            End If
        Next
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        ' /**  註:此段程式在將左邊清單lbItems點選項目加到右邊清單lbAdd,並調整數量和小計  **/

        If Me.lbItems.SelectedItems.Count > 0 Then
            If Microsoft.VisualBasic.Left(lbItems.SelectedItem.ToString, 1) = "S" Then
                lblAmt.Text += 50
            Else
                lblAmt.Text += 100
            End If
            lbAdd.Items.Add(lbItems.SelectedItem.ToString)
            lbItems.Items.Remove(lbItems.SelectedItem.ToString)
            lblQty.Text += 1

            Call CalTotal()

        Else
            MsgBox("請選擇要租的影片!", MsgBoxStyle.Information)
        End If

    End Sub


    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        ' /**  註:此段程式在將右邊清單lbAdd點選項目移除,若與左邊清單同類,則加入左邊清單,並調整數量和小計  **/

        If Me.lbAdd.SelectedItems.Count > 0 Then '有點選才執行
            If Microsoft.VisualBasic.Left(lbAdd.SelectedItem.ToString, 1) = "S" Then
                lblAmt.Text -= 50
                If LblTP.Text = "S經典動畫" Then
                    lbItems.Items.Add(lbAdd.SelectedItem.ToString)
                End If
            Else
                lblAmt.Text -= 100
                If LblTP.Text = "N熱門新片" Then
                    lbItems.Items.Add(lbAdd.SelectedItem.ToString)
                End If
            End If
            ' 指定i為點選索引值

            lbAdd.Items.Remove(lbAdd.SelectedItem.ToString)
            lblQty.Text -= 1 '數量減 1

            Call CalTotal()  '計算合計金額

        End If
    End Sub

    Private Sub CalTotal()
        ' /**  註:此段程式在 計算合計金額 **/

        '合計=小計+10*數量*天數
        lblTotal.Text = lblAmt.Text + 10 * lblQty.Text * lblDays.Text

    End Sub

    Private Sub tlsReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' /**  註:此段程式在 重新選擇 **/

        lbAdd.Items.Clear()  '清空右邊清單選項
        If Me.LblTP.Text = "S經典動畫" Then    '依目前所選的項目，執行 SetN() or SetS()
            lbItems.Items.AddRange(S)
        Else
            lbItems.Items.AddRange(N)
        End If
    End Sub

    Private Sub 結束ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 結束ToolStripMenuItem.Click
        End
    End Sub

    Private Sub N熱門新片ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N熱門新片ToolStripMenuItem.Click
        Call SetN()
    End Sub

    Private Sub S經典動畫ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S經典動畫ToolStripMenuItem.Click
        Call SetS()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = Now

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        lblDays.Text = DateDiff(DateInterval.Day, Now, DateTimePicker1.Value) + 1
        If Format(DateTimePicker1.Value, "D") = Format(Now, "D") Then lblDays.Text = 0
        Call CalTotal()
    End Sub

    Private Sub 重新選擇ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 重新選擇ToolStripMenuItem.Click
        DateTimePicker1.MinDate = Now
        lblQty.Text = 0
        lblAmt.Text = 0
        lblDays.Text = 0
        lbAdd.Items.Clear()
        lblTotal.Text = 0
    End Sub
End Class
