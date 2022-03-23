Public Class Form1
    Dim a As String

    Private Sub T1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T1.TextChanged
        T2.Text = ""

        For i = 1 To Len(T1.Text)
            a = Microsoft.VisualBasic.Mid(T1.Text, i, 1)
            If Asc(a) >= 89 Then
                a = Chr(Asc(a) + 2 - 26)
            Else
                a = Chr(Asc(a) + 2)
            End If

            Select Case a
                Case "A" : a = "K"
                Case "Z" : a = "E"
                Case "C" : a = "H"
                Case "S" : a = "U"
                Case "R" : a = "V"
                Case "K" : a = "N"
                Case "P" : a = "T"
                Case "B" : a = "C"
            End Select

            Select Case a
                Case Is = "A", "E", "I", "O", "U"
                    a = Chr(Asc(a) + 32)
                Case Is = "J" : a = "1"
                Case Is = "Q" : a = "2"
                Case Is = "K" : a = "3"
                Case Is = "X", "Y", "Z" : a = "?"
            End Select
            T2.Text &= a
        Next
       

   
    End Sub
End Class
