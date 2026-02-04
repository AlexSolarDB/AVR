<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class csvDB
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(csvDB))
        Me.btnCsvLoad = New System.Windows.Forms.Button()
        Me.dgvCsv = New System.Windows.Forms.DataGridView()
        Me.btnSaveCsv = New System.Windows.Forms.Button()
        Me.btnTableAddRow = New System.Windows.Forms.Button()
        Me.btnReportOut = New System.Windows.Forms.Button()
        Me.tlpTables = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.dgvCsv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpTables.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCsvLoad
        '
        Me.btnCsvLoad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCsvLoad.Location = New System.Drawing.Point(0, 0)
        Me.btnCsvLoad.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btnCsvLoad.MinimumSize = New System.Drawing.Size(225, 25)
        Me.btnCsvLoad.Name = "btnCsvLoad"
        Me.btnCsvLoad.Size = New System.Drawing.Size(256, 25)
        Me.btnCsvLoad.TabIndex = 0
        Me.btnCsvLoad.Text = "Загрузить таблицу"
        Me.btnCsvLoad.UseVisualStyleBackColor = True
        '
        'dgvCsv
        '
        Me.dgvCsv.AllowUserToAddRows = False
        Me.dgvCsv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvCsv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCsv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCsv.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvCsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCsv.Location = New System.Drawing.Point(15, 15)
        Me.dgvCsv.Margin = New System.Windows.Forms.Padding(15)
        Me.dgvCsv.MinimumSize = New System.Drawing.Size(947, 40)
        Me.dgvCsv.Name = "dgvCsv"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.dgvCsv.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCsv.Size = New System.Drawing.Size(1047, 800)
        Me.dgvCsv.TabIndex = 4
        '
        'btnSaveCsv
        '
        Me.btnSaveCsv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveCsv.Location = New System.Drawing.Point(266, 0)
        Me.btnSaveCsv.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btnSaveCsv.MinimumSize = New System.Drawing.Size(225, 25)
        Me.btnSaveCsv.Name = "btnSaveCsv"
        Me.btnSaveCsv.Size = New System.Drawing.Size(251, 25)
        Me.btnSaveCsv.TabIndex = 1
        Me.btnSaveCsv.Text = "Сохранить текущую таблицу"
        Me.btnSaveCsv.UseVisualStyleBackColor = True
        '
        'btnTableAddRow
        '
        Me.btnTableAddRow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTableAddRow.Location = New System.Drawing.Point(527, 0)
        Me.btnTableAddRow.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btnTableAddRow.MinimumSize = New System.Drawing.Size(225, 25)
        Me.btnTableAddRow.Name = "btnTableAddRow"
        Me.btnTableAddRow.Size = New System.Drawing.Size(251, 25)
        Me.btnTableAddRow.TabIndex = 2
        Me.btnTableAddRow.Text = "Добавить строку"
        Me.btnTableAddRow.UseVisualStyleBackColor = True
        '
        'btnReportOut
        '
        Me.btnReportOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReportOut.Location = New System.Drawing.Point(788, 0)
        Me.btnReportOut.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnReportOut.MinimumSize = New System.Drawing.Size(225, 25)
        Me.btnReportOut.Name = "btnReportOut"
        Me.btnReportOut.Size = New System.Drawing.Size(259, 25)
        Me.btnReportOut.TabIndex = 3
        Me.btnReportOut.Text = "Вывод части таблицы"
        Me.btnReportOut.UseVisualStyleBackColor = True
        '
        'tlpTables
        '
        Me.tlpTables.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpTables.ColumnCount = 4
        Me.tlpTables.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpTables.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpTables.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpTables.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpTables.Controls.Add(Me.btnCsvLoad, 0, 0)
        Me.tlpTables.Controls.Add(Me.btnSaveCsv, 1, 0)
        Me.tlpTables.Controls.Add(Me.btnTableAddRow, 2, 0)
        Me.tlpTables.Controls.Add(Me.btnReportOut, 3, 0)
        Me.tlpTables.Location = New System.Drawing.Point(15, 830)
        Me.tlpTables.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpTables.Name = "tlpTables"
        Me.tlpTables.RowCount = 1
        Me.tlpTables.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTables.Size = New System.Drawing.Size(1047, 25)
        Me.tlpTables.TabIndex = 5
        '
        'csvDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1077, 871)
        Me.Controls.Add(Me.tlpTables)
        Me.Controls.Add(Me.dgvCsv)
        Me.Font = New System.Drawing.Font("Maple Mono", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MinimumSize = New System.Drawing.Size(993, 149)
        Me.Name = "csvDB"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Окно работы с таблицами"
        CType(Me.dgvCsv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpTables.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCsvLoad As Button
    Friend WithEvents dgvCsv As DataGridView
    Friend WithEvents btnSaveCsv As Button
    Friend WithEvents btnTableAddRow As Button
    Friend WithEvents btnReportOut As Button
    Friend WithEvents tlpTables As TableLayoutPanel
End Class
