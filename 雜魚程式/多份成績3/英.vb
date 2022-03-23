Public Class 英
    Dim a As Byte '代替數
    Dim s1 As String '代替數
    Dim b(4) As Byte '篩選每部分成績的人數
    Dim a1(成.x) As Byte
  
    Private Sub 英_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '將原英文成績的數丟入新的陣列
        For i = 1 To 成.x
            a1(i) = 成.aa(i, 2)
        Next
        '小到大排列
        For i = 1 To 成.x
            For j = 1 To 成.x
                If a1(i) > a1(j) Then
                    a = a1(i) : a1(i) = a1(j) : a1(j) = a
                End If
            Next
        Next
        '最大成績   最小成績   排序
        txt1.Text = a1(成.x) : txt2.Text = a1(1)
        '排序
        For i = 1 To 成.x
            s1 &= a1(i)
            If i <> 成.x Then s1 &= "，"
            If i Mod 10 = 0 Then s1 &= vbNewLine
        Next
        lbl123.Text = s1

        '篩選每部分成績的人數
        For i = 1 To 成.x
            Select Case a1(i)
                Case Is >= 91
                    b(0) += 1
                Case Is >= 81
                    b(1) += 1
                Case Is >= 71
                    b(2) += 1
                Case Is >= 60
                    b(3) += 1
                Case Is >= 0
                    b(4) += 1
            End Select
        Next


        show1.Text = b(0) : show2.Text = b(1) : show3.Text = b(2) : show4.Text = b(3) : show5.Text = b(4)
    End Sub
End Class