Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, aa As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行。")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ii = sr.ReadLine
        aa = 1
        sw.Write(zz(ii))
        sw.Flush() : sw.Close()
        End
    End Sub

    Function zz(ByVal a As Integer)
        If a = 1 Then
            Return aa
        Else
            aa *= a
            Return zz(a - 1)
        End If
    End Function
End Class
