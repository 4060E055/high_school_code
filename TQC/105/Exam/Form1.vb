Public Class Form1
    Dim cardChar() As String = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"}
    Dim n As Integer
    Private Sub ButtonPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPlay.Click
        Dim CardNum(4) As Integer '5個元素，每一元素值 0~51, 代表52牌中之某一張
        Dim CardValue(4) As Integer '5個元素，每一元素值 0~12, 代表A, 1, .., J, Q, K
        Dim CardSuit(4) As Integer '5個元素，每一元素值  0~3, 代表 spade(梅花), heart(愛心), diamond(菱形), club(黑陶)
        Dim isTaken(51) As Boolean '記錄某一張樸克牌是否已發過
        Dim i As Integer ' 目前所發的樸克牌
        '請至表單設計畫面，調整PicCover1~5之位置，使之置於樸克牌正上方
        PicCover1.Show()
        PicCover2.Show()
        PicCover3.Show()
        PicCover4.Show()
        PicCover5.Show()

        For i = 0 To 4
            Dim isOK As Boolean = False '是否已成功發一張卡

            Do
                Randomize()
                ' 產生一張卡
                n = Fix(Rnd() * 52)
                CardNum(i) = n
                '判斷是否已發過，發過必須重發
                If isTaken(n) <> True Then
                    isTaken(n) = True
                    isOK = True
                End If

            Loop Until isOK = True


            CardValue(i) = n Mod 13
            CardSuit(i) = n \ 13
        Next


        '顯示樸克牌點數及顏色於Label1 ~ Label5
        '顯示樸克牌花色於PictureBox1 ~ PictureBox5
        If CardSuit(0) = 1 Or CardSuit(0) = 2 Then
            Label1.ForeColor = Color.Red
        ElseIf CardSuit(0) = 0 Or CardSuit(0) = 3 Then
            Label1.ForeColor = Color.Black
        End If

        Label1.Text = cardChar(CardValue(0))
        PictureBox1.Image = ImageList1.Images(CardSuit(0))


        If CardSuit(1) = 1 Or CardSuit(1) = 2 Then
            Label2.ForeColor = Color.Red
        ElseIf CardSuit(1) = 0 Or CardSuit(1) = 3 Then
            Label2.ForeColor = Color.Black
        End If

        Label2.Text = cardChar(CardValue(1))
        PictureBox2.Image = ImageList1.Images(CardSuit(1))


        If CardSuit(2) = 1 Or CardSuit(2) = 2 Then
            Label3.ForeColor = Color.Red
        ElseIf CardSuit(2) = 0 Or CardSuit(2) = 3 Then
            Label3.ForeColor = Color.Black
        End If

        Label3.Text = cardChar(CardValue(2))
        PictureBox3.Image = ImageList1.Images(CardSuit(2))


        If CardSuit(3) = 1 Or CardSuit(3) = 2 Then
            Label4.ForeColor = Color.Red
        ElseIf CardSuit(3) = 0 Or CardSuit(3) = 3 Then
            Label4.ForeColor = Color.Black
        End If

        Label4.Text = cardChar(CardValue(3))
        PictureBox4.Image = ImageList1.Images(CardSuit(3))


        If CardSuit(4) = 1 Or CardSuit(4) = 2 Then
            Label5.ForeColor = Color.Red
        ElseIf CardSuit(4) = 0 Or CardSuit(4) = 3 Then
            Label5.ForeColor = Color.Black
        End If

        Label5.Text = cardChar(CardValue(4))
        PictureBox5.Image = ImageList1.Images(CardSuit(4))
        '顯示Panel
        Panel1.Show()
    End Sub

    Private Sub PicCover1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicCover1.Click
        PicCover1.Hide() '掀第一張牌
    End Sub

    Private Sub PicCover2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicCover2.Click
        PicCover2.Hide()  '掀第二張牌
    End Sub

    Private Sub PicCover3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicCover3.Click
        PicCover3.Hide() '掀第三張牌
    End Sub

    Private Sub PicCover4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicCover4.Click
        PicCover4.Hide() '掀第四張牌
    End Sub

    Private Sub PicCover5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicCover5.Click
        PicCover5.Hide() '掀第五張牌
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        Panel1.Hide() '隱藏Panel
    End Sub
End Class
