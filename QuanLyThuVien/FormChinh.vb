Public Class FormChinh
    Private Sub FormChinh_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True ' Hủy sự kiện đóng form
        End If
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn thoát không ?", vbYesNo, "Xác nhận ?")
        If hoi = vbYes Then
            Close()
        Else
            Enabled = True
        End If
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Dim hoi As Integer
        hoi = MsgBox("Chắc chắn đăng xuất !", vbYesNo, "Xác nhận ?")
        If hoi = vbYes Then
            Dim lienket As Formdangnhap = New Formdangnhap
            lienket.Show()
            Hide()
        End If
    End Sub

    Private Sub ThủThưToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThủThưToolStripMenuItem.Click
        Dim lienket As Formthuthu = New Formthuthu
        lienket.Show()
        Hide()
    End Sub

    Private Sub ĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐộcGiảToolStripMenuItem.Click
        Dim lienket As Formdocgia = New Formdocgia
        lienket.Show()
        Hide()
    End Sub

    Private Sub TácGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TácGiảToolStripMenuItem.Click
        Dim lienket As Formtacgia = New Formtacgia
        lienket.Show()
        Hide()
    End Sub

    Private Sub NhàXuấtBảnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhàXuấtBảnToolStripMenuItem.Click
        Dim lienket As Formnhaxuatban = New Formnhaxuatban
        lienket.Show()
        Hide()
    End Sub

    Private Sub ThểLoạiSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThểLoạiSáchToolStripMenuItem.Click
        Dim lienket As Formtheloaisach = New Formtheloaisach
        lienket.Show()
        Hide()
    End Sub

    Private Sub QuảnLýSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSáchToolStripMenuItem.Click
        Dim lienket As Formquanlysach = New Formquanlysach
        lienket.Show()
        Hide()
    End Sub

    Private Sub MượnSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MượnSáchToolStripMenuItem.Click
        Dim lienket As Formmuonsach = New Formmuonsach
        lienket.Show()
        Hide()
    End Sub

    Private Sub ThốngKêSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThốngKêSáchToolStripMenuItem.Click
        Dim lienket As Formthongkesach = New Formthongkesach
        lienket.Show()
        Hide()
    End Sub

    Private Sub ĐộcGiảToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ĐộcGiảToolStripMenuItem1.Click
        Dim lienket As Formthongkedocgia = New Formthongkedocgia
        lienket.Show()
        Hide()
    End Sub

    Private Sub TrảSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrảSáchToolStripMenuItem.Click
        Dim lienket As Formtrasach = New Formtrasach
        lienket.Show()
        Hide()
    End Sub
End Class
