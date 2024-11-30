Imports System.Data.OleDb
Public Class Formmuonsach
    Private Sub Formmuontrasach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
        Me.SachTableAdapter.Fill(Me.DataSet.sach)
        Me.ChitietphieumuonTableAdapter.Fill(Me.DataSet.chitietphieumuon)
        Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
        Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
        Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
        BTluupm.Visible = False
        BThuypm.Visible = False
        TBmpm.Enabled = False
        BTluuctpm.Visible = False
        BThuyctpm.Visible = False
        BTtpm.Visible = False
        BTtctpm.Visible = False
        CBmpctpm.Enabled = False
        DTPnmctpm.Enabled = False
        UpdatePhieuMuonCount()
    End Sub

    Private Sub loaddata()
        OleDbDataAdapterpm.Fill(DataSet)
        OleDbDataAdapterctpm.Fill(DataSet)
    End Sub

    '--------------------------------------------------------------------------------------------------------
    Private Function GetMinMissingMaPhieuMuon() As Integer
        Dim missingMaDocGia As Integer = 1
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT CAST(SUBSTRING(mapm, 3, LEN(mapm) - 2) AS INTEGER) AS Ma FROM phieumuon ORDER BY Ma"
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
            MessageBox.Show("Lỗi khi lấy mã phiếu mượn tiếp theo: " & ex.Message)
        Finally
            ' Đảm bảo kết nối được đóng lại ngay cả khi có lỗi
            If OleDbConnection.State = ConnectionState.Open Then
                OleDbConnection.Close()
            End If
        End Try
        Return missingMaDocGia
    End Function

    Private Function GenerateNextMaPhieuMuon() As String
        Dim nextMa As Integer = GetMinMissingMaPhieuMuon()
        Return "PM" & nextMa.ToString("D8")
    End Function

    '--------------------------------------------------------------------------------------------------------
    Private Function CountPhieuMuon() As Integer
        Dim count As Integer = 0
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT COUNT(*) FROM phieumuon"
            Dim command As New OleDbCommand(sql, OleDbConnection)
            count = Convert.ToInt32(command.ExecuteScalar())
            OleDbConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi đếm số phiếu mượn: " & ex.Message)
        End Try
        Return count
    End Function

    Private Sub UpdatePhieuMuonCount()
        Dim count As Integer = CountPhieuMuon()
        LBdempm.Text = "Tổng số phiếu mượn: " & count.ToString()
    End Sub

    '--------------------------------------------------------------------------------------------------------
    Private Sub BTthempm_Click(sender As Object, e As EventArgs) Handles BTthempm.Click
        TBmpm.Text = GenerateNextMaPhieuMuon()
        CBmdgpm.SelectedIndex = 0
        CBmttpm.SelectedIndex = 0
        DTPnlpm.ResetText()

        BTxoapm.Enabled = False
        BTtkpm.Enabled = False
        BTluupm.Visible = True
        BThuypm.Visible = True
        DTPnlpm.Enabled = False
    End Sub

    Private Sub BTluupm_Click(sender As Object, e As EventArgs) Handles BTluupm.Click
        Dim ngaylapphieu As String
        ngaylapphieu = DTPnlpm.Value.ToString("yyyy/MM/dd")
        If TBmpm.Text = "" Then
            MsgBox("Chưa nhập mã phiếu mượn")
            TBmpm.Focus()
            Return
        ElseIf CBmdgpm.Text = "" Then
            MsgBox("Chưa nhập mã độc giả")
            CBmdgpm.Focus()
            Return
        ElseIf CBmttpm.Text = "" Then
            MsgBox("Chưa nhập mã thủ thư")
            CBmttpm.Focus()
            Return
        Else
            Try
                OleDbConnection.Open()
                Dim sql As String = "INSERT INTO phieumuon
                  (mapm, matt, madg, ngaylapphieu)
VALUES (N'" & TBmpm.Text & "',N'" & CBmttpm.Text & "',N'" & CBmdgpm.Text & "',N'" & ngaylapphieu & "')"
                OleDbInsertCommandpm.CommandText = sql
                OleDbInsertCommandpm.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Thêm thành công !")
                UpdatePhieuMuonCount()
                BTthempm.Enabled = True
                BTsuapm.Enabled = True
                BTxoapm.Enabled = True
                BTtkpm.Enabled = True
                BTluupm.Visible = False
                BThuypm.Visible = False
                DTPnlpm.Enabled = True
                Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
                Me.SachTableAdapter.Fill(Me.DataSet.sach)
                Me.ChitietphieumuonTableAdapter.Fill(Me.DataSet.chitietphieumuon)
                Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
                Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
                Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
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

    Private Sub BTsuapm_Click(sender As Object, e As EventArgs) Handles BTsuapm.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn sửa ?", vbYesNo, "Xác nhận ?")
        Dim ngaylapphieu As String
        ngaylapphieu = DTPnlpm.Value.ToString("yyyy/MM/dd")
        If TBmpm.Text = "" Then
            MsgBox("Chưa nhập mã phiếu mượn")
            TBmpm.Focus()
        ElseIf CBmdgpm.Text = "" Then
            MsgBox("Chưa nhập mã độc giả")
            CBmdgpm.Focus()
        ElseIf CBmttpm.Text = "" Then
            MsgBox("Chưa nhập mã thủ thư")
            CBmttpm.Focus()
        ElseIf hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "UPDATE phieumuon
SET          [mapm] = N'" & TBmpm.Text & "',[matt] = N'" & CBmttpm.Text & "', [madg] = N'" & CBmdgpm.Text & "', [ngaylapphieu] = N'" & ngaylapphieu & "'
WHERE        [mapm] = N'" & TBmpm.Text & "'"
                OleDbUpdateCommandpm.CommandText = sql
                OleDbUpdateCommandpm.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Sửa thành công !")
                UpdatePhieuMuonCount()
                Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
                Me.SachTableAdapter.Fill(Me.DataSet.sach)
                Me.ChitietphieumuonTableAdapter.Fill(Me.DataSet.chitietphieumuon)
                Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
                Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
                Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
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

    Private Sub BTxoapm_Click(sender As Object, e As EventArgs) Handles BTxoapm.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn xóa ?", vbYesNo, "Xác nhận ?")
        If hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "DELETE FROM phieumuon
WHERE  mapm = N'" & TBmpm.Text & "' "
                OleDbDeleteCommandpm.CommandText = sql
                OleDbDeleteCommandpm.ExecuteNonQuery()
                OleDbConnection.Close()
                DataSet.Clear()
                loaddata()
                MsgBox("Xóa thành công !")
                UpdatePhieuMuonCount()
                Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
                Me.SachTableAdapter.Fill(Me.DataSet.sach)
                Me.ChitietphieumuonTableAdapter.Fill(Me.DataSet.chitietphieumuon)
                Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
                Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
                Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
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

    Private Sub BThuypm_Click(sender As Object, e As EventArgs) Handles BThuypm.Click
        BTluupm.Visible = False
        BThuypm.Visible = False
        BTxoapm.Enabled = True
        BTthempm.Enabled = True
        BTsuapm.Visible = True
        BTtkpm.Enabled = True
        BTtkpm.Visible = True
        BTtpm.Visible = False
        TBmpm.Enabled = False
        DTPnlpm.Enabled = True
        loaddata()
        Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
        Me.SachTableAdapter.Fill(Me.DataSet.sach)
        Me.ChitietphieumuonTableAdapter.Fill(Me.DataSet.chitietphieumuon)
        Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
        Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
        Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
    End Sub

    Private Sub BTtpm_Click(sender As Object, e As EventArgs) Handles BTtpm.Click
        OleDbConnection.Open()
        Dim sql As String = "SELECT mapm, matt, madg, ngaylapphieu
FROM     phieumuon
Where mapm = N'" & TBmpm.Text & "' Or madg = N'" & CBmdgpm.Text & "' Or matt = N'" & CBmttpm.Text & "'"
        OleDbSelectCommandpm.CommandText = sql
        OleDbSelectCommandpm.ExecuteNonQuery()
        DataSet.Clear()
        OleDbConnection.Close()
        loaddata()
        Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
        Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
        BThuypm.Visible = True
        BTthempm.Enabled = True
        BTxoapm.Enabled = True
        BTtpm.Visible = False
        BTtkpm.Visible = True
        BThuypm.Visible = False
        BTsuapm.Visible = True
        TBmpm.Enabled = False
    End Sub

    Private Sub BTtkpm_Click(sender As Object, e As EventArgs) Handles BTtkpm.Click
        BTtkpm.Visible = False
        BTthempm.Enabled = False
        BThuypm.Visible = True
        BTsuapm.Visible = False
        BTxoapm.Enabled = False
        BTtpm.Visible = True
        TBmpm.Enabled = True
        TBmpm.Text = ""
        CBmdgpm.Text = ""
        CBmttpm.Text = ""
        DTPnlpm.ResetText()
    End Sub

    Private Sub BTloadpm_Click(sender As Object, e As EventArgs) Handles BTloadpm.Click
        Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
        Me.SachTableAdapter.Fill(Me.DataSet.sach)
        Me.ChitietphieumuonTableAdapter.Fill(Me.DataSet.chitietphieumuon)
        Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
        Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
        Me.PhieumuonTableAdapter.Fill(Me.DataSet.phieumuon)
    End Sub

    '--------------------------------------------------------------------------------------------------------
    Private Sub BTthemctpm_Click(sender As Object, e As EventArgs) Handles BTthemctpm.Click
        CBmsctpm.SelectedIndex = 0
        DTPnmctpm.Value = DateTime.Now
        DTPntctpm.Value = DateTime.Now.AddDays(5)

        DTPnmctpm.Enabled = False
        DTPntctpm.Enabled = False
        BTxoactpm.Enabled = False
        BTluuctpm.Visible = True
        BThuyctpm.Visible = True
        Dim lienket As Formquanlysach = New Formquanlysach
        lienket.Show()
    End Sub

    Private Sub BTluuctpm_Click(sender As Object, e As EventArgs) Handles BTluuctpm.Click
        Dim ngaymuon As String
        ngaymuon = DTPnmctpm.Value.ToString("yyyy/MM/dd")
        Dim ngaytra As String
        ngaytra = DTPntctpm.Value.ToString("yyyy/MM/dd")
        If CBmpctpm.Text = "" Then
            MsgBox("Chưa nhập mã phiếu mượn")
            CBmpctpm.Focus()
            Return
        ElseIf CBmsctpm.Text = "" Then
            MsgBox("Chưa nhập mã sách")
            CBmsctpm.Focus()
            Return
        ElseIf ngaymuon > ngaytra Then
            MsgBox("Chưa ngày mượn không thể lớn hơn ngày trả")
            Return
        Else
            Try
                OleDbConnection.Open()
                Dim sql As String = "INSERT INTO chitietphieumuon
                  (mapm, mas, ngaymuon, ngaytra, ghichuctpm)
VALUES (N'" & CBmpctpm.Text & "',N'" & CBmsctpm.Text & "',N'" & ngaymuon & "',N'" & ngaytra & "',N'" & TBgcctpm.Text & "')"
                OleDbInsertCommandctpm.CommandText = sql
                OleDbInsertCommandctpm.ExecuteNonQuery()
                OleDbConnection.Close()
                MsgBox("Thêm thành công !")

                OleDbConnection.Open()
                Dim sql1 As String = "SELECT mapm, mas, ngaymuon, ngaytra, ghichuctpm
FROM     chitietphieumuon
Where mapm = N'" & CBmpctpm.Text & "'"
                OleDbSelectCommandctpm.CommandText = sql1
                OleDbSelectCommandctpm.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                Me.SachTableAdapter.Fill(Me.DataSet.sach)
                loaddata()

                BTthemctpm.Enabled = True
                BTsuactpm.Enabled = True
                BTxoactpm.Enabled = True
                BTtkctpm.Enabled = True
                BTluuctpm.Visible = False
                BThuyctpm.Visible = False
                DTPntctpm.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Đã có thông tin !")
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

    Private Sub BTsuactpm_Click(sender As Object, e As EventArgs) Handles BTsuactpm.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn gia hạn thêm ?", vbYesNo, "Xác nhận ?")
        Dim ngaymuon As String
        ngaymuon = DTPnmctpm.Value.ToString("yyyy/MM/dd")
        Dim ngaytra As String
        ngaytra = DTPntctpm.Value.ToString("yyyy/MM/dd")

        If TBmpm.Text = "" Then
            MsgBox("Chưa nhập mã phiếu mượn")
            TBmpm.Focus()
        ElseIf CBmdgpm.Text = "" Then
            MsgBox("Chưa nhập mã độc giả")
            CBmdgpm.Focus()
        ElseIf CBmttpm.Text = "" Then
            MsgBox("Chưa nhập mã thủ thư")
            CBmttpm.Focus()
        ElseIf hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "UPDATE chitietphieumuon
                                 SET [mapm] = N'" & CBmpctpm.Text & "', [mas] = N'" & CBmsctpm.Text & "', [ngaymuon] = N'" & ngaymuon & "', [ngaytra] = N'" & ngaytra & "', [ghichuctpm] = N'" & TBgcctpm.Text & "'
                                 WHERE [mapm] = N'" & CBmpctpm.Text & "' and [mas] = N'" & CBmsctpm.Text & "'"
                OleDbUpdateCommandctpm.CommandText = sql
                OleDbUpdateCommandctpm.ExecuteNonQuery()
                OleDbConnection.Close()
                MsgBox("Gia hạn thành công !")
                OleDbConnection.Open()
                Dim sql1 As String = "SELECT mapm, mas, ngaymuon, ngaytra, ghichuctpm
FROM     chitietphieumuon
Where mapm = N'" & CBmpctpm.Text & "'"
                OleDbSelectCommandctpm.CommandText = sql1
                OleDbSelectCommandctpm.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                Me.SachTableAdapter.Fill(Me.DataSet.sach)
                loaddata()
            Catch ex As Exception
                MsgBox("Lỗi không thể gia hạn: " & ex.Message)
                Dim hoi1 As Integer
                hoi1 = MsgBox("Vui lòng vào lại form để tránh lỗi dữ liệu !", vbYes, "Cảnh báo ?")
                If hoi1 = vbYes Then
                    Dim lienket As New FormChinh
                    lienket.Show()
                    Me.Hide()
                End If
            End Try
        Else
            Me.Enabled = True
        End If
    End Sub


    Private Sub BTxoactpm_Click(sender As Object, e As EventArgs) Handles BTxoactpm.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn xóa ?", vbYesNo, "Xác nhận ?")
        If hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "DELETE FROM chitietphieumuon
WHERE  mapm = N'" & CBmpctpm.Text & "' AND mas = N'" & CBmsctpm.Text & "'"
                OleDbDeleteCommandctpm.CommandText = sql
                OleDbDeleteCommandctpm.ExecuteNonQuery()
                OleDbConnection.Close()
                MsgBox("Xóa thành công !")

                OleDbConnection.Open()
                Dim sql1 As String = "SELECT mapm, mas, ngaymuon, ngaytra, ghichuctpm
FROM     chitietphieumuon
Where mapm = N'" & CBmpctpm.Text & "'"
                OleDbSelectCommandctpm.CommandText = sql1
                OleDbSelectCommandctpm.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                Me.SachTableAdapter.Fill(Me.DataSet.sach)
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

    Private Sub BThuyctpm_Click(sender As Object, e As EventArgs) Handles BThuyctpm.Click
        DTPntctpm.Enabled = True
        BTluuctpm.Visible = False
        BThuyctpm.Visible = False
        BTxoactpm.Enabled = True
        BTthemctpm.Enabled = True
        BTsuactpm.Visible = True
        BTtkctpm.Enabled = True
        BTtkctpm.Visible = True
        BTtctpm.Visible = False
        OleDbConnection.Open()
        Dim sql1 As String = "SELECT mapm, mas, ngaymuon, ngaytra, ghichuctpm
FROM     chitietphieumuon
Where mapm = N'" & CBmpctpm.Text & "'"
        OleDbSelectCommandctpm.CommandText = sql1
        OleDbSelectCommandctpm.ExecuteNonQuery()
        DataSet.Clear()
        OleDbConnection.Close()
        Me.SachTableAdapter.Fill(Me.DataSet.sach)
        loaddata()
    End Sub

    Private Sub BTtctpm_Click(sender As Object, e As EventArgs) Handles BTtctpm.Click
        OleDbConnection.Open()
        Dim sql As String = "SELECT mapm, mas, ngaymuon, ngaytra, ghichuctpm
FROM     chitietphieumuon
Where mapm = N'" & CBmpctpm.Text & "' AND mas = N'" & CBmsctpm.Text & "'"
        OleDbSelectCommandctpm.CommandText = sql
        OleDbSelectCommandctpm.ExecuteNonQuery()
        DataSet.Clear()
        OleDbConnection.Close()
        Me.SachTableAdapter.Fill(Me.DataSet.sach)
        loaddata()

        BThuyctpm.Visible = True
        BTthemctpm.Enabled = True
        BTxoactpm.Enabled = True
        BTtctpm.Visible = False
        BTtkctpm.Visible = True
        BThuyctpm.Visible = False
        BTsuactpm.Visible = True
    End Sub

    Private Sub BTtkctpm_Click(sender As Object, e As EventArgs) Handles BTtkctpm.Click
        BTtkctpm.Visible = False
        BTthemctpm.Enabled = False
        BThuyctpm.Visible = True
        BTsuactpm.Visible = False
        BTxoactpm.Enabled = False
        BTtctpm.Visible = True
        CBmsctpm.Text = ""
        TBgcctpm.Text = ""
        DTPnmctpm.ResetText()
        DTPntctpm.ResetText()
    End Sub


    Private Sub BTloadctpm_Click(sender As Object, e As EventArgs) Handles BTloadctpm.Click
        OleDbConnection.Open()
        Dim sql As String = "SELECT mapm, mas, ngaymuon, ngaytra, ghichuctpm
FROM     chitietphieumuon
Where mapm = N'" & CBmpctpm.Text & "' AND mas = N'" & CBmsctpm.Text & "'"
        OleDbSelectCommandctpm.CommandText = sql
        OleDbSelectCommandctpm.ExecuteNonQuery()
        DataSet.Clear()
        OleDbConnection.Close()
        Me.SachTableAdapter.Fill(Me.DataSet.sach)
        loaddata()
    End Sub

    '--------------------------------------------------------------------------------------------------------
    Private Sub Formmuonsach_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim lienket As FormChinh = New FormChinh
            lienket.Show()
        Else
            e.Cancel = True ' Hủy sự kiện đóng form
        End If
    End Sub

    Private Sub BTct_Click(sender As Object, e As EventArgs) Handles BTct.Click
        DTPnmctpm.Enabled = False
        TCmts.SelectedTab = TPctpm
        Dim maPhieuMuon As String = TBmpm.Text
        If String.IsNullOrEmpty(maPhieuMuon) Then
            MessageBox.Show("Vui lòng nhập mã phiếu mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT mapm, mas, ngaymuon, ngaytra, ghichuctpm
                             FROM chitietphieumuon
                             WHERE mapm = N'" & maPhieuMuon & "'"
            OleDbSelectCommandctpm.CommandText = sql
            OleDbSelectCommandctpm.ExecuteNonQuery()
            DataSet.Clear()
            OleDbConnection.Close()
            loaddata()
            BThuyctpm.Visible = True
            BTthemctpm.Enabled = True
            BTxoactpm.Enabled = True
            BTtctpm.Visible = False
            BTtkctpm.Visible = True
            BThuyctpm.Visible = False
            BTsuactpm.Visible = True
            Me.SachTableAdapter.Fill(Me.DataSet.sach)
        Catch ex As Exception
            MessageBox.Show("Có lỗi xảy ra khi lấy dữ liệu chi tiết phiếu mượn: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Đảm bảo kết nối được đóng lại ngay cả khi có lỗi
            If OleDbConnection.State = ConnectionState.Open Then
                OleDbConnection.Close()
            End If
        End Try
    End Sub

    Private Sub BTthoatctpm_Click(sender As Object, e As EventArgs) Handles BTthoatctpm.Click
        TCmts.SelectedTab = TPlpm
    End Sub
End Class