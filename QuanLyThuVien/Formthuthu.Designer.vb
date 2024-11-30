<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formthuthu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formthuthu))
        Me.GBtt = New System.Windows.Forms.GroupBox()
        Me.BTttt = New System.Windows.Forms.Button()
        Me.BTtktt = New System.Windows.Forms.Button()
        Me.BTloadtt = New System.Windows.Forms.Button()
        Me.LBdemtt = New System.Windows.Forms.Label()
        Me.BThuytt = New System.Windows.Forms.Button()
        Me.BTluutt = New System.Windows.Forms.Button()
        Me.TBsdttt = New System.Windows.Forms.TextBox()
        Me.ThuthuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New QuanLyThuVien.DataSet()
        Me.LBsdttt = New System.Windows.Forms.Label()
        Me.BTxoatt = New System.Windows.Forms.Button()
        Me.BTsuatt = New System.Windows.Forms.Button()
        Me.BTthemtt = New System.Windows.Forms.Button()
        Me.TBgctt = New System.Windows.Forms.TextBox()
        Me.TBdctt = New System.Windows.Forms.TextBox()
        Me.DTPnstt = New System.Windows.Forms.DateTimePicker()
        Me.CBgttt = New System.Windows.Forms.ComboBox()
        Me.TBhttt = New System.Windows.Forms.TextBox()
        Me.TBmtt = New System.Windows.Forms.TextBox()
        Me.LBgctt = New System.Windows.Forms.Label()
        Me.LBdctt = New System.Windows.Forms.Label()
        Me.LBnstt = New System.Windows.Forms.Label()
        Me.LBgttt = New System.Windows.Forms.Label()
        Me.LBhttt = New System.Windows.Forms.Label()
        Me.LBmtt = New System.Windows.Forms.Label()
        Me.DataGridViewtt = New System.Windows.Forms.DataGridView()
        Me.ThuthuTableAdapter = New QuanLyThuVien.DataSetTableAdapters.thuthuTableAdapter()
        Me.OleDbSelectCommandtt = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommandtt = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommandtt = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommandtt = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdaptertt = New System.Data.OleDb.OleDbDataAdapter()
        Me.MattDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HotenttDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioitinhttDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaysinhttDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SdtttDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiachittDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhichuttDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBtt.SuspendLayout()
        CType(Me.ThuthuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewtt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBtt
        '
        Me.GBtt.Controls.Add(Me.BTttt)
        Me.GBtt.Controls.Add(Me.BTtktt)
        Me.GBtt.Controls.Add(Me.BTloadtt)
        Me.GBtt.Controls.Add(Me.LBdemtt)
        Me.GBtt.Controls.Add(Me.BThuytt)
        Me.GBtt.Controls.Add(Me.BTluutt)
        Me.GBtt.Controls.Add(Me.TBsdttt)
        Me.GBtt.Controls.Add(Me.LBsdttt)
        Me.GBtt.Controls.Add(Me.BTxoatt)
        Me.GBtt.Controls.Add(Me.BTsuatt)
        Me.GBtt.Controls.Add(Me.BTthemtt)
        Me.GBtt.Controls.Add(Me.TBgctt)
        Me.GBtt.Controls.Add(Me.TBdctt)
        Me.GBtt.Controls.Add(Me.DTPnstt)
        Me.GBtt.Controls.Add(Me.CBgttt)
        Me.GBtt.Controls.Add(Me.TBhttt)
        Me.GBtt.Controls.Add(Me.TBmtt)
        Me.GBtt.Controls.Add(Me.LBgctt)
        Me.GBtt.Controls.Add(Me.LBdctt)
        Me.GBtt.Controls.Add(Me.LBnstt)
        Me.GBtt.Controls.Add(Me.LBgttt)
        Me.GBtt.Controls.Add(Me.LBhttt)
        Me.GBtt.Controls.Add(Me.LBmtt)
        Me.GBtt.ForeColor = System.Drawing.Color.Red
        Me.GBtt.Location = New System.Drawing.Point(0, 329)
        Me.GBtt.Name = "GBtt"
        Me.GBtt.Size = New System.Drawing.Size(1102, 283)
        Me.GBtt.TabIndex = 4
        Me.GBtt.TabStop = False
        Me.GBtt.Text = "Cập nhập thông tin thủ thư"
        '
        'BTttt
        '
        Me.BTttt.ForeColor = System.Drawing.Color.Blue
        Me.BTttt.Location = New System.Drawing.Point(682, 239)
        Me.BTttt.Name = "BTttt"
        Me.BTttt.Size = New System.Drawing.Size(97, 32)
        Me.BTttt.TabIndex = 33
        Me.BTttt.Text = "Tìm"
        Me.BTttt.UseVisualStyleBackColor = True
        '
        'BTtktt
        '
        Me.BTtktt.ForeColor = System.Drawing.Color.Blue
        Me.BTtktt.Location = New System.Drawing.Point(682, 239)
        Me.BTtktt.Name = "BTtktt"
        Me.BTtktt.Size = New System.Drawing.Size(97, 32)
        Me.BTtktt.TabIndex = 32
        Me.BTtktt.Text = "Tìm kiếm"
        Me.BTtktt.UseVisualStyleBackColor = True
        '
        'BTloadtt
        '
        Me.BTloadtt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTloadtt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTloadtt.ForeColor = System.Drawing.Color.Red
        Me.BTloadtt.Location = New System.Drawing.Point(1060, 12)
        Me.BTloadtt.Name = "BTloadtt"
        Me.BTloadtt.Size = New System.Drawing.Size(36, 33)
        Me.BTloadtt.TabIndex = 30
        Me.BTloadtt.Text = "O"
        Me.BTloadtt.UseVisualStyleBackColor = False
        '
        'LBdemtt
        '
        Me.LBdemtt.AutoSize = True
        Me.LBdemtt.ForeColor = System.Drawing.Color.Red
        Me.LBdemtt.Location = New System.Drawing.Point(6, 28)
        Me.LBdemtt.Name = "LBdemtt"
        Me.LBdemtt.Size = New System.Drawing.Size(116, 17)
        Me.LBdemtt.TabIndex = 21
        Me.LBdemtt.Text = "Tổng số thủ thư :"
        '
        'BThuytt
        '
        Me.BThuytt.ForeColor = System.Drawing.Color.Blue
        Me.BThuytt.Location = New System.Drawing.Point(412, 239)
        Me.BThuytt.Name = "BThuytt"
        Me.BThuytt.Size = New System.Drawing.Size(97, 33)
        Me.BThuytt.TabIndex = 20
        Me.BThuytt.Text = "Hủy"
        Me.BThuytt.UseVisualStyleBackColor = True
        '
        'BTluutt
        '
        Me.BTluutt.ForeColor = System.Drawing.Color.Blue
        Me.BTluutt.Location = New System.Drawing.Point(277, 239)
        Me.BTluutt.Name = "BTluutt"
        Me.BTluutt.Size = New System.Drawing.Size(97, 33)
        Me.BTluutt.TabIndex = 19
        Me.BTluutt.Text = "Lưu"
        Me.BTluutt.UseVisualStyleBackColor = True
        '
        'TBsdttt
        '
        Me.TBsdttt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ThuthuBindingSource, "sdttt", True))
        Me.TBsdttt.Location = New System.Drawing.Point(150, 170)
        Me.TBsdttt.Name = "TBsdttt"
        Me.TBsdttt.Size = New System.Drawing.Size(200, 22)
        Me.TBsdttt.TabIndex = 18
        '
        'ThuthuBindingSource
        '
        Me.ThuthuBindingSource.DataMember = "thuthu"
        Me.ThuthuBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LBsdttt
        '
        Me.LBsdttt.AutoSize = True
        Me.LBsdttt.ForeColor = System.Drawing.Color.Black
        Me.LBsdttt.Location = New System.Drawing.Point(53, 173)
        Me.LBsdttt.Name = "LBsdttt"
        Me.LBsdttt.Size = New System.Drawing.Size(91, 17)
        Me.LBsdttt.TabIndex = 17
        Me.LBsdttt.Text = "Số điện thoại"
        '
        'BTxoatt
        '
        Me.BTxoatt.ForeColor = System.Drawing.Color.Blue
        Me.BTxoatt.Location = New System.Drawing.Point(552, 239)
        Me.BTxoatt.Name = "BTxoatt"
        Me.BTxoatt.Size = New System.Drawing.Size(97, 33)
        Me.BTxoatt.TabIndex = 15
        Me.BTxoatt.Text = "Xóa"
        Me.BTxoatt.UseVisualStyleBackColor = True
        '
        'BTsuatt
        '
        Me.BTsuatt.ForeColor = System.Drawing.Color.Blue
        Me.BTsuatt.Location = New System.Drawing.Point(412, 239)
        Me.BTsuatt.Name = "BTsuatt"
        Me.BTsuatt.Size = New System.Drawing.Size(97, 33)
        Me.BTsuatt.TabIndex = 14
        Me.BTsuatt.Text = "Sửa"
        Me.BTsuatt.UseVisualStyleBackColor = True
        '
        'BTthemtt
        '
        Me.BTthemtt.ForeColor = System.Drawing.Color.Blue
        Me.BTthemtt.Location = New System.Drawing.Point(277, 239)
        Me.BTthemtt.Name = "BTthemtt"
        Me.BTthemtt.Size = New System.Drawing.Size(97, 33)
        Me.BTthemtt.TabIndex = 13
        Me.BTthemtt.Text = "Thêm"
        Me.BTthemtt.UseVisualStyleBackColor = True
        '
        'TBgctt
        '
        Me.TBgctt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ThuthuBindingSource, "ghichutt", True))
        Me.TBgctt.Location = New System.Drawing.Point(785, 53)
        Me.TBgctt.Multiline = True
        Me.TBgctt.Name = "TBgctt"
        Me.TBgctt.Size = New System.Drawing.Size(238, 139)
        Me.TBgctt.TabIndex = 12
        '
        'TBdctt
        '
        Me.TBdctt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ThuthuBindingSource, "diachitt", True))
        Me.TBdctt.Location = New System.Drawing.Point(440, 52)
        Me.TBdctt.Multiline = True
        Me.TBdctt.Name = "TBdctt"
        Me.TBdctt.Size = New System.Drawing.Size(238, 140)
        Me.TBdctt.TabIndex = 11
        '
        'DTPnstt
        '
        Me.DTPnstt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ThuthuBindingSource, "ngaysinhtt", True))
        Me.DTPnstt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPnstt.Location = New System.Drawing.Point(150, 142)
        Me.DTPnstt.Name = "DTPnstt"
        Me.DTPnstt.Size = New System.Drawing.Size(200, 22)
        Me.DTPnstt.TabIndex = 10
        '
        'CBgttt
        '
        Me.CBgttt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ThuthuBindingSource, "gioitinhtt", True))
        Me.CBgttt.FormattingEnabled = True
        Me.CBgttt.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.CBgttt.Location = New System.Drawing.Point(150, 112)
        Me.CBgttt.Name = "CBgttt"
        Me.CBgttt.Size = New System.Drawing.Size(200, 24)
        Me.CBgttt.TabIndex = 9
        '
        'TBhttt
        '
        Me.TBhttt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ThuthuBindingSource, "hotentt", True))
        Me.TBhttt.Location = New System.Drawing.Point(150, 84)
        Me.TBhttt.Name = "TBhttt"
        Me.TBhttt.Size = New System.Drawing.Size(200, 22)
        Me.TBhttt.TabIndex = 8
        '
        'TBmtt
        '
        Me.TBmtt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ThuthuBindingSource, "matt", True))
        Me.TBmtt.Location = New System.Drawing.Point(150, 56)
        Me.TBmtt.Name = "TBmtt"
        Me.TBmtt.Size = New System.Drawing.Size(200, 22)
        Me.TBmtt.TabIndex = 7
        '
        'LBgctt
        '
        Me.LBgctt.AutoSize = True
        Me.LBgctt.ForeColor = System.Drawing.Color.Black
        Me.LBgctt.Location = New System.Drawing.Point(722, 56)
        Me.LBgctt.Name = "LBgctt"
        Me.LBgctt.Size = New System.Drawing.Size(57, 17)
        Me.LBgctt.TabIndex = 6
        Me.LBgctt.Text = "Ghi chú"
        '
        'LBdctt
        '
        Me.LBdctt.AutoSize = True
        Me.LBdctt.ForeColor = System.Drawing.Color.Black
        Me.LBdctt.Location = New System.Drawing.Point(383, 54)
        Me.LBdctt.Name = "LBdctt"
        Me.LBdctt.Size = New System.Drawing.Size(51, 17)
        Me.LBdctt.TabIndex = 5
        Me.LBdctt.Text = "Địa chỉ"
        '
        'LBnstt
        '
        Me.LBnstt.AutoSize = True
        Me.LBnstt.ForeColor = System.Drawing.Color.Black
        Me.LBnstt.Location = New System.Drawing.Point(53, 145)
        Me.LBnstt.Name = "LBnstt"
        Me.LBnstt.Size = New System.Drawing.Size(71, 17)
        Me.LBnstt.TabIndex = 4
        Me.LBnstt.Text = "Ngày sinh"
        '
        'LBgttt
        '
        Me.LBgttt.AutoSize = True
        Me.LBgttt.ForeColor = System.Drawing.Color.Black
        Me.LBgttt.Location = New System.Drawing.Point(53, 117)
        Me.LBgttt.Name = "LBgttt"
        Me.LBgttt.Size = New System.Drawing.Size(60, 17)
        Me.LBgttt.TabIndex = 3
        Me.LBgttt.Text = "Giới tinh"
        '
        'LBhttt
        '
        Me.LBhttt.AutoSize = True
        Me.LBhttt.ForeColor = System.Drawing.Color.Black
        Me.LBhttt.Location = New System.Drawing.Point(53, 87)
        Me.LBhttt.Name = "LBhttt"
        Me.LBhttt.Size = New System.Drawing.Size(50, 17)
        Me.LBhttt.TabIndex = 2
        Me.LBhttt.Text = "Họ tên"
        '
        'LBmtt
        '
        Me.LBmtt.AutoSize = True
        Me.LBmtt.ForeColor = System.Drawing.Color.Black
        Me.LBmtt.Location = New System.Drawing.Point(53, 60)
        Me.LBmtt.Name = "LBmtt"
        Me.LBmtt.Size = New System.Drawing.Size(75, 17)
        Me.LBmtt.TabIndex = 1
        Me.LBmtt.Text = "Mã thủ thư"
        '
        'DataGridViewtt
        '
        Me.DataGridViewtt.AutoGenerateColumns = False
        Me.DataGridViewtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewtt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MattDataGridViewTextBoxColumn, Me.HotenttDataGridViewTextBoxColumn, Me.GioitinhttDataGridViewTextBoxColumn, Me.NgaysinhttDataGridViewTextBoxColumn, Me.SdtttDataGridViewTextBoxColumn, Me.DiachittDataGridViewTextBoxColumn, Me.GhichuttDataGridViewTextBoxColumn})
        Me.DataGridViewtt.DataSource = Me.ThuthuBindingSource
        Me.DataGridViewtt.Location = New System.Drawing.Point(0, 1)
        Me.DataGridViewtt.Name = "DataGridViewtt"
        Me.DataGridViewtt.RowHeadersWidth = 51
        Me.DataGridViewtt.RowTemplate.Height = 24
        Me.DataGridViewtt.Size = New System.Drawing.Size(1102, 322)
        Me.DataGridViewtt.TabIndex = 3
        '
        'ThuthuTableAdapter
        '
        Me.ThuthuTableAdapter.ClearBeforeFill = True
        '
        'OleDbSelectCommandtt
        '
        Me.OleDbSelectCommandtt.CommandText = "SELECT thuthu.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     thuthu"
        Me.OleDbSelectCommandtt.Connection = Me.OleDbConnection
        '
        'OleDbConnection
        '
        Me.OleDbConnection.ConnectionString = "Provider=SQLOLEDB.1;Data Source=ADMIN;Password=123;User ID=sa;Initial Catalog=QLT" &
    "V"
        '
        'OleDbInsertCommandtt
        '
        Me.OleDbInsertCommandtt.CommandText = "INSERT INTO [thuthu] ([matt], [hotentt], [gioitinhtt], [ngaysinhtt], [diachitt], " &
    "[sdttt], [ghichutt]) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommandtt.Connection = Me.OleDbConnection
        Me.OleDbInsertCommandtt.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("matt", System.Data.OleDb.OleDbType.VarWChar, 0, "matt"), New System.Data.OleDb.OleDbParameter("hotentt", System.Data.OleDb.OleDbType.VarWChar, 0, "hotentt"), New System.Data.OleDb.OleDbParameter("gioitinhtt", System.Data.OleDb.OleDbType.VarWChar, 0, "gioitinhtt"), New System.Data.OleDb.OleDbParameter("ngaysinhtt", System.Data.OleDb.OleDbType.VarWChar, 0, "ngaysinhtt"), New System.Data.OleDb.OleDbParameter("diachitt", System.Data.OleDb.OleDbType.VarWChar, 0, "diachitt"), New System.Data.OleDb.OleDbParameter("sdttt", System.Data.OleDb.OleDbType.VarWChar, 0, "sdttt"), New System.Data.OleDb.OleDbParameter("ghichutt", System.Data.OleDb.OleDbType.VarWChar, 0, "ghichutt")})
        '
        'OleDbUpdateCommandtt
        '
        Me.OleDbUpdateCommandtt.CommandText = resources.GetString("OleDbUpdateCommandtt.CommandText")
        Me.OleDbUpdateCommandtt.Connection = Me.OleDbConnection
        Me.OleDbUpdateCommandtt.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("matt", System.Data.OleDb.OleDbType.VarWChar, 0, "matt"), New System.Data.OleDb.OleDbParameter("hotentt", System.Data.OleDb.OleDbType.VarWChar, 0, "hotentt"), New System.Data.OleDb.OleDbParameter("gioitinhtt", System.Data.OleDb.OleDbType.VarWChar, 0, "gioitinhtt"), New System.Data.OleDb.OleDbParameter("ngaysinhtt", System.Data.OleDb.OleDbType.VarWChar, 0, "ngaysinhtt"), New System.Data.OleDb.OleDbParameter("diachitt", System.Data.OleDb.OleDbType.VarWChar, 0, "diachitt"), New System.Data.OleDb.OleDbParameter("sdttt", System.Data.OleDb.OleDbType.VarWChar, 0, "sdttt"), New System.Data.OleDb.OleDbParameter("ghichutt", System.Data.OleDb.OleDbType.VarWChar, 0, "ghichutt"), New System.Data.OleDb.OleDbParameter("Original_matt", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "matt", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_hotentt", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hotentt", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_gioitinhtt", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "gioitinhtt", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_gioitinhtt", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "gioitinhtt", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ngaysinhtt", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ngaysinhtt", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ngaysinhtt", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ngaysinhtt", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_diachitt", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "diachitt", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_sdttt", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sdttt", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ghichutt", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ghichutt", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ghichutt", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ghichutt", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommandtt
        '
        Me.OleDbDeleteCommandtt.CommandText = resources.GetString("OleDbDeleteCommandtt.CommandText")
        Me.OleDbDeleteCommandtt.Connection = Me.OleDbConnection
        Me.OleDbDeleteCommandtt.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_matt", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "matt", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_hotentt", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hotentt", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_gioitinhtt", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "gioitinhtt", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_gioitinhtt", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "gioitinhtt", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ngaysinhtt", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ngaysinhtt", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ngaysinhtt", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ngaysinhtt", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_diachitt", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "diachitt", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_sdttt", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sdttt", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ghichutt", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ghichutt", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ghichutt", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ghichutt", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdaptertt
        '
        Me.OleDbDataAdaptertt.DeleteCommand = Me.OleDbDeleteCommandtt
        Me.OleDbDataAdaptertt.InsertCommand = Me.OleDbInsertCommandtt
        Me.OleDbDataAdaptertt.SelectCommand = Me.OleDbSelectCommandtt
        Me.OleDbDataAdaptertt.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "thuthu", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("matt", "matt"), New System.Data.Common.DataColumnMapping("hotentt", "hotentt"), New System.Data.Common.DataColumnMapping("gioitinhtt", "gioitinhtt"), New System.Data.Common.DataColumnMapping("ngaysinhtt", "ngaysinhtt"), New System.Data.Common.DataColumnMapping("diachitt", "diachitt"), New System.Data.Common.DataColumnMapping("sdttt", "sdttt"), New System.Data.Common.DataColumnMapping("ghichutt", "ghichutt")})})
        Me.OleDbDataAdaptertt.UpdateCommand = Me.OleDbUpdateCommandtt
        '
        'MattDataGridViewTextBoxColumn
        '
        Me.MattDataGridViewTextBoxColumn.DataPropertyName = "matt"
        Me.MattDataGridViewTextBoxColumn.HeaderText = "Mã thủ thư"
        Me.MattDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MattDataGridViewTextBoxColumn.Name = "MattDataGridViewTextBoxColumn"
        Me.MattDataGridViewTextBoxColumn.Width = 125
        '
        'HotenttDataGridViewTextBoxColumn
        '
        Me.HotenttDataGridViewTextBoxColumn.DataPropertyName = "hotentt"
        Me.HotenttDataGridViewTextBoxColumn.HeaderText = "Họ tên thủ thư"
        Me.HotenttDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HotenttDataGridViewTextBoxColumn.Name = "HotenttDataGridViewTextBoxColumn"
        Me.HotenttDataGridViewTextBoxColumn.Width = 145
        '
        'GioitinhttDataGridViewTextBoxColumn
        '
        Me.GioitinhttDataGridViewTextBoxColumn.DataPropertyName = "gioitinhtt"
        Me.GioitinhttDataGridViewTextBoxColumn.HeaderText = "Giới tính"
        Me.GioitinhttDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GioitinhttDataGridViewTextBoxColumn.Name = "GioitinhttDataGridViewTextBoxColumn"
        Me.GioitinhttDataGridViewTextBoxColumn.Width = 125
        '
        'NgaysinhttDataGridViewTextBoxColumn
        '
        Me.NgaysinhttDataGridViewTextBoxColumn.DataPropertyName = "ngaysinhtt"
        Me.NgaysinhttDataGridViewTextBoxColumn.HeaderText = "Ngày sinh"
        Me.NgaysinhttDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NgaysinhttDataGridViewTextBoxColumn.Name = "NgaysinhttDataGridViewTextBoxColumn"
        Me.NgaysinhttDataGridViewTextBoxColumn.Width = 125
        '
        'SdtttDataGridViewTextBoxColumn
        '
        Me.SdtttDataGridViewTextBoxColumn.DataPropertyName = "sdttt"
        Me.SdtttDataGridViewTextBoxColumn.HeaderText = "Số điện thoại"
        Me.SdtttDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SdtttDataGridViewTextBoxColumn.Name = "SdtttDataGridViewTextBoxColumn"
        Me.SdtttDataGridViewTextBoxColumn.Width = 125
        '
        'DiachittDataGridViewTextBoxColumn
        '
        Me.DiachittDataGridViewTextBoxColumn.DataPropertyName = "diachitt"
        Me.DiachittDataGridViewTextBoxColumn.HeaderText = "Địa chỉ"
        Me.DiachittDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiachittDataGridViewTextBoxColumn.Name = "DiachittDataGridViewTextBoxColumn"
        Me.DiachittDataGridViewTextBoxColumn.Width = 300
        '
        'GhichuttDataGridViewTextBoxColumn
        '
        Me.GhichuttDataGridViewTextBoxColumn.DataPropertyName = "ghichutt"
        Me.GhichuttDataGridViewTextBoxColumn.HeaderText = "Ghi chú"
        Me.GhichuttDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GhichuttDataGridViewTextBoxColumn.Name = "GhichuttDataGridViewTextBoxColumn"
        Me.GhichuttDataGridViewTextBoxColumn.Width = 500
        '
        'Formthuthu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 612)
        Me.Controls.Add(Me.GBtt)
        Me.Controls.Add(Me.DataGridViewtt)
        Me.Name = "Formthuthu"
        Me.Text = "Quản lý thông tin thủ thư"
        Me.GBtt.ResumeLayout(False)
        Me.GBtt.PerformLayout()
        CType(Me.ThuthuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewtt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBtt As GroupBox
    Friend WithEvents BTttt As Button
    Friend WithEvents BTtktt As Button
    Friend WithEvents BTloadtt As Button
    Friend WithEvents LBdemtt As Label
    Friend WithEvents BThuytt As Button
    Friend WithEvents BTluutt As Button
    Friend WithEvents TBsdttt As TextBox
    Friend WithEvents LBsdttt As Label
    Friend WithEvents BTxoatt As Button
    Friend WithEvents BTsuatt As Button
    Friend WithEvents BTthemtt As Button
    Friend WithEvents TBgctt As TextBox
    Friend WithEvents TBdctt As TextBox
    Friend WithEvents DTPnstt As DateTimePicker
    Friend WithEvents CBgttt As ComboBox
    Friend WithEvents TBhttt As TextBox
    Friend WithEvents TBmtt As TextBox
    Friend WithEvents LBgctt As Label
    Friend WithEvents LBdctt As Label
    Friend WithEvents LBnstt As Label
    Friend WithEvents LBgttt As Label
    Friend WithEvents LBhttt As Label
    Friend WithEvents LBmtt As Label
    Friend WithEvents DataGridViewtt As DataGridView
    Friend WithEvents DataSet As DataSet
    Friend WithEvents ThuthuBindingSource As BindingSource
    Friend WithEvents ThuthuTableAdapter As DataSetTableAdapters.thuthuTableAdapter
    Friend WithEvents OleDbSelectCommandtt As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommandtt As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommandtt As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommandtt As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdaptertt As OleDb.OleDbDataAdapter
    Friend WithEvents MattDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HotenttDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GioitinhttDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaysinhttDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SdtttDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiachittDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GhichuttDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
