<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formnhaxuatban
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formnhaxuatban))
        Me.GBnxb = New System.Windows.Forms.GroupBox()
        Me.BTloadnxb = New System.Windows.Forms.Button()
        Me.BTtnxb = New System.Windows.Forms.Button()
        Me.BTtknxb = New System.Windows.Forms.Button()
        Me.LBdemnxb = New System.Windows.Forms.Label()
        Me.BThuynxb = New System.Windows.Forms.Button()
        Me.BTluunxb = New System.Windows.Forms.Button()
        Me.TBsdtnxb = New System.Windows.Forms.TextBox()
        Me.NhaxuatbanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New QuanLyThuVien.DataSet()
        Me.LBsdtnxb = New System.Windows.Forms.Label()
        Me.BTxoanxb = New System.Windows.Forms.Button()
        Me.BTsuanxb = New System.Windows.Forms.Button()
        Me.BTthemnxb = New System.Windows.Forms.Button()
        Me.TBgcnxb = New System.Windows.Forms.TextBox()
        Me.TBdcnxb = New System.Windows.Forms.TextBox()
        Me.TBtnxb = New System.Windows.Forms.TextBox()
        Me.TBmnxb = New System.Windows.Forms.TextBox()
        Me.LBgcnxb = New System.Windows.Forms.Label()
        Me.LBdcnxb = New System.Windows.Forms.Label()
        Me.LBtnxb = New System.Windows.Forms.Label()
        Me.LBmnxb = New System.Windows.Forms.Label()
        Me.DataGridViewnxb = New System.Windows.Forms.DataGridView()
        Me.NhaxuatbanTableAdapter = New QuanLyThuVien.DataSetTableAdapters.nhaxuatbanTableAdapter()
        Me.OleDbSelectCommandnxb = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommandnxb = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommandnxb = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommandnxb = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapternxb = New System.Data.OleDb.OleDbDataAdapter()
        Me.ManxbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TennxbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SdtnxbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiachinxbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhichunxbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBnxb.SuspendLayout()
        CType(Me.NhaxuatbanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewnxb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBnxb
        '
        Me.GBnxb.Controls.Add(Me.BTloadnxb)
        Me.GBnxb.Controls.Add(Me.BTtnxb)
        Me.GBnxb.Controls.Add(Me.BTtknxb)
        Me.GBnxb.Controls.Add(Me.LBdemnxb)
        Me.GBnxb.Controls.Add(Me.BThuynxb)
        Me.GBnxb.Controls.Add(Me.BTluunxb)
        Me.GBnxb.Controls.Add(Me.TBsdtnxb)
        Me.GBnxb.Controls.Add(Me.LBsdtnxb)
        Me.GBnxb.Controls.Add(Me.BTxoanxb)
        Me.GBnxb.Controls.Add(Me.BTsuanxb)
        Me.GBnxb.Controls.Add(Me.BTthemnxb)
        Me.GBnxb.Controls.Add(Me.TBgcnxb)
        Me.GBnxb.Controls.Add(Me.TBdcnxb)
        Me.GBnxb.Controls.Add(Me.TBtnxb)
        Me.GBnxb.Controls.Add(Me.TBmnxb)
        Me.GBnxb.Controls.Add(Me.LBgcnxb)
        Me.GBnxb.Controls.Add(Me.LBdcnxb)
        Me.GBnxb.Controls.Add(Me.LBtnxb)
        Me.GBnxb.Controls.Add(Me.LBmnxb)
        Me.GBnxb.ForeColor = System.Drawing.Color.Red
        Me.GBnxb.Location = New System.Drawing.Point(0, 329)
        Me.GBnxb.Name = "GBnxb"
        Me.GBnxb.Size = New System.Drawing.Size(1102, 283)
        Me.GBnxb.TabIndex = 8
        Me.GBnxb.TabStop = False
        Me.GBnxb.Text = "Cập nhập thông tin nhà xuất bản"
        '
        'BTloadnxb
        '
        Me.BTloadnxb.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTloadnxb.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTloadnxb.ForeColor = System.Drawing.Color.Red
        Me.BTloadnxb.Location = New System.Drawing.Point(1045, 9)
        Me.BTloadnxb.Name = "BTloadnxb"
        Me.BTloadnxb.Size = New System.Drawing.Size(57, 36)
        Me.BTloadnxb.TabIndex = 26
        Me.BTloadnxb.Text = "O"
        Me.BTloadnxb.UseVisualStyleBackColor = False
        '
        'BTtnxb
        '
        Me.BTtnxb.ForeColor = System.Drawing.Color.Blue
        Me.BTtnxb.Location = New System.Drawing.Point(682, 235)
        Me.BTtnxb.Name = "BTtnxb"
        Me.BTtnxb.Size = New System.Drawing.Size(97, 36)
        Me.BTtnxb.TabIndex = 25
        Me.BTtnxb.Text = "Tìm"
        Me.BTtnxb.UseVisualStyleBackColor = True
        '
        'BTtknxb
        '
        Me.BTtknxb.ForeColor = System.Drawing.Color.Blue
        Me.BTtknxb.Location = New System.Drawing.Point(682, 235)
        Me.BTtknxb.Name = "BTtknxb"
        Me.BTtknxb.Size = New System.Drawing.Size(97, 36)
        Me.BTtknxb.TabIndex = 24
        Me.BTtknxb.Text = "Tìm kiếm"
        Me.BTtknxb.UseVisualStyleBackColor = True
        '
        'LBdemnxb
        '
        Me.LBdemnxb.AutoSize = True
        Me.LBdemnxb.ForeColor = System.Drawing.Color.Red
        Me.LBdemnxb.Location = New System.Drawing.Point(6, 28)
        Me.LBdemnxb.Name = "LBdemnxb"
        Me.LBdemnxb.Size = New System.Drawing.Size(150, 17)
        Me.LBdemnxb.TabIndex = 21
        Me.LBdemnxb.Text = "Tổng số nhà xuất bản:"
        '
        'BThuynxb
        '
        Me.BThuynxb.ForeColor = System.Drawing.Color.Blue
        Me.BThuynxb.Location = New System.Drawing.Point(411, 235)
        Me.BThuynxb.Name = "BThuynxb"
        Me.BThuynxb.Size = New System.Drawing.Size(97, 36)
        Me.BThuynxb.TabIndex = 20
        Me.BThuynxb.Text = "Hủy"
        Me.BThuynxb.UseVisualStyleBackColor = True
        '
        'BTluunxb
        '
        Me.BTluunxb.ForeColor = System.Drawing.Color.Blue
        Me.BTluunxb.Location = New System.Drawing.Point(276, 235)
        Me.BTluunxb.Name = "BTluunxb"
        Me.BTluunxb.Size = New System.Drawing.Size(97, 36)
        Me.BTluunxb.TabIndex = 19
        Me.BTluunxb.Text = "Lưu"
        Me.BTluunxb.UseVisualStyleBackColor = True
        '
        'TBsdtnxb
        '
        Me.TBsdtnxb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NhaxuatbanBindingSource, "sdtnxb", True))
        Me.TBsdtnxb.Location = New System.Drawing.Point(148, 124)
        Me.TBsdtnxb.Name = "TBsdtnxb"
        Me.TBsdtnxb.Size = New System.Drawing.Size(200, 22)
        Me.TBsdtnxb.TabIndex = 18
        '
        'NhaxuatbanBindingSource
        '
        Me.NhaxuatbanBindingSource.DataMember = "nhaxuatban"
        Me.NhaxuatbanBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LBsdtnxb
        '
        Me.LBsdtnxb.AutoSize = True
        Me.LBsdtnxb.ForeColor = System.Drawing.Color.Black
        Me.LBsdtnxb.Location = New System.Drawing.Point(29, 127)
        Me.LBsdtnxb.Name = "LBsdtnxb"
        Me.LBsdtnxb.Size = New System.Drawing.Size(91, 17)
        Me.LBsdtnxb.TabIndex = 17
        Me.LBsdtnxb.Text = "Số điện thoại"
        '
        'BTxoanxb
        '
        Me.BTxoanxb.ForeColor = System.Drawing.Color.Blue
        Me.BTxoanxb.Location = New System.Drawing.Point(551, 236)
        Me.BTxoanxb.Name = "BTxoanxb"
        Me.BTxoanxb.Size = New System.Drawing.Size(97, 36)
        Me.BTxoanxb.TabIndex = 15
        Me.BTxoanxb.Text = "Xóa"
        Me.BTxoanxb.UseVisualStyleBackColor = True
        '
        'BTsuanxb
        '
        Me.BTsuanxb.ForeColor = System.Drawing.Color.Blue
        Me.BTsuanxb.Location = New System.Drawing.Point(411, 236)
        Me.BTsuanxb.Name = "BTsuanxb"
        Me.BTsuanxb.Size = New System.Drawing.Size(97, 36)
        Me.BTsuanxb.TabIndex = 14
        Me.BTsuanxb.Text = "Sửa"
        Me.BTsuanxb.UseVisualStyleBackColor = True
        '
        'BTthemnxb
        '
        Me.BTthemnxb.ForeColor = System.Drawing.Color.Blue
        Me.BTthemnxb.Location = New System.Drawing.Point(276, 236)
        Me.BTthemnxb.Name = "BTthemnxb"
        Me.BTthemnxb.Size = New System.Drawing.Size(97, 36)
        Me.BTthemnxb.TabIndex = 13
        Me.BTthemnxb.Text = "Thêm"
        Me.BTthemnxb.UseVisualStyleBackColor = True
        '
        'TBgcnxb
        '
        Me.TBgcnxb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NhaxuatbanBindingSource, "ghichunxb", True))
        Me.TBgcnxb.Location = New System.Drawing.Point(785, 53)
        Me.TBgcnxb.Multiline = True
        Me.TBgcnxb.Name = "TBgcnxb"
        Me.TBgcnxb.Size = New System.Drawing.Size(238, 139)
        Me.TBgcnxb.TabIndex = 12
        '
        'TBdcnxb
        '
        Me.TBdcnxb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NhaxuatbanBindingSource, "diachinxb", True))
        Me.TBdcnxb.Location = New System.Drawing.Point(440, 52)
        Me.TBdcnxb.Multiline = True
        Me.TBdcnxb.Name = "TBdcnxb"
        Me.TBdcnxb.Size = New System.Drawing.Size(238, 140)
        Me.TBdcnxb.TabIndex = 11
        '
        'TBtnxb
        '
        Me.TBtnxb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NhaxuatbanBindingSource, "tennxb", True))
        Me.TBtnxb.Location = New System.Drawing.Point(148, 96)
        Me.TBtnxb.Name = "TBtnxb"
        Me.TBtnxb.Size = New System.Drawing.Size(200, 22)
        Me.TBtnxb.TabIndex = 8
        '
        'TBmnxb
        '
        Me.TBmnxb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NhaxuatbanBindingSource, "manxb", True))
        Me.TBmnxb.Location = New System.Drawing.Point(148, 68)
        Me.TBmnxb.Name = "TBmnxb"
        Me.TBmnxb.Size = New System.Drawing.Size(200, 22)
        Me.TBmnxb.TabIndex = 7
        '
        'LBgcnxb
        '
        Me.LBgcnxb.AutoSize = True
        Me.LBgcnxb.ForeColor = System.Drawing.Color.Black
        Me.LBgcnxb.Location = New System.Drawing.Point(722, 56)
        Me.LBgcnxb.Name = "LBgcnxb"
        Me.LBgcnxb.Size = New System.Drawing.Size(57, 17)
        Me.LBgcnxb.TabIndex = 6
        Me.LBgcnxb.Text = "Ghi chú"
        '
        'LBdcnxb
        '
        Me.LBdcnxb.AutoSize = True
        Me.LBdcnxb.ForeColor = System.Drawing.Color.Black
        Me.LBdcnxb.Location = New System.Drawing.Point(383, 54)
        Me.LBdcnxb.Name = "LBdcnxb"
        Me.LBdcnxb.Size = New System.Drawing.Size(51, 17)
        Me.LBdcnxb.TabIndex = 5
        Me.LBdcnxb.Text = "Địa chỉ"
        '
        'LBtnxb
        '
        Me.LBtnxb.AutoSize = True
        Me.LBtnxb.ForeColor = System.Drawing.Color.Black
        Me.LBtnxb.Location = New System.Drawing.Point(29, 99)
        Me.LBtnxb.Name = "LBtnxb"
        Me.LBtnxb.Size = New System.Drawing.Size(119, 17)
        Me.LBtnxb.TabIndex = 2
        Me.LBtnxb.Text = "Tên nhà xuất bản"
        '
        'LBmnxb
        '
        Me.LBmnxb.AutoSize = True
        Me.LBmnxb.ForeColor = System.Drawing.Color.Black
        Me.LBmnxb.Location = New System.Drawing.Point(29, 71)
        Me.LBmnxb.Name = "LBmnxb"
        Me.LBmnxb.Size = New System.Drawing.Size(113, 17)
        Me.LBmnxb.TabIndex = 1
        Me.LBmnxb.Text = "Mã nhà xuất bản"
        '
        'DataGridViewnxb
        '
        Me.DataGridViewnxb.AutoGenerateColumns = False
        Me.DataGridViewnxb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewnxb.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ManxbDataGridViewTextBoxColumn, Me.TennxbDataGridViewTextBoxColumn, Me.SdtnxbDataGridViewTextBoxColumn, Me.DiachinxbDataGridViewTextBoxColumn, Me.GhichunxbDataGridViewTextBoxColumn})
        Me.DataGridViewnxb.DataSource = Me.NhaxuatbanBindingSource
        Me.DataGridViewnxb.Location = New System.Drawing.Point(0, 1)
        Me.DataGridViewnxb.Name = "DataGridViewnxb"
        Me.DataGridViewnxb.RowHeadersWidth = 51
        Me.DataGridViewnxb.RowTemplate.Height = 24
        Me.DataGridViewnxb.Size = New System.Drawing.Size(1102, 322)
        Me.DataGridViewnxb.TabIndex = 7
        '
        'NhaxuatbanTableAdapter
        '
        Me.NhaxuatbanTableAdapter.ClearBeforeFill = True
        '
        'OleDbSelectCommandnxb
        '
        Me.OleDbSelectCommandnxb.CommandText = "SELECT nhaxuatban.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     nhaxuatban"
        Me.OleDbSelectCommandnxb.Connection = Me.OleDbConnection
        '
        'OleDbConnection
        '
        Me.OleDbConnection.ConnectionString = "Provider=SQLOLEDB.1;Data Source=ADMIN;Password=123;User ID=sa;Initial Catalog=QLT" &
    "V"
        '
        'OleDbInsertCommandnxb
        '
        Me.OleDbInsertCommandnxb.CommandText = "INSERT INTO [nhaxuatban] ([manxb], [tennxb], [diachinxb], [sdtnxb], [ghichunxb]) " &
    "VALUES (?, ?, ?, ?, ?)"
        Me.OleDbInsertCommandnxb.Connection = Me.OleDbConnection
        Me.OleDbInsertCommandnxb.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("manxb", System.Data.OleDb.OleDbType.VarWChar, 0, "manxb"), New System.Data.OleDb.OleDbParameter("tennxb", System.Data.OleDb.OleDbType.VarWChar, 0, "tennxb"), New System.Data.OleDb.OleDbParameter("diachinxb", System.Data.OleDb.OleDbType.VarWChar, 0, "diachinxb"), New System.Data.OleDb.OleDbParameter("sdtnxb", System.Data.OleDb.OleDbType.VarWChar, 0, "sdtnxb"), New System.Data.OleDb.OleDbParameter("ghichunxb", System.Data.OleDb.OleDbType.VarWChar, 0, "ghichunxb")})
        '
        'OleDbUpdateCommandnxb
        '
        Me.OleDbUpdateCommandnxb.CommandText = resources.GetString("OleDbUpdateCommandnxb.CommandText")
        Me.OleDbUpdateCommandnxb.Connection = Me.OleDbConnection
        Me.OleDbUpdateCommandnxb.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("manxb", System.Data.OleDb.OleDbType.VarWChar, 0, "manxb"), New System.Data.OleDb.OleDbParameter("tennxb", System.Data.OleDb.OleDbType.VarWChar, 0, "tennxb"), New System.Data.OleDb.OleDbParameter("diachinxb", System.Data.OleDb.OleDbType.VarWChar, 0, "diachinxb"), New System.Data.OleDb.OleDbParameter("sdtnxb", System.Data.OleDb.OleDbType.VarWChar, 0, "sdtnxb"), New System.Data.OleDb.OleDbParameter("ghichunxb", System.Data.OleDb.OleDbType.VarWChar, 0, "ghichunxb"), New System.Data.OleDb.OleDbParameter("Original_manxb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "manxb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_tennxb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tennxb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_diachinxb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "diachinxb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_sdtnxb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sdtnxb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ghichunxb", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ghichunxb", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ghichunxb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ghichunxb", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommandnxb
        '
        Me.OleDbDeleteCommandnxb.CommandText = "DELETE FROM [nhaxuatban] WHERE (([manxb] = ?) AND ([tennxb] = ?) AND ([diachinxb]" &
    " = ?) AND ([sdtnxb] = ?) AND ((? = 1 AND [ghichunxb] IS NULL) OR ([ghichunxb] = " &
    "?)))"
        Me.OleDbDeleteCommandnxb.Connection = Me.OleDbConnection
        Me.OleDbDeleteCommandnxb.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_manxb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "manxb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_tennxb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tennxb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_diachinxb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "diachinxb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_sdtnxb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sdtnxb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ghichunxb", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ghichunxb", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ghichunxb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ghichunxb", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapternxb
        '
        Me.OleDbDataAdapternxb.DeleteCommand = Me.OleDbDeleteCommandnxb
        Me.OleDbDataAdapternxb.InsertCommand = Me.OleDbInsertCommandnxb
        Me.OleDbDataAdapternxb.SelectCommand = Me.OleDbSelectCommandnxb
        Me.OleDbDataAdapternxb.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "nhaxuatban", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("manxb", "manxb"), New System.Data.Common.DataColumnMapping("tennxb", "tennxb"), New System.Data.Common.DataColumnMapping("diachinxb", "diachinxb"), New System.Data.Common.DataColumnMapping("sdtnxb", "sdtnxb"), New System.Data.Common.DataColumnMapping("ghichunxb", "ghichunxb")})})
        Me.OleDbDataAdapternxb.UpdateCommand = Me.OleDbUpdateCommandnxb
        '
        'ManxbDataGridViewTextBoxColumn
        '
        Me.ManxbDataGridViewTextBoxColumn.DataPropertyName = "manxb"
        Me.ManxbDataGridViewTextBoxColumn.HeaderText = "Mã nhà xuất bản"
        Me.ManxbDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ManxbDataGridViewTextBoxColumn.Name = "ManxbDataGridViewTextBoxColumn"
        Me.ManxbDataGridViewTextBoxColumn.Width = 145
        '
        'TennxbDataGridViewTextBoxColumn
        '
        Me.TennxbDataGridViewTextBoxColumn.DataPropertyName = "tennxb"
        Me.TennxbDataGridViewTextBoxColumn.HeaderText = "Tên nhà xuất bản"
        Me.TennxbDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TennxbDataGridViewTextBoxColumn.Name = "TennxbDataGridViewTextBoxColumn"
        Me.TennxbDataGridViewTextBoxColumn.Width = 150
        '
        'SdtnxbDataGridViewTextBoxColumn
        '
        Me.SdtnxbDataGridViewTextBoxColumn.DataPropertyName = "sdtnxb"
        Me.SdtnxbDataGridViewTextBoxColumn.HeaderText = "Số điện thoại"
        Me.SdtnxbDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SdtnxbDataGridViewTextBoxColumn.Name = "SdtnxbDataGridViewTextBoxColumn"
        Me.SdtnxbDataGridViewTextBoxColumn.Width = 125
        '
        'DiachinxbDataGridViewTextBoxColumn
        '
        Me.DiachinxbDataGridViewTextBoxColumn.DataPropertyName = "diachinxb"
        Me.DiachinxbDataGridViewTextBoxColumn.HeaderText = "Địa chỉ"
        Me.DiachinxbDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiachinxbDataGridViewTextBoxColumn.Name = "DiachinxbDataGridViewTextBoxColumn"
        Me.DiachinxbDataGridViewTextBoxColumn.Width = 300
        '
        'GhichunxbDataGridViewTextBoxColumn
        '
        Me.GhichunxbDataGridViewTextBoxColumn.DataPropertyName = "ghichunxb"
        Me.GhichunxbDataGridViewTextBoxColumn.HeaderText = "Ghi chú"
        Me.GhichunxbDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GhichunxbDataGridViewTextBoxColumn.Name = "GhichunxbDataGridViewTextBoxColumn"
        Me.GhichunxbDataGridViewTextBoxColumn.Width = 500
        '
        'Formnhaxuatban
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 612)
        Me.Controls.Add(Me.GBnxb)
        Me.Controls.Add(Me.DataGridViewnxb)
        Me.Name = "Formnhaxuatban"
        Me.Text = "Quản lý thông tin nhà xuất bản"
        Me.GBnxb.ResumeLayout(False)
        Me.GBnxb.PerformLayout()
        CType(Me.NhaxuatbanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewnxb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBnxb As GroupBox
    Friend WithEvents BTloadnxb As Button
    Friend WithEvents BTtnxb As Button
    Friend WithEvents BTtknxb As Button
    Friend WithEvents LBdemnxb As Label
    Friend WithEvents BThuynxb As Button
    Friend WithEvents BTluunxb As Button
    Friend WithEvents TBsdtnxb As TextBox
    Friend WithEvents LBsdtnxb As Label
    Friend WithEvents BTxoanxb As Button
    Friend WithEvents BTsuanxb As Button
    Friend WithEvents BTthemnxb As Button
    Friend WithEvents TBgcnxb As TextBox
    Friend WithEvents TBdcnxb As TextBox
    Friend WithEvents TBtnxb As TextBox
    Friend WithEvents TBmnxb As TextBox
    Friend WithEvents LBgcnxb As Label
    Friend WithEvents LBdcnxb As Label
    Friend WithEvents LBtnxb As Label
    Friend WithEvents LBmnxb As Label
    Friend WithEvents DataGridViewnxb As DataGridView
    Friend WithEvents DataSet As DataSet
    Friend WithEvents NhaxuatbanBindingSource As BindingSource
    Friend WithEvents NhaxuatbanTableAdapter As DataSetTableAdapters.nhaxuatbanTableAdapter
    Friend WithEvents OleDbSelectCommandnxb As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommandnxb As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommandnxb As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommandnxb As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapternxb As OleDb.OleDbDataAdapter
    Friend WithEvents ManxbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TennxbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SdtnxbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiachinxbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GhichunxbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
