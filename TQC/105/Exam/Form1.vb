Public Class Form1
    Dim cardChar() As String = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"}
    Dim n As Integer
    Private Sub ButtonPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPlay.Click
        Dim CardNum(4) As Integer '5�Ӥ����A�C�@������ 0~51, �N��52�P�����Y�@�i
        Dim CardValue(4) As Integer '5�Ӥ����A�C�@������ 0~12, �N��A, 1, .., J, Q, K
        Dim CardSuit(4) As Integer '5�Ӥ����A�C�@������  0~3, �N�� spade(����), heart(�R��), diamond(�٧�), club(�³�)
        Dim isTaken(51) As Boolean '�O���Y�@�i��J�P�O�_�w�o�L
        Dim i As Integer ' �ثe�ҵo����J�P
        '�Цܪ��]�p�e���A�վ�PicCover1~5����m�A�Ϥ��m���J�P���W��
        PicCover1.Show()
        PicCover2.Show()
        PicCover3.Show()
        PicCover4.Show()
        PicCover5.Show()

        For i = 0 To 4
            Dim isOK As Boolean = False '�O�_�w���\�o�@�i�d

            Do
                Randomize()
                ' ���ͤ@�i�d
                n = Fix(Rnd() * 52)
                CardNum(i) = n
                '�P�_�O�_�w�o�L�A�o�L�������o
                If isTaken(n) <> True Then
                    isTaken(n) = True
                    isOK = True
                End If

            Loop Until isOK = True


            CardValue(i) = n Mod 13
            CardSuit(i) = n \ 13
        Next


        '��ܾ�J�P�I�Ƥ��C���Label1 ~ Label5
        '��ܾ�J�P����PictureBox1 ~ PictureBox5
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
        '���Panel
        Panel1.Show()
    End Sub

    Private Sub PicCover1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicCover1.Click
        PicCover1.Hide() '�ȲĤ@�i�P
    End Sub

    Private Sub PicCover2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicCover2.Click
        PicCover2.Hide()  '�ȲĤG�i�P
    End Sub

    Private Sub PicCover3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicCover3.Click
        PicCover3.Hide() '�ȲĤT�i�P
    End Sub

    Private Sub PicCover4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicCover4.Click
        PicCover4.Hide() '�Ȳĥ|�i�P
    End Sub

    Private Sub PicCover5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicCover5.Click
        PicCover5.Hide() '�ȲĤ��i�P
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        Panel1.Hide() '����Panel
    End Sub
End Class
