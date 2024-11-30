Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Formthongkesach
    Private Sub Formthongkesach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ThongKeSach' table. You can move, or remove it, as needed.
        Me.ThongKeSachTableAdapter.Fill(Me.DataSet.ThongKeSach)
        LoadBookTypes()
    End Sub

    Private Sub loaddata()
        OleDbDataAdaptertks.Fill(DataSet)
    End Sub

    Private Sub Formthongkesach_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub LoadBookTypes()
        ' Giả sử ComboBox có tên là ComboBox1
        CBtctk.Items.Add("Tất cả sách")
        CBtctk.Items.Add("Sách trễ hạn trả")
        CBtctk.Items.Add("Sách đang được mượn")
        CBtctk.Items.Add("Sách không được mượn")
        CBtctk.SelectedIndex = 0 ' Chọn mục đầu tiên là "Tất cả" mặc định
    End Sub

    Private Sub LoadBooksByType(bookType As String)
        Dim commandText As String = "SELECT * FROM ThongKeSach WHERE Loai = @Loai"
        Dim command As New SqlCommand(commandText, connection)
        command.Parameters.AddWithValue("@Loai", bookType)

        DisplayBooks(command)
    End Sub

    Private Sub DisplayBooks(command As SqlCommand)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        Try
            connection.Open()
            adapter.Fill(table)

            ' Hiển thị dữ liệu lên giao diện
            DataGridViewtks.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub BTtks_Click(sender As Object, e As EventArgs) Handles BTtks.Click
        Dim selectedType As String = CBtctk.SelectedItem.ToString()
        LoadBooksByType(selectedType)
    End Sub

    Private Sub BTloadtks_Click(sender As Object, e As EventArgs)
        Me.ThongKeSachTableAdapter.Fill(Me.DataSet.ThongKeSach)
        loaddata()
    End Sub
End Class