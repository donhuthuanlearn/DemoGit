<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formtacgia
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
        Me.BTttg = New System.Windows.Forms.Button()
        Me.BTtktg = New System.Windows.Forms.Button()
        Me.BTloadtg = New System.Windows.Forms.Button()
        Me.LBdemtg = New System.Windows.Forms.Label()
        Me.BThuytg = New System.Windows.Forms.Button()
        Me.BTluutg = New System.Windows.Forms.Button()
        Me.BTxoatg = New System.Windows.Forms.Button()
        Me.BTsuatg = New System.Windows.Forms.Button()
        Me.BTthemtg = New System.Windows.Forms.Button()
        Me.TBtstg = New System.Windows.Forms.TextBox()
        Me.TacgiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New QuanLyThuVien.DataSet()
        Me.TBhttg = New System.Windows.Forms.TextBox()
        Me.TBmtg = New System.Windows.Forms.TextBox()
        Me.LBtstg = New System.Windows.Forms.Label()
        Me.LBhttg = New System.Windows.Forms.Label()
        Me.LBmtg = New System.Windows.Forms.Label()
        Me.DataGridViewtg = New System.Windows.Forms.DataGridView()
        Me.PictureBoxtg = New System.Windows.Forms.PictureBox()
        Me.TacgiaTableAdapter = New QuanLyThuVien.DataSetTableAdapters.tacgiaTableAdapter()
        Me.OleDbSelectCommandtg = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommandtg = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommandtg = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommandtg = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdaptertg = New System.Data.OleDb.OleDbDataAdapter()
        Me.MatgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HotentgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TieusutgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TacgiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewtg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTttg
        '
        Me.BTttg.ForeColor = System.Drawing.Color.Blue
        Me.BTttg.Location = New System.Drawing.Point(149, 480)
        Me.BTttg.Name = "BTttg"
        Me.BTttg.Size = New System.Drawing.Size(97, 32)
        Me.BTttg.TabIndex = 48
        Me.BTttg.Text = "Tìm"
        Me.BTttg.UseVisualStyleBackColor = True
        '
        'BTtktg
        '
        Me.BTtktg.ForeColor = System.Drawing.Color.Blue
        Me.BTtktg.Location = New System.Drawing.Point(149, 480)
        Me.BTtktg.Name = "BTtktg"
        Me.BTtktg.Size = New System.Drawing.Size(97, 32)
        Me.BTtktg.TabIndex = 47
        Me.BTtktg.Text = "Tìm kiếm"
        Me.BTtktg.UseVisualStyleBackColor = True
        '
        'BTloadtg
        '
        Me.BTloadtg.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTloadtg.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTloadtg.ForeColor = System.Drawing.Color.Red
        Me.BTloadtg.Location = New System.Drawing.Point(243, 0)
        Me.BTloadtg.Name = "BTloadtg"
        Me.BTloadtg.Size = New System.Drawing.Size(36, 33)
        Me.BTloadtg.TabIndex = 46
        Me.BTloadtg.Text = "O"
        Me.BTloadtg.UseVisualStyleBackColor = False
        '
        'LBdemtg
        '
        Me.LBdemtg.AutoSize = True
        Me.LBdemtg.ForeColor = System.Drawing.Color.Red
        Me.LBdemtg.Location = New System.Drawing.Point(11, 116)
        Me.LBdemtg.Name = "LBdemtg"
        Me.LBdemtg.Size = New System.Drawing.Size(114, 17)
        Me.LBdemtg.TabIndex = 45
        Me.LBdemtg.Text = "Tổng số tác giả :"
        '
        'BThuytg
        '
        Me.BThuytg.ForeColor = System.Drawing.Color.Blue
        Me.BThuytg.Location = New System.Drawing.Point(149, 442)
        Me.BThuytg.Name = "BThuytg"
        Me.BThuytg.Size = New System.Drawing.Size(97, 32)
        Me.BThuytg.TabIndex = 43
        Me.BThuytg.Text = "Hủy"
        Me.BThuytg.UseVisualStyleBackColor = True
        '
        'BTluutg
        '
        Me.BTluutg.ForeColor = System.Drawing.Color.Blue
        Me.BTluutg.Location = New System.Drawing.Point(14, 442)
        Me.BTluutg.Name = "BTluutg"
        Me.BTluutg.Size = New System.Drawing.Size(97, 32)
        Me.BTluutg.TabIndex = 42
        Me.BTluutg.Text = "Lưu"
        Me.BTluutg.UseVisualStyleBackColor = True
        '
        'BTxoatg
        '
        Me.BTxoatg.ForeColor = System.Drawing.Color.Blue
        Me.BTxoatg.Location = New System.Drawing.Point(14, 480)
        Me.BTxoatg.Name = "BTxoatg"
        Me.BTxoatg.Size = New System.Drawing.Size(97, 32)
        Me.BTxoatg.TabIndex = 41
        Me.BTxoatg.Text = "Xóa"
        Me.BTxoatg.UseVisualStyleBackColor = True
        '
        'BTsuatg
        '
        Me.BTsuatg.ForeColor = System.Drawing.Color.Blue
        Me.BTsuatg.Location = New System.Drawing.Point(149, 442)
        Me.BTsuatg.Name = "BTsuatg"
        Me.BTsuatg.Size = New System.Drawing.Size(97, 32)
        Me.BTsuatg.TabIndex = 40
        Me.BTsuatg.Text = "Sửa"
        Me.BTsuatg.UseVisualStyleBackColor = True
        '
        'BTthemtg
        '
        Me.BTthemtg.ForeColor = System.Drawing.Color.Blue
        Me.BTthemtg.Location = New System.Drawing.Point(14, 442)
        Me.BTthemtg.Name = "BTthemtg"
        Me.BTthemtg.Size = New System.Drawing.Size(97, 32)
        Me.BTthemtg.TabIndex = 39
        Me.BTthemtg.Text = "Thêm"
        Me.BTthemtg.UseVisualStyleBackColor = True
        '
        'TBtstg
        '
        Me.TBtstg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TacgiaBindingSource, "tieusutg", True))
        Me.TBtstg.Location = New System.Drawing.Point(88, 212)
        Me.TBtstg.Multiline = True
        Me.TBtstg.Name = "TBtstg"
        Me.TBtstg.Size = New System.Drawing.Size(178, 155)
        Me.TBtstg.TabIndex = 38
        '
        'TacgiaBindingSource
        '
        Me.TacgiaBindingSource.DataMember = "tacgia"
        Me.TacgiaBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBhttg
        '
        Me.TBhttg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TacgiaBindingSource, "hotentg", True))
        Me.TBhttg.Location = New System.Drawing.Point(88, 182)
        Me.TBhttg.Name = "TBhttg"
        Me.TBhttg.Size = New System.Drawing.Size(178, 22)
        Me.TBhttg.TabIndex = 37
        '
        'TBmtg
        '
        Me.TBmtg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TacgiaBindingSource, "matg", True))
        Me.TBmtg.Location = New System.Drawing.Point(88, 154)
        Me.TBmtg.Name = "TBmtg"
        Me.TBmtg.Size = New System.Drawing.Size(178, 22)
        Me.TBmtg.TabIndex = 36
        '
        'LBtstg
        '
        Me.LBtstg.AutoSize = True
        Me.LBtstg.ForeColor = System.Drawing.Color.Black
        Me.LBtstg.Location = New System.Drawing.Point(7, 212)
        Me.LBtstg.Name = "LBtstg"
        Me.LBtstg.Size = New System.Drawing.Size(55, 17)
        Me.LBtstg.TabIndex = 35
        Me.LBtstg.Text = "Tiểu sử"
        '
        'LBhttg
        '
        Me.LBhttg.AutoSize = True
        Me.LBhttg.ForeColor = System.Drawing.Color.Black
        Me.LBhttg.Location = New System.Drawing.Point(8, 185)
        Me.LBhttg.Name = "LBhttg"
        Me.LBhttg.Size = New System.Drawing.Size(50, 17)
        Me.LBhttg.TabIndex = 34
        Me.LBhttg.Text = "Họ tên"
        '
        'LBmtg
        '
        Me.LBmtg.AutoSize = True
        Me.LBmtg.ForeColor = System.Drawing.Color.Black
        Me.LBmtg.Location = New System.Drawing.Point(7, 159)
        Me.LBmtg.Name = "LBmtg"
        Me.LBmtg.Size = New System.Drawing.Size(73, 17)
        Me.LBmtg.TabIndex = 33
        Me.LBmtg.Text = "Mã tác giả"
        '
        'DataGridViewtg
        '
        Me.DataGridViewtg.AutoGenerateColumns = False
        Me.DataGridViewtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatgDataGridViewTextBoxColumn, Me.HotentgDataGridViewTextBoxColumn, Me.TieusutgDataGridViewTextBoxColumn})
        Me.DataGridViewtg.DataSource = Me.TacgiaBindingSource
        Me.DataGridViewtg.Location = New System.Drawing.Point(285, 0)
        Me.DataGridViewtg.Name = "DataGridViewtg"
        Me.DataGridViewtg.RowHeadersWidth = 51
        Me.DataGridViewtg.RowTemplate.Height = 24
        Me.DataGridViewtg.Size = New System.Drawing.Size(563, 534)
        Me.DataGridViewtg.TabIndex = 32
        '
        'PictureBoxtg
        '
        Me.PictureBoxtg.Image = Global.QuanLyThuVien.My.Resources.Resources.anhnentg
        Me.PictureBoxtg.Location = New System.Drawing.Point(104, 22)
        Me.PictureBoxtg.Name = "PictureBoxtg"
        Me.PictureBoxtg.Size = New System.Drawing.Size(61, 77)
        Me.PictureBoxtg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxtg.TabIndex = 44
        Me.PictureBoxtg.TabStop = False
        '
        'TacgiaTableAdapter
        '
        Me.TacgiaTableAdapter.ClearBeforeFill = True
        '
        'OleDbSelectCommandtg
        '
        Me.OleDbSelectCommandtg.CommandText = "SELECT tacgia.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     tacgia"
        Me.OleDbSelectCommandtg.Connection = Me.OleDbConnection
        '
        'OleDbConnection
        '
        Me.OleDbConnection.ConnectionString = "Provider=SQLOLEDB.1;Data Source=ADMIN;Password=123;User ID=sa;Initial Catalog=QLT" &
    "V"
        '
        'OleDbInsertCommandtg
        '
        Me.OleDbInsertCommandtg.CommandText = "INSERT INTO [tacgia] ([matg], [hotentg], [tieusutg]) VALUES (?, ?, ?)"
        Me.OleDbInsertCommandtg.Connection = Me.OleDbConnection
        Me.OleDbInsertCommandtg.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("matg", System.Data.OleDb.OleDbType.VarWChar, 0, "matg"), New System.Data.OleDb.OleDbParameter("hotentg", System.Data.OleDb.OleDbType.VarWChar, 0, "hotentg"), New System.Data.OleDb.OleDbParameter("tieusutg", System.Data.OleDb.OleDbType.VarWChar, 0, "tieusutg")})
        '
        'OleDbUpdateCommandtg
        '
        Me.OleDbUpdateCommandtg.CommandText = "UPDATE [tacgia] SET [matg] = ?, [hotentg] = ?, [tieusutg] = ? WHERE (([matg] = ?)" &
    " AND ([hotentg] = ?) AND ((? = 1 AND [tieusutg] IS NULL) OR ([tieusutg] = ?)))"
        Me.OleDbUpdateCommandtg.Connection = Me.OleDbConnection
        Me.OleDbUpdateCommandtg.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("matg", System.Data.OleDb.OleDbType.VarWChar, 0, "matg"), New System.Data.OleDb.OleDbParameter("hotentg", System.Data.OleDb.OleDbType.VarWChar, 0, "hotentg"), New System.Data.OleDb.OleDbParameter("tieusutg", System.Data.OleDb.OleDbType.VarWChar, 0, "tieusutg"), New System.Data.OleDb.OleDbParameter("Original_matg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "matg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_hotentg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hotentg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_tieusutg", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tieusutg", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_tieusutg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tieusutg", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommandtg
        '
        Me.OleDbDeleteCommandtg.CommandText = "DELETE FROM [tacgia] WHERE (([matg] = ?) AND ([hotentg] = ?) AND ((? = 1 AND [tie" &
    "usutg] IS NULL) OR ([tieusutg] = ?)))"
        Me.OleDbDeleteCommandtg.Connection = Me.OleDbConnection
        Me.OleDbDeleteCommandtg.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_matg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "matg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_hotentg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hotentg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_tieusutg", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tieusutg", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_tieusutg", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tieusutg", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdaptertg
        '
        Me.OleDbDataAdaptertg.DeleteCommand = Me.OleDbDeleteCommandtg
        Me.OleDbDataAdaptertg.InsertCommand = Me.OleDbInsertCommandtg
        Me.OleDbDataAdaptertg.SelectCommand = Me.OleDbSelectCommandtg
        Me.OleDbDataAdaptertg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tacgia", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("matg", "matg"), New System.Data.Common.DataColumnMapping("hotentg", "hotentg"), New System.Data.Common.DataColumnMapping("tieusutg", "tieusutg")})})
        Me.OleDbDataAdaptertg.UpdateCommand = Me.OleDbUpdateCommandtg
        '
        'MatgDataGridViewTextBoxColumn
        '
        Me.MatgDataGridViewTextBoxColumn.DataPropertyName = "matg"
        Me.MatgDataGridViewTextBoxColumn.HeaderText = "Mã tác giả"
        Me.MatgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MatgDataGridViewTextBoxColumn.Name = "MatgDataGridViewTextBoxColumn"
        Me.MatgDataGridViewTextBoxColumn.Width = 125
        '
        'HotentgDataGridViewTextBoxColumn
        '
        Me.HotentgDataGridViewTextBoxColumn.DataPropertyName = "hotentg"
        Me.HotentgDataGridViewTextBoxColumn.HeaderText = "Họ tên"
        Me.HotentgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HotentgDataGridViewTextBoxColumn.Name = "HotentgDataGridViewTextBoxColumn"
        Me.HotentgDataGridViewTextBoxColumn.Width = 140
        '
        'TieusutgDataGridViewTextBoxColumn
        '
        Me.TieusutgDataGridViewTextBoxColumn.DataPropertyName = "tieusutg"
        Me.TieusutgDataGridViewTextBoxColumn.HeaderText = "Tiểu sử"
        Me.TieusutgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TieusutgDataGridViewTextBoxColumn.Name = "TieusutgDataGridViewTextBoxColumn"
        Me.TieusutgDataGridViewTextBoxColumn.Width = 500
        '
        'Formtacgia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 534)
        Me.Controls.Add(Me.BTttg)
        Me.Controls.Add(Me.BTtktg)
        Me.Controls.Add(Me.BTloadtg)
        Me.Controls.Add(Me.LBdemtg)
        Me.Controls.Add(Me.PictureBoxtg)
        Me.Controls.Add(Me.BThuytg)
        Me.Controls.Add(Me.BTluutg)
        Me.Controls.Add(Me.BTxoatg)
        Me.Controls.Add(Me.BTsuatg)
        Me.Controls.Add(Me.BTthemtg)
        Me.Controls.Add(Me.TBtstg)
        Me.Controls.Add(Me.TBhttg)
        Me.Controls.Add(Me.TBmtg)
        Me.Controls.Add(Me.LBtstg)
        Me.Controls.Add(Me.LBhttg)
        Me.Controls.Add(Me.LBmtg)
        Me.Controls.Add(Me.DataGridViewtg)
        Me.Name = "Formtacgia"
        Me.Text = "Quản lý thông tin tác giả"
        CType(Me.TacgiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewtg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTttg As Button
    Friend WithEvents BTtktg As Button
    Friend WithEvents BTloadtg As Button
    Friend WithEvents LBdemtg As Label
    Friend WithEvents PictureBoxtg As PictureBox
    Friend WithEvents BThuytg As Button
    Friend WithEvents BTluutg As Button
    Friend WithEvents BTxoatg As Button
    Friend WithEvents BTsuatg As Button
    Friend WithEvents BTthemtg As Button
    Friend WithEvents TBtstg As TextBox
    Friend WithEvents TBhttg As TextBox
    Friend WithEvents TBmtg As TextBox
    Friend WithEvents LBtstg As Label
    Friend WithEvents LBhttg As Label
    Friend WithEvents LBmtg As Label
    Friend WithEvents DataGridViewtg As DataGridView
    Friend WithEvents DataSet As DataSet
    Friend WithEvents TacgiaBindingSource As BindingSource
    Friend WithEvents TacgiaTableAdapter As DataSetTableAdapters.tacgiaTableAdapter
    Friend WithEvents OleDbSelectCommandtg As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommandtg As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommandtg As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommandtg As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdaptertg As OleDb.OleDbDataAdapter
    Friend WithEvents MatgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HotentgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TieusutgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
