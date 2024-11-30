Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Formdocgia
    Private Sub Formdocgia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
        BTluudg.Visible = False
        BThuydg.Visible = False
        BTtdg.Visible = False
        TBmdg.Enabled = False
        UpdateDocGiaCount()
    End Sub

    Private Sub loaddata()
        OleDbDataAdapterdg.Fill(DataSet)
    End Sub

    ' ------------------------------------------------------------------------------------
    Private Function GetMinMissingMaDocGia() As Integer
        Dim missingMaDocGia As Integer = 1
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT CAST(SUBSTRING(madg, 3, LEN(madg) - 2) AS INTEGER) AS Ma FROM docgia ORDER BY Ma"
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
            MessageBox.Show("Lỗi khi lấy mã độc giả tiếp theo: " & ex.Message)
        Finally
            ' Đảm bảo kết nối được đóng lại ngay cả khi có lỗi
            If OleDbConnection.State = ConnectionState.Open Then
                OleDbConnection.Close()
            End If
        End Try
        Return missingMaDocGia
    End Function

    Private Function GenerateNextMaDocGia() As String
        Dim nextMa As Integer = GetMinMissingMaDocGia()
        Return "DG" & nextMa.ToString("D8")
    End Function

    ' ------------------------------------------------------------------------------------
    Private Function CountDocGia() As Integer
        Dim count As Integer = 0
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT COUNT(*) FROM docgia"
            Dim command As New OleDbCommand(sql, OleDbConnection)
            count = Convert.ToInt32(command.ExecuteScalar())
            OleDbConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi đếm số độc giả: " & ex.Message)
        End Try
        Return count
    End Function

    Private Sub UpdateDocGiaCount()
        Dim count As Integer = CountDocGia()
        LBdemdg.Text = "Tổng số độc giả: " & count.ToString()
    End Sub

    ' ------------------------------------------------------------------------------------
    Private Sub Themdg_Click(sender As Object, e As EventArgs) Handles BTthemdg.Click
        TBmdg.Text = GenerateNextMaDocGia()
        TBhtdg.Text = ""
        CBgtdg.SelectedIndex = 0
        TBdcdg.Text = ""
        TBsdtdg.Text = ""
        TBgcdg.Text = ""
        DTPnsdg.ResetText()

        BTxoadg.Enabled = False
        BTtkdg.Enabled = False
        BTluudg.Visible = True
        BThuydg.Visible = True
    End Sub

    Private Sub BTluudg_Click(sender As Object, e As EventArgs) Handles BTluudg.Click
        Dim ngaysinhdg As String
        ngaysinhdg = DTPnsdg.Value.ToString("yyyy/MM/dd")
        Dim sdtPattern As String = "^\d{10,15}$"
        If TBmdg.Text = "" Then
            MsgBox("Chưa nhập mã độc giả")
            TBmdg.Focus()
            Return
        ElseIf TBhtdg.Text = "" Then
            MsgBox("Chưa nhập họ tên")
            TBhtdg.Focus()
            Return
        ElseIf CBgtdg.Text = "" Then
            MsgBox("Chưa nhập chọn giới tính")
        ElseIf CBgtdg.Text <> "Nam" And CBgtdg.Text <> "Nữ" Then
            MsgBox("Vui lòng chọn lại giới tính")
            CBgtdg.Focus()
            Return
        ElseIf TBdcdg.Text = "" Then
            MsgBox("Chưa nhập địa chỉ")
            TBdcdg.Focus()
            Return
        ElseIf TBsdtdg.Text = "" Then
            MsgBox("Chưa nhập số điện thoại")
            TBsdtdg.Focus()
            Return
        ElseIf Not Regex.IsMatch(TBsdtdg.Text, sdtPattern) Then
            MsgBox("Số điện thoại phải có từ 10 đến 15 số")
            TBsdtdg.Focus()
            Return
        Else
            Try
                OleDbConnection.Open()
                Dim sql As String = "INSERT INTO docgia
                  (madg, hotendg, gioitinhdg, ngaysinhdg, diachidg, sdtdg, ghichudg)
VALUES (N'" & TBmdg.Text & "',N'" & TBhtdg.Text & "',N'" & CBgtdg.Text & "',N'" & ngaysinhdg & "',N'" & TBdcdg.Text & "',N'" & TBsdtdg.Text & "',N'" & TBgcdg.Text & "')"
                OleDbInsertCommanddg.CommandText = sql
                OleDbInsertCommanddg.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Thêm thành công !")
                UpdateDocGiaCount()
                BTthemdg.Enabled = True
                BTsuadg.Enabled = True
                BTxoadg.Enabled = True
                BTtkdg.Enabled = True
                BTluudg.Visible = False
                BThuydg.Visible = False
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

    Private Sub BTsuadg_Click(sender As Object, e As EventArgs) Handles BTsuadg.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn sửa ?", vbYesNo, "Xác nhận ?")
        Dim ngaysinhdg As String
        ngaysinhdg = DTPnsdg.Value.ToString("yyyy/MM/dd")
        If TBmdg.Text = "" Then
            MsgBox("Chưa nhập mã độc giả")
            TBmdg.Focus()
        ElseIf TBhtdg.Text = "" Then
            MsgBox("Chưa nhập họ tên")
            TBhtdg.Focus()
        ElseIf CBgtdg.Text = "" Then
            MsgBox("Chưa nhập chọn giới tính")
        ElseIf CBgtdg.Text <> "Nam" And CBgtdg.Text <> "Nữ" Then
            MsgBox("Vui lòng chọn lại giới tính")
            CBgtdg.Focus()
        ElseIf TBdcdg.Text = "" Then
            MsgBox("Chưa nhập địa chỉ")
            TBdcdg.Focus()
        ElseIf TBsdtdg.Text = "" Then
            MsgBox("Chưa nhập số điện thoại")
            TBsdtdg.Focus()
        ElseIf hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "UPDATE docgia
SET          [madg] = N'" & TBmdg.Text & "',[hotendg] = N'" & TBhtdg.Text & "', [gioitinhdg] = N'" & CBgtdg.Text & "', [ngaysinhdg] = N'" & ngaysinhdg & "', [diachidg] = N'" & TBdcdg.Text & "', [sdtdg] = N'" & TBsdtdg.Text & "', [ghichudg] = N'" & TBgcdg.Text & "'
WHERE        [madg] = N'" & TBmdg.Text & "'"
                OleDbUpdateCommanddg.CommandText = sql
                OleDbUpdateCommanddg.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Sửa thành công !")
                UpdateDocGiaCount()
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

    Private Sub BTxoadg_Click(sender As Object, e As EventArgs) Handles BTxoadg.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn xóa ?", vbYesNo, "Xác nhận ?")
        If hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "DELETE FROM docgia
WHERE  madg = N'" & TBmdg.Text & "' "
                OleDbDeleteCommanddg.CommandText = sql
                OleDbDeleteCommanddg.ExecuteNonQuery()
                OleDbConnection.Close()
                DataSet.Clear()
                loaddata()
                MsgBox("Xóa thành công !")
                UpdateDocGiaCount()
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


    Private Sub BThuytt_Click(sender As Object, e As EventArgs) Handles BThuydg.Click
        BTluudg.Visible = False
        BThuydg.Visible = False
        BTxoadg.Enabled = True
        BTthemdg.Enabled = True
        BTsuadg.Visible = True
        BTtkdg.Enabled = True
        BTtkdg.Visible = True
        BTtdg.Visible = False
        TBmdg.Enabled = False
        loaddata()
        Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
    End Sub

    Private Sub BTtkdg_Click(sender As Object, e As EventArgs) Handles BTtkdg.Click
        BTtkdg.Visible = False
        BTthemdg.Enabled = False
        BThuydg.Visible = True
        BTsuadg.Visible = False
        BTxoadg.Enabled = False
        BTtdg.Visible = True
        TBmdg.Enabled = True
        TBmdg.Text = ""
        TBhtdg.Text = ""
        TBhtdg.Text = ""
        CBgtdg.Text = ""
        TBsdtdg.Text = ""
        TBdcdg.Text = ""
        DTPnsdg.ResetText()
    End Sub

    Private Sub BTtdg_Click(sender As Object, e As EventArgs) Handles BTtdg.Click
        OleDbConnection.Open()
        Dim sql As String = "SELECT madg, hotendg, gioitinhdg, ngaysinhdg, diachidg, sdtdg, ghichudg
FROM     docgia
Where madg = N'" & TBmdg.Text & "' Or hotendg = N'" & TBhtdg.Text & "'"
        OleDbSelectCommanddg.CommandText = sql
        OleDbSelectCommanddg.ExecuteNonQuery()
        DataSet.Clear()
        OleDbConnection.Close()
        loaddata()
        BThuydg.Visible = True
        BTthemdg.Enabled = True
        BTxoadg.Enabled = True
        BTtdg.Visible = False
        BTtkdg.Visible = True
        BThuydg.Visible = False
        BTsuadg.Visible = True
        TBmdg.Enabled = False
    End Sub

    Private Sub BTloaddg_Click(sender As Object, e As EventArgs) Handles BTloaddg.Click
        Me.DocgiaTableAdapter.Fill(Me.DataSet.docgia)
    End Sub

    ' ------------------------------------------------------------------------------------
    Private Sub Formdocgia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim lienket As FormChinh = New FormChinh
            lienket.Show()
            Hide()
        Else
            e.Cancel = True
        End If
    End Sub
End Class