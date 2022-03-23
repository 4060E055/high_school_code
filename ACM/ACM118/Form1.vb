Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim gg() As String = {"E", "S", "W", "N"}
    Dim ii(3), aa As String
    Dim n, a(1), x As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ii(0) = Trim(sr.ReadLine)

        For i = 1 To Len(ii(0)) '取前面兩個數
            If Microsoft.VisualBasic.Mid(ii(0), i, 1) <> " " Then
                a(n) &= Microsoft.VisualBasic.Mid(ii(0), i, 1)
            ElseIf Microsoft.VisualBasic.Mid(ii(0), i, 1) = " " Then
                n += 1
            End If
        Next
        n = 0
        Dim ob(2) As String

        Do '取締2航開始ㄉ每行數  並帶入指令
            ii(n) = Trim(sr.ReadLine)
            If ii(n) = "" Then Exit Do
            If (n + 1) Mod 2 = 0 Then
                ob(x) = ii(n)
                x += 1
                ReDim Preserve ob(x)
            End If
            n += 1
            ReDim Preserve ii(n)
        Loop
        Dim oa((n + 1) / 2, 3) As String



        For i = 0 To n - 1 Step 2 '分解數
            x = 0
            For j = 1 To Len(ii(i))
                If Microsoft.VisualBasic.Mid(ii(0), j, 1) <> " " Then
                    oa(i / 2, x) &= Microsoft.VisualBasic.Mid(ii(i), j, 1)
                ElseIf Microsoft.VisualBasic.Mid(ii(0), j, 1) = " " Then
                    x += 1
                End If
            Next
        Next

        For i = 0 To n / 2
            For j = 1 To Len(ob(i))
                aa = Microsoft.VisualBasic.Mid(ob(i), j, 1)
                Select Case aa
                    Case "R"
                        For k = 0 To 3
                            If oa(i, 2) = gg(k) Then
                                If k = 3 Then
                                    oa(i, 2) = gg(0)
                                Else
                                    oa(i, 2) = gg(k + 1) : Exit For
                                End If
                            End If
                        Next
                    Case "L"
                        For k = 0 To 3
                            If oa(i, 2) = gg(k) Then
                                If k = 0 Then
                                    oa(i, 2) = gg(3) : Exit For
                                Else
                                    oa(i, 2) = gg(k - 1) : Exit For
                                End If
                            End If
                        Next
                    Case "F"

                        For l = 0 To n / 2
                            If oa(l, 3) = "LOSE" And oa(l, 0) = oa(i, 0) And oa(l, 1) = oa(i, 1) Then
                                Select Case oa(i, 2)
                                    Case "E"
                                        If Val(oa(i, 0)) + 1 < a(0) Then
                                            oa(i, 0) = Val(oa(i, 0)) + 1
                                        End If
                                        Exit For
                                    Case "W"
                                        If Val(oa(i, 0)) - 1 > 0 Then
                                            oa(i, 0) = Val(oa(i, 0)) - 1
                                        End If
                                        Exit For
                                    Case "N"

                                        If Val(oa(i, 1)) + 1 < a(1) Then
                                            oa(i, 1) = Val(oa(i, 1)) + 1
                                        End If
                                        Exit For
                                    Case "S"

                                        If Val(oa(i, 1)) - 1 > 0 Then
                                            oa(i, 1) = Val(oa(i, 1)) - 1
                                        End If
                                        Exit For
                                End Select
                            ElseIf l = n / 2 Then
                                Select Case oa(i, 2)
                                    Case "E"
                                        If Val(oa(i, 0)) + 1 > a(0) Then GoTo 2

                                        oa(i, 0) = Val(oa(i, 0)) + 1

                                    Case "W"
                                        If Val(oa(i, 0)) - 1 < 0 Then GoTo 2
                                        oa(i, 0) = Val(oa(i, 0)) - 1
                                    Case "N"
                                        If Val(oa(i, 1)) + 1 > a(1) Then GoTo 2
                                        oa(i, 1) = Val(oa(i, 1)) + 1

                                    Case "S"
                                        If Val(oa(i, 1)) - 1 < 0 Then GoTo 2
                                        oa(i, 1) = Val(oa(i, 1)) - 1

                                    Case Else
2:                                      sw.WriteLine(oa(i, 0) & " " & oa(i, 1) & " " & oa(i, 2) & " LOSE")
                                        oa(i, 3) = "LOSE" : GoTo 1
                                End Select
                            End If
                        Next
                End Select
            Next
            sw.WriteLine(oa(i, 0) & " " & oa(i, 1) & " " & oa(i, 2))


1:
        Next
  
       


        sw.Flush() : sw.Close() : End
    End Sub
End Class
