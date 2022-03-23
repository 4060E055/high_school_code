Imports System.IO
Public Class Form1
    Dim f1 As New FileInfo("輸入檔7.txt")
    Dim g1 As New FileInfo("輸出檔7.txt")
    Dim sw As StreamWriter = g1.CreateText
    Dim io, z As Byte '   io = 輸入的數(代替數)  z = 0,1的總數
    Dim o1(1), r As String 'o1 = 0,1的集合  r = 補0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If f1.Exists Then '判斷輸入檔是否存在
            If g1.Exists Then '判斷輸出檔是否存在
                Call zxc()
            Else '不存在則創建
                g1.Create()
                Call zxc()
            End If
        Else '不存在則結束執行
            MsgBox("找不到檔案，程式即將結束", MsgBoxStyle.Critical, "注意!!")
            End
        End If
    End Sub
    Sub zxc()
        Dim sr As StreamReader = f1.OpenText

        io = Val(sr.ReadLine) '帶入數
        If io > 100 OrElse io < 1 OrElse io <> Fix(io) Then '檢驗輸入資料正確性
            MsgBox("輸入錯誤，程式即將結束執行", MsgBoxStyle.Critical, "注意!")
            End
        End If
        z = 1
        Do
            If io Mod 2 = 1 Then '餘1連接1
                o1(z) = 1
            ElseIf io Mod 2 = 0 Then '餘0連接0
                o1(z) = 0
            End If
            io = io \ 2
            z += 1
            ReDim Preserve o1(z)
        Loop Until io = 1
        o1(z) = 1

        For i = z To 1 Step -1 '倒過來連接
            o1(0) &= o1(i)
        Next
        For i = 1 To (8 - Len(o1(0)))
            r &= "0"
        Next

        sw.WriteLine(r & o1(0))
        sw.Flush() : sw.Close() '存檔  關閉
        End '結束
    End Sub
End Class
