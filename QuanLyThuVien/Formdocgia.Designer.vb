<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formdocgia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formdocgia))
        Me.GBdg = New System.Windows.Forms.GroupBox()
        Me.BTloaddg = New System.Windows.Forms.Button()
        Me.BTtdg = New System.Windows.Forms.Button()
        Me.BTtkdg = New System.Windows.Forms.Button()
        Me.LBdemdg = New System.Windows.Forms.Label()
        Me.BThuydg = New System.Windows.Forms.Button()
        Me.BTluudg = New System.Windows.Forms.Button()
        Me.TBsdtdg = New System.Windows.Forms.TextBox()
        Me.DocgiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New QuanLyThuVien.DataSet()
        Me.LBsdtdg = New System.Windows.Forms.Label()
        Me.BTxoadg = New System.Windows.Forms.Button()
        Me.BTsuadg = New System.Windows.Forms.Button()
        Me.BTthemdg = New System.Windows.Forms.Button()
        Me.TBgcdg = New System.Windows.Forms.TextBox()
        Me.TBdcdg = New System.Windows.Forms.TextBox()
        Me.DTPnsdg = New System.Windows.Forms.DateTimePicker()
        Me.CBgtdg = New System.Windows.Forms.ComboBox()
        Me.TBhtdg = New System.Windows.Forms.TextBox()
        Me.TBmdg = New System.Windows.Forms.TextBox()
        Me.LBgcdg = New System.Windows.Forms.Label()
        Me.LBdcdg = New System.Windows.Forms.Label()
        Me.LBnsdg = New System.Windows.Forms.Label()
        Me.LBgtdg = New System.Windows.Forms.Label()
        Me.LBhtdg = New System.Windows.Forms.Label()
        Me.LBmdg = New System.Windows.Forms.Label()
        Me.DataGridViewdg = New System.Windows.Forms.DataGridView()
        Me.MadgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HotendgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioitinhdgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaysinhdgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SdtdgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiachidgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhichudgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocgiaTableAdapter = New QuanLyThuVien.DataSetTableAdapters.docgiaTableAdapter()
        Me.OleDbSelectCommanddg = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommanddg = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommanddg = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommanddg = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapterdg = New System.Data.OleDb.OleDbDataAdapter()
        Me.GBdg.SuspendLayout()
        CType(Me.DocgiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewdg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBdg
        '
        Me.GBdg.Controls.Add(Me.BTloaddg)
        Me.GBdg.Controls.Add(Me.BTtdg)
        Me.GBdg.Controls.Add(Me.BTtkdg)
        Me.GBdg.Controls.Add(Me.LBdemdg)
        Me.GBdg.Controls.Add(Me.BThuydg)
        Me.GBdg.Controls.Add(Me.BTluudg)
        Me.GBdg.Controls.Add(Me.TBsdtdg)
        Me.GBdg.Controls.Add(Me.LBsdtdg)
        Me.GBdg.Controls.Add(Me.BTxoadg)
        Me.GBdg.Controls.Add(Me.BTsuadg)
        Me.GBdg.Controls.Add(Me.BTthemdg)
        Me.GBdg.Controls.Add(Me.TBgcdg)
        Me.GBdg.Controls.Add(Me.TBdcdg)
        Me.GBdg.Controls.Add(Me.DTPnsdg)
        Me.GBdg.Controls.Add(Me.CBgtdg)
        Me.GBdg.Controls.Add(Me.TBhtdg)
        Me.GBdg.Controls.Add(Me.TBmdg)
        Me.GBdg.Controls.Add(Me.LBgcdg)
        Me.GBdg.Controls.Add(Me.LBdcdg)
        Me.GBdg.Controls.Add(Me.LBnsdg)
        Me.GBdg.Controls.Add(Me.LBgtdg)
        Me.GBdg.Controls.Add(Me.LBhtdg)
        Me.GBdg.Controls.Add(Me.LBmdg)
        Me.GBdg.ForeColor = System.Drawing.Color.Red
        Me.GBdg.Location = New System.Drawing.Point(0, 329)
        Me.GBdg.Name = "GBdg"
        Me.GBdg.Size = New System.Drawing.Size(1102, 283)
        Me.GBdg.TabIndex = 6
        Me.GBdg.TabStop = False
        Me.GBdg.Text = "Cập nhập thông tin độc giả"
        '
        'BTloaddg
        '
        Me.BTloaddg.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTloaddg.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTloaddg.ForeColor = System.Drawing.Color.Red
        Me.BTloaddg.Location = New System.Drawing.Point(1066, 9)
        Me.BTloaddg.Name = "BTloaddg"
        Me.BTloaddg.Size = New System.Drawing.Size(36, 36)
        Me.BTloaddg.TabIndex = 24
        Me.BTloaddg.Text = "O"
        Me.BTloaddg.UseVisualStyleBackColor = False
        '
        'BTtdg
        '
        Me.BTtdg.ForeColor = System.Drawing.Color.Blue
        Me.BTtdg.Location = New System.Drawing.Point(731, 235)
        Me.BTtdg.Name = "BTtdg"
        Me.BTtdg.Size = New System.Drawing.Size(97, 36)
        Me.BTtdg.TabIndex = 23
        Me.BTtdg.Text = "Tìm"
        Me.BTtdg.UseVisualStyleBackColor = True
        '
        'BTtkdg
        '
        Me.BTtkdg.ForeColor = System.Drawing.Color.Blue
        Me.BTtkdg.Location = New System.Drawing.Point(731, 235)
        Me.BTtkdg.Name = "BTtkdg"
        Me.BTtkdg.Size = New System.Drawing.Size(97, 36)
        Me.BTtkdg.TabIndex = 22
        Me.BTtkdg.Text = "Tìm kiếm"
        Me.BTtkdg.UseVisualStyleBackColor = True
        '
        'LBdemdg
        '
        Me.LBdemdg.AutoSize = True
        Me.LBdemdg.ForeColor = System.Drawing.Color.Red
        Me.LBdemdg.Location = New System.Drawing.Point(6, 28)
        Me.LBdemdg.Name = "LBdemdg"
        Me.LBdemdg.Size = New System.Drawing.Size(118, 17)
        Me.LBdemdg.TabIndex = 21
        Me.LBdemdg.Text = "Tổng số độc giả :"
        '
        'BThuydg
        '
        Me.BThuydg.ForeColor = System.Drawing.Color.Blue
        Me.BThuydg.Location = New System.Drawing.Point(460, 235)
        Me.BThuydg.Name = "BThuydg"
        Me.BThuydg.Size = New System.Drawing.Size(97, 36)
        Me.BThuydg.TabIndex = 20
        Me.BThuydg.Text = "Hủy"
        Me.BThuydg.UseVisualStyleBackColor = True
        '
        'BTluudg
        '
        Me.BTluudg.ForeColor = System.Drawing.Color.Blue
        Me.BTluudg.Location = New System.Drawing.Point(325, 235)
        Me.BTluudg.Name = "BTluudg"
        Me.BTluudg.Size = New System.Drawing.Size(97, 36)
        Me.BTluudg.TabIndex = 19
        Me.BTluudg.Text = "Lưu"
        Me.BTluudg.UseVisualStyleBackColor = True
        '
        'TBsdtdg
        '
        Me.TBsdtdg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocgiaBindingSource, "sdtdg", True))
        Me.TBsdtdg.Location = New System.Drawing.Point(150, 170)
        Me.TBsdtdg.Name = "TBsdtdg"
        Me.TBsdtdg.Size = New System.Drawing.Size(200, 22)
        Me.TBsdtdg.TabIndex = 18
        '
        'DocgiaBindingSource
        '
        Me.DocgiaBindingSource.DataMember = "docgia"
        Me.DocgiaBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LBsdtdg
        '
        Me.LBsdtdg.AutoSize = True
        Me.LBsdtdg.ForeColor = System.Drawing.Color.Black
        Me.LBsdtdg.Location = New System.Drawing.Point(53, 173)
        Me.LBsdtdg.Name = "LBsdtdg"
        Me.LBsdtdg.Size = New System.Drawing.Size(91, 17)
        Me.LBsdtdg.TabIndex = 17
        Me.LBsdtdg.Text = "Số điện thoại"
        '
        'BTxoadg
        '
        Me.BTxoadg.ForeColor = System.Drawing.Color.Blue
        Me.BTxoadg.Location = New System.Drawing.Point(600, 236)
        Me.BTxoadg.Name = "BTxoadg"
        Me.BTxoadg.Size = New System.Drawing.Size(97, 36)
        Me.BTxoadg.TabIndex = 15
        Me.BTxoadg.Text = "Xóa"
        Me.BTxoadg.UseVisualStyleBackColor = True
        '
        'BTsuadg
        '
        Me.BTsuadg.ForeColor = System.Drawing.Color.Blue
        Me.BTsuadg.Location = New System.Drawing.Point(460, 236)
        Me.BTsuadg.Name = "BTsuadg"
        Me.BTsuadg.Size = New System.Drawing.Size(97, 36)
        Me.BTsuadg.TabIndex = 14
        Me.BTsuadg.Text = "Sửa"
        Me.BTsuadg.UseVisualStyleBackColor = True
        '
        'BTthemdg
        '
        Me.BTthemdg.ForeColor = System.Drawing.Color.Blue
        Me.BTthemdg.Location = New System.Drawing.Point(325, 236)
        Me.BTthemdg.Name = "BTthemdg"
        Me.BTthemdg.Size = New System.Drawing.Size(97, 36)
        Me.BTthemdg.TabIndex = 13
        Me.BTthemdg.Text = "Thêm"
        Me.BTthemdg.UseVisualStyleBackColor = True
        '
        'TBgcdg
        '
        Me.TBgcdg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocgiaBindingSource, "ghichudg", True))
        Me.TBgcdg.Location = New System.Drawing.Point(785, 53)
        Me.TBgcdg.Multiline = True
        Me.TBgcdg.Name = "TBgcdg"
        Me.TBgcdg.Size = New System.Drawing.Size(238, 139)
        Me.TBgcdg.TabIndex = 12
        '
        'TBdcdg
        '
        Me.TBdcdg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocgiaBindingSource, "diachidg", True))
        Me.TBdcdg.Location = New System.Drawing.Point(440, 52)
        Me.TBdcdg.Multiline = True
        Me.TBdcdg.Name = "TBdcdg"
        Me.TBdcdg.Size = New System.Drawing.Size(238, 140)
        Me.TBdcdg.TabIndex = 11
        '
        'DTPnsdg
        '
        Me.DTPnsdg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocgiaBindingSource, "ngaysinhdg", True))
        Me.DTPnsdg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPnsdg.Location = New System.Drawing.Point(150, 142)
        Me.DTPnsdg.Name = "DTPnsdg"
        Me.DTPnsdg.Size = New System.Drawing.Size(200, 22)
        Me.DTPnsdg.TabIndex = 10
        '
        'CBgtdg
        '
        Me.CBgtdg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocgiaBindingSource, "gioitinhdg", True))
        Me.CBgtdg.FormattingEnabled = True
        Me.CBgtdg.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.CBgtdg.Location = New System.Drawing.Point(150, 112)
        Me.CBgtdg.Name = "CBgtdg"
        Me.CBgtdg.Size = New System.Drawing.Size(200, 24)
        Me.CBgtdg.TabIndex = 9
        '
        'TBhtdg
        '
        Me.TBhtdg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocgiaBindingSource, "hotendg", True))
        Me.TBhtdg.Location = New System.Drawing.Point(150, 84)
        Me.TBhtdg.Name = "TBhtdg"
        Me.TBhtdg.Size = New System.Drawing.Size(200, 22)
        Me.TBhtdg.TabIndex = 8
        '
        'TBmdg
        '
        Me.TBmdg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocgiaBindingSource, "madg", True))
        Me.TBmdg.Location = New System.Drawing.Point(150, 56)
        Me.TBmdg.Name = "TBmdg"
        Me.TBmdg.Size = New System.Drawing.Size(200, 22)
        Me.TBmdg.TabIndex = 7
        '
        'LBgcdg
        '
        Me.LBgcdg.AutoSize = True
        Me.LBgcdg.ForeColor = System.Drawing.Color.Black
        Me.LBgcdg.Location = New System.Drawing.Point(722, 56)
        Me.LBgcdg.Name = "LBgcdg"
        Me.LBgcdg.Size = New System.Drawing.Size(57, 17)
        Me.LBgcdg.TabIndex = 6
        Me.LBgcdg.Text = "Ghi chú"
        '
        'LBdcdg
        '
        Me.LBdcdg.AutoSize = True
        Me.LBdcdg.ForeColor = System.Drawing.Color.Black
        Me.LBdcdg.Location = New System.Drawing.Point(383, 54)
        Me.LBdcdg.Name = "LBdcdg"
        Me.LBdcdg.Size = New System.Drawing.Size(51, 17)
        Me.LBdcdg.TabIndex = 5
        Me.LBdcdg.Text = "Địa chỉ"
        '
        'LBnsdg
        '
        Me.LBnsdg.AutoSize = True
        Me.LBnsdg.ForeColor = System.Drawing.Color.Black
        Me.LBnsdg.Location = New System.Drawing.Point(53, 145)
        Me.LBnsdg.Name = "LBnsdg"
        Me.LBnsdg.Size = New System.Drawing.Size(71, 17)
        Me.LBnsdg.TabIndex = 4
        Me.LBnsdg.Text = "Ngày sinh"
        '
        'LBgtdg
        '
        Me.LBgtdg.AutoSize = True
        Me.LBgtdg.ForeColor = System.Drawing.Color.Black
        Me.LBgtdg.Location = New System.Drawing.Point(53, 117)
        Me.LBgtdg.Name = "LBgtdg"
        Me.LBgtdg.Size = New System.Drawing.Size(60, 17)
        Me.LBgtdg.TabIndex = 3
        Me.LBgtdg.Text = "Giới tinh"
        '
        'LBhtdg
        '
        Me.LBhtdg.AutoSize = True
        Me.LBhtdg.ForeColor = System.Drawing.Color.Black
        Me.LBhtdg.Location = New System.Drawing.Point(53, 87)
        Me.LBhtdg.Name = "LBhtdg"
        Me.LBhtdg.Size = New System.Drawing.Size(50, 17)
        Me.LBhtdg.TabIndex = 2
        Me.LBhtdg.Text = "Họ tên"
        '
        'LBmdg
        '
        Me.LBmdg.AutoSize = True
        Me.LBmdg.ForeColor = System.Drawing.Color.Black
        Me.LBmdg.Location = New System.Drawing.Point(53, 60)
        Me.LBmdg.Name = "LBmdg"
        Me.LBmdg.Size = New System.Drawing.Size(77, 17)
        Me.LBmdg.TabIndex = 1
        Me.LBmdg.Text = "Mã độc giả"
        '
        'DataGridViewdg
        '
        Me.DataGridViewdg.AutoGenerateColumns = False
        Me.DataGridViewdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewdg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MadgDataGridViewTextBoxColumn, Me.HotendgDataGridViewTextBoxColumn, Me.GioitinhdgDataGridViewTextBoxColumn, Me.NgaysinhdgDataGridViewTextBoxColumn, Me.SdtdgDataGridViewTextBoxColumn, Me.DiachidgDataGridViewTextBoxColumn, Me.GhichudgDataGridViewTextBoxColumn})
        Me.DataGridViewdg.DataSource = Me.DocgiaBindingSource
        Me.DataGridViewdg.Location = New System.Drawing.Point(0, 1)
        Me.DataGridViewdg.Name = "DataGridViewdg"
        Me.DataGridViewdg.RowHeadersWidth = 51
        Me.DataGridViewdg.RowTemplate.Height = 24
        Me.DataGridViewdg.Size = New System.Drawing.Size(1102, 322)
        Me.DataGridViewdg.TabIndex = 5
        '
        'MadgDataGridViewTextBoxColumn
        '
        Me.MadgDataGridViewTextBoxColumn.DataPropertyName = "madg"
        Me.MadgDataGridViewTextBoxColumn.HeaderText = "Mã độc giả"
        Me.MadgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MadgDataGridViewTextBoxColumn.Name = "MadgDataGridViewTextBoxColumn"
        Me.MadgDataGridViewTextBoxColumn.Width = 125
        '
        'HotendgDataGridViewTextBoxColumn
        '
        Me.HotendgDataGridViewTextBoxColumn.DataPropertyName = "hotendg"
        Me.HotendgDataGridViewTextBoxColumn.HeaderText = "Họ tên"
        Me.HotendgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HotendgDataGridViewTextBoxColumn.Name = "HotendgDataGridViewTextBoxColumn"
        Me.HotendgDataGridViewTextBoxColumn.Width = 140
        '
        'GioitinhdgDataGridViewTextBoxColumn
        '
        Me.GioitinhdgDataGridViewTextBoxColumn.DataPropertyName = "gioitinhdg"
        Me.GioitinhdgDataGridViewTextBoxColumn.HeaderText = "Giới tính"
        Me.GioitinhdgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GioitinhdgDataGridViewTextBoxColumn.Name = "GioitinhdgDataGridViewTextBoxColumn"
        Me.GioitinhdgDataGridViewTextBoxColumn.Width = 125
        '
        'NgaysinhdgDataGridViewTextBoxColumn
        '
        Me.NgaysinhdgDataGridViewTextBoxColumn.DataPropertyName = "ngaysinhdg"
        Me.NgaysinhdgDataGridViewTextBoxColumn.HeaderText = "Ngày sinh"
        Me.NgaysinhdgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NgaysinhdgDataGridViewTextBoxColumn.Name = "NgaysinhdgDataGridViewTextBoxColumn"
        Me.NgaysinhdgDataGridViewTextBoxColumn.Width = 125
        '
        'SdtdgDataGridViewTextBoxColumn
        '
        Me.SdtdgDataGridViewTextBoxColumn.DataPropertyName = "sdtdg"
        Me.SdtdgDataGridViewTextBoxColumn.HeaderText = "Số điện thoại"
        Me.SdtdgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SdtdgDataGridViewTextBoxColumn.Name = "SdtdgDataGridViewTextBoxColumn"
        Me.SdtdgDataGridViewTextBoxColumn.Width = 125
        '
        'DiachidgDataGridViewTextBoxColumn
        '
        Me.DiachidgDataGridViewTextBoxColumn.DataPropertyName = "diachidg"
        Me.DiachidgDataGridViewTextBoxColumn.HeaderText = "Địa chỉ"
        Me.DiachidgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiachidgDataGridViewTextBoxColumn.Name = "DiachidgDataGridViewTextBoxColumn"
        Me.DiachidgDataGridViewTextBoxColumn.Width = 300
        '
        'GhichudgDataGridViewTextBoxColumn
        '
        Me.GhichudgDataGridViewTextBoxColumn.DataPropertyName = "ghichudg"
        Me.GhichudgDataGridViewTextBoxColumn.HeaderText = "Ghi chú"
        Me.GhichudgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GhichudgDataGridViewTextBoxColumn.Name = "GhichudgDataGridViewTextBoxColumn"
        Me.GhichudgDataGridViewTextBoxColumn.Width = 500
        '
        'DocgiaTableAdapter
        '
        Me.DocgiaTableAdapter.ClearBeforeFill = True
        '
        'OleDbSelectCommanddg
        '
        Me.OleDbSelectCommanddg.CommandText = "SELECT docgia.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     docgia"
        Me.OleDbSelectCommanddg.Connection = Me.OleDbConnection
        '
        'OleDbConnection
        '
        Me.OleDbConnection.ConnectionString = "Provider=SQLOLEDB.1;Data Source=ADMIN;Password=123;User ID=sa;Initial Catalog=QLT" &
    "V"
        '
        'OleDbInsertCommanddg
        '
        Me.OleDbInsertCommanddg.CommandText = "INSERT INTO [docgia] ([madg], [hotendg], [gioitinhdg], [ngaysinhdg], [diachidg], " &
    "[sdtdg], [ghichudg]) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommanddg.Connection = Me.OleDbConnection
        Me.OleDbInsertCommanddg.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("madg", System.Data.OleDb.OleDbType.VarWChar, 0, "madg"), New System.Data.OleDb.OleDbParameter("hotendg", System.Data.OleDb.OleDbType.VarWChar, 0, "hotendg"), New System.Data.OleDb.OleDbParameter("gioitinhdg", System.Data.OleDb.OleDbType.VarWChar, 0, "gioitinhdg"), New System.Data.OleDb.OleDbParameter("ngaysinhdg", System.Data.OleDb.OleDbType.VarWChar, 0, "ngaysinhdg"), New System.Data.OleDb.OleDbParameter("diachidg", System.Data.OleDb.OleDbType.VarWChar, 0, "diachidg"), New System.Data.OleDb.OleDbParameter("sdtdg", System.Data.OleDb.OleDbType.VarWChar, 0, "sdtdg"), New System.Data.OleDb.OleDbParameter("ghichudg", System.Data.OleDb.OleDbType.VarWChar, 0, "ghichudg")})
        '
        'OleDbUpdateCommanddg
        '
        Me.OleDbUpdateCommanddg.CommandText = resources.GetString("OleDbUpdateCommanddg.CommandText")
        Me.OleDbUpdateCommanddg.Connection = Me.OleDbConnection
        Me.OleDbUpdateCommanddg.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("madg", System.Data.OleDb.OleDbType.VarWChar, 0, "madg"), New System.Data.OleDb.OleDbParameter("hotendg", System.Data.OleDb.OleDbType.VarWChar, 0, "hotendg"), New System.Data.OleDb.OleDbParameter("gioitinhdg", System.Data.OleDb.OleDbType.VarWChar, 0, "gioitinhdg"), New System.Data.OleDb.OleDbParameter("ngaysinhdg", System.Data.OleDb.OleDbType.VarWChar, 0, "ngaysinhdg"), New System.Data.OleDb.OleDbParameter("diachidg", System.Data.OleDb.OleDbType.VarWChar, 0, "diachidg"), New System.Data.OleDb.OleDbParameter("sdtdg", System.Data.OleDb.OleDbType.VarWChar, 0, "sdtdg"), New System.Data.OleDb.OleDbParameter("ghichudg", System.Data.OleDb.OleDbType.VarWChar, 0, "ghichudg"), New System.Data.OleDb.OleDbParameter("Original_madg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "madg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_hotendg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hotendg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_gioitinhdg", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "gioitinhdg", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_gioitinhdg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "gioitinhdg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ngaysinhdg", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ngaysinhdg", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ngaysinhdg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ngaysinhdg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_diachidg", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "diachidg", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_diachidg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "diachidg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sdtdg", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sdtdg", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sdtdg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sdtdg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ghichudg", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ghichudg", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ghichudg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ghichudg", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommanddg
        '
        Me.OleDbDeleteCommanddg.CommandText = resources.GetString("OleDbDeleteCommanddg.CommandText")
        Me.OleDbDeleteCommanddg.Connection = Me.OleDbConnection
        Me.OleDbDeleteCommanddg.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_madg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "madg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_hotendg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hotendg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_gioitinhdg", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "gioitinhdg", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_gioitinhdg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "gioitinhdg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ngaysinhdg", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ngaysinhdg", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ngaysinhdg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ngaysinhdg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_diachidg", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "diachidg", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_diachidg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "diachidg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sdtdg", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sdtdg", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sdtdg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sdtdg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ghichudg", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ghichudg", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ghichudg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ghichudg", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapterdg
        '
        Me.OleDbDataAdapterdg.DeleteCommand = Me.OleDbDeleteCommanddg
        Me.OleDbDataAdapterdg.InsertCommand = Me.OleDbInsertCommanddg
        Me.OleDbDataAdapterdg.SelectCommand = Me.OleDbSelectCommanddg
        Me.OleDbDataAdapterdg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "docgia", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("madg", "madg"), New System.Data.Common.DataColumnMapping("hotendg", "hotendg"), New System.Data.Common.DataColumnMapping("gioitinhdg", "gioitinhdg"), New System.Data.Common.DataColumnMapping("ngaysinhdg", "ngaysinhdg"), New System.Data.Common.DataColumnMapping("diachidg", "diachidg"), New System.Data.Common.DataColumnMapping("sdtdg", "sdtdg"), New System.Data.Common.DataColumnMapping("ghichudg", "ghichudg")})})
        Me.OleDbDataAdapterdg.UpdateCommand = Me.OleDbUpdateCommanddg
        '
        'Formdocgia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 612)
        Me.Controls.Add(Me.GBdg)
        Me.Controls.Add(Me.DataGridViewdg)
        Me.Name = "Formdocgia"
        Me.Text = "Quản lý thông tin độc giả"
        Me.GBdg.ResumeLayout(False)
        Me.GBdg.PerformLayout()
        CType(Me.DocgiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewdg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBdg As GroupBox
    Friend WithEvents BTloaddg As Button
    Friend WithEvents BTtdg As Button
    Friend WithEvents BTtkdg As Button
    Friend WithEvents LBdemdg As Label
    Friend WithEvents BThuydg As Button
    Friend WithEvents BTluudg As Button
    Friend WithEvents TBsdtdg As TextBox
    Friend WithEvents LBsdtdg As Label
    Friend WithEvents BTxoadg As Button
    Friend WithEvents BTsuadg As Button
    Friend WithEvents BTthemdg As Button
    Friend WithEvents TBgcdg As TextBox
    Friend WithEvents TBdcdg As TextBox
    Friend WithEvents DTPnsdg As DateTimePicker
    Friend WithEvents CBgtdg As ComboBox
    Friend WithEvents TBhtdg As TextBox
    Friend WithEvents TBmdg As TextBox
    Friend WithEvents LBgcdg As Label
    Friend WithEvents LBdcdg As Label
    Friend WithEvents LBnsdg As Label
    Friend WithEvents LBgtdg As Label
    Friend WithEvents LBhtdg As Label
    Friend WithEvents LBmdg As Label
    Friend WithEvents DataGridViewdg As DataGridView
    Friend WithEvents DataSet As DataSet
    Friend WithEvents DocgiaBindingSource As BindingSource
    Friend WithEvents DocgiaTableAdapter As DataSetTableAdapters.docgiaTableAdapter
    Friend WithEvents OleDbSelectCommanddg As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommanddg As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommanddg As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommanddg As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapterdg As OleDb.OleDbDataAdapter
    Friend WithEvents MadgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HotendgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GioitinhdgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaysinhdgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SdtdgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiachidgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GhichudgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
