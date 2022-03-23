Imports System.IO
Public Class Form1
    Dim txt1 As New FileInfo("輸入檔.txt")
    Dim txt2 As New FileInfo("輸出檔.txt")
    Dim tx1 As StreamReader = txt1.OpenText
    Dim tx2 As StreamWriter = txt2.CreateText
    Dim a(4) As Double
    Dim b As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If txt1.Exists Then
            If txt2.Exists Then
                Call zxc()
            Else
                txt2.Create()
                Call zxc()
            End If
        Else
            MsgBox("未找到輸入檔", MsgBoxStyle.Exclamation, "笨蛋")
            Me.Close()
        End If

    End Sub
    Sub zxc()

        For i = 0 To 4
            b = tx1.ReadLine
            If b = "" Then
                MsgBox("輸入不完整", MsgBoxStyle.Critical, "注意!")
                End
            End If
            a(i) = Val(b)
        Next
        tx1.Close()
        For i = 0 To 4
            If a(i) < 0 Then
                tx2.WriteLine(a(i) & Space(1) & "-")
            ElseIf a(i) > 0 Then
                tx2.WriteLine(a(i) & Space(1) & "+")
            ElseIf a(i) = 0 Then
                tx2.WriteLine(a(i) & Space(1) & "0")
            End If
        Next

        tx2.Flush() : tx2.Close()
        Me.Close()

    End Sub
End Class
