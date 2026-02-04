<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.lblProgramInfo = New System.Windows.Forms.Label()
        Me.lblWorkStartDate = New System.Windows.Forms.Label()
        Me.txtbWorkStartDate = New System.Windows.Forms.TextBox()
        Me.lblWorkEndDate = New System.Windows.Forms.Label()
        Me.txtbWorkEndDate = New System.Windows.Forms.TextBox()
        Me.lblGreenEndDate = New System.Windows.Forms.Label()
        Me.txtbGreenEndDate = New System.Windows.Forms.TextBox()
        Me.lblDocumentsDate = New System.Windows.Forms.Label()
        Me.txtbDocumentsDate = New System.Windows.Forms.TextBox()
        Me.lblShortAdress = New System.Windows.Forms.Label()
        Me.txtbShortAdress = New System.Windows.Forms.TextBox()
        Me.lblFullAdress = New System.Windows.Forms.Label()
        Me.txtbFullAdress = New System.Windows.Forms.TextBox()
        Me.lblNotionNumber = New System.Windows.Forms.Label()
        Me.txtbNotionNumber = New System.Windows.Forms.TextBox()
        Me.lblMasterName = New System.Windows.Forms.Label()
        Me.lblNotionOrgs = New System.Windows.Forms.Label()
        Me.lblWorkType = New System.Windows.Forms.Label()
        Me.lstWorkType = New System.Windows.Forms.ListBox()
        Me.btnSubmitForm = New System.Windows.Forms.Button()
        Me.lstMasteNames = New System.Windows.Forms.ListBox()
        Me.lstNotionOrgs = New System.Windows.Forms.ListBox()
        Me.tlpDocuments = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpDocuments.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProgramInfo
        '
        Me.lblProgramInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProgramInfo.BackColor = System.Drawing.Color.White
        Me.lblProgramInfo.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblProgramInfo.Location = New System.Drawing.Point(15, 15)
        Me.lblProgramInfo.Margin = New System.Windows.Forms.Padding(15)
        Me.lblProgramInfo.Name = "lblProgramInfo"
        Me.lblProgramInfo.Size = New System.Drawing.Size(515, 25)
        Me.lblProgramInfo.TabIndex = 1
        Me.lblProgramInfo.Text = "Пожалуйста, заполните поля ниже для подготовки документов"
        Me.lblProgramInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWorkStartDate
        '
        Me.lblWorkStartDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWorkStartDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblWorkStartDate.Location = New System.Drawing.Point(0, 5)
        Me.lblWorkStartDate.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.lblWorkStartDate.Name = "lblWorkStartDate"
        Me.lblWorkStartDate.Size = New System.Drawing.Size(252, 22)
        Me.lblWorkStartDate.TabIndex = 2
        Me.lblWorkStartDate.Text = "Дата начала работ"
        Me.lblWorkStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbWorkStartDate
        '
        Me.txtbWorkStartDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbWorkStartDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbWorkStartDate.Location = New System.Drawing.Point(0, 37)
        Me.txtbWorkStartDate.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.txtbWorkStartDate.Name = "txtbWorkStartDate"
        Me.txtbWorkStartDate.Size = New System.Drawing.Size(252, 25)
        Me.txtbWorkStartDate.TabIndex = 1
        Me.txtbWorkStartDate.Text = "12.05.2020"
        Me.txtbWorkStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWorkEndDate
        '
        Me.lblWorkEndDate.BackColor = System.Drawing.SystemColors.Window
        Me.lblWorkEndDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWorkEndDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblWorkEndDate.Location = New System.Drawing.Point(262, 5)
        Me.lblWorkEndDate.Margin = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.lblWorkEndDate.Name = "lblWorkEndDate"
        Me.lblWorkEndDate.Size = New System.Drawing.Size(253, 22)
        Me.lblWorkEndDate.TabIndex = 4
        Me.lblWorkEndDate.Text = "Дата окончания работ"
        Me.lblWorkEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbWorkEndDate
        '
        Me.txtbWorkEndDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbWorkEndDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbWorkEndDate.Location = New System.Drawing.Point(262, 37)
        Me.txtbWorkEndDate.Margin = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.txtbWorkEndDate.Name = "txtbWorkEndDate"
        Me.txtbWorkEndDate.Size = New System.Drawing.Size(253, 25)
        Me.txtbWorkEndDate.TabIndex = 2
        Me.txtbWorkEndDate.Text = "26.05.2020"
        Me.txtbWorkEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGreenEndDate
        '
        Me.lblGreenEndDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGreenEndDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblGreenEndDate.Location = New System.Drawing.Point(0, 69)
        Me.lblGreenEndDate.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.lblGreenEndDate.Name = "lblGreenEndDate"
        Me.lblGreenEndDate.Size = New System.Drawing.Size(252, 22)
        Me.lblGreenEndDate.TabIndex = 6
        Me.lblGreenEndDate.Text = "Дата окончания благоустройства"
        Me.lblGreenEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbGreenEndDate
        '
        Me.txtbGreenEndDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbGreenEndDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbGreenEndDate.Location = New System.Drawing.Point(0, 101)
        Me.txtbGreenEndDate.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.txtbGreenEndDate.Name = "txtbGreenEndDate"
        Me.txtbGreenEndDate.Size = New System.Drawing.Size(252, 25)
        Me.txtbGreenEndDate.TabIndex = 3
        Me.txtbGreenEndDate.Text = "12.06.2020"
        Me.txtbGreenEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDocumentsDate
        '
        Me.lblDocumentsDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDocumentsDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblDocumentsDate.Location = New System.Drawing.Point(262, 69)
        Me.lblDocumentsDate.Margin = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.lblDocumentsDate.Name = "lblDocumentsDate"
        Me.lblDocumentsDate.Size = New System.Drawing.Size(253, 22)
        Me.lblDocumentsDate.TabIndex = 8
        Me.lblDocumentsDate.Text = "Дата подачи документов"
        Me.lblDocumentsDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbDocumentsDate
        '
        Me.txtbDocumentsDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbDocumentsDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbDocumentsDate.Location = New System.Drawing.Point(262, 101)
        Me.txtbDocumentsDate.Margin = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.txtbDocumentsDate.Name = "txtbDocumentsDate"
        Me.txtbDocumentsDate.Size = New System.Drawing.Size(253, 25)
        Me.txtbDocumentsDate.TabIndex = 4
        Me.txtbDocumentsDate.Text = "12.05.2020"
        Me.txtbDocumentsDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblShortAdress
        '
        Me.lblShortAdress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblShortAdress.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblShortAdress.Location = New System.Drawing.Point(0, 133)
        Me.lblShortAdress.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.lblShortAdress.Name = "lblShortAdress"
        Me.lblShortAdress.Size = New System.Drawing.Size(252, 22)
        Me.lblShortAdress.TabIndex = 10
        Me.lblShortAdress.Text = "Краткий адрес"
        Me.lblShortAdress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbShortAdress
        '
        Me.txtbShortAdress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbShortAdress.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbShortAdress.Location = New System.Drawing.Point(0, 165)
        Me.txtbShortAdress.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.txtbShortAdress.Name = "txtbShortAdress"
        Me.txtbShortAdress.Size = New System.Drawing.Size(252, 25)
        Me.txtbShortAdress.TabIndex = 5
        Me.txtbShortAdress.Text = "Пушкина, 17"
        Me.txtbShortAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFullAdress
        '
        Me.lblFullAdress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFullAdress.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblFullAdress.Location = New System.Drawing.Point(15, 265)
        Me.lblFullAdress.Name = "lblFullAdress"
        Me.lblFullAdress.Size = New System.Drawing.Size(515, 25)
        Me.lblFullAdress.TabIndex = 14
        Me.lblFullAdress.Text = "Полный адрес"
        Me.lblFullAdress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbFullAdress
        '
        Me.txtbFullAdress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbFullAdress.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbFullAdress.Location = New System.Drawing.Point(15, 295)
        Me.txtbFullAdress.Name = "txtbFullAdress"
        Me.txtbFullAdress.Size = New System.Drawing.Size(515, 25)
        Me.txtbFullAdress.TabIndex = 7
        Me.txtbFullAdress.Text = "улица Пушкина, возле дома №17"
        Me.txtbFullAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNotionNumber
        '
        Me.lblNotionNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNotionNumber.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblNotionNumber.Location = New System.Drawing.Point(262, 133)
        Me.lblNotionNumber.Margin = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.lblNotionNumber.Name = "lblNotionNumber"
        Me.lblNotionNumber.Size = New System.Drawing.Size(253, 22)
        Me.lblNotionNumber.TabIndex = 12
        Me.lblNotionNumber.Text = "Номер уведомления"
        Me.lblNotionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbNotionNumber
        '
        Me.txtbNotionNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbNotionNumber.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbNotionNumber.Location = New System.Drawing.Point(262, 165)
        Me.txtbNotionNumber.Margin = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.txtbNotionNumber.Name = "txtbNotionNumber"
        Me.txtbNotionNumber.Size = New System.Drawing.Size(253, 25)
        Me.txtbNotionNumber.TabIndex = 6
        Me.txtbNotionNumber.Text = "50"
        Me.txtbNotionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMasterName
        '
        Me.lblMasterName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMasterName.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblMasterName.Location = New System.Drawing.Point(15, 335)
        Me.lblMasterName.Name = "lblMasterName"
        Me.lblMasterName.Size = New System.Drawing.Size(515, 25)
        Me.lblMasterName.TabIndex = 16
        Me.lblMasterName.Text = "Фамилия ответственного"
        Me.lblMasterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNotionOrgs
        '
        Me.lblNotionOrgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotionOrgs.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblNotionOrgs.Location = New System.Drawing.Point(15, 455)
        Me.lblNotionOrgs.Name = "lblNotionOrgs"
        Me.lblNotionOrgs.Size = New System.Drawing.Size(515, 25)
        Me.lblNotionOrgs.TabIndex = 18
        Me.lblNotionOrgs.Text = "Уведомление иных организаций"
        Me.lblNotionOrgs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWorkType
        '
        Me.lblWorkType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWorkType.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblWorkType.Location = New System.Drawing.Point(15, 575)
        Me.lblWorkType.Name = "lblWorkType"
        Me.lblWorkType.Size = New System.Drawing.Size(515, 25)
        Me.lblWorkType.TabIndex = 20
        Me.lblWorkType.Text = "Вид выполняемых работ"
        Me.lblWorkType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstWorkType
        '
        Me.lstWorkType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstWorkType.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lstWorkType.FormattingEnabled = True
        Me.lstWorkType.ItemHeight = 17
        Me.lstWorkType.Location = New System.Drawing.Point(15, 605)
        Me.lstWorkType.Name = "lstWorkType"
        Me.lstWorkType.Size = New System.Drawing.Size(515, 72)
        Me.lstWorkType.TabIndex = 10
        '
        'btnSubmitForm
        '
        Me.btnSubmitForm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmitForm.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.btnSubmitForm.Location = New System.Drawing.Point(15, 695)
        Me.btnSubmitForm.Name = "btnSubmitForm"
        Me.btnSubmitForm.Size = New System.Drawing.Size(515, 25)
        Me.btnSubmitForm.TabIndex = 11
        Me.btnSubmitForm.Text = "Подготовить документы"
        Me.btnSubmitForm.UseVisualStyleBackColor = True
        '
        'lstMasteNames
        '
        Me.lstMasteNames.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstMasteNames.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lstMasteNames.FormattingEnabled = True
        Me.lstMasteNames.ItemHeight = 17
        Me.lstMasteNames.Location = New System.Drawing.Point(15, 365)
        Me.lstMasteNames.Name = "lstMasteNames"
        Me.lstMasteNames.Size = New System.Drawing.Size(515, 72)
        Me.lstMasteNames.TabIndex = 8
        '
        'lstNotionOrgs
        '
        Me.lstNotionOrgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstNotionOrgs.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lstNotionOrgs.FormattingEnabled = True
        Me.lstNotionOrgs.ItemHeight = 17
        Me.lstNotionOrgs.Location = New System.Drawing.Point(15, 485)
        Me.lstNotionOrgs.Name = "lstNotionOrgs"
        Me.lstNotionOrgs.Size = New System.Drawing.Size(515, 72)
        Me.lstNotionOrgs.TabIndex = 9
        '
        'tlpDocuments
        '
        Me.tlpDocuments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpDocuments.ColumnCount = 2
        Me.tlpDocuments.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDocuments.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDocuments.Controls.Add(Me.lblWorkStartDate, 0, 0)
        Me.tlpDocuments.Controls.Add(Me.txtbWorkStartDate, 0, 1)
        Me.tlpDocuments.Controls.Add(Me.lblGreenEndDate, 0, 2)
        Me.tlpDocuments.Controls.Add(Me.txtbGreenEndDate, 0, 3)
        Me.tlpDocuments.Controls.Add(Me.lblShortAdress, 0, 4)
        Me.tlpDocuments.Controls.Add(Me.txtbShortAdress, 0, 5)
        Me.tlpDocuments.Controls.Add(Me.lblWorkEndDate, 1, 0)
        Me.tlpDocuments.Controls.Add(Me.txtbWorkEndDate, 1, 1)
        Me.tlpDocuments.Controls.Add(Me.txtbNotionNumber, 1, 5)
        Me.tlpDocuments.Controls.Add(Me.lblDocumentsDate, 1, 2)
        Me.tlpDocuments.Controls.Add(Me.lblNotionNumber, 1, 4)
        Me.tlpDocuments.Controls.Add(Me.txtbDocumentsDate, 1, 3)
        Me.tlpDocuments.Location = New System.Drawing.Point(15, 55)
        Me.tlpDocuments.Margin = New System.Windows.Forms.Padding(10)
        Me.tlpDocuments.Name = "tlpDocuments"
        Me.tlpDocuments.RowCount = 6
        Me.tlpDocuments.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpDocuments.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpDocuments.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpDocuments.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpDocuments.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpDocuments.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpDocuments.Size = New System.Drawing.Size(515, 195)
        Me.tlpDocuments.TabIndex = 32
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(545, 735)
        Me.Controls.Add(Me.tlpDocuments)
        Me.Controls.Add(Me.lstNotionOrgs)
        Me.Controls.Add(Me.lstMasteNames)
        Me.Controls.Add(Me.btnSubmitForm)
        Me.Controls.Add(Me.lstWorkType)
        Me.Controls.Add(Me.lblWorkType)
        Me.Controls.Add(Me.lblNotionOrgs)
        Me.Controls.Add(Me.lblMasterName)
        Me.Controls.Add(Me.txtbFullAdress)
        Me.Controls.Add(Me.lblFullAdress)
        Me.Controls.Add(Me.lblProgramInfo)
        Me.Font = New System.Drawing.Font("Maple Mono", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(561, 774)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Окно подготовки документов"
        Me.tlpDocuments.ResumeLayout(False)
        Me.tlpDocuments.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProgramInfo As Label
    Friend WithEvents lblWorkStartDate As Label
    Friend WithEvents txtbWorkStartDate As TextBox
    Friend WithEvents lblWorkEndDate As Label
    Friend WithEvents txtbWorkEndDate As TextBox
    Friend WithEvents lblGreenEndDate As Label
    Friend WithEvents txtbGreenEndDate As TextBox
    Friend WithEvents lblDocumentsDate As Label
    Friend WithEvents txtbDocumentsDate As TextBox
    Friend WithEvents lblShortAdress As Label
    Friend WithEvents txtbShortAdress As TextBox
    Friend WithEvents txtbFullAdress As TextBox
    Friend WithEvents lblNotionNumber As Label
    Friend WithEvents txtbNotionNumber As TextBox
    Friend WithEvents lblMasterName As Label
    Friend WithEvents lblNotionOrgs As Label
    Friend WithEvents lblWorkType As Label
    Friend WithEvents lstWorkType As ListBox
    Friend WithEvents btnSubmitForm As Button
    Friend WithEvents lstMasteNames As ListBox
    Friend WithEvents lstNotionOrgs As ListBox
    Friend WithEvents lblFullAdress As Label
    Friend WithEvents tlpDocuments As TableLayoutPanel
End Class
