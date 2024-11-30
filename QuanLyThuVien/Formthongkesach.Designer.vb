<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formthongkesach
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTtks = New System.Windows.Forms.Button()
        Me.CBtctk = New System.Windows.Forms.ComboBox()
        Me.DataGridViewtks = New System.Windows.Forms.DataGridView()
        Me.ThongKeSachBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New QuanLyThuVien.DataSet()
        Me.ThongKeSachTableAdapter = New QuanLyThuVien.DataSetTableAdapters.ThongKeSachTableAdapter()
        Me.OleDbSelectCommandtks = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection = New System.Data.OleDb.OleDbConnection()
        Me.OleDbDataAdaptertks = New System.Data.OleDb.OleDbDataAdapter()
        Me.LoaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSachDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSachDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamXuatBanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TacGiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NhaXuatBanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TheLoaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayMuonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayTraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoNgayTreHanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewtks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThongKeSachBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTtks)
        Me.GroupBox1.Controls.Add(Me.CBtctk)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(1, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1554, 138)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tùy chọn thống kê sách"
        '
        'BTtks
        '
        Me.BTtks.ForeColor = System.Drawing.Color.Blue
        Me.BTtks.Location = New System.Drawing.Point(860, 54)
        Me.BTtks.Name = "BTtks"
        Me.BTtks.Size = New System.Drawing.Size(104, 30)
        Me.BTtks.TabIndex = 1
        Me.BTtks.Text = "Thống kê"
        Me.BTtks.UseVisualStyleBackColor = True
        '
        'CBtctk
        '
        Me.CBtctk.FormattingEnabled = True
        Me.CBtctk.Location = New System.Drawing.Point(497, 60)
        Me.CBtctk.Name = "CBtctk"
        Me.CBtctk.Size = New System.Drawing.Size(291, 24)
        Me.CBtctk.TabIndex = 0
        '
        'DataGridViewtks
        '
        Me.DataGridViewtks.AutoGenerateColumns = False
        Me.DataGridViewtks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewtks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoaiDataGridViewTextBoxColumn, Me.MaSachDataGridViewTextBoxColumn, Me.TenSachDataGridViewTextBoxColumn, Me.NamXuatBanDataGridViewTextBoxColumn, Me.TacGiaDataGridViewTextBoxColumn, Me.NhaXuatBanDataGridViewTextBoxColumn, Me.TheLoaiDataGridViewTextBoxColumn, Me.NgayMuonDataGridViewTextBoxColumn, Me.NgayTraDataGridViewTextBoxColumn, Me.SoNgayTreHanDataGridViewTextBoxColumn})
        Me.DataGridViewtks.DataSource = Me.ThongKeSachBindingSource
        Me.DataGridViewtks.Location = New System.Drawing.Point(1, 174)
        Me.DataGridViewtks.Name = "DataGridViewtks"
        Me.DataGridViewtks.RowHeadersWidth = 51
        Me.DataGridViewtks.RowTemplate.Height = 24
        Me.DataGridViewtks.Size = New System.Drawing.Size(1554, 453)
        Me.DataGridViewtks.TabIndex = 2
        '
        'ThongKeSachBindingSource
        '
        Me.ThongKeSachBindingSource.DataMember = "ThongKeSach"
        Me.ThongKeSachBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ThongKeSachTableAdapter
        '
        Me.ThongKeSachTableAdapter.ClearBeforeFill = True
        '
        'OleDbSelectCommandtks
        '
        Me.OleDbSelectCommandtks.CommandText = "SELECT ThongKeSach.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     ThongKeSach"
        Me.OleDbSelectCommandtks.Connection = Me.OleDbConnection
        '
        'OleDbConnection
        '
        Me.OleDbConnection.ConnectionString = "Provider=SQLOLEDB.1;Data Source=ADMIN;Password=123;User ID=sa;Initial Catalog=QLT" &
    "V"
        '
        'OleDbDataAdaptertks
        '
        Me.OleDbDataAdaptertks.SelectCommand = Me.OleDbSelectCommandtks
        Me.OleDbDataAdaptertks.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ThongKeSach", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Loai", "Loai"), New System.Data.Common.DataColumnMapping("MaSach", "MaSach"), New System.Data.Common.DataColumnMapping("TenSach", "TenSach"), New System.Data.Common.DataColumnMapping("NamXuatBan", "NamXuatBan"), New System.Data.Common.DataColumnMapping("TacGia", "TacGia"), New System.Data.Common.DataColumnMapping("NhaXuatBan", "NhaXuatBan"), New System.Data.Common.DataColumnMapping("TheLoai", "TheLoai"), New System.Data.Common.DataColumnMapping("NgayMuon", "NgayMuon"), New System.Data.Common.DataColumnMapping("NgayTra", "NgayTra"), New System.Data.Common.DataColumnMapping("SoNgayTreHan", "SoNgayTreHan")})})
        '
        'LoaiDataGridViewTextBoxColumn
        '
        Me.LoaiDataGridViewTextBoxColumn.DataPropertyName = "Loai"
        Me.LoaiDataGridViewTextBoxColumn.HeaderText = "Loại"
        Me.LoaiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LoaiDataGridViewTextBoxColumn.Name = "LoaiDataGridViewTextBoxColumn"
        Me.LoaiDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoaiDataGridViewTextBoxColumn.Width = 130
        '
        'MaSachDataGridViewTextBoxColumn
        '
        Me.MaSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach"
        Me.MaSachDataGridViewTextBoxColumn.HeaderText = "Mã sách"
        Me.MaSachDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaSachDataGridViewTextBoxColumn.Name = "MaSachDataGridViewTextBoxColumn"
        Me.MaSachDataGridViewTextBoxColumn.Width = 125
        '
        'TenSachDataGridViewTextBoxColumn
        '
        Me.TenSachDataGridViewTextBoxColumn.DataPropertyName = "TenSach"
        Me.TenSachDataGridViewTextBoxColumn.HeaderText = "Tên sách"
        Me.TenSachDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenSachDataGridViewTextBoxColumn.Name = "TenSachDataGridViewTextBoxColumn"
        Me.TenSachDataGridViewTextBoxColumn.Width = 150
        '
        'NamXuatBanDataGridViewTextBoxColumn
        '
        Me.NamXuatBanDataGridViewTextBoxColumn.DataPropertyName = "NamXuatBan"
        Me.NamXuatBanDataGridViewTextBoxColumn.HeaderText = "Năm xuất bản"
        Me.NamXuatBanDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NamXuatBanDataGridViewTextBoxColumn.Name = "NamXuatBanDataGridViewTextBoxColumn"
        Me.NamXuatBanDataGridViewTextBoxColumn.Width = 130
        '
        'TacGiaDataGridViewTextBoxColumn
        '
        Me.TacGiaDataGridViewTextBoxColumn.DataPropertyName = "TacGia"
        Me.TacGiaDataGridViewTextBoxColumn.HeaderText = "Tác giả"
        Me.TacGiaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TacGiaDataGridViewTextBoxColumn.Name = "TacGiaDataGridViewTextBoxColumn"
        Me.TacGiaDataGridViewTextBoxColumn.Width = 125
        '
        'NhaXuatBanDataGridViewTextBoxColumn
        '
        Me.NhaXuatBanDataGridViewTextBoxColumn.DataPropertyName = "NhaXuatBan"
        Me.NhaXuatBanDataGridViewTextBoxColumn.HeaderText = "Nhà xuất bản"
        Me.NhaXuatBanDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NhaXuatBanDataGridViewTextBoxColumn.Name = "NhaXuatBanDataGridViewTextBoxColumn"
        Me.NhaXuatBanDataGridViewTextBoxColumn.Width = 125
        '
        'TheLoaiDataGridViewTextBoxColumn
        '
        Me.TheLoaiDataGridViewTextBoxColumn.DataPropertyName = "TheLoai"
        Me.TheLoaiDataGridViewTextBoxColumn.HeaderText = "Thể loại"
        Me.TheLoaiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TheLoaiDataGridViewTextBoxColumn.Name = "TheLoaiDataGridViewTextBoxColumn"
        Me.TheLoaiDataGridViewTextBoxColumn.Width = 125
        '
        'NgayMuonDataGridViewTextBoxColumn
        '
        Me.NgayMuonDataGridViewTextBoxColumn.DataPropertyName = "NgayMuon"
        Me.NgayMuonDataGridViewTextBoxColumn.HeaderText = "Ngày mượn"
        Me.NgayMuonDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NgayMuonDataGridViewTextBoxColumn.Name = "NgayMuonDataGridViewTextBoxColumn"
        Me.NgayMuonDataGridViewTextBoxColumn.ReadOnly = True
        Me.NgayMuonDataGridViewTextBoxColumn.Width = 125
        '
        'NgayTraDataGridViewTextBoxColumn
        '
        Me.NgayTraDataGridViewTextBoxColumn.DataPropertyName = "NgayTra"
        Me.NgayTraDataGridViewTextBoxColumn.HeaderText = "Ngày trả"
        Me.NgayTraDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NgayTraDataGridViewTextBoxColumn.Name = "NgayTraDataGridViewTextBoxColumn"
        Me.NgayTraDataGridViewTextBoxColumn.ReadOnly = True
        Me.NgayTraDataGridViewTextBoxColumn.Width = 125
        '
        'SoNgayTreHanDataGridViewTextBoxColumn
        '
        Me.SoNgayTreHanDataGridViewTextBoxColumn.DataPropertyName = "SoNgayTreHan"
        Me.SoNgayTreHanDataGridViewTextBoxColumn.HeaderText = "Số ngày trễ hạn"
        Me.SoNgayTreHanDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SoNgayTreHanDataGridViewTextBoxColumn.Name = "SoNgayTreHanDataGridViewTextBoxColumn"
        Me.SoNgayTreHanDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoNgayTreHanDataGridViewTextBoxColumn.Width = 145
        '
        'Formthongkesach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1557, 629)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewtks)
        Me.Name = "Formthongkesach"
        Me.Text = "Quản lý thống kê sách"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewtks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThongKeSachBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTtks As Button
    Friend WithEvents CBtctk As ComboBox
    Friend WithEvents DataGridViewtks As DataGridView
    Friend WithEvents DataSet As DataSet
    Friend WithEvents ThongKeSachBindingSource As BindingSource
    Friend WithEvents ThongKeSachTableAdapter As DataSetTableAdapters.ThongKeSachTableAdapter
    Friend WithEvents OleDbSelectCommandtks As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection As OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdaptertks As OleDb.OleDbDataAdapter
    Friend WithEvents LoaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaSachDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenSachDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamXuatBanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TacGiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NhaXuatBanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TheLoaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayMuonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayTraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoNgayTreHanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
