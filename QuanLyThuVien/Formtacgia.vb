Imports System.Data.OleDb

Public Class Formtacgia
    Private Sub Formtacgia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tacgia' table. You can move, or remove it, as needed.
        Me.TacgiaTableAdapter.Fill(Me.DataSet.tacgia)
        BTluutg.Visible = False
        BThuytg.Visible = False
        BTttg.Visible = False
        TBmtg.Enabled = False
        UpdateTacGiaCount()
    End Sub

    Private Sub loaddata()
        OleDbDataAdaptertg.Fill(DataSet)
    End Sub

    ' ------------------------------------------------------------------------------------
    Private Function GetMinMissingMaTacGia() As Integer
        Dim missingMaDocGia As Integer = 1
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT CAST(SUBSTRING(matg, 3, LEN(matg) - 2) AS INTEGER) AS Ma FROM tacgia ORDER BY Ma"
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
            MessageBox.Show("Lỗi khi lấy mã tác giả tiếp theo: " & ex.Message)
        Finally
            ' Đảm bảo kết nối được đóng lại ngay cả khi có lỗi
            If OleDbConnection.State = ConnectionState.Open Then
                OleDbConnection.Close()
            End If
        End Try
        Return missingMaDocGia
    End Function

    Private Function GenerateNextMaTacGia() As String
        Dim nextMa As Integer = GetMinMissingMaTacGia()
        Return "TG" & nextMa.ToString("D8")
    End Function

    ' ------------------------------------------------------------------------------------
    Private Function CountTacGia() As Integer
        Dim count As Integer = 0
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT COUNT(*) FROM tacgia"
            Dim command As New OleDbCommand(sql, OleDbConnection)
            count = Convert.ToInt32(command.ExecuteScalar())
            OleDbConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi đếm số tác giả: " & ex.Message)
        End Try
        Return count
    End Function

    Private Sub UpdateTacGiaCount()
        Dim count As Integer = CountTacGia()
        LBdemtg.Text = "Tổng số tác giả: " & count.ToString()
    End Sub

    ' ------------------------------------------------------------------------------------
    Private Sub BTthemtg_Click(sender As Object, e As EventArgs) Handles BTthemtg.Click
        TBmtg.Text = GenerateNextMaTacGia()
        TBhttg.Text = ""
        TBtstg.Text = ""

        BTxoatg.Enabled = False
        BTtktg.Enabled = False
        BTluutg.Visible = True
        BThuytg.Visible = True
    End Sub

    Private Sub BTluutg_Click(sender As Object, e As EventArgs) Handles BTluutg.Click
        If TBmtg.Text = "" Then
            MsgBox("Chưa nhập mã tác giả")
            TBmtg.Focus()
            Return
        ElseIf TBhttg.Text = "" Then
            MsgBox("Chưa nhập họ tên")
            TBhttg.Focus()
            Return
        Else
            Try
                OleDbConnection.Open()
                Dim sql As String = "INSERT INTO tacgia
                  (matg, hotentg, tieusutg)
VALUES (N'" & TBmtg.Text & "',N'" & TBhttg.Text & "',N'" & TBtstg.Text & "')"
                OleDbInsertCommandtg.CommandText = sql
                OleDbInsertCommandtg.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Thêm thành công !")
                UpdateTacGiaCount()
                BTthemtg.Enabled = True
                BTsuatg.Enabled = True
                BTxoatg.Enabled = True
                BTtktg.Enabled = True
                BTluutg.Visible = False
                BThuytg.Visible = False
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

    Private Sub BTsuatg_Click(sender As Object, e As EventArgs) Handles BTsuatg.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn sửa ?", vbYesNo, "Xác nhận ?")
        If TBmtg.Text = "" Then
            MsgBox("Chưa nhập mã tác giả")
            TBmtg.Focus()
            Return
        ElseIf TBhttg.Text = "" Then
            MsgBox("Chưa nhập họ tên")
            TBhttg.Focus()
            Return
        ElseIf hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "UPDATE tacgia
SET          [matg] = N'" & TBmtg.Text & "',[hotentg] = N'" & TBhttg.Text & "', [tieusutg] = N'" & TBtstg.Text & "'
WHERE        [matg] = N'" & TBmtg.Text & "'"
                OleDbUpdateCommandtg.CommandText = sql
                OleDbUpdateCommandtg.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Sửa thành công !")
                UpdateTacGiaCount()
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

    Private Sub BTxoatg_Click(sender As Object, e As EventArgs) Handles BTxoatg.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn xóa ?", vbYesNo, "Xác nhận ?")
        If hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "DELETE FROM tacgia
WHERE  matg = N'" & TBmtg.Text & "' "
                OleDbDeleteCommandtg.CommandText = sql
                OleDbDeleteCommandtg.ExecuteNonQuery()
                OleDbConnection.Close()
                DataSet.Clear()
                loaddata()
                MsgBox("Xóa thành công !")
                UpdateTacGiaCount()
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

    Private Sub BThuytg_Click(sender As Object, e As EventArgs) Handles BThuytg.Click
        BTluutg.Visible = False
        BThuytg.Visible = False
        BTxoatg.Enabled = True
        BTthemtg.Enabled = True
        BTsuatg.Visible = True
        BTtktg.Enabled = True
        BTtktg.Visible = True
        BTttg.Visible = False
        TBmtg.Enabled = False
        loaddata()
        Me.TacgiaTableAdapter.Fill(Me.DataSet.tacgia)
    End Sub

    Private Sub BTtdg_Click(sender As Object, e As EventArgs) Handles BTttg.Click
        OleDbConnection.Open()
        Dim sql As String = "SELECT matg, hotentg, tieusutg
FROM     tacgia
Where matg = N'" & TBmtg.Text & "' Or hotentg = N'" & TBhttg.Text & "'"
        OleDbSelectCommandtg.CommandText = sql
        OleDbSelectCommandtg.ExecuteNonQuery()
        DataSet.Clear()
        OleDbConnection.Close()
        loaddata()
        BThuytg.Visible = True
        BTthemtg.Enabled = True
        BTxoatg.Enabled = True
        BTttg.Visible = False
        BTtktg.Visible = True
        BThuytg.Visible = False
        BTsuatg.Visible = True
        TBmtg.Enabled = False
    End Sub

    Private Sub BTtkdg_Click(sender As Object, e As EventArgs) Handles BTtktg.Click
        BTtktg.Visible = False
        BTthemtg.Enabled = False
        BThuytg.Visible = True
        BTsuatg.Visible = False
        BTxoatg.Enabled = False
        BTttg.Visible = True
        TBmtg.Enabled = True

        TBmtg.Text = ""
        TBtstg.Text = ""
        TBhttg.Text = ""
    End Sub

    Private Sub BTloadtg_Click(sender As Object, e As EventArgs) Handles BTloadtg.Click
        Me.TacgiaTableAdapter.Fill(Me.DataSet.tacgia)
    End Sub

    ' ------------------------------------------------------------------------------------

    Private Sub Formtacgia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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