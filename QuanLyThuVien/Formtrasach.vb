Imports System.Data.OleDb

Public Class Formtrasach
    Private Sub Formtrasach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ChitietphieumuonTableAdapter.Fill(Me.DataSet.chitietphieumuon)
        Me.SachTableAdapter.Fill(Me.DataSet.sach)
        Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
        Me.ChitietphieutraTableAdapter.Fill(Me.DataSet.chitietphieutra)
        Me.PhieutraTableAdapter.Fill(Me.DataSet.phieutra)
        Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
        Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
        BTluupt.Visible = False
        BThuypt.Visible = False
        TBmpt.Enabled = False
        BTluuctpt.Visible = False
        BThuyctpt.Visible = False
        BTtpt.Visible = False
        BTtctpt.Visible = False
        CBmpctpt.Enabled = False
        UpdatePhieuTraCount()
    End Sub

    Private Sub loaddata()
        OleDbDataAdapterpt.Fill(DataSet)
        OleDbDataAdapterctpt.Fill(DataSet)
        OleDbDataAdapterctpm.Fill(DataSet)
    End Sub

    Private Function GetMinMissingMaPhieuTra() As Integer
        Dim missingMaDocGia As Integer = 1
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT CAST(SUBSTRING(mapt, 3, LEN(mapt) - 2) AS INTEGER) AS Ma FROM phieutra ORDER BY Ma"
            Dim command As New OleDbCommand(sql, OleDbConnection)
            Dim reader As OleDbDataReader = command.ExecuteReader()
            Dim existingMas As New List(Of Integer)

            While reader.Read()
                If Not IsDBNull(reader("Ma")) Then
                    existingMas.Add(Convert.ToInt32(reader("Ma")))
                End If
            End While
            reader.Close()

            If existingMas.Count > 0 Then
                missingMaDocGia = Enumerable.Range(1, existingMas.Max() + 1).Except(existingMas).FirstOrDefault()
            End If

        Catch ex As Exception
            MessageBox.Show("Lỗi khi lấy mã phiếu trả tiếp theo: " & ex.Message)
        Finally
            ' Đảm bảo kết nối được đóng lại ngay cả khi có lỗi
            If OleDbConnection.State = ConnectionState.Open Then
                OleDbConnection.Close()
            End If
        End Try
        Return missingMaDocGia
    End Function

    Private Function GenerateNextMaPhieuTra() As String
        Dim nextMa As Integer = GetMinMissingMaPhieuTra()
        Return "PT" & nextMa.ToString("D8")
    End Function

    '--------------------------------------------------------------------------------------------------------
    Private Function CountPhieuTra() As Integer
        Dim count As Integer = 0
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT COUNT(*) FROM phieutra"
            Dim command As New OleDbCommand(sql, OleDbConnection)
            count = Convert.ToInt32(command.ExecuteScalar())
            OleDbConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi đếm số phiếu trả: " & ex.Message)
        End Try
        Return count
    End Function

    Private Sub UpdatePhieuTraCount()
        Dim count As Integer = CountPhieuTra()
        LBdempt.Text = "Tổng số phiếu trả: " & count.ToString()
    End Sub

    Private Sub BTthempt_Click(sender As Object, e As EventArgs) Handles BTthempt.Click
        TBmpt.Text = GenerateNextMaPhieuTra()
        CBmdgpt.SelectedIndex = 0
        CBmttpt.SelectedIndex = 0
        DTPnlpt.ResetText()

        BTxoapt.Enabled = False
        BTtkpt.Enabled = False
        BTluupt.Visible = True
        BThuypt.Visible = True
        DTPnlpt.Enabled = False
    End Sub

    Private Sub BTluupt_Click(sender As Object, e As EventArgs) Handles BTluupt.Click
        Dim ngaylapphieu As String
        ngaylapphieu = DTPnlpt.Value.ToString("yyyy/MM/dd")
        If TBmpt.Text = "" Then
            MsgBox("Chưa nhập mã phiếu mượn")
            TBmpt.Focus()
            Return
        ElseIf CBmdgpt.Text = "" Then
            MsgBox("Chưa nhập mã độc giả")
            CBmdgpt.Focus()
            Return
        ElseIf CBmttpt.Text = "" Then
            MsgBox("Chưa nhập mã thủ thư")
            CBmttpt.Focus()
            Return
        Else
            Try
                OleDbConnection.Open()
                Dim sql As String = "INSERT INTO phieutra
                  (mapt, matt, madg, ngaylapphieu)
VALUES (N'" & TBmpt.Text & "',N'" & CBmttpt.Text & "',N'" & CBmdgpt.Text & "',N'" & ngaylapphieu & "')"
                OleDbInsertCommandpt.CommandText = sql
                OleDbInsertCommandpt.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Thêm thành công !")
                UpdatePhieuTraCount()
                BTthempt.Enabled = True
                BTsuapt.Enabled = True
                BTxoapt.Enabled = True
                BTtkpt.Enabled = True
                BTluupt.Visible = False
                BThuypt.Visible = False
                DTPnlpt.Enabled = True
                Me.SachTableAdapter.Fill(Me.DataSet.sach)
                Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
                Me.ChitietphieutraTableAdapter.Fill(Me.DataSet.chitietphieutra)
                Me.PhieutraTableAdapter.Fill(Me.DataSet.phieutra)
                Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
                Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
            Catch ex As Exception
                MessageBox.Show("Có lỗi xảy ra !")
                Dim hoi As Integer
                hoi = MsgBox("Vui lòng vào lại form để tránh lỗi dữ liệu !", vbYes, "Cảnh báo ?")
                If hoi = vbOK Then
                    Dim lienket As FormChinh = New FormChinh
                    lienket.Show()
                    Hide()
                End If
            End Try
        End If
    End Sub

    Private Sub BTsuapt_Click(sender As Object, e As EventArgs) Handles BTsuapt.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn sửa ?", vbYesNo, "Xác nhận ?")
        Dim ngaylapphieu As String
        ngaylapphieu = DTPnlpt.Value.ToString("yyyy/MM/dd")
        If TBmpt.Text = "" Then
            MsgBox("Chưa nhập mã phiếu trả")
            TBmpt.Focus()
        ElseIf CBmdgpt.Text = "" Then
            MsgBox("Chưa nhập mã độc giả")
            CBmdgpt.Focus()
        ElseIf CBmttpt.Text = "" Then
            MsgBox("Chưa nhập mã thủ thư")
            CBmttpt.Focus()
        ElseIf hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "UPDATE phieutra
SET          [mapt] = N'" & TBmpt.Text & "',[matt] = N'" & CBmttpt.Text & "', [madg] = N'" & CBmdgpt.Text & "', [ngaylapphieu] = N'" & ngaylapphieu & "'
WHERE        [mapt] = N'" & TBmpt.Text & "'"
                OleDbUpdateCommandpt.CommandText = sql
                OleDbUpdateCommandpt.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Sửa thành công !")
                UpdatePhieuTraCount()
                Me.SachTableAdapter.Fill(Me.DataSet.sach)
                Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
                Me.ChitietphieutraTableAdapter.Fill(Me.DataSet.chitietphieutra)
                Me.PhieutraTableAdapter.Fill(Me.DataSet.phieutra)
                Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
                Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
            Catch ex As Exception
                MessageBox.Show("Lỗi không thể sửa !")
                Dim hoi1 As Integer
                hoi1 = MsgBox("Vui lòng vào lại form để tránh lỗi dữ liệu !", vbYes, "Cảnh báo ?")
                If hoi1 = vbOK Then
                    Dim lienket As FormChinh = New FormChinh
                    lienket.Show()
                    Hide()
                End If
            End Try
        Else
            Enabled = True
        End If
    End Sub

    Private Sub BTxoapt_Click(sender As Object, e As EventArgs) Handles BTxoapt.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn xóa ?", vbYesNo, "Xác nhận ?")
        If hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "DELETE FROM phieutra
WHERE  mapt = N'" & TBmpt.Text & "' "
                OleDbDeleteCommandpt.CommandText = sql
                OleDbDeleteCommandpt.ExecuteNonQuery()
                OleDbConnection.Close()
                DataSet.Clear()
                loaddata()
                MsgBox("Xóa thành công !")
                UpdatePhieuTraCount()
                Me.SachTableAdapter.Fill(Me.DataSet.sach)
                Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
                Me.ChitietphieutraTableAdapter.Fill(Me.DataSet.chitietphieutra)
                Me.PhieutraTableAdapter.Fill(Me.DataSet.phieutra)
                Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
                Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
            Catch ex As Exception
                MessageBox.Show("Lỗi không thể xóa !")
                Dim hoi2 As Integer
                hoi2 = MsgBox("Vui lòng vào lại form để tránh lỗi dữ liệu !", vbYes, "Cảnh báo ?")
                If hoi2 = vbOK Then
                    Dim lienket As FormChinh = New FormChinh
                    lienket.Show()
                    Hide()
                End If
            End Try
        Else
            Enabled = True
        End If
    End Sub

    Private Sub BThuypt_Click(sender As Object, e As EventArgs) Handles BThuypt.Click
        BTluupt.Visible = False
        BThuypt.Visible = False
        BTxoapt.Enabled = True
        BTthempt.Enabled = True
        BTsuapt.Visible = True
        BTtkpt.Enabled = True
        BTtkpt.Visible = True
        BTtpt.Visible = False
        TBmpt.Enabled = False
        DTPnlpt.Enabled = True
        loaddata()
        Me.SachTableAdapter.Fill(Me.DataSet.sach)
        Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
        Me.ChitietphieutraTableAdapter.Fill(Me.DataSet.chitietphieutra)
        Me.PhieutraTableAdapter.Fill(Me.DataSet.phieutra)
        Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
        Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
    End Sub

    Private Sub BTtpt_Click(sender As Object, e As EventArgs) Handles BTtpt.Click
        OleDbConnection.Open()
        Dim sql As String = "SELECT mapt, matt, madg, ngaylapphieu
FROM     phieutra
Where mapt = N'" & TBmpt.Text & "' Or madg = N'" & CBmdgpt.Text & "' Or matt = N'" & CBmttpt.Text & "'"
        OleDbSelectCommandpt.CommandText = sql
        OleDbSelectCommandpt.ExecuteNonQuery()
        DataSet.Clear()
        OleDbConnection.Close()
        loaddata()
        Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
        Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
        BThuypt.Visible = True
        BTthempt.Enabled = True
        BTxoapt.Enabled = True
        BTtpt.Visible = False
        BTtkpt.Visible = True
        BThuypt.Visible = False
        BTsuapt.Visible = True
        TBmpt.Enabled = False
    End Sub

    Private Sub BTtkpt_Click(sender As Object, e As EventArgs) Handles BTtkpt.Click
        BTtkpt.Visible = False
        BTthempt.Enabled = False
        BThuypt.Visible = True
        BTsuapt.Visible = False
        BTxoapt.Enabled = False
        BTtpt.Visible = True
        TBmpt.Enabled = True
        TBmpt.Text = ""
        CBmdgpt.Text = ""
        CBmttpt.Text = ""
        DTPnlpt.ResetText()
    End Sub
    Private Sub BTloadpt_Click(sender As Object, e As EventArgs) Handles BTloadpt.Click
        Me.SachTableAdapter.Fill(Me.DataSet.sach)
        Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
        Me.ChitietphieutraTableAdapter.Fill(Me.DataSet.chitietphieutra)
        Me.PhieutraTableAdapter.Fill(Me.DataSet.phieutra)
        Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
        Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
    End Sub

    '--------------------------------------------------------------------------------------------------------

    Private Sub BTthemctpt_Click(sender As Object, e As EventArgs) Handles BTthemctpt.Click
        CBmpctpt.SelectedIndex = 0
        CBmsctpt.SelectedIndex = 0
        CBmptctpt.SelectedIndex = 0
        DTPntctpt.ResetText()
        Dim lienket As Formmuonsach = New Formmuonsach
        lienket.Show()

        DTPntctpt.Enabled = False
        BTxoactpt.Enabled = False
        BTluuctpt.Visible = True
        BThuyctpt.Visible = True
    End Sub

    Private Sub BTluuctpt_Click(sender As Object, e As EventArgs) Handles BTluuctpt.Click
        Dim ngaytra As String
        ngaytra = DTPntctpt.Value.ToString("yyyy/MM/dd")
        If CBmpctpt.Text = "" Then
            MsgBox("Chưa nhập mã phiếu mượn")
            CBmpctpt.Focus()
            Return
        ElseIf CBmsctpt.Text = "" Then
            MsgBox("Chưa nhập mã sách")
            CBmsctpt.Focus()
            Return
        ElseIf CBmptctpt.Text = "" Then
            MsgBox("Chưa nhập mã phiếu mượn")
            CBmsctpt.Focus()
            Return
        Else
            Try
                OleDbConnection.Open()
                Dim sql As String = "INSERT INTO chitietphieutra
                  (mapt, mapm, mas, ngaytra, ghichuctpt)
VALUES (N'" & CBmpctpt.Text & "',N'" & CBmptctpt.Text & "',N'" & CBmsctpt.Text & "',N'" & ngaytra & "',N'" & TBgcctpt.Text & "')"
                OleDbInsertCommandctpt.CommandText = sql
                OleDbInsertCommandctpt.ExecuteNonQuery()
                OleDbConnection.Close()


                OleDbConnection.Open()
                Dim sql1 As String = "SELECT mapt, mapm, mas, ngaytra, ghichuctpt
FROM     chitietphieutra
Where mapt = N'" & CBmpctpt.Text & "'"
                OleDbSelectCommandctpt.CommandText = sql1
                OleDbSelectCommandctpt.ExecuteNonQuery()
                OleDbConnection.Close()

                OleDbConnection.Open()
                Dim sql2 As String = "DELETE FROM chitietphieumuon
WHERE  mapm = N'" & CBmptctpt.Text & "' AND mas = N'" & CBmsctpt.Text & "'"
                OleDbDeleteCommandctpm.CommandText = sql2
                OleDbDeleteCommandctpm.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                MsgBox("Trả thành công !")
                Me.SachTableAdapter.Fill(Me.DataSet.sach)
                Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
                Me.ChitietphieumuonTableAdapter.Fill(Me.DataSet.chitietphieumuon)
                loaddata()

                BTthemctpt.Enabled = True
                BTsuactpt.Enabled = True
                BTxoactpt.Enabled = True
                BTtkctpt.Enabled = True
                BTluuctpt.Visible = False
                BThuyctpt.Visible = False

                Formmuonsach.Close()
            Catch ex As Exception
                MessageBox.Show("Trả sách không thành công !")
                Dim hoi As Integer
                hoi = MsgBox("Vui lòng vào lại form để tránh lỗi dữ liệu !", vbYes, "Cảnh báo ?")
                If hoi = vbOK Then
                    Dim lienket As FormChinh = New FormChinh
                    lienket.Show()
                    Hide()
                End If
            End Try
        End If
    End Sub

    Private Sub BTsuactpt_Click(sender As Object, e As EventArgs) Handles BTsuactpt.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn sửa ?", vbYesNo, "Xác nhận ?")
        Dim ngaytra As String
        ngaytra = DTPntctpt.Value.ToString("yyyy/MM/dd")
        If CBmpctpt.Text = "" Then
            MsgBox("Chưa nhập mã phiếu mượn")
            CBmpctpt.Focus()
        ElseIf CBmsctpt.Text = "" Then
            MsgBox("Chưa nhập mã sách")
            CBmsctpt.Focus()
        ElseIf CBmptctpt.Text = "" Then
            MsgBox("Chưa nhập mã phiếu mượn")
            CBmsctpt.Focus()
        ElseIf hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "UPDATE chitietphieutra
SET          [mapt] = N'" & CBmpctpt.Text & "',[mapm] = N'" & CBmptctpt.Text & "', [mas] = N'" & CBmsctpt.Text & "', [ngaytra] = N'" & ngaytra & "', [ghichuctpt] = N'" & TBgcctpt.Text & "'
WHERE        [mapt] = N'" & CBmpctpt.Text & "'"
                OleDbUpdateCommandctpt.CommandText = sql
                OleDbUpdateCommandctpt.ExecuteNonQuery()
                OleDbConnection.Close()
                MsgBox("Sửa thành công !")
                OleDbConnection.Open()
                Dim sql1 As String = "SELECT mapt, mapm, mas, ngaytra, ghichuctpt
FROM     chitietphieumuon
Where mapt = N'" & CBmpctpt.Text & "'"
                OleDbSelectCommandctpt.CommandText = sql1
                OleDbSelectCommandctpt.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                Me.SachTableAdapter.Fill(Me.DataSet.sach)
                Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
                loaddata()

            Catch ex As Exception
                MessageBox.Show("Lỗi không thể xóa !")
                Dim hoi1 As Integer
                hoi1 = MsgBox("Vui lòng vào lại form để tránh lỗi dữ liệu !", vbYes, "Cảnh báo ?")
                If hoi1 = vbOK Then
                    Dim lienket As FormChinh = New FormChinh
                    lienket.Show()
                    Hide()
                End If
            End Try
        Else
            Enabled = True
        End If
    End Sub

    Private Sub BTxoactpt_Click(sender As Object, e As EventArgs) Handles BTxoactpt.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn xóa ?", vbYesNo, "Xác nhận ?")
        If hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "DELETE FROM chitietphieutra
WHERE  mapt = N'" & CBmpctpt.Text & "'  AND mapm = N'" & CBmptctpt.Text & "' AND mas = N'" & CBmsctpt.Text & "'"
                OleDbDeleteCommandctpt.CommandText = sql
                OleDbDeleteCommandctpt.ExecuteNonQuery()
                OleDbConnection.Close()
                MsgBox("Xóa thành công !")

                OleDbConnection.Open()
                Dim sql1 As String = "SELECT mapt, mapm, mas, ngaytra, ghichuctpt
FROM     chitietphieutra
Where mapt = N'" & CBmpctpt.Text & "'"
                OleDbSelectCommandctpt.CommandText = sql1
                OleDbSelectCommandctpt.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                Me.SachTableAdapter.Fill(Me.DataSet.sach)
                Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
                loaddata()

            Catch ex As Exception
                MessageBox.Show("Lỗi không thể xóa !")
                Dim hoi2 As Integer
                hoi2 = MsgBox("Vui lòng vào lại form để tránh lỗi dữ liệu !", vbYes, "Cảnh báo ?")
                If hoi2 = vbOK Then
                    Dim lienket As FormChinh = New FormChinh
                    lienket.Show()
                    Hide()
                End If
            End Try
        Else
            Enabled = True
        End If
    End Sub

    Private Sub BThuyctpt_Click(sender As Object, e As EventArgs) Handles BThuyctpt.Click
        BTluuctpt.Visible = False
        BThuyctpt.Visible = False
        BTxoactpt.Enabled = True
        BTthemctpt.Enabled = True
        BTsuactpt.Visible = True
        BTtkctpt.Enabled = True
        BTtkctpt.Visible = True
        BTtctpt.Visible = False

        OleDbConnection.Open()
        Dim sql1 As String = "SELECT mapt, mapm, mas, ngaytra, ghichuctpt
FROM     chitietphieutra
Where mapt = N'" & CBmpctpt.Text & "'"
        OleDbSelectCommandctpt.CommandText = sql1
        OleDbSelectCommandctpt.ExecuteNonQuery()
        DataSet.Clear()
        OleDbConnection.Close()
        Me.SachTableAdapter.Fill(Me.DataSet.sach)
        Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
        loaddata()
    End Sub

    Private Sub BTtctpt_Click(sender As Object, e As EventArgs) Handles BTtctpt.Click
        OleDbConnection.Open()
        Dim sql As String = "SELECT mapt, mapm, mas, ngaytra, ghichuctpt
FROM     chitietphieutra
Where mapt = N'" & CBmpctpt.Text & "' AND mapm = N'" & CBmptctpt.Text & "' AND mas = N'" & CBmsctpt.Text & "'"
        OleDbSelectCommandctpt.CommandText = sql
        OleDbSelectCommandctpt.ExecuteNonQuery()
        DataSet.Clear()
        OleDbConnection.Close()
        Me.SachTableAdapter.Fill(Me.DataSet.sach)
        Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
        loaddata()

        BThuyctpt.Visible = True
        BTthemctpt.Enabled = True
        BTxoactpt.Enabled = True
        BTtctpt.Visible = False
        BTtkctpt.Visible = True
        BThuyctpt.Visible = False
        BTsuactpt.Visible = True
    End Sub

    Private Sub BTtkctpt_Click(sender As Object, e As EventArgs) Handles BTtkctpt.Click
        BTtkctpt.Visible = False
        BTthemctpt.Enabled = False
        BThuyctpt.Visible = True
        BTsuactpt.Visible = False
        BTxoactpt.Enabled = False
        BTtctpt.Visible = True
        CBmsctpt.Text = ""
        TBgcctpt.Text = ""
        DTPntctpt.ResetText()
    End Sub

    Private Sub BTloadctpt_Click(sender As Object, e As EventArgs) Handles BTloadctpt.Click
        OleDbConnection.Open()
        Dim sql1 As String = "SELECT mapt, mapm, mas, ngaytra, ghichuctpt
FROM     chitietphieutra
Where mapt = N'" & CBmpctpt.Text & "'"
        OleDbSelectCommandctpt.CommandText = sql1
        OleDbSelectCommandctpt.ExecuteNonQuery()
        DataSet.Clear()
        OleDbConnection.Close()
        Me.SachTableAdapter.Fill(Me.DataSet.sach)
        Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
        loaddata()
    End Sub

    '--------------------------------------------------------------------------------------------------------
    Private Sub Formtrasach_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim lienket As FormChinh = New FormChinh
            lienket.Show()
        Else
            e.Cancel = True ' Hủy sự kiện đóng form
        End If
    End Sub

    Private Sub BTct_Click(sender As Object, e As EventArgs) Handles BTct.Click
        TCts.SelectedTab = TPctpt
        Dim maPhieuTra As String = TBmpt.Text
        If String.IsNullOrEmpty(maPhieuTra) Then
            MessageBox.Show("Vui lòng nhập mã phiếu mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT mapt, mapm, mas, ngaytra, ghichuctpt
FROM     chitietphieutra
Where mapt = N'" & maPhieuTra & "'"
            OleDbSelectCommandctpt.CommandText = sql
            OleDbSelectCommandctpt.ExecuteNonQuery()
            DataSet.Clear()
            OleDbConnection.Close()
            loaddata()
            BThuyctpt.Visible = True
            BTthemctpt.Enabled = True
            BTxoactpt.Enabled = True
            BTtctpt.Visible = False
            BTtkctpt.Visible = True
            BThuyctpt.Visible = False
            BTsuactpt.Visible = True
            Me.SachTableAdapter.Fill(Me.DataSet.sach)
            Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
        Catch ex As Exception
            MessageBox.Show("Có lỗi xảy ra khi lấy dữ liệu chi tiết phiếu mượn: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Đảm bảo kết nối được đóng lại ngay cả khi có lỗi
            If OleDbConnection.State = ConnectionState.Open Then
                OleDbConnection.Close()
            End If
        End Try
    End Sub

    Private Sub BTthoatctpt_Click(sender As Object, e As EventArgs) Handles BTthoatctpt.Click
        TCts.SelectedTab = TPlpt
    End Sub

End Class