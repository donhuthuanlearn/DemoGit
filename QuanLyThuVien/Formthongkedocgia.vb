Imports System.Data.SqlClient

Public Class Formthongkedocgia
    Private Sub Formthongkedocgia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.ThongKeDocGia' table. You can move, or remove it, as needed.
        Me.ThongKeDocGiaTableAdapter.Fill(Me.DataSet.ThongKeDocGia)
        Me.ThongKeDocGiaTableAdapter.Fill(Me.DataSet.ThongKeDocGia)
        LoadDocGIaTypes()
    End Sub

    Private Sub loaddata()
        OleDbDataAdaptertkdg.Fill(DataSet)
    End Sub

    Private Sub Formthongkedocgia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim lienket As FormChinh = New FormChinh
            lienket.Show()
            Hide()
        Else
            e.Cancel = True ' Hủy sự kiện đóng form
        End If
    End Sub

    Dim connectionString As String = "Data Source=ADMIN;Initial Catalog=QLTV;User ID=sa;Password=123"
    Dim connection As New SqlConnection(connectionString)

    Private Sub LoadDocGIaTypes()
        ' Giả sử ComboBox có tên là ComboBox1
        CBtctk.Items.Add("Tất cả độc giả")
        CBtctk.Items.Add("Không mượn sách")
        CBtctk.Items.Add("Đang mượn sách")
        CBtctk.Items.Add("Trễ hạn trả")
        CBtctk.SelectedIndex = 0 ' Chọn mục đầu tiên là "Tất cả" mặc định
    End Sub

    Private Sub LoadDocGiasByType(docgiaType As String)
        Dim commandText As String = "SELECT * FROM ThongKeDocGia WHERE Loai = @Loai"
        Dim command As New SqlCommand(commandText, connection)
        command.Parameters.AddWithValue("@Loai", docgiaType)

        DisplayDocGias(command)
    End Sub

    Private Sub DisplayDocGias(command As SqlCommand)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        Try
            connection.Open()
            adapter.Fill(table)

            ' Hiển thị dữ liệu lên giao diện
            DataGridViewtkdg.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub BTtkdg_Click(sender As Object, e As EventArgs) Handles BTtkdg.Click
        Dim selectedType As String = CBtctk.SelectedItem.ToString()
        LoadDocGiasByType(selectedType)
    End Sub

End Class