Public Class Form1
    Dim xx As Integer
    Dim zxc As Boolean = False
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        image1.Image = ImageList1.Images(0)
        image2.Image = ImageList1.Images(1)
        image3.Image = ImageList1.Images(2)
        image4.Image = ImageList1.Images(3)
        image5.Image = ImageList1.Images(4)
    End Sub

    Private Sub image1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles image1.MouseMove
        Shape1.Visible = True
        Shape1.Top = image1.Top - (Shape1.Height - image1.Height) \ 2 - 0.2
        Shape1.Left = image1.Left - (Shape1.Width - image1.Width) \ 2 - 0.2

    End Sub

    Private Sub image2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles image2.MouseMove
        Shape1.Visible = True
        Shape1.Top = image2.Top - (Shape1.Height - image2.Height) \ 2 - 0.2
        Shape1.Left = image2.Left - (Shape1.Width - image2.Width) \ 2 - 0.2

    End Sub

 

    Private Sub image3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles image3.MouseMove
        Shape1.Visible = True
        Shape1.Top = image3.Top - (Shape1.Height - image3.Height) \ 2 - 0.2
        Shape1.Left = image3.Left - (Shape1.Width - image3.Width) \ 2 - 0.2

    End Sub

   
    Private Sub image4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles image4.MouseMove
        Shape1.Visible = True
        Shape1.Top = image4.Top - (Shape1.Height - image4.Height) \ 2 - 0.2
        Shape1.Left = image4.Left - (Shape1.Width - image4.Width) \ 2 - 0.2

    End Sub

    Private Sub image5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles image5.MouseMove
        Shape1.Visible = True
        Shape1.Top = image5.Top - (Shape1.Height - image5.Height) \ 2 - 0.2
        Shape1.Left = image5.Left - (Shape1.Width - image5.Width) \ 2 - 0.2

    End Sub

    Private Sub image1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles image1.MouseUp
        If zxc = True Then
            image.Image = ImageList1.Images(0)
        End If     
    End Sub

    Private Sub image2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles image2.MouseUp
        If zxc = True Then
            image.Image = ImageList1.Images(1)
        End If     
    End Sub

    Private Sub image3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles image3.MouseUp
        If zxc = True Then
            image.Image = ImageList1.Images(2)
        End If       
    End Sub

    Private Sub image4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles image4.MouseUp
        If zxc = True Then
            image.Image = ImageList1.Images(3)
        End If    
    End Sub

    Private Sub image5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles image5.MouseUp
        If zxc = True Then
            image.Image = ImageList1.Images(4)
        End If     
    End Sub
End Class
