<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formthongkedocgia
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
        Me.BTtkdg = New System.Windows.Forms.Button()
        Me.CBtctk = New System.Windows.Forms.ComboBox()
        Me.DataGridViewtkdg = New System.Windows.Forms.DataGridView()
        Me.ThongKeDocGiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New QuanLyThuVien.DataSet()
        Me.ThongKeDocGiaTableAdapter = New QuanLyThuVien.DataSetTableAdapters.ThongKeDocGiaTableAdapter()
        Me.OleDbSelectCommandtkdg = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection = New System.Data.OleDb.OleDbConnection()
        Me.OleDbDataAdaptertkdg = New System.Data.OleDb.OleDbDataAdapter()
        Me.LoaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaDocGiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTenDocGiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoDienThoaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewtkdg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThongKeDocGiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTtkdg)
        Me.GroupBox1.Controls.Add(Me.CBtctk)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(2, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1227, 138)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tùy chọn thống kê độc giả"
        '
        'BTtkdg
        '
        Me.BTtkdg.ForeColor = System.Drawing.Color.Blue
        Me.BTtkdg.Location = New System.Drawing.Point(678, 62)
        Me.BTtkdg.Name = "BTtkdg"
        Me.BTtkdg.Size = New System.Drawing.Size(104, 30)
        Me.BTtkdg.TabIndex = 1
        Me.BTtkdg.Text = "Thống kê"
        Me.BTtkdg.UseVisualStyleBackColor = True
        '
        'CBtctk
        '
        Me.CBtctk.FormattingEnabled = True
        Me.CBtctk.Location = New System.Drawing.Point(346, 68)
        Me.CBtctk.Name = "CBtctk"
        Me.CBtctk.Size = New System.Drawing.Size(291, 24)
        Me.CBtctk.TabIndex = 0
        '
        'DataGridViewtkdg
        '
        Me.DataGridViewtkdg.AutoGenerateColumns = False
        Me.DataGridViewtkdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewtkdg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoaiDataGridViewTextBoxColumn, Me.MaDocGiaDataGridViewTextBoxColumn, Me.HoTenDocGiaDataGridViewTextBoxColumn, Me.GioiTinhDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.SoDienThoaiDataGridViewTextBoxColumn, Me.DiaChiDataGridViewTextBoxColumn, Me.GhiChuDataGridViewTextBoxColumn})
        Me.DataGridViewtkdg.DataSource = Me.ThongKeDocGiaBindingSource
        Me.DataGridViewtkdg.Location = New System.Drawing.Point(2, 160)
        Me.DataGridViewtkdg.Name = "DataGridViewtkdg"
        Me.DataGridViewtkdg.RowHeadersWidth = 51
        Me.DataGridViewtkdg.RowTemplate.Height = 24
        Me.DataGridViewtkdg.Size = New System.Drawing.Size(1227, 468)
        Me.DataGridViewtkdg.TabIndex = 4
        '
        'ThongKeDocGiaBindingSource
        '
        Me.ThongKeDocGiaBindingSource.DataMember = "ThongKeDocGia"
        Me.ThongKeDocGiaBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ThongKeDocGiaTableAdapter
        '
        Me.ThongKeDocGiaTableAdapter.ClearBeforeFill = True
        '
        'OleDbSelectCommandtkdg
        '
        Me.OleDbSelectCommandtkdg.CommandText = "SELECT ThongKeDocGia.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     ThongKeDocGia"
        Me.OleDbSelectCommandtkdg.Connection = Me.OleDbConnection
        '
        'OleDbConnection
        '
        Me.OleDbConnection.ConnectionString = "Provider=SQLOLEDB.1;Data Source=ADMIN;Password=123;User ID=sa;Initial Catalog=QLT" &
    "V"
        '
        'OleDbDataAdaptertkdg
        '
        Me.OleDbDataAdaptertkdg.SelectCommand = Me.OleDbSelectCommandtkdg
        Me.OleDbDataAdaptertkdg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ThongKeDocGia", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Loai", "Loai"), New System.Data.Common.DataColumnMapping("MaDocGia", "MaDocGia"), New System.Data.Common.DataColumnMapping("HoTenDocGia", "HoTenDocGia"), New System.Data.Common.DataColumnMapping("GioiTinh", "GioiTinh"), New System.Data.Common.DataColumnMapping("NgaySinh", "NgaySinh"), New System.Data.Common.DataColumnMapping("DiaChi", "DiaChi"), New System.Data.Common.DataColumnMapping("SoDienThoai", "SoDienThoai"), New System.Data.Common.DataColumnMapping("GhiChu", "GhiChu")})})
        '
        'LoaiDataGridViewTextBoxColumn
        '
        Me.LoaiDataGridViewTextBoxColumn.DataPropertyName = "Loai"
        Me.LoaiDataGridViewTextBoxColumn.HeaderText = "Loại"
        Me.LoaiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LoaiDataGridViewTextBoxColumn.Name = "LoaiDataGridViewTextBoxColumn"
        Me.LoaiDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoaiDataGridViewTextBoxColumn.Width = 125
        '
        'MaDocGiaDataGridViewTextBoxColumn
        '
        Me.MaDocGiaDataGridViewTextBoxColumn.DataPropertyName = "MaDocGia"
        Me.MaDocGiaDataGridViewTextBoxColumn.HeaderText = "Mã độc giả"
        Me.MaDocGiaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaDocGiaDataGridViewTextBoxColumn.Name = "MaDocGiaDataGridViewTextBoxColumn"
        Me.MaDocGiaDataGridViewTextBoxColumn.Width = 125
        '
        'HoTenDocGiaDataGridViewTextBoxColumn
        '
        Me.HoTenDocGiaDataGridViewTextBoxColumn.DataPropertyName = "HoTenDocGia"
        Me.HoTenDocGiaDataGridViewTextBoxColumn.HeaderText = "Họ tên độc giả"
        Me.HoTenDocGiaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HoTenDocGiaDataGridViewTextBoxColumn.Name = "HoTenDocGiaDataGridViewTextBoxColumn"
        Me.HoTenDocGiaDataGridViewTextBoxColumn.Width = 135
        '
        'GioiTinhDataGridViewTextBoxColumn
        '
        Me.GioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính"
        Me.GioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GioiTinhDataGridViewTextBoxColumn.Name = "GioiTinhDataGridViewTextBoxColumn"
        Me.GioiTinhDataGridViewTextBoxColumn.Width = 125
        '
        'NgaySinhDataGridViewTextBoxColumn
        '
        Me.NgaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh"
        Me.NgaySinhDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NgaySinhDataGridViewTextBoxColumn.Name = "NgaySinhDataGridViewTextBoxColumn"
        Me.NgaySinhDataGridViewTextBoxColumn.Width = 125
        '
        'SoDienThoaiDataGridViewTextBoxColumn
        '
        Me.SoDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai"
        Me.SoDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại"
        Me.SoDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SoDienThoaiDataGridViewTextBoxColumn.Name = "SoDienThoaiDataGridViewTextBoxColumn"
        Me.SoDienThoaiDataGridViewTextBoxColumn.Width = 125
        '
        'DiaChiDataGridViewTextBoxColumn
        '
        Me.DiaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ"
        Me.DiaChiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiaChiDataGridViewTextBoxColumn.Name = "DiaChiDataGridViewTextBoxColumn"
        Me.DiaChiDataGridViewTextBoxColumn.Width = 300
        '
        'GhiChuDataGridViewTextBoxColumn
        '
        Me.GhiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu"
        Me.GhiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú"
        Me.GhiChuDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GhiChuDataGridViewTextBoxColumn.Name = "GhiChuDataGridViewTextBoxColumn"
        Me.GhiChuDataGridViewTextBoxColumn.Width = 500
        '
        'Formthongkedocgia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 629)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewtkdg)
        Me.Name = "Formthongkedocgia"
        Me.Text = "Quản lý thống kê độc giả"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewtkdg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThongKeDocGiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTtkdg As Button
    Friend WithEvents CBtctk As ComboBox
    Friend WithEvents DataGridViewtkdg As DataGridView
    Friend WithEvents DataSet As DataSet
    Friend WithEvents ThongKeDocGiaBindingSource As BindingSource
    Friend WithEvents ThongKeDocGiaTableAdapter As DataSetTableAdapters.ThongKeDocGiaTableAdapter
    Friend WithEvents OleDbSelectCommandtkdg As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection As OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdaptertkdg As OleDb.OleDbDataAdapter
    Friend WithEvents LoaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaDocGiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoTenDocGiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GioiTinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoDienThoaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiaChiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GhiChuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
