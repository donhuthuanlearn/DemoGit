Imports System.Data.OleDb

Public Class Formtheloaisach
    Private Sub Formtheloaisach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.theloai' table. You can move, or remove it, as needed.
        Me.TheloaiTableAdapter.Fill(Me.DataSet.theloai)
        BTluutl.Visible = False
        BThuytl.Visible = False
        BTttl.Visible = False
        TBmtl.Enabled = False
        UpdateTheLoaiCount()
    End Sub

    Private Sub loaddata()
        OleDbDataAdaptertl.Fill(DataSet)
    End Sub

    ' ------------------------------------------------------------------------------------
    Private Function GetMinMissingMaTheLoai() As Integer
        Dim missingMaDocGia As Integer = 1
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT CAST(SUBSTRING(matl, 3, LEN(matl) - 2) AS INTEGER) AS Ma FROM theloai ORDER BY Ma"
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
            MessageBox.Show("Lỗi khi lấy mã thể loại tiếp theo: " & ex.Message)
        Finally
            ' Đảm bảo kết nối được đóng lại ngay cả khi có lỗi
            If OleDbConnection.State = ConnectionState.Open Then
                OleDbConnection.Close()
            End If
        End Try
        Return missingMaDocGia
    End Function

    Private Function GenerateNextMaTheLoai() As String
        Dim nextMa As Integer = GetMinMissingMaTheLoai()
        Return "TL" & nextMa.ToString("D8")
    End Function

    ' ------------------------------------------------------------------------------------
    Private Function CountTheLoai() As Integer
        Dim count As Integer = 0
        Try
            OleDbConnection.Open()
            Dim sql As String = "SELECT COUNT(*) FROM theloai"
            Dim command As New OleDbCommand(sql, OleDbConnection)
            count = Convert.ToInt32(command.ExecuteScalar())
            OleDbConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi đếm mã thể loại: " & ex.Message)
        End Try
        Return count
    End Function

    Private Sub UpdateTheLoaiCount()
        Dim count As Integer = CountTheLoai()
        LBdemtl.Text = "Tổng số thể loại sách: " & count.ToString()
    End Sub

    ' ------------------------------------------------------------------------------------
    Private Sub BTthemtl_Click(sender As Object, e As EventArgs) Handles BTthemtl.Click
        TBmtl.Text = GenerateNextMaTheLoai()
        TBhttl.Text = ""
        TBmttl.Text = ""

        BTxoatl.Enabled = False
        BTtktl.Enabled = False
        BTluutl.Visible = True
        BThuytl.Visible = True
    End Sub

    Private Sub BTluutl_Click(sender As Object, e As EventArgs) Handles BTluutl.Click
        If TBmtl.Text = "" Then
            MsgBox("Chưa nhập mã thể loại")
            TBmtl.Focus()
            Return
        ElseIf TBhttl.Text = "" Then
            MsgBox("Chưa nhập tên thể loại")
            TBhttl.Focus()
            Return
        Else
            Try
                OleDbConnection.Open()
                Dim sql As String = "INSERT INTO theloai
                  (matl, hotentl, motatl)
VALUES (N'" & TBmtl.Text & "',N'" & TBhttl.Text & "',N'" & TBmttl.Text & "')"
                OleDbInsertCommandtl.CommandText = sql
                OleDbInsertCommandtl.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Thêm thành công !")
                UpdateTheLoaiCount()
                BTthemtl.Enabled = True
                BTsuatl.Enabled = True
                BTxoatl.Enabled = True
                BTtktl.Enabled = True
                BTluutl.Visible = False
                BThuytl.Visible = False
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

    Private Sub BTsuatl_Click(sender As Object, e As EventArgs) Handles BTsuatl.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn sửa ?", vbYesNo, "Xác nhận ?")
        If TBmtl.Text = "" Then
            MsgBox("Chưa nhập mã thể loại")
            TBmtl.Focus()
            Return
        ElseIf TBhttl.Text = "" Then
            MsgBox("Chưa nhập tên thể loại")
            TBhttl.Focus()
            Return
        ElseIf hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "UPDATE theloai
SET          [matl] = N'" & TBmtl.Text & "',[hotentl] = N'" & TBhttl.Text & "', [motatl] = N'" & TBmttl.Text & "'
WHERE        [matl] = N'" & TBmtl.Text & "'"
                OleDbUpdateCommandtl.CommandText = sql
                OleDbUpdateCommandtl.ExecuteNonQuery()
                DataSet.Clear()
                OleDbConnection.Close()
                loaddata()
                MsgBox("Sửa thành công !")
                UpdateTheLoaiCount()
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

    Private Sub BTxoatl_Click(sender As Object, e As EventArgs) Handles BTxoatl.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn xóa ?", vbYesNo, "Xác nhận ?")
        If hoi = vbYes Then
            Try
                OleDbConnection.Open()
                Dim sql As String = "DELETE FROM theloai
WHERE  matl = N'" & TBmtl.Text & "' "
                OleDbDeleteCommandtl.CommandText = sql
                OleDbDeleteCommandtl.ExecuteNonQuery()
                OleDbConnection.Close()
                DataSet.Clear()
                loaddata()
                MsgBox("Xóa thành công !")
                UpdateTheLoaiCount()
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


    Private Sub BThuytl_Click(sender As Object, e As EventArgs) Handles BThuytl.Click
        BTluutl.Visible = False
        BThuytl.Visible = False
        BTxoatl.Enabled = True
        BTthemtl.Enabled = True
        BTsuatl.Visible = True
        BTtktl.Enabled = True
        BTtktl.Visible = True
        BTttl.Visible = False
        TBmtl.Enabled = False
        loaddata()
        Me.TheloaiTableAdapter.Fill(Me.DataSet.theloai)
    End Sub

    Private Sub BTttl_Click(sender As Object, e As EventArgs) Handles BTttl.Click
        OleDbConnection.Open()
        Dim sql As String = "SELECT matl, hotentl, motatl
FROM     theloai
Where matl = N'" & TBmtl.Text & "' Or hotentl = N'" & TBhttl.Text & "'"
        OleDbSelectCommandtl.CommandText = sql
        OleDbSelectCommandtl.ExecuteNonQuery()
        DataSet.Clear()
        OleDbConnection.Close()
        loaddata()
        BThuytl.Visible = True
        BTthemtl.Enabled = True
        BTxoatl.Enabled = True
        BTttl.Visible = False
        BTtktl.Visible = True
        BThuytl.Visible = False
        BTsuatl.Visible = True
        TBmtl.Enabled = False
    End Sub

    Private Sub BTtktl_Click(sender As Object, e As EventArgs) Handles BTtktl.Click
        BTtktl.Visible = False
        BTthemtl.Enabled = False
        BThuytl.Visible = True
        BTsuatl.Visible = False
        BTxoatl.Enabled = False
        BTttl.Visible = True
        TBmtl.Enabled = True

        TBmtl.Text = ""
        TBhttl.Text = ""
        TBmttl.Text = ""
    End Sub

    Private Sub BTloadtl_Click(sender As Object, e As EventArgs) Handles BTloadtl.Click
        Me.TheloaiTableAdapter.Fill(Me.DataSet.theloai)
    End Sub

    ' -----------------------------------------------------------------------
    Private Sub Formtheloaisach_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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