Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Formnhaxuatban
    Private Sub Formnhaxuatban_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.nhaxuatban' table. You can move, or remove it, as needed.
        Me.NhaxuatbanTableAdapter.Fill(Me.DataSet.nhaxuatban)
        BTluunxb.Visible = False
        BThuynxb.Visible = False
        BTtnxb.Visible = False
        TBmnxb.Enabled = False
        UpdateNhaXuatBanCount()
    End Sub

    Private Sub loaddata()
        OleDbDataAdapternxb.Fill(DataSet)
    End Sub

    '--------------------------------------------------------------------------------------------------------
    Private Function GetMinMissingMaNhaXuatBan() As Integer
        Dim missingMaDocGia As Integer = 1
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT CAST(SUBSTRING(manxb, 4, LEN(manxb) - 3) AS INTEGER) AS Ma FROM nhaxuatban ORDER BY Ma"
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
            MessageBox.Show("Lỗi khi lấy mã nhà xuất bản tiếp theo: " & ex.Message)
        Finally
            ' Đảm bảo kết nối được đóng lại ngay cả khi có lỗi
            If OleDbConnection.State = ConnectionState.Open Then
                OleDbConnection.Close()
            End If
        End Try
        Return missingMaDocGia
    End Function

    Private Function GenerateNextMaNhaXuatBan() As String
        Dim nextMa As Integer = GetMinMissingMaNhaXuatBan()
        Return "NXB" & nextMa.ToString("D7")
    End Function

    '--------------------------------------------------------------------------------------------------------
    Private Function CountNhaXuatBan() As Integer
        Dim count As Integer = 0
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT COUNT(*) FROM nhaxuatban"
            Dim command As New OleDbCommand(sql, OleDbConnection)
            count = Convert.ToInt32(command.ExecuteScalar())
            OleDbConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi đếm số nhà xuất bản: " & ex.Message)
        End Try
        Return count
    End Function

    Private Sub UpdateNhaXuatBanCount()
        Dim count As Integer = CountNhaXuatBan()
        LBdemnxb.Text = "Tổng số nhà xuất bản: " & count.ToString()
    End Sub


    '--------------------------------------------------------------------------------------------------------
    Private Sub Themnxb_Click(sender As Object, e As EventArgs) Handles BTthemnxb.Click
        TBmnxb.Text = GenerateNextMaNhaXuatBan()
        TBtnxb.Text = ""
        TBsdtnxb.Text = ""
        TBdcnxb.Text = ""
        TBgcnxb.Text = ""

        BTxoanxb.Enabled = False
        BTtknxb.Enabled = False
        BTluunxb.Visible = True
        BThuynxb.Visible = True
    End Sub

    Private Sub BTluunxb_Click(sender As Object, e As EventArgs) Handles BTluunxb.Click
        Dim sdtPattern As String = "^\d{10,15}$"
        If TBmnxb.Text = "" Then
            MsgBox("Chưa nhập mã nhà xuất bản")
            TBmnxb.Focus()
            Return
        ElseIf TBtnxb.Text = "" Then
            MsgBox("Chưa nhập tên nhà xuất bản")
            TBtnxb.Focus()
            Return
        ElseIf TBsdtnxb.Text = "" Then
            MsgBox("Chưa nhập số điện thoại")
            TBsdtnxb.Focus()
            Return
        ElseIf Not Regex.IsMatch(TBsdtnxb.Text, sdtPattern) Then
            MsgBox("Số điện thoại phải có từ 10 đến 15 số")
            TBsdtnxb.Focus()
            Return
        ElseIf TBdcnxb.Text = "" Then
            MsgBox("Chưa nhập địa chỉ")
            TBdcnxb.Focus()
            Return
        Else
            Try
                OleDbConnection.Open()
                Dim sql As String = "INSERT INTO nhaxuatban
                  (manxb, tennxb, diachinxb, sdtnxb, ghichunxb)
VALUES (N'" & TBmnxb.Text & "',N'" & TBtnxb.Text & "',N'" & TBdcnxb.Text & "',N'" & TBsdtnxb.Text & "',N'" & TBgcnxb.Text & "')"
                OleDbInsertCommandnxb.CommandText = sql
                OleDbInsertCommandnxb.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Thêm thành công !")
                UpdateNhaXuatBanCount()
                BTthemnxb.Enabled = True
                BTsuanxb.Enabled = True
                BTxoanxb.Enabled = True
                BTtknxb.Enabled = True
                BTluunxb.Visible = False
                BThuynxb.Visible = False
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

    Private Sub BTsuanxb_Click(sender As Object, e As EventArgs) Handles BTsuanxb.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn sửa ?", vbYesNo, "Xác nhận ?")
        Dim sdtPattern As String = "^\d{10,15}$"
        If TBmnxb.Text = "" Then
            MsgBox("Chưa nhập mã nhà xuất bản")
            TBmnxb.Focus()
        ElseIf TBtnxb.Text = "" Then
            MsgBox("Chưa nhập tên nhà xuất bản")
            TBtnxb.Focus()
        ElseIf TBsdtnxb.Text = "" Then
            MsgBox("Chưa nhập số điện thoại")
            TBsdtnxb.Focus()
        ElseIf Not Regex.IsMatch(TBsdtnxb.Text, sdtPattern) Then
            MsgBox("Số điện thoại phải có từ 10 đến 15 số")
            TBsdtnxb.Focus()
        ElseIf TBdcnxb.Text = "" Then
            MsgBox("Chưa nhập địa chỉ")
            TBdcnxb.Focus()
        ElseIf hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "UPDATE nhaxuatban
SET          [manxb] = N'" & TBmnxb.Text & "',[tennxb] = N'" & TBtnxb.Text & "', [diachinxb] = N'" & TBdcnxb.Text & "', [sdtnxb] = N'" & TBsdtnxb.Text & "', [ghichunxb] = N'" & TBgcnxb.Text & "'
WHERE        [manxb] = N'" & TBmnxb.Text & "'"
                OleDbUpdateCommandnxb.CommandText = sql
                OleDbUpdateCommandnxb.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Sửa thành công !")
                UpdateNhaXuatBanCount()
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

    Private Sub BTxoanxb_Click(sender As Object, e As EventArgs) Handles BTxoanxb.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn xóa ?", vbYesNo, "Xác nhận ?")
        If hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "DELETE FROM nhaxuatban
WHERE  manxb = N'" & TBmnxb.Text & "' "
                OleDbDeleteCommandnxb.CommandText = sql
                OleDbDeleteCommandnxb.ExecuteNonQuery()
                OleDbConnection.Close()
                DataSet.Clear()
                loaddata()
                MsgBox("Xóa thành công !")
                UpdateNhaXuatBanCount()
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

    Private Sub BThuytt_Click(sender As Object, e As EventArgs) Handles BThuynxb.Click
        BTluunxb.Visible = False
        BThuynxb.Visible = False
        BTxoanxb.Enabled = True
        BTthemnxb.Enabled = True
        BTsuanxb.Visible = True
        BTtknxb.Enabled = True
        BTtknxb.Visible = True
        BTtnxb.Visible = False
        TBmnxb.Enabled = False
        loaddata()
        Me.NhaxuatbanTableAdapter.Fill(Me.DataSet.nhaxuatban)
    End Sub

    Private Sub BTtknxb_Click(sender As Object, e As EventArgs) Handles BTtknxb.Click
        BTtknxb.Visible = False
        BTthemnxb.Enabled = False
        BThuynxb.Visible = True
        BTsuanxb.Visible = False
        BTxoanxb.Enabled = False
        BTtnxb.Visible = True
        TBmnxb.Enabled = True
        TBmnxb.Text = ""
        TBtnxb.Text = ""
        TBsdtnxb.Text = ""
        TBdcnxb.Text = ""
        TBgcnxb.Text = ""
    End Sub

    Private Sub BTtnxb_Click(sender As Object, e As EventArgs) Handles BTtnxb.Click
        OleDbConnection.Open()
        Dim sql As String = "SELECT manxb, tennxb, diachinxb, sdtnxb, ghichunxb
FROM     nhaxuatban
Where manxb = N'" & TBmnxb.Text & "' Or tennxb = N'" & TBtnxb.Text & "'"
        OleDbSelectCommandnxb.CommandText = sql
        OleDbSelectCommandnxb.ExecuteNonQuery()
        DataSet.Clear()
        OleDbConnection.Close()
        loaddata()
        BThuynxb.Visible = True
        BTthemnxb.Enabled = True
        BTxoanxb.Enabled = True
        BTtnxb.Visible = False
        BTtknxb.Visible = True
        BThuynxb.Visible = False
        BTsuanxb.Visible = True
        TBmnxb.Enabled = False
    End Sub



    '--------------------------------------------------------------------------------------------------------
    Private Sub Formnhaxuatban_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim lienket As FormChinh = New FormChinh
            lienket.Show()
            Hide()
        Else
            e.Cancel = True ' Hủy sự kiện đóng form
        End If
    End Sub

    Private Sub BTloadnxb_Click(sender As Object, e As EventArgs) Handles BTloadnxb.Click
        Me.NhaxuatbanTableAdapter.Fill(Me.DataSet.nhaxuatban)
    End Sub
End Class