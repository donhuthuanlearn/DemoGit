Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Formthuthu
    Private Sub Formthuthu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.thuthu' table. You can move, or remove it, as needed.
        Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
        BTluutt.Visible = False
        BThuytt.Visible = False
        BTttt.Visible = False
        TBmtt.Enabled = False
        UpdateThuThuCount()
    End Sub

    Private Sub loaddata()
        OleDbDataAdaptertt.Fill(DataSet)
    End Sub

    ' ---------------------------------------------------------------------------
    Private Function GetMinMissingMaThuThu() As Integer
        Dim missingMaDocGia As Integer = 1
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT CAST(SUBSTRING(matt, 3, LEN(matt) - 2) AS INTEGER) AS Ma FROM thuthu ORDER BY Ma"
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
            MessageBox.Show("Lỗi khi lấy mã thủ thư tiếp theo: " & ex.Message)
        Finally
            ' Đảm bảo kết nối được đóng lại ngay cả khi có lỗi
            If OleDbConnection.State = ConnectionState.Open Then
                OleDbConnection.Close()
            End If
        End Try
        Return missingMaDocGia
    End Function

    Private Function GenerateNextMaThuThu() As String
        Dim nextMa As Integer = GetMinMissingMaThuThu()
        Return "TT" & nextMa.ToString("D8")
    End Function

    ' ---------------------------------------------------------------------------
    Private Function CountThuThu() As Integer
        Dim count As Integer = 0
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT COUNT(*) FROM thuthu"
            Dim command As New OleDbCommand(sql, OleDbConnection)
            count = Convert.ToInt32(command.ExecuteScalar())
            OleDbConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi đếm số thủ thư: " & ex.Message)
        End Try
        Return count
    End Function

    Private Sub UpdateThuThuCount()
        Dim count As Integer = CountThuThu()
        LBdemtt.Text = "Tổng số thủ thư: " & count.ToString()
    End Sub

    ' ---------------------------------------------------------------------------
    Private Sub Themtt_Click(sender As Object, e As EventArgs) Handles BTthemtt.Click
        TBmtt.Text = GenerateNextMaThuThu()
        TBhttt.Text = ""
        CBgttt.SelectedIndex = 0
        TBdctt.Text = ""
        TBsdttt.Text = ""
        TBgctt.Text = ""
        DTPnstt.ResetText()

        BTxoatt.Enabled = False
        BTtktt.Enabled = False
        BTluutt.Visible = True
        BThuytt.Visible = True
    End Sub

    Private Sub BTluutt_Click(sender As Object, e As EventArgs) Handles BTluutt.Click
        Dim ngaysinhtt As String
        ngaysinhtt = DTPnstt.Value.ToString("yyyy/MM/dd")
        Dim sdtPattern As String = "^\d{10,15}$"
        If TBmtt.Text = "" Then
            MsgBox("Chưa nhập mã thủ thư")
            TBmtt.Focus()
            Return
        ElseIf TBhttt.Text = "" Then
            MsgBox("Chưa nhập họ tên")
            TBhttt.Focus()
            Return
        ElseIf CBgttt.Text = "" Then
            MsgBox("Chưa nhập chọn giới tính")
        ElseIf CBgttt.Text <> "Nam" And CBgttt.Text <> "Nữ" Then
            MsgBox("Vui lòng chọn lại giới tính")
            CBgttt.Focus()
            Return
        ElseIf TBdctt.Text = "" Then
            MsgBox("Chưa nhập địa chỉ")
            TBdctt.Focus()
            Return
        ElseIf TBsdttt.Text = "" Then
            MsgBox("Chưa nhập số điện thoại")
            TBsdttt.Focus()
            Return
        ElseIf Not Regex.IsMatch(TBsdttt.Text, sdtPattern) Then
            MsgBox("Số điện thoại phải có từ 10 đến 15 số")
            TBsdttt.Focus()
            Return
        Else
            Try
                OleDbConnection.Open()
                Dim sql As String = "INSERT INTO thuthu
                  (matt, hotentt, gioitinhtt, ngaysinhtt, diachitt, sdttt, ghichutt)
VALUES (N'" & TBmtt.Text & "',N'" & TBhttt.Text & "',N'" & CBgttt.Text & "',N'" & ngaysinhtt & "',N'" & TBdctt.Text & "',N'" & TBsdttt.Text & "',N'" & TBgctt.Text & "')"
                OleDbInsertCommandtt.CommandText = sql
                OleDbInsertCommandtt.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Thêm thành công !")
                UpdateThuThuCount()
                BTthemtt.Enabled = True
                BTsuatt.Enabled = True
                BTxoatt.Enabled = True
                BTtktt.Enabled = True
                BTluutt.Visible = False
                BThuytt.Visible = False
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

    Private Sub BTsuatt_Click(sender As Object, e As EventArgs) Handles BTsuatt.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn sửa ?", vbYesNo, "Xác nhận ?")
        Dim ngaysinhtt As String
        ngaysinhtt = DTPnstt.Value.ToString("yyyy/MM/dd")
        If TBmtt.Text = "" Then
            MsgBox("Chưa nhập mã thủ thư")
            TBmtt.Focus()
        ElseIf TBhttt.Text = "" Then
            MsgBox("Chưa nhập họ tên")
            TBhttt.Focus()
        ElseIf CBgttt.Text = "" Then
            MsgBox("Chưa nhập chọn giới tính")
        ElseIf CBgttt.Text <> "Nam" And CBgttt.Text <> "Nữ" Then
            MsgBox("Vui lòng chọn lại giới tính")
            CBgttt.Focus()
        ElseIf TBdctt.Text = "" Then
            MsgBox("Chưa nhập địa chỉ")
            TBdctt.Focus()
        ElseIf TBsdttt.Text = "" Then
            MsgBox("Chưa nhập số điện thoại")
            TBsdttt.Focus()
        ElseIf hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "UPDATE thuthu
SET          [matt] = N'" & TBmtt.Text & "',[hotentt] = N'" & TBhttt.Text & "', [gioitinhtt] = N'" & CBgttt.Text & "', [ngaysinhtt] = N'" & ngaysinhtt & "', [diachitt] = N'" & TBdctt.Text & "', [sdttt] = N'" & TBsdttt.Text & "', [ghichutt] = N'" & TBgctt.Text & "'
WHERE        [matt] = N'" & TBmtt.Text & "'"
                OleDbUpdateCommandtt.CommandText = sql
                OleDbUpdateCommandtt.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Sửa thành công !")
                UpdateThuThuCount()
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

    Private Sub BTxoatt_Click(sender As Object, e As EventArgs) Handles BTxoatt.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn xóa ?", vbYesNo, "Xác nhận ?")
        If hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "DELETE FROM thuthu
WHERE  matt = N'" & TBmtt.Text & "' "
                OleDbDeleteCommandtt.CommandText = sql
                OleDbDeleteCommandtt.ExecuteNonQuery()
                OleDbConnection.Close()
                DataSet.Clear()
                loaddata()
                MsgBox("Xóa thành công !")
                UpdateThuThuCount()
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

    Private Sub BThuytt_Click(sender As Object, e As EventArgs) Handles BThuytt.Click
        BTluutt.Visible = False
        BThuytt.Visible = False
        BTxoatt.Enabled = True
        BTthemtt.Enabled = True
        BTsuatt.Visible = True
        BTtktt.Enabled = True
        BTtktt.Visible = True
        BTttt.Visible = False
        TBmtt.Enabled = False
        loaddata()
        Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
    End Sub

    Private Sub BTttt_Click(sender As Object, e As EventArgs) Handles BTttt.Click
        OleDbConnection.Open()
        Dim sql As String = "SELECT matt, hotentt, gioitinhtt, ngaysinhtt, diachitt, sdttt, ghichutt
FROM     thuthu
Where matt = N'" & TBmtt.Text & "' Or hotentt = N'" & TBhttt.Text & "'"
        OleDbSelectCommandtt.CommandText = sql
        OleDbSelectCommandtt.ExecuteNonQuery()
        DataSet.Clear()
        OleDbConnection.Close()
        loaddata()
        BThuytt.Visible = True
        BTthemtt.Enabled = True
        BTxoatt.Enabled = True
        BTttt.Visible = False
        BTtktt.Visible = True
        BThuytt.Visible = False
        BTsuatt.Visible = True
        TBmtt.Enabled = False
    End Sub

    Private Sub BTtktt_Click(sender As Object, e As EventArgs) Handles BTtktt.Click
        BTtktt.Visible = False
        BTthemtt.Enabled = False
        BThuytt.Visible = True
        BTsuatt.Visible = False
        BTxoatt.Enabled = False
        BTttt.Visible = True
        TBmtt.Enabled = True

        TBmtt.Text = ""
        TBhttt.Text = ""
        CBgttt.Text = ""
        TBdctt.Text = ""
        TBsdttt.Text = ""
        TBgctt.Text = ""
        DTPnstt.ResetText()
    End Sub

    Private Sub BTloadtt_Click(sender As Object, e As EventArgs) Handles BTloadtt.Click
        Me.ThuthuTableAdapter.Fill(Me.DataSet.thuthu)
    End Sub

    ' --------------------------------------------------------------------------
    Private Sub Formthuthu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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