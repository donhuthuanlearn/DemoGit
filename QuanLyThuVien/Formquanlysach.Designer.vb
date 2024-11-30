<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formquanlysach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formquanlysach))
        Me.GBs = New System.Windows.Forms.GroupBox()
        Me.BTts = New System.Windows.Forms.Button()
        Me.BTtks = New System.Windows.Forms.Button()
        Me.BTloads = New System.Windows.Forms.Button()
        Me.CBmtls = New System.Windows.Forms.ComboBox()
        Me.SachBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New QuanLyThuVien.DataSet()
        Me.TheloaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBmnxbs = New System.Windows.Forms.ComboBox()
        Me.NhaxuatbanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBnxbs = New System.Windows.Forms.TextBox()
        Me.LBdems = New System.Windows.Forms.Label()
        Me.BThuys = New System.Windows.Forms.Button()
        Me.BTluus = New System.Windows.Forms.Button()
        Me.LBmnxbs = New System.Windows.Forms.Label()
        Me.BTxoas = New System.Windows.Forms.Button()
        Me.BTsuas = New System.Windows.Forms.Button()
        Me.BTthems = New System.Windows.Forms.Button()
        Me.TBgcs = New System.Windows.Forms.TextBox()
        Me.CBmtgs = New System.Windows.Forms.ComboBox()
        Me.TacgiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBts = New System.Windows.Forms.TextBox()
        Me.TBms = New System.Windows.Forms.TextBox()
        Me.LBgcs = New System.Windows.Forms.Label()
        Me.LBmtls = New System.Windows.Forms.Label()
        Me.LBnxbs = New System.Windows.Forms.Label()
        Me.LBmtgs = New System.Windows.Forms.Label()
        Me.LBts = New System.Windows.Forms.Label()
        Me.LBms = New System.Windows.Forms.Label()
        Me.DataGridViews = New System.Windows.Forms.DataGridView()
        Me.SachTableAdapter = New QuanLyThuVien.DataSetTableAdapters.sachTableAdapter()
        Me.OleDbSelectCommands = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommands = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommands = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommands = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapters = New System.Data.OleDb.OleDbDataAdapter()
        Me.TheloaiTableAdapter = New QuanLyThuVien.DataSetTableAdapters.theloaiTableAdapter()
        Me.TacgiaTableAdapter = New QuanLyThuVien.DataSetTableAdapters.tacgiaTableAdapter()
        Me.NhaxuatbanTableAdapter = New QuanLyThuVien.DataSetTableAdapters.nhaxuatbanTableAdapter()
        Me.MasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TensDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManxbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamxbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhichusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBs.SuspendLayout()
        CType(Me.SachBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TheloaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NhaxuatbanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TacgiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViews, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBs
        '
        Me.GBs.Controls.Add(Me.BTts)
        Me.GBs.Controls.Add(Me.BTtks)
        Me.GBs.Controls.Add(Me.BTloads)
        Me.GBs.Controls.Add(Me.CBmtls)
        Me.GBs.Controls.Add(Me.CBmnxbs)
        Me.GBs.Controls.Add(Me.TBnxbs)
        Me.GBs.Controls.Add(Me.LBdems)
        Me.GBs.Controls.Add(Me.BThuys)
        Me.GBs.Controls.Add(Me.BTluus)
        Me.GBs.Controls.Add(Me.LBmnxbs)
        Me.GBs.Controls.Add(Me.BTxoas)
        Me.GBs.Controls.Add(Me.BTsuas)
        Me.GBs.Controls.Add(Me.BTthems)
        Me.GBs.Controls.Add(Me.TBgcs)
        Me.GBs.Controls.Add(Me.CBmtgs)
        Me.GBs.Controls.Add(Me.TBts)
        Me.GBs.Controls.Add(Me.TBms)
        Me.GBs.Controls.Add(Me.LBgcs)
        Me.GBs.Controls.Add(Me.LBmtls)
        Me.GBs.Controls.Add(Me.LBnxbs)
        Me.GBs.Controls.Add(Me.LBmtgs)
        Me.GBs.Controls.Add(Me.LBts)
        Me.GBs.Controls.Add(Me.LBms)
        Me.GBs.ForeColor = System.Drawing.Color.Red
        Me.GBs.Location = New System.Drawing.Point(0, 328)
        Me.GBs.Name = "GBs"
        Me.GBs.Size = New System.Drawing.Size(1102, 268)
        Me.GBs.TabIndex = 6
        Me.GBs.TabStop = False
        Me.GBs.Text = "Cập nhập thông tin sách"
        '
        'BTts
        '
        Me.BTts.ForeColor = System.Drawing.Color.Blue
        Me.BTts.Location = New System.Drawing.Point(696, 222)
        Me.BTts.Name = "BTts"
        Me.BTts.Size = New System.Drawing.Size(97, 33)
        Me.BTts.TabIndex = 51
        Me.BTts.Text = "Tìm"
        Me.BTts.UseVisualStyleBackColor = True
        '
        'BTtks
        '
        Me.BTtks.ForeColor = System.Drawing.Color.Blue
        Me.BTtks.Location = New System.Drawing.Point(696, 225)
        Me.BTtks.Name = "BTtks"
        Me.BTtks.Size = New System.Drawing.Size(97, 33)
        Me.BTtks.TabIndex = 50
        Me.BTtks.Text = "Tìm kiếm"
        Me.BTtks.UseVisualStyleBackColor = True
        '
        'BTloads
        '
        Me.BTloads.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTloads.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTloads.ForeColor = System.Drawing.Color.Red
        Me.BTloads.Location = New System.Drawing.Point(1045, 9)
        Me.BTloads.Name = "BTloads"
        Me.BTloads.Size = New System.Drawing.Size(57, 36)
        Me.BTloads.TabIndex = 49
        Me.BTloads.Text = "O"
        Me.BTloads.UseVisualStyleBackColor = False
        '
        'CBmtls
        '
        Me.CBmtls.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachBindingSource, "matl", True))
        Me.CBmtls.DataSource = Me.TheloaiBindingSource
        Me.CBmtls.DisplayMember = "matl"
        Me.CBmtls.FormattingEnabled = True
        Me.CBmtls.Location = New System.Drawing.Point(509, 82)
        Me.CBmtls.Name = "CBmtls"
        Me.CBmtls.Size = New System.Drawing.Size(200, 24)
        Me.CBmtls.TabIndex = 24
        '
        'SachBindingSource
        '
        Me.SachBindingSource.DataMember = "sach"
        Me.SachBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TheloaiBindingSource
        '
        Me.TheloaiBindingSource.DataMember = "theloai"
        Me.TheloaiBindingSource.DataSource = Me.DataSet
        '
        'CBmnxbs
        '
        Me.CBmnxbs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachBindingSource, "manxb", True))
        Me.CBmnxbs.DataSource = Me.NhaxuatbanBindingSource
        Me.CBmnxbs.DisplayMember = "manxb"
        Me.CBmnxbs.FormattingEnabled = True
        Me.CBmnxbs.Location = New System.Drawing.Point(509, 144)
        Me.CBmnxbs.Name = "CBmnxbs"
        Me.CBmnxbs.Size = New System.Drawing.Size(200, 24)
        Me.CBmnxbs.TabIndex = 23
        '
        'NhaxuatbanBindingSource
        '
        Me.NhaxuatbanBindingSource.DataMember = "nhaxuatban"
        Me.NhaxuatbanBindingSource.DataSource = Me.DataSet
        '
        'TBnxbs
        '
        Me.TBnxbs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachBindingSource, "namxb", True))
        Me.TBnxbs.Location = New System.Drawing.Point(152, 144)
        Me.TBnxbs.Name = "TBnxbs"
        Me.TBnxbs.Size = New System.Drawing.Size(200, 22)
        Me.TBnxbs.TabIndex = 22
        '
        'LBdems
        '
        Me.LBdems.AutoSize = True
        Me.LBdems.ForeColor = System.Drawing.Color.Red
        Me.LBdems.Location = New System.Drawing.Point(6, 28)
        Me.LBdems.Name = "LBdems"
        Me.LBdems.Size = New System.Drawing.Size(98, 17)
        Me.LBdems.TabIndex = 21
        Me.LBdems.Text = "Tổng số sách:"
        '
        'BThuys
        '
        Me.BThuys.ForeColor = System.Drawing.Color.Blue
        Me.BThuys.Location = New System.Drawing.Point(410, 225)
        Me.BThuys.Name = "BThuys"
        Me.BThuys.Size = New System.Drawing.Size(97, 33)
        Me.BThuys.TabIndex = 20
        Me.BThuys.Text = "Hủy"
        Me.BThuys.UseVisualStyleBackColor = True
        '
        'BTluus
        '
        Me.BTluus.ForeColor = System.Drawing.Color.Blue
        Me.BTluus.Location = New System.Drawing.Point(275, 225)
        Me.BTluus.Name = "BTluus"
        Me.BTluus.Size = New System.Drawing.Size(97, 33)
        Me.BTluus.TabIndex = 19
        Me.BTluus.Text = "Lưu"
        Me.BTluus.UseVisualStyleBackColor = True
        '
        'LBmnxbs
        '
        Me.LBmnxbs.AutoSize = True
        Me.LBmnxbs.ForeColor = System.Drawing.Color.Black
        Me.LBmnxbs.Location = New System.Drawing.Point(390, 147)
        Me.LBmnxbs.Name = "LBmnxbs"
        Me.LBmnxbs.Size = New System.Drawing.Size(113, 17)
        Me.LBmnxbs.TabIndex = 17
        Me.LBmnxbs.Text = "Mã nhà xuất bản"
        '
        'BTxoas
        '
        Me.BTxoas.ForeColor = System.Drawing.Color.Blue
        Me.BTxoas.Location = New System.Drawing.Point(550, 225)
        Me.BTxoas.Name = "BTxoas"
        Me.BTxoas.Size = New System.Drawing.Size(97, 33)
        Me.BTxoas.TabIndex = 15
        Me.BTxoas.Text = "Xóa"
        Me.BTxoas.UseVisualStyleBackColor = True
        '
        'BTsuas
        '
        Me.BTsuas.ForeColor = System.Drawing.Color.Blue
        Me.BTsuas.Location = New System.Drawing.Point(410, 225)
        Me.BTsuas.Name = "BTsuas"
        Me.BTsuas.Size = New System.Drawing.Size(97, 33)
        Me.BTsuas.TabIndex = 14
        Me.BTsuas.Text = "Sửa"
        Me.BTsuas.UseVisualStyleBackColor = True
        '
        'BTthems
        '
        Me.BTthems.ForeColor = System.Drawing.Color.Blue
        Me.BTthems.Location = New System.Drawing.Point(275, 225)
        Me.BTthems.Name = "BTthems"
        Me.BTthems.Size = New System.Drawing.Size(97, 33)
        Me.BTthems.TabIndex = 13
        Me.BTthems.Text = "Thêm"
        Me.BTthems.UseVisualStyleBackColor = True
        '
        'TBgcs
        '
        Me.TBgcs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachBindingSource, "ghichus", True))
        Me.TBgcs.Location = New System.Drawing.Point(814, 82)
        Me.TBgcs.Multiline = True
        Me.TBgcs.Name = "TBgcs"
        Me.TBgcs.Size = New System.Drawing.Size(238, 86)
        Me.TBgcs.TabIndex = 12
        '
        'CBmtgs
        '
        Me.CBmtgs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachBindingSource, "matg", True))
        Me.CBmtgs.DataSource = Me.TacgiaBindingSource
        Me.CBmtgs.DisplayMember = "matg"
        Me.CBmtgs.FormattingEnabled = True
        Me.CBmtgs.Location = New System.Drawing.Point(509, 112)
        Me.CBmtgs.Name = "CBmtgs"
        Me.CBmtgs.Size = New System.Drawing.Size(200, 24)
        Me.CBmtgs.TabIndex = 9
        '
        'TacgiaBindingSource
        '
        Me.TacgiaBindingSource.DataMember = "tacgia"
        Me.TacgiaBindingSource.DataSource = Me.DataSet
        '
        'TBts
        '
        Me.TBts.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachBindingSource, "tens", True))
        Me.TBts.Location = New System.Drawing.Point(152, 112)
        Me.TBts.Name = "TBts"
        Me.TBts.Size = New System.Drawing.Size(200, 22)
        Me.TBts.TabIndex = 8
        '
        'TBms
        '
        Me.TBms.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachBindingSource, "mas", True))
        Me.TBms.Location = New System.Drawing.Point(152, 82)
        Me.TBms.Name = "TBms"
        Me.TBms.Size = New System.Drawing.Size(200, 22)
        Me.TBms.TabIndex = 7
        '
        'LBgcs
        '
        Me.LBgcs.AutoSize = True
        Me.LBgcs.ForeColor = System.Drawing.Color.Black
        Me.LBgcs.Location = New System.Drawing.Point(751, 85)
        Me.LBgcs.Name = "LBgcs"
        Me.LBgcs.Size = New System.Drawing.Size(57, 17)
        Me.LBgcs.TabIndex = 6
        Me.LBgcs.Text = "Ghi chú"
        '
        'LBmtls
        '
        Me.LBmtls.AutoSize = True
        Me.LBmtls.ForeColor = System.Drawing.Color.Black
        Me.LBmtls.Location = New System.Drawing.Point(390, 85)
        Me.LBmtls.Name = "LBmtls"
        Me.LBmtls.Size = New System.Drawing.Size(77, 17)
        Me.LBmtls.TabIndex = 5
        Me.LBmtls.Text = "Mã thể loại"
        '
        'LBnxbs
        '
        Me.LBnxbs.AutoSize = True
        Me.LBnxbs.ForeColor = System.Drawing.Color.Black
        Me.LBnxbs.Location = New System.Drawing.Point(33, 147)
        Me.LBnxbs.Name = "LBnxbs"
        Me.LBnxbs.Size = New System.Drawing.Size(95, 17)
        Me.LBnxbs.TabIndex = 4
        Me.LBnxbs.Text = "Năm xuất bản"
        '
        'LBmtgs
        '
        Me.LBmtgs.AutoSize = True
        Me.LBmtgs.ForeColor = System.Drawing.Color.Black
        Me.LBmtgs.Location = New System.Drawing.Point(390, 115)
        Me.LBmtgs.Name = "LBmtgs"
        Me.LBmtgs.Size = New System.Drawing.Size(73, 17)
        Me.LBmtgs.TabIndex = 3
        Me.LBmtgs.Text = "Mã tác giả"
        '
        'LBts
        '
        Me.LBts.AutoSize = True
        Me.LBts.ForeColor = System.Drawing.Color.Black
        Me.LBts.Location = New System.Drawing.Point(33, 115)
        Me.LBts.Name = "LBts"
        Me.LBts.Size = New System.Drawing.Size(67, 17)
        Me.LBts.TabIndex = 2
        Me.LBts.Text = "Tên sách"
        '
        'LBms
        '
        Me.LBms.AutoSize = True
        Me.LBms.ForeColor = System.Drawing.Color.Black
        Me.LBms.Location = New System.Drawing.Point(33, 85)
        Me.LBms.Name = "LBms"
        Me.LBms.Size = New System.Drawing.Size(61, 17)
        Me.LBms.TabIndex = 1
        Me.LBms.Text = "Mã sách"
        '
        'DataGridViews
        '
        Me.DataGridViews.AutoGenerateColumns = False
        Me.DataGridViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViews.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MasDataGridViewTextBoxColumn, Me.TensDataGridViewTextBoxColumn, Me.MatgDataGridViewTextBoxColumn, Me.ManxbDataGridViewTextBoxColumn, Me.MatlDataGridViewTextBoxColumn, Me.NamxbDataGridViewTextBoxColumn, Me.GhichusDataGridViewTextBoxColumn})
        Me.DataGridViews.DataSource = Me.SachBindingSource
        Me.DataGridViews.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViews.Name = "DataGridViews"
        Me.DataGridViews.RowHeadersWidth = 51
        Me.DataGridViews.RowTemplate.Height = 24
        Me.DataGridViews.Size = New System.Drawing.Size(1102, 322)
        Me.DataGridViews.TabIndex = 5
        '
        'SachTableAdapter
        '
        Me.SachTableAdapter.ClearBeforeFill = True
        '
        'OleDbSelectCommands
        '
        Me.OleDbSelectCommands.CommandText = "SELECT sach.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     sach"
        Me.OleDbSelectCommands.Connection = Me.OleDbConnection
        '
        'OleDbConnection
        '
        Me.OleDbConnection.ConnectionString = "Provider=SQLOLEDB.1;Data Source=ADMIN;Password=123;User ID=sa;Initial Catalog=QLT" &
    "V"
        '
        'OleDbInsertCommands
        '
        Me.OleDbInsertCommands.CommandText = "INSERT INTO [sach] ([mas], [tens], [matg], [manxb], [matl], [namxb], [ghichus]) V" &
    "ALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommands.Connection = Me.OleDbConnection
        Me.OleDbInsertCommands.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("mas", System.Data.OleDb.OleDbType.VarWChar, 0, "mas"), New System.Data.OleDb.OleDbParameter("tens", System.Data.OleDb.OleDbType.VarWChar, 0, "tens"), New System.Data.OleDb.OleDbParameter("matg", System.Data.OleDb.OleDbType.VarWChar, 0, "matg"), New System.Data.OleDb.OleDbParameter("manxb", System.Data.OleDb.OleDbType.VarWChar, 0, "manxb"), New System.Data.OleDb.OleDbParameter("matl", System.Data.OleDb.OleDbType.VarWChar, 0, "matl"), New System.Data.OleDb.OleDbParameter("namxb", System.Data.OleDb.OleDbType.VarWChar, 0, "namxb"), New System.Data.OleDb.OleDbParameter("ghichus", System.Data.OleDb.OleDbType.VarWChar, 0, "ghichus")})
        '
        'OleDbUpdateCommands
        '
        Me.OleDbUpdateCommands.CommandText = resources.GetString("OleDbUpdateCommands.CommandText")
        Me.OleDbUpdateCommands.Connection = Me.OleDbConnection
        Me.OleDbUpdateCommands.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("mas", System.Data.OleDb.OleDbType.VarWChar, 0, "mas"), New System.Data.OleDb.OleDbParameter("tens", System.Data.OleDb.OleDbType.VarWChar, 0, "tens"), New System.Data.OleDb.OleDbParameter("matg", System.Data.OleDb.OleDbType.VarWChar, 0, "matg"), New System.Data.OleDb.OleDbParameter("manxb", System.Data.OleDb.OleDbType.VarWChar, 0, "manxb"), New System.Data.OleDb.OleDbParameter("matl", System.Data.OleDb.OleDbType.VarWChar, 0, "matl"), New System.Data.OleDb.OleDbParameter("namxb", System.Data.OleDb.OleDbType.VarWChar, 0, "namxb"), New System.Data.OleDb.OleDbParameter("ghichus", System.Data.OleDb.OleDbType.VarWChar, 0, "ghichus"), New System.Data.OleDb.OleDbParameter("Original_mas", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mas", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_tens", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tens", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_matg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "matg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_manxb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "manxb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_matl", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "matl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_namxb", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "namxb", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_namxb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "namxb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ghichus", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ghichus", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ghichus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ghichus", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommands
        '
        Me.OleDbDeleteCommands.CommandText = resources.GetString("OleDbDeleteCommands.CommandText")
        Me.OleDbDeleteCommands.Connection = Me.OleDbConnection
        Me.OleDbDeleteCommands.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_mas", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mas", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_tens", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tens", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_matg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "matg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_manxb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "manxb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_matl", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "matl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_namxb", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "namxb", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_namxb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "namxb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ghichus", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ghichus", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ghichus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ghichus", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapters
        '
        Me.OleDbDataAdapters.DeleteCommand = Me.OleDbDeleteCommands
        Me.OleDbDataAdapters.InsertCommand = Me.OleDbInsertCommands
        Me.OleDbDataAdapters.SelectCommand = Me.OleDbSelectCommands
        Me.OleDbDataAdapters.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "sach", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("mas", "mas"), New System.Data.Common.DataColumnMapping("tens", "tens"), New System.Data.Common.DataColumnMapping("matg", "matg"), New System.Data.Common.DataColumnMapping("manxb", "manxb"), New System.Data.Common.DataColumnMapping("matl", "matl"), New System.Data.Common.DataColumnMapping("namxb", "namxb"), New System.Data.Common.DataColumnMapping("ghichus", "ghichus")})})
        Me.OleDbDataAdapters.UpdateCommand = Me.OleDbUpdateCommands
        '
        'TheloaiTableAdapter
        '
        Me.TheloaiTableAdapter.ClearBeforeFill = True
        '
        'TacgiaTableAdapter
        '
        Me.TacgiaTableAdapter.ClearBeforeFill = True
        '
        'NhaxuatbanTableAdapter
        '
        Me.NhaxuatbanTableAdapter.ClearBeforeFill = True
        '
        'MasDataGridViewTextBoxColumn
        '
        Me.MasDataGridViewTextBoxColumn.DataPropertyName = "mas"
        Me.MasDataGridViewTextBoxColumn.HeaderText = "Mã sách"
        Me.MasDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MasDataGridViewTextBoxColumn.Name = "MasDataGridViewTextBoxColumn"
        Me.MasDataGridViewTextBoxColumn.Width = 125
        '
        'TensDataGridViewTextBoxColumn
        '
        Me.TensDataGridViewTextBoxColumn.DataPropertyName = "tens"
        Me.TensDataGridViewTextBoxColumn.HeaderText = "Tên sách"
        Me.TensDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TensDataGridViewTextBoxColumn.Name = "TensDataGridViewTextBoxColumn"
        Me.TensDataGridViewTextBoxColumn.Width = 125
        '
        'MatgDataGridViewTextBoxColumn
        '
        Me.MatgDataGridViewTextBoxColumn.DataPropertyName = "matg"
        Me.MatgDataGridViewTextBoxColumn.HeaderText = "Mã tác giả"
        Me.MatgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MatgDataGridViewTextBoxColumn.Name = "MatgDataGridViewTextBoxColumn"
        Me.MatgDataGridViewTextBoxColumn.Width = 125
        '
        'ManxbDataGridViewTextBoxColumn
        '
        Me.ManxbDataGridViewTextBoxColumn.DataPropertyName = "manxb"
        Me.ManxbDataGridViewTextBoxColumn.HeaderText = "Mã nhà xuất bản"
        Me.ManxbDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ManxbDataGridViewTextBoxColumn.Name = "ManxbDataGridViewTextBoxColumn"
        Me.ManxbDataGridViewTextBoxColumn.Width = 140
        '
        'MatlDataGridViewTextBoxColumn
        '
        Me.MatlDataGridViewTextBoxColumn.DataPropertyName = "matl"
        Me.MatlDataGridViewTextBoxColumn.HeaderText = "Mã thể loại"
        Me.MatlDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MatlDataGridViewTextBoxColumn.Name = "MatlDataGridViewTextBoxColumn"
        Me.MatlDataGridViewTextBoxColumn.Width = 125
        '
        'NamxbDataGridViewTextBoxColumn
        '
        Me.NamxbDataGridViewTextBoxColumn.DataPropertyName = "namxb"
        Me.NamxbDataGridViewTextBoxColumn.HeaderText = "Năm xuất bản"
        Me.NamxbDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NamxbDataGridViewTextBoxColumn.Name = "NamxbDataGridViewTextBoxColumn"
        Me.NamxbDataGridViewTextBoxColumn.Width = 125
        '
        'GhichusDataGridViewTextBoxColumn
        '
        Me.GhichusDataGridViewTextBoxColumn.DataPropertyName = "ghichus"
        Me.GhichusDataGridViewTextBoxColumn.HeaderText = "Ghi chú"
        Me.GhichusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GhichusDataGridViewTextBoxColumn.Name = "GhichusDataGridViewTextBoxColumn"
        Me.GhichusDataGridViewTextBoxColumn.Width = 500
        '
        'Formquanlysach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 596)
        Me.Controls.Add(Me.GBs)
        Me.Controls.Add(Me.DataGridViews)
        Me.Name = "Formquanlysach"
        Me.Text = "Quản lý sách"
        Me.GBs.ResumeLayout(False)
        Me.GBs.PerformLayout()
        CType(Me.SachBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TheloaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NhaxuatbanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TacgiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViews, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBs As GroupBox
    Friend WithEvents BTts As Button
    Friend WithEvents BTtks As Button
    Friend WithEvents BTloads As Button
    Friend WithEvents CBmtls As ComboBox
    Friend WithEvents CBmnxbs As ComboBox
    Friend WithEvents TBnxbs As TextBox
    Friend WithEvents LBdems As Label
    Friend WithEvents BThuys As Button
    Friend WithEvents BTluus As Button
    Friend WithEvents LBmnxbs As Label
    Friend WithEvents BTxoas As Button
    Friend WithEvents BTsuas As Button
    Friend WithEvents BTthems As Button
    Friend WithEvents TBgcs As TextBox
    Friend WithEvents CBmtgs As ComboBox
    Friend WithEvents TBts As TextBox
    Friend WithEvents TBms As TextBox
    Friend WithEvents LBgcs As Label
    Friend WithEvents LBmtls As Label
    Friend WithEvents LBnxbs As Label
    Friend WithEvents LBmtgs As Label
    Friend WithEvents LBts As Label
    Friend WithEvents LBms As Label
    Friend WithEvents DataGridViews As DataGridView
    Friend WithEvents DataSet As DataSet
    Friend WithEvents SachBindingSource As BindingSource
    Friend WithEvents SachTableAdapter As DataSetTableAdapters.sachTableAdapter
    Friend WithEvents OleDbSelectCommands As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommands As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommands As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommands As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapters As OleDb.OleDbDataAdapter
    Friend WithEvents TheloaiBindingSource As BindingSource
    Friend WithEvents TheloaiTableAdapter As DataSetTableAdapters.theloaiTableAdapter
    Friend WithEvents TacgiaBindingSource As BindingSource
    Friend WithEvents TacgiaTableAdapter As DataSetTableAdapters.tacgiaTableAdapter
    Friend WithEvents NhaxuatbanBindingSource As BindingSource
    Friend WithEvents NhaxuatbanTableAdapter As DataSetTableAdapters.nhaxuatbanTableAdapter
    Friend WithEvents MasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TensDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManxbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamxbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GhichusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
