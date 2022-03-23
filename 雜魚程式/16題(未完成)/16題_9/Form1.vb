Public Class Form1
    Dim fw As New IO.FileInfo("output.txt")
    Dim sw As IO.StreamWriter = fw.CreateText
    Dim abc(3) As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fw.Exists = False Then
            fw.Create()
        End If

        For i = 100 To 999
            For j = 2 To 0 Step -1
                abc(j) = Microsoft.VisualBasic.Mid(CStr(i), j + 1, 1)
                abc(3) += abc(j) ^ 3
            Next
            If i = abc(3) Then
                sw.WriteLine(i)
            End If
            ReDim abc(3)
        Next

        sw.Flush() : sw.Close()
        End
    End Sub
End Class
