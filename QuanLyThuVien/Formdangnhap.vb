Public Class Formdangnhap
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If TBtk.Text = "" Or TBmk.Text = "" Then
            MsgBox("Bạn chưa nhập tên đăng nhập hoặc mật khẩu")
        Else
            If TBtk.Text = "Admin" And TBmk.Text = "123456" Then
                MsgBox("Đăng nhập thành công!")
                Dim lienket As New FormChinh
                lienket.Show()
                Hide()
            Else
                MessageBox.Show("Đăng nhập thất bại")
            End If
        End If
    End Sub

    Private Sub TBtk_GotFocus(sender As Object, e As EventArgs) Handles TBtk.GotFocus
        If TBtk.Text = "Nhập Email hoặc số điện thoại" Then
            TBtk.Text = ""
        End If
    End Sub

    Private Sub TBtk_LostFocus(sender As Object, e As EventArgs) Handles TBtk.LostFocus
        If TBtk.Text = "" Then
            TBtk.Text = "Nhập Email hoặc số điện thoại"
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cance.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn thoát không?", vbYesNo, "Xác nhận ?")
        If hoi = vbYes Then
            Close()
        Else
            Enabled = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBmk.PasswordChar = "*" ' Thêm dòng này để đặt ký tự mật khẩu
    End Sub

End Class
