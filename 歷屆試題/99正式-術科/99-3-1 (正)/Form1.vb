Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1.txt")
    Dim frr As New FileInfo("in2.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As String
    Dim n, x As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Or frr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim srr As StreamReader = frr.OpenText

        For i = 0 To 1
            If i = 0 Then ia = Trim(sr.ReadLine)
            If i = 1 Then ia = Trim(srr.ReadLine)
            Dim aa(Len(ia), 1) As Integer : n = Len(ia)

            For j = 1 To Len(ia)
                Select Case Microsoft.VisualBasic.Mid(ia, j, 1)
                    Case "#" : aa(j - 1, 0) = 48 : aa(j - 1, 1) = 57
                    Case "*" : aa(j - 1, 0) = 65 : aa(j - 1, 1) = 90
                    Case "$" : aa(j - 1, 0) = 97 : aa(j - 1, 1) = 122
                End Select
            Next

            Do
1:              If i = 0 Then ia = Trim(sr.ReadLine)
                If i = 1 Then ia = Trim(srr.ReadLine)
                If ia = "" Then Exit Do

                For j = 1 To Len(ia) - 1
                    If Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) >= aa(0, 0) And _
                        Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) <= aa(0, 1) Then
                        x = 1
                        For k = j + 1 To Len(ia)
                            If Asc(Microsoft.VisualBasic.Mid(ia, k, 1)) >= aa(x, 0) And _
                               Asc(Microsoft.VisualBasic.Mid(ia, k, 1)) <= aa(x, 1) Then
                                x += 1
                                If x = n Then sw.WriteLine("符合") : GoTo 1
                            Else : Exit For
                            End If
                        Next
                    End If
                    If j = Len(ia) - 1 Then sw.WriteLine("不符合")
                Next
            Loop
            sw.WriteLine()
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
