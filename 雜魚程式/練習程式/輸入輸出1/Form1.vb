Imports System.IO
Public Class Form1
    Dim txt1 As New FileInfo("輸入檔.txt")
    Dim txt2 As New FileInfo("輸出檔.txt")
    Dim te1 As StreamReader = txt1.OpenText
    Dim te2 As StreamWriter = txt2.CreateText
    Dim a, b As Short
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


        a = Val(te1.ReadLine)
        If a > 20 Or a < 10 Then
            MsgBox("限定輸入10-20的數")
            End
        End If

        For i = 1 To a
            b += i
        Next

        te2.WriteLine("you input " & a)
        te2.WriteLine("1-" & a & " total=" & b)
        te2.Flush()
        te2.Close()
        te1.Close()
        Me.Close()
    End Sub

End Class
