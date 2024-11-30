Imports System.Data.OleDb

Public Class Formquanlysach

    Private Sub Formquanlysach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.nhaxuatban' table. You can move, or remove it, as needed.
        Me.NhaxuatbanTableAdapter.Fill(Me.DataSet.nhaxuatban)
        'TODO: This line of code loads data into the 'DataSet.tacgia' table. You can move, or remove it, as needed.
        Me.TacgiaTableAdapter.Fill(Me.DataSet.tacgia)
        'TODO: This line of code loads data into the 'DataSet.theloai' table. You can move, or remove it, as needed.
        Me.TheloaiTableAdapter.Fill(Me.DataSet.theloai)
        Me.NhaxuatbanTableAdapter.Fill(Me.DataSet.nhaxuatban)
        Me.TacgiaTableAdapter.Fill(Me.DataSet.tacgia)
        Me.TheloaiTableAdapter.Fill(Me.DataSet.theloai)
        Me.SachTableAdapter.Fill(Me.DataSet.sach)
        BTluus.Visible = False
        BThuys.Visible = False
        BTts.Visible = False
        TBms.Enabled = False

        UpdateSachCount()
    End Sub
    Private Sub loaddata()
        OleDbDataAdapters.Fill(DataSet)
    End Sub

    ' ------------------------------------------------------------------------------------
    Private Function GetMinMissingMaSach() As Integer
        Dim missingMaDocGia As Integer = 1
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT CAST(SUBSTRING(mas, 2, LEN(mas) - 1) AS INTEGER) AS Ma FROM sach ORDER BY Ma"
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
            MessageBox.Show("Lỗi khi lấy mã sách tiếp theo: " & ex.Message)
        Finally
            ' Đảm bảo kết nối được đóng lại ngay cả khi có lỗi
            If OleDbConnection.State = ConnectionState.Open Then
                OleDbConnection.Close()
            End If
        End Try
        Return missingMaDocGia
    End Function

    Private Function GenerateNextMaSach() As String
        Dim nextMa As Integer = GetMinMissingMaSach()
        Return "S" & nextMa.ToString("D9")
    End Function

    ' ------------------------------------------------------------------------------------
    Private Function CountSach() As Integer
        Dim count As Integer = 0
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT COUNT(*) FROM sach"
            Dim command As New OleDbCommand(sql, OleDbConnection)
            count = Convert.ToInt32(command.ExecuteScalar())
            OleDbConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi đếm số sách: " & ex.Message)
        End Try
        Return count
    End Function

    Private Sub UpdateSachCount()
        Dim count As Integer = CountSach()
        LBdems.Text = "Tổng số sách: " & count.ToString()
    End Sub

    ' ------------------------------------------------------------------------------------
    Private Sub Thems_Click(sender As Object, e As EventArgs) Handles BTthems.Click
        TBms.Text = GenerateNextMaSach()
        TBts.Text = ""
        TBnxbs.Text = ""
        CBmtls.SelectedIndex = 0
        CBmtgs.SelectedIndex = 0
        CBmnxbs.SelectedIndex = 0
        TBgcs.Text = ""

        BTxoas.Enabled = False
        BTtks.Enabled = False
        BTluus.Visible = True
        BThuys.Visible = True
    End Sub

    Private Sub BTluus_Click(sender As Object, e As EventArgs) Handles BTluus.Click
        If TBms.Text = "" Then
            MsgBox("Chưa nhập mã sách")
            TBms.Focus()
            Return
        ElseIf TBts.Text = "" Then
            MsgBox("Chưa nhập tên sách")
            TBts.Focus()
            Return
        ElseIf TBnxbs.Text = "" Then
            MsgBox("Chưa nhập năm xuất bản")
            TBnxbs.Focus()
            Return
        ElseIf CBmtls.Text = "" Then
            MsgBox("Chưa nhập mã thể loại sách")
            TBnxbs.Focus()
            Return
        ElseIf CBmtgs.Text = "" Then
            MsgBox("Chưa nhập mã tác giả")
            TBnxbs.Focus()
            Return
        ElseIf CBmnxbs.Text = "" Then
            MsgBox("Chưa nhập mã nhà xuất bản")
            TBnxbs.Focus()
            Return
        Else
            Try
                OleDbConnection.Open()
                Dim sql As String = "INSERT INTO sach
                  (mas, tens, matg, manxb, matl, namxb, ghichus)
VALUES (N'" & TBms.Text & "',N'" & TBts.Text & "',N'" & CBmtgs.Text & "',N'" & CBmnxbs.Text & "',N'" & CBmtls.Text & "',N'" & TBnxbs.Text & "',N'" & TBgcs.Text & "')"
                OleDbInsertCommands.CommandText = sql
                OleDbInsertCommands.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Thêm thành công !")
                UpdateSachCount()
                BTthems.Enabled = True
                BTsuas.Enabled = True
                BTxoas.Enabled = True
                BTtks.Enabled = True
                BTluus.Visible = False
                BThuys.Visible = False
                Me.NhaxuatbanTableAdapter.Fill(Me.DataSet.nhaxuatban)
                Me.TacgiaTableAdapter.Fill(Me.DataSet.tacgia)
                Me.TheloaiTableAdapter.Fill(Me.DataSet.theloai)
                Me.SachTableAdapter.Fill(Me.DataSet.sach)
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

    Private Sub BTsuas_Click(sender As Object, e As EventArgs) Handles BTsuas.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn sửa ?", vbYesNo, "Xác nhận ?")
        If TBms.Text = "" Then
            MsgBox("Chưa nhập mã sách")
            TBms.Focus()
        ElseIf TBts.Text = "" Then
            MsgBox("Chưa nhập tên sách")
            TBts.Focus()
        ElseIf TBnxbs.Text = "" Then
            MsgBox("Chưa nhập năm xuất bản")
            TBnxbs.Focus()
        ElseIf CBmtls.Text = "" Then
            MsgBox("Chưa nhập mã thể loại sách")
            TBnxbs.Focus()
        ElseIf CBmtgs.Text = "" Then
            MsgBox("Chưa nhập mã tác giả")
            TBnxbs.Focus()
        ElseIf CBmnxbs.Text = "" Then
            MsgBox("Chưa nhập mã nhà xuất bản")
            TBnxbs.Focus()
        ElseIf hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "UPDATE sach
SET          [mas] = N'" & TBms.Text & "',[tens] = N'" & TBts.Text & "', [matg] = N'" & CBmtgs.Text & "', [manxb] = N'" & CBmnxbs.Text & "', [matl] = N'" & CBmtls.Text & "', [namxb] = N'" & TBnxbs.Text & "', [ghichus] = N'" & TBgcs.Text & "'
WHERE        [mas] = N'" & TBms.Text & "'"
                OleDbUpdateCommands.CommandText = sql
                OleDbUpdateCommands.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Sửa thành công !")
                UpdateSachCount()
                Me.NhaxuatbanTableAdapter.Fill(Me.DataSet.nhaxuatban)
                Me.TacgiaTableAdapter.Fill(Me.DataSet.tacgia)
                Me.TheloaiTableAdapter.Fill(Me.DataSet.theloai)
                Me.SachTableAdapter.Fill(Me.DataSet.sach)
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

    Private Sub BTxoas_Click(sender As Object, e As EventArgs) Handles BTxoas.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn xóa ?", vbYesNo, "Xác nhận ?")
        If hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "DELETE FROM sach
WHERE  mas = N'" & TBms.Text & "' "
                OleDbDeleteCommands.CommandText = sql
                OleDbDeleteCommands.ExecuteNonQuery()
                OleDbConnection.Close()
                DataSet.Clear()
                loaddata()
                MsgBox("Xóa thành công !")
                UpdateSachCount()
                Me.NhaxuatbanTableAdapter.Fill(Me.DataSet.nhaxuatban)
                Me.TacgiaTableAdapter.Fill(Me.DataSet.tacgia)
                Me.TheloaiTableAdapter.Fill(Me.DataSet.theloai)
                Me.SachTableAdapter.Fill(Me.DataSet.sach)
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

    Private Sub BThuys_Click(sender As Object, e As EventArgs) Handles BThuys.Click
        BTluus.Visible = False
        BThuys.Visible = False
        BTxoas.Enabled = True
        BTthems.Enabled = True
        BTsuas.Visible = True
        BTtks.Enabled = True
        BTtks.Visible = True
        BTts.Visible = False
        TBms.Enabled = False
        loaddata()
        Me.NhaxuatbanTableAdapter.Fill(Me.DataSet.nhaxuatban)
        Me.TacgiaTableAdapter.Fill(Me.DataSet.tacgia)
        Me.TheloaiTableAdapter.Fill(Me.DataSet.theloai)
        Me.SachTableAdapter.Fill(Me.DataSet.sach)
    End Sub

    Private Sub BTts_Click(sender As Object, e As EventArgs) Handles BTts.Click
        OleDbConnection.Open()
        Dim sql As String = "SELECT mas, tens, matg, manxb, matl, namxb, ghichus
FROM     sach
Where mas = N'" & TBms.Text & "' Or tens = N'" & TBts.Text & "' Or matg = N'" & CBmtgs.Text & "' Or manxb = N'" & CBmnxbs.Text & "' Or matl = N'" & CBmtls.Text & "' Or matg = N'" & TBnxbs.Text & "'"
        OleDbSelectCommands.CommandText = sql
        OleDbSelectCommands.ExecuteNonQuery()
        DataSet.Clear()
        OleDbConnection.Close()
        loaddata()
        BThuys.Visible = True
        BTthems.Enabled = True
        BTxoas.Enabled = True
        BTts.Visible = False
        BTtks.Visible = True
        BThuys.Visible = False
        BTsuas.Visible = True
        TBms.Enabled = False
    End Sub

    Private Sub BTtks_Click(sender As Object, e As EventArgs) Handles BTtks.Click
        BTtks.Visible = False
        BTthems.Enabled = False
        BThuys.Visible = True
        BTsuas.Visible = False
        BTxoas.Enabled = False
        BTts.Visible = True
        TBms.Enabled = True
        TBms.Text = ""
        TBts.Text = ""
        TBnxbs.Text = ""
        CBmtls.Text = ""
        CBmtgs.Text = ""
        CBmnxbs.Text = ""
        TBgcs.Text = ""
    End Sub

    Private Sub BTloads_Click(sender As Object, e As EventArgs) Handles BTloads.Click
        Me.NhaxuatbanTableAdapter.Fill(Me.DataSet.nhaxuatban)
        Me.TacgiaTableAdapter.Fill(Me.DataSet.tacgia)
        Me.TheloaiTableAdapter.Fill(Me.DataSet.theloai)
        Me.SachTableAdapter.Fill(Me.DataSet.sach)
    End Sub


    ' ------------------------------------------------------------------------------------
    Private Sub Formquanlysach_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim lienket As FormChinh = New FormChinh
            lienket.Show()
            Hide()
        Else
            e.Cancel = True ' Hủy sự kiện đóng form
        End If
    End Sub
End Class