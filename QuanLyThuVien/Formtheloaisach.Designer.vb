<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formtheloaisach
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
        Me.BTttl = New System.Windows.Forms.Button()
        Me.BTtktl = New System.Windows.Forms.Button()
        Me.BTloadtl = New System.Windows.Forms.Button()
        Me.LBdemtl = New System.Windows.Forms.Label()
        Me.BThuytl = New System.Windows.Forms.Button()
        Me.BTluutl = New System.Windows.Forms.Button()
        Me.BTxoatl = New System.Windows.Forms.Button()
        Me.BTsuatl = New System.Windows.Forms.Button()
        Me.BTthemtl = New System.Windows.Forms.Button()
        Me.TBmttl = New System.Windows.Forms.TextBox()
        Me.TheloaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New QuanLyThuVien.DataSet()
        Me.TBhttl = New System.Windows.Forms.TextBox()
        Me.TBmtl = New System.Windows.Forms.TextBox()
        Me.LBmttl = New System.Windows.Forms.Label()
        Me.LBhttl = New System.Windows.Forms.Label()
        Me.LBmtl = New System.Windows.Forms.Label()
        Me.DataGridViewtl = New System.Windows.Forms.DataGridView()
        Me.PictureBoxtl = New System.Windows.Forms.PictureBox()
        Me.TheloaiTableAdapter = New QuanLyThuVien.DataSetTableAdapters.theloaiTableAdapter()
        Me.OleDbSelectCommandtl = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommandtl = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommandtl = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommandtl = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdaptertl = New System.Data.OleDb.OleDbDataAdapter()
        Me.MatlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HotentlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotatlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TheloaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewtl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxtl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTttl
        '
        Me.BTttl.ForeColor = System.Drawing.Color.Blue
        Me.BTttl.Location = New System.Drawing.Point(146, 495)
        Me.BTttl.Name = "BTttl"
        Me.BTttl.Size = New System.Drawing.Size(97, 27)
        Me.BTttl.TabIndex = 63
        Me.BTttl.Text = "Tìm"
        Me.BTttl.UseVisualStyleBackColor = True
        '
        'BTtktl
        '
        Me.BTtktl.ForeColor = System.Drawing.Color.Blue
        Me.BTtktl.Location = New System.Drawing.Point(146, 495)
        Me.BTtktl.Name = "BTtktl"
        Me.BTtktl.Size = New System.Drawing.Size(97, 27)
        Me.BTtktl.TabIndex = 62
        Me.BTtktl.Text = "Tìm kiếm"
        Me.BTtktl.UseVisualStyleBackColor = True
        '
        'BTloadtl
        '
        Me.BTloadtl.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTloadtl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTloadtl.ForeColor = System.Drawing.Color.Red
        Me.BTloadtl.Location = New System.Drawing.Point(240, 0)
        Me.BTloadtl.Name = "BTloadtl"
        Me.BTloadtl.Size = New System.Drawing.Size(36, 33)
        Me.BTloadtl.TabIndex = 61
        Me.BTloadtl.Text = "O"
        Me.BTloadtl.UseVisualStyleBackColor = False
        '
        'LBdemtl
        '
        Me.LBdemtl.AutoSize = True
        Me.LBdemtl.ForeColor = System.Drawing.Color.Red
        Me.LBdemtl.Location = New System.Drawing.Point(8, 116)
        Me.LBdemtl.Name = "LBdemtl"
        Me.LBdemtl.Size = New System.Drawing.Size(114, 17)
        Me.LBdemtl.TabIndex = 60
        Me.LBdemtl.Text = "Tổng số thể loại:"
        '
        'BThuytl
        '
        Me.BThuytl.ForeColor = System.Drawing.Color.Blue
        Me.BThuytl.Location = New System.Drawing.Point(146, 453)
        Me.BThuytl.Name = "BThuytl"
        Me.BThuytl.Size = New System.Drawing.Size(97, 27)
        Me.BThuytl.TabIndex = 58
        Me.BThuytl.Text = "Hủy"
        Me.BThuytl.UseVisualStyleBackColor = True
        '
        'BTluutl
        '
        Me.BTluutl.ForeColor = System.Drawing.Color.Blue
        Me.BTluutl.Location = New System.Drawing.Point(11, 453)
        Me.BTluutl.Name = "BTluutl"
        Me.BTluutl.Size = New System.Drawing.Size(97, 27)
        Me.BTluutl.TabIndex = 57
        Me.BTluutl.Text = "Lưu"
        Me.BTluutl.UseVisualStyleBackColor = True
        '
        'BTxoatl
        '
        Me.BTxoatl.ForeColor = System.Drawing.Color.Blue
        Me.BTxoatl.Location = New System.Drawing.Point(11, 495)
        Me.BTxoatl.Name = "BTxoatl"
        Me.BTxoatl.Size = New System.Drawing.Size(97, 27)
        Me.BTxoatl.TabIndex = 56
        Me.BTxoatl.Text = "Xóa"
        Me.BTxoatl.UseVisualStyleBackColor = True
        '
        'BTsuatl
        '
        Me.BTsuatl.ForeColor = System.Drawing.Color.Blue
        Me.BTsuatl.Location = New System.Drawing.Point(146, 453)
        Me.BTsuatl.Name = "BTsuatl"
        Me.BTsuatl.Size = New System.Drawing.Size(97, 27)
        Me.BTsuatl.TabIndex = 55
        Me.BTsuatl.Text = "Sửa"
        Me.BTsuatl.UseVisualStyleBackColor = True
        '
        'BTthemtl
        '
        Me.BTthemtl.ForeColor = System.Drawing.Color.Blue
        Me.BTthemtl.Location = New System.Drawing.Point(11, 453)
        Me.BTthemtl.Name = "BTthemtl"
        Me.BTthemtl.Size = New System.Drawing.Size(97, 27)
        Me.BTthemtl.TabIndex = 54
        Me.BTthemtl.Text = "Thêm"
        Me.BTthemtl.UseVisualStyleBackColor = True
        '
        'TBmttl
        '
        Me.TBmttl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TheloaiBindingSource, "motatl", True))
        Me.TBmttl.Location = New System.Drawing.Point(85, 212)
        Me.TBmttl.Multiline = True
        Me.TBmttl.Name = "TBmttl"
        Me.TBmttl.Size = New System.Drawing.Size(178, 155)
        Me.TBmttl.TabIndex = 53
        '
        'TheloaiBindingSource
        '
        Me.TheloaiBindingSource.DataMember = "theloai"
        Me.TheloaiBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBhttl
        '
        Me.TBhttl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TheloaiBindingSource, "hotentl", True))
        Me.TBhttl.Location = New System.Drawing.Point(85, 182)
        Me.TBhttl.Name = "TBhttl"
        Me.TBhttl.Size = New System.Drawing.Size(178, 22)
        Me.TBhttl.TabIndex = 52
        '
        'TBmtl
        '
        Me.TBmtl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TheloaiBindingSource, "matl", True))
        Me.TBmtl.Location = New System.Drawing.Point(85, 154)
        Me.TBmtl.Name = "TBmtl"
        Me.TBmtl.Size = New System.Drawing.Size(178, 22)
        Me.TBmtl.TabIndex = 51
        '
        'LBmttl
        '
        Me.LBmttl.AutoSize = True
        Me.LBmttl.ForeColor = System.Drawing.Color.Black
        Me.LBmttl.Location = New System.Drawing.Point(4, 212)
        Me.LBmttl.Name = "LBmttl"
        Me.LBmttl.Size = New System.Drawing.Size(43, 17)
        Me.LBmttl.TabIndex = 50
        Me.LBmttl.Text = "Mô tả"
        '
        'LBhttl
        '
        Me.LBhttl.AutoSize = True
        Me.LBhttl.ForeColor = System.Drawing.Color.Black
        Me.LBhttl.Location = New System.Drawing.Point(5, 185)
        Me.LBhttl.Name = "LBhttl"
        Me.LBhttl.Size = New System.Drawing.Size(83, 17)
        Me.LBhttl.TabIndex = 49
        Me.LBhttl.Text = "Tên thể loại"
        '
        'LBmtl
        '
        Me.LBmtl.AutoSize = True
        Me.LBmtl.ForeColor = System.Drawing.Color.Black
        Me.LBmtl.Location = New System.Drawing.Point(4, 159)
        Me.LBmtl.Name = "LBmtl"
        Me.LBmtl.Size = New System.Drawing.Size(77, 17)
        Me.LBmtl.TabIndex = 48
        Me.LBmtl.Text = "Mã thể loại"
        '
        'DataGridViewtl
        '
        Me.DataGridViewtl.AutoGenerateColumns = False
        Me.DataGridViewtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewtl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatlDataGridViewTextBoxColumn, Me.HotentlDataGridViewTextBoxColumn, Me.MotatlDataGridViewTextBoxColumn})
        Me.DataGridViewtl.DataSource = Me.TheloaiBindingSource
        Me.DataGridViewtl.Location = New System.Drawing.Point(282, 0)
        Me.DataGridViewtl.Name = "DataGridViewtl"
        Me.DataGridViewtl.RowHeadersWidth = 51
        Me.DataGridViewtl.RowTemplate.Height = 24
        Me.DataGridViewtl.Size = New System.Drawing.Size(563, 534)
        Me.DataGridViewtl.TabIndex = 47
        '
        'PictureBoxtl
        '
        Me.PictureBoxtl.Image = Global.QuanLyThuVien.My.Resources.Resources.icontheloaisach
        Me.PictureBoxtl.Location = New System.Drawing.Point(85, 21)
        Me.PictureBoxtl.Name = "PictureBoxtl"
        Me.PictureBoxtl.Size = New System.Drawing.Size(94, 77)
        Me.PictureBoxtl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxtl.TabIndex = 59
        Me.PictureBoxtl.TabStop = False
        '
        'TheloaiTableAdapter
        '
        Me.TheloaiTableAdapter.ClearBeforeFill = True
        '
        'OleDbSelectCommandtl
        '
        Me.OleDbSelectCommandtl.CommandText = "SELECT matl, hotentl, motatl" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     theloai"
        Me.OleDbSelectCommandtl.Connection = Me.OleDbConnection
        '
        'OleDbConnection
        '
        Me.OleDbConnection.ConnectionString = "Provider=SQLOLEDB.1;Data Source=ADMIN;Password=123;User ID=sa;Initial Catalog=QLT" &
    "V"
        '
        'OleDbInsertCommandtl
        '
        Me.OleDbInsertCommandtl.CommandText = "INSERT INTO [theloai] ([matl], [hotentl], [motatl]) VALUES (?, ?, ?)"
        Me.OleDbInsertCommandtl.Connection = Me.OleDbConnection
        Me.OleDbInsertCommandtl.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("matl", System.Data.OleDb.OleDbType.VarWChar, 0, "matl"), New System.Data.OleDb.OleDbParameter("hotentl", System.Data.OleDb.OleDbType.VarWChar, 0, "hotentl"), New System.Data.OleDb.OleDbParameter("motatl", System.Data.OleDb.OleDbType.VarWChar, 0, "motatl")})
        '
        'OleDbUpdateCommandtl
        '
        Me.OleDbUpdateCommandtl.CommandText = "UPDATE [theloai] SET [matl] = ?, [hotentl] = ?, [motatl] = ? WHERE (([matl] = ?) " &
    "AND ([hotentl] = ?) AND ((? = 1 AND [motatl] IS NULL) OR ([motatl] = ?)))"
        Me.OleDbUpdateCommandtl.Connection = Me.OleDbConnection
        Me.OleDbUpdateCommandtl.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("matl", System.Data.OleDb.OleDbType.VarWChar, 0, "matl"), New System.Data.OleDb.OleDbParameter("hotentl", System.Data.OleDb.OleDbType.VarWChar, 0, "hotentl"), New System.Data.OleDb.OleDbParameter("motatl", System.Data.OleDb.OleDbType.VarWChar, 0, "motatl"), New System.Data.OleDb.OleDbParameter("Original_matl", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "matl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_hotentl", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hotentl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_motatl", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "motatl", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_motatl", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "motatl", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommandtl
        '
        Me.OleDbDeleteCommandtl.CommandText = "DELETE FROM [theloai] WHERE (([matl] = ?) AND ([hotentl] = ?) AND ((? = 1 AND [mo" &
    "tatl] IS NULL) OR ([motatl] = ?)))"
        Me.OleDbDeleteCommandtl.Connection = Me.OleDbConnection
        Me.OleDbDeleteCommandtl.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_matl", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "matl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_hotentl", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hotentl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_motatl", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "motatl", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_motatl", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "motatl", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdaptertl
        '
        Me.OleDbDataAdaptertl.DeleteCommand = Me.OleDbDeleteCommandtl
        Me.OleDbDataAdaptertl.InsertCommand = Me.OleDbInsertCommandtl
        Me.OleDbDataAdaptertl.SelectCommand = Me.OleDbSelectCommandtl
        Me.OleDbDataAdaptertl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "theloai", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("matl", "matl"), New System.Data.Common.DataColumnMapping("hotentl", "hotentl"), New System.Data.Common.DataColumnMapping("motatl", "motatl")})})
        Me.OleDbDataAdaptertl.UpdateCommand = Me.OleDbUpdateCommandtl
        '
        'MatlDataGridViewTextBoxColumn
        '
        Me.MatlDataGridViewTextBoxColumn.DataPropertyName = "matl"
        Me.MatlDataGridViewTextBoxColumn.HeaderText = "Mã thể loại"
        Me.MatlDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MatlDataGridViewTextBoxColumn.Name = "MatlDataGridViewTextBoxColumn"
        Me.MatlDataGridViewTextBoxColumn.Width = 130
        '
        'HotentlDataGridViewTextBoxColumn
        '
        Me.HotentlDataGridViewTextBoxColumn.DataPropertyName = "hotentl"
        Me.HotentlDataGridViewTextBoxColumn.HeaderText = "Tên thể loại"
        Me.HotentlDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HotentlDataGridViewTextBoxColumn.Name = "HotentlDataGridViewTextBoxColumn"
        Me.HotentlDataGridViewTextBoxColumn.Width = 135
        '
        'MotatlDataGridViewTextBoxColumn
        '
        Me.MotatlDataGridViewTextBoxColumn.DataPropertyName = "motatl"
        Me.MotatlDataGridViewTextBoxColumn.HeaderText = "Mô tả"
        Me.MotatlDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MotatlDataGridViewTextBoxColumn.Name = "MotatlDataGridViewTextBoxColumn"
        Me.MotatlDataGridViewTextBoxColumn.Width = 500
        '
        'Formtheloaisach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 534)
        Me.Controls.Add(Me.BTttl)
        Me.Controls.Add(Me.BTtktl)
        Me.Controls.Add(Me.BTloadtl)
        Me.Controls.Add(Me.LBdemtl)
        Me.Controls.Add(Me.PictureBoxtl)
        Me.Controls.Add(Me.BThuytl)
        Me.Controls.Add(Me.BTluutl)
        Me.Controls.Add(Me.BTxoatl)
        Me.Controls.Add(Me.BTsuatl)
        Me.Controls.Add(Me.BTthemtl)
        Me.Controls.Add(Me.TBmttl)
        Me.Controls.Add(Me.TBhttl)
        Me.Controls.Add(Me.TBmtl)
        Me.Controls.Add(Me.LBmttl)
        Me.Controls.Add(Me.LBhttl)
        Me.Controls.Add(Me.LBmtl)
        Me.Controls.Add(Me.DataGridViewtl)
        Me.Name = "Formtheloaisach"
        Me.Text = "Quản lý thông tin thể loại sách"
        CType(Me.TheloaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewtl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxtl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTttl As Button
    Friend WithEvents BTtktl As Button
    Friend WithEvents BTloadtl As Button
    Friend WithEvents LBdemtl As Label
    Friend WithEvents PictureBoxtl As PictureBox
    Friend WithEvents BThuytl As Button
    Friend WithEvents BTluutl As Button
    Friend WithEvents BTxoatl As Button
    Friend WithEvents BTsuatl As Button
    Friend WithEvents BTthemtl As Button
    Friend WithEvents TBmttl As TextBox
    Friend WithEvents TBhttl As TextBox
    Friend WithEvents TBmtl As TextBox
    Friend WithEvents LBmttl As Label
    Friend WithEvents LBhttl As Label
    Friend WithEvents LBmtl As Label
    Friend WithEvents DataGridViewtl As DataGridView
    Friend WithEvents DataSet As DataSet
    Friend WithEvents TheloaiBindingSource As BindingSource
    Friend WithEvents TheloaiTableAdapter As DataSetTableAdapters.theloaiTableAdapter
    Friend WithEvents OleDbSelectCommandtl As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommandtl As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommandtl As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommandtl As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdaptertl As OleDb.OleDbDataAdapter
    Friend WithEvents MatlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HotentlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotatlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
