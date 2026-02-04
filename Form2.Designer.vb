<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.tbcSettings = New System.Windows.Forms.TabControl()
        Me.tbcSettingP1 = New System.Windows.Forms.TabPage()
        Me.btnClosedActsDirPath = New System.Windows.Forms.Button()
        Me.btnOpenActsDirPath = New System.Windows.Forms.Button()
        Me.btnExamplesDirPath = New System.Windows.Forms.Button()
        Me.btnPathsHepl = New System.Windows.Forms.Button()
        Me.txtbClosedActsDirPath = New System.Windows.Forms.TextBox()
        Me.lblClosedActsDirPath = New System.Windows.Forms.Label()
        Me.txtbOpenActsDirPath = New System.Windows.Forms.TextBox()
        Me.lblOpenActsDirPath = New System.Windows.Forms.Label()
        Me.txtbExamplesDirPath = New System.Windows.Forms.TextBox()
        Me.lblExamplesDirPath = New System.Windows.Forms.Label()
        Me.lblPathsInfo = New System.Windows.Forms.Label()
        Me.tbcSettingsP2 = New System.Windows.Forms.TabPage()
        Me.btnListsHelp = New System.Windows.Forms.Button()
        Me.txtbWorkTypes = New System.Windows.Forms.TextBox()
        Me.lblWorkTypes = New System.Windows.Forms.Label()
        Me.txtbNotionOrgs = New System.Windows.Forms.TextBox()
        Me.lblNotionOrgs = New System.Windows.Forms.Label()
        Me.txtbMasterNames = New System.Windows.Forms.TextBox()
        Me.lblMasterNames = New System.Windows.Forms.Label()
        Me.lblListsInfo = New System.Windows.Forms.Label()
        Me.tbcSettingsP3 = New System.Windows.Forms.TabPage()
        Me.tlpSettingsTemplates = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTmpltDocumentsDateStr = New System.Windows.Forms.Label()
        Me.txtbTmpltDocumentsDateStr = New System.Windows.Forms.TextBox()
        Me.txtbTmpltWorkStartDate = New System.Windows.Forms.TextBox()
        Me.lblTmpltWorkStartDate = New System.Windows.Forms.Label()
        Me.btnHelpTmplt = New System.Windows.Forms.Button()
        Me.txtbTmpltGreenEndDate = New System.Windows.Forms.TextBox()
        Me.lblTmpltGreenEndDate = New System.Windows.Forms.Label()
        Me.txtbTmpltWorkEndDate = New System.Windows.Forms.TextBox()
        Me.lblTmpltWorkEndDate = New System.Windows.Forms.Label()
        Me.txtbTmpltDocumentsDateD = New System.Windows.Forms.TextBox()
        Me.lblTmpltDocumentsDateD = New System.Windows.Forms.Label()
        Me.txtbTmpltWorkType = New System.Windows.Forms.TextBox()
        Me.lblTmpltWorkType = New System.Windows.Forms.Label()
        Me.txtbTmpltFullAdress = New System.Windows.Forms.TextBox()
        Me.lblTmpltFullAdress = New System.Windows.Forms.Label()
        Me.txtbTmpltNotionNumber = New System.Windows.Forms.TextBox()
        Me.lblTmpltNotionNumber = New System.Windows.Forms.Label()
        Me.lblTmpltsInfo = New System.Windows.Forms.Label()
        Me.tbcSettingsP4 = New System.Windows.Forms.TabPage()
        Me.btnTablePastPath = New System.Windows.Forms.Button()
        Me.txtbTablePastPath = New System.Windows.Forms.TextBox()
        Me.lblTablePastPath = New System.Windows.Forms.Label()
        Me.btnTableCurrentPath = New System.Windows.Forms.Button()
        Me.txtbTableCurrentPath = New System.Windows.Forms.TextBox()
        Me.lblTableCurrentPath = New System.Windows.Forms.Label()
        Me.txtbTableHeaders = New System.Windows.Forms.TextBox()
        Me.lblTableHeaders = New System.Windows.Forms.Label()
        Me.lblTableInfo = New System.Windows.Forms.Label()
        Me.btnTableHelp = New System.Windows.Forms.Button()
        Me.tbcSettingsP5 = New System.Windows.Forms.TabPage()
        Me.btnTableExtraHelp = New System.Windows.Forms.Button()
        Me.txtbTableExtraOutTemplate = New System.Windows.Forms.TextBox()
        Me.lblTableExtraInfo = New System.Windows.Forms.Label()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.fbdExamplesDirPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.fbdOpenActsDirPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.fbdClosedActsDirPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.ofdTableCurrenPath = New System.Windows.Forms.OpenFileDialog()
        Me.ofdTablePastPath = New System.Windows.Forms.OpenFileDialog()
        Me.btnSettingsReset = New System.Windows.Forms.Button()
        Me.tbcSettings.SuspendLayout()
        Me.tbcSettingP1.SuspendLayout()
        Me.tbcSettingsP2.SuspendLayout()
        Me.tbcSettingsP3.SuspendLayout()
        Me.tlpSettingsTemplates.SuspendLayout()
        Me.tbcSettingsP4.SuspendLayout()
        Me.tbcSettingsP5.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcSettings
        '
        Me.tbcSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcSettings.Controls.Add(Me.tbcSettingP1)
        Me.tbcSettings.Controls.Add(Me.tbcSettingsP2)
        Me.tbcSettings.Controls.Add(Me.tbcSettingsP3)
        Me.tbcSettings.Controls.Add(Me.tbcSettingsP4)
        Me.tbcSettings.Controls.Add(Me.tbcSettingsP5)
        Me.tbcSettings.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.tbcSettings.Location = New System.Drawing.Point(15, 15)
        Me.tbcSettings.Name = "tbcSettings"
        Me.tbcSettings.SelectedIndex = 0
        Me.tbcSettings.Size = New System.Drawing.Size(553, 495)
        Me.tbcSettings.TabIndex = 0
        '
        'tbcSettingP1
        '
        Me.tbcSettingP1.BackColor = System.Drawing.SystemColors.Window
        Me.tbcSettingP1.Controls.Add(Me.btnClosedActsDirPath)
        Me.tbcSettingP1.Controls.Add(Me.btnOpenActsDirPath)
        Me.tbcSettingP1.Controls.Add(Me.btnExamplesDirPath)
        Me.tbcSettingP1.Controls.Add(Me.btnPathsHepl)
        Me.tbcSettingP1.Controls.Add(Me.txtbClosedActsDirPath)
        Me.tbcSettingP1.Controls.Add(Me.lblClosedActsDirPath)
        Me.tbcSettingP1.Controls.Add(Me.txtbOpenActsDirPath)
        Me.tbcSettingP1.Controls.Add(Me.lblOpenActsDirPath)
        Me.tbcSettingP1.Controls.Add(Me.txtbExamplesDirPath)
        Me.tbcSettingP1.Controls.Add(Me.lblExamplesDirPath)
        Me.tbcSettingP1.Controls.Add(Me.lblPathsInfo)
        Me.tbcSettingP1.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.tbcSettingP1.Location = New System.Drawing.Point(4, 26)
        Me.tbcSettingP1.Margin = New System.Windows.Forms.Padding(0)
        Me.tbcSettingP1.Name = "tbcSettingP1"
        Me.tbcSettingP1.Size = New System.Drawing.Size(545, 465)
        Me.tbcSettingP1.TabIndex = 0
        Me.tbcSettingP1.Text = "Пути"
        '
        'btnClosedActsDirPath
        '
        Me.btnClosedActsDirPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClosedActsDirPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClosedActsDirPath.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.btnClosedActsDirPath.ForeColor = System.Drawing.Color.Transparent
        Me.btnClosedActsDirPath.Location = New System.Drawing.Point(505, 225)
        Me.btnClosedActsDirPath.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClosedActsDirPath.MaximumSize = New System.Drawing.Size(25, 25)
        Me.btnClosedActsDirPath.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btnClosedActsDirPath.Name = "btnClosedActsDirPath"
        Me.btnClosedActsDirPath.Size = New System.Drawing.Size(25, 25)
        Me.btnClosedActsDirPath.TabIndex = 9
        Me.btnClosedActsDirPath.UseVisualStyleBackColor = True
        '
        'btnOpenActsDirPath
        '
        Me.btnOpenActsDirPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenActsDirPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOpenActsDirPath.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.btnOpenActsDirPath.ForeColor = System.Drawing.Color.Transparent
        Me.btnOpenActsDirPath.Location = New System.Drawing.Point(505, 155)
        Me.btnOpenActsDirPath.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOpenActsDirPath.MaximumSize = New System.Drawing.Size(25, 25)
        Me.btnOpenActsDirPath.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btnOpenActsDirPath.Name = "btnOpenActsDirPath"
        Me.btnOpenActsDirPath.Size = New System.Drawing.Size(25, 25)
        Me.btnOpenActsDirPath.TabIndex = 6
        Me.btnOpenActsDirPath.UseVisualStyleBackColor = True
        '
        'btnExamplesDirPath
        '
        Me.btnExamplesDirPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExamplesDirPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExamplesDirPath.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.btnExamplesDirPath.ForeColor = System.Drawing.Color.Transparent
        Me.btnExamplesDirPath.Location = New System.Drawing.Point(505, 85)
        Me.btnExamplesDirPath.Margin = New System.Windows.Forms.Padding(15)
        Me.btnExamplesDirPath.MaximumSize = New System.Drawing.Size(25, 25)
        Me.btnExamplesDirPath.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btnExamplesDirPath.Name = "btnExamplesDirPath"
        Me.btnExamplesDirPath.Size = New System.Drawing.Size(25, 25)
        Me.btnExamplesDirPath.TabIndex = 3
        Me.btnExamplesDirPath.UseVisualStyleBackColor = True
        '
        'btnPathsHepl
        '
        Me.btnPathsHepl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPathsHepl.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.btnPathsHepl.Location = New System.Drawing.Point(15, 425)
        Me.btnPathsHepl.Name = "btnPathsHepl"
        Me.btnPathsHepl.Size = New System.Drawing.Size(515, 25)
        Me.btnPathsHepl.TabIndex = 10
        Me.btnPathsHepl.Text = "Справка"
        Me.btnPathsHepl.UseVisualStyleBackColor = True
        '
        'txtbClosedActsDirPath
        '
        Me.txtbClosedActsDirPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbClosedActsDirPath.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbClosedActsDirPath.Location = New System.Drawing.Point(15, 225)
        Me.txtbClosedActsDirPath.Name = "txtbClosedActsDirPath"
        Me.txtbClosedActsDirPath.Size = New System.Drawing.Size(475, 25)
        Me.txtbClosedActsDirPath.TabIndex = 8
        Me.txtbClosedActsDirPath.Text = "D:\Закрытие"
        Me.txtbClosedActsDirPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblClosedActsDirPath
        '
        Me.lblClosedActsDirPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClosedActsDirPath.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblClosedActsDirPath.Location = New System.Drawing.Point(15, 195)
        Me.lblClosedActsDirPath.Name = "lblClosedActsDirPath"
        Me.lblClosedActsDirPath.Size = New System.Drawing.Size(475, 25)
        Me.lblClosedActsDirPath.TabIndex = 7
        Me.lblClosedActsDirPath.Text = "Путь к папке с документами для заявок на закрытие"
        Me.lblClosedActsDirPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbOpenActsDirPath
        '
        Me.txtbOpenActsDirPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbOpenActsDirPath.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbOpenActsDirPath.Location = New System.Drawing.Point(15, 155)
        Me.txtbOpenActsDirPath.Name = "txtbOpenActsDirPath"
        Me.txtbOpenActsDirPath.Size = New System.Drawing.Size(475, 25)
        Me.txtbOpenActsDirPath.TabIndex = 5
        Me.txtbOpenActsDirPath.Text = "D:\Открытие"
        Me.txtbOpenActsDirPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblOpenActsDirPath
        '
        Me.lblOpenActsDirPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOpenActsDirPath.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblOpenActsDirPath.Location = New System.Drawing.Point(15, 125)
        Me.lblOpenActsDirPath.Name = "lblOpenActsDirPath"
        Me.lblOpenActsDirPath.Size = New System.Drawing.Size(475, 25)
        Me.lblOpenActsDirPath.TabIndex = 4
        Me.lblOpenActsDirPath.Text = "Путь к папке с документами для заявок на открытие"
        Me.lblOpenActsDirPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbExamplesDirPath
        '
        Me.txtbExamplesDirPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbExamplesDirPath.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbExamplesDirPath.Location = New System.Drawing.Point(15, 85)
        Me.txtbExamplesDirPath.Name = "txtbExamplesDirPath"
        Me.txtbExamplesDirPath.Size = New System.Drawing.Size(475, 25)
        Me.txtbExamplesDirPath.TabIndex = 2
        Me.txtbExamplesDirPath.Text = "D:\Образцы"
        Me.txtbExamplesDirPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblExamplesDirPath
        '
        Me.lblExamplesDirPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExamplesDirPath.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblExamplesDirPath.Location = New System.Drawing.Point(15, 55)
        Me.lblExamplesDirPath.Name = "lblExamplesDirPath"
        Me.lblExamplesDirPath.Size = New System.Drawing.Size(475, 25)
        Me.lblExamplesDirPath.TabIndex = 1
        Me.lblExamplesDirPath.Text = "Путь к папке с образцами документов"
        Me.lblExamplesDirPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPathsInfo
        '
        Me.lblPathsInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPathsInfo.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblPathsInfo.Location = New System.Drawing.Point(15, 15)
        Me.lblPathsInfo.Name = "lblPathsInfo"
        Me.lblPathsInfo.Size = New System.Drawing.Size(515, 25)
        Me.lblPathsInfo.TabIndex = 0
        Me.lblPathsInfo.Text = "Здесь представлены пути к необходимым папкам."
        Me.lblPathsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbcSettingsP2
        '
        Me.tbcSettingsP2.Controls.Add(Me.btnListsHelp)
        Me.tbcSettingsP2.Controls.Add(Me.txtbWorkTypes)
        Me.tbcSettingsP2.Controls.Add(Me.lblWorkTypes)
        Me.tbcSettingsP2.Controls.Add(Me.txtbNotionOrgs)
        Me.tbcSettingsP2.Controls.Add(Me.lblNotionOrgs)
        Me.tbcSettingsP2.Controls.Add(Me.txtbMasterNames)
        Me.tbcSettingsP2.Controls.Add(Me.lblMasterNames)
        Me.tbcSettingsP2.Controls.Add(Me.lblListsInfo)
        Me.tbcSettingsP2.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.tbcSettingsP2.Location = New System.Drawing.Point(4, 26)
        Me.tbcSettingsP2.Margin = New System.Windows.Forms.Padding(5)
        Me.tbcSettingsP2.Name = "tbcSettingsP2"
        Me.tbcSettingsP2.Padding = New System.Windows.Forms.Padding(5)
        Me.tbcSettingsP2.Size = New System.Drawing.Size(545, 465)
        Me.tbcSettingsP2.TabIndex = 1
        Me.tbcSettingsP2.Text = "Списки"
        Me.tbcSettingsP2.UseVisualStyleBackColor = True
        '
        'btnListsHelp
        '
        Me.btnListsHelp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListsHelp.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.btnListsHelp.Location = New System.Drawing.Point(15, 425)
        Me.btnListsHelp.Name = "btnListsHelp"
        Me.btnListsHelp.Size = New System.Drawing.Size(515, 25)
        Me.btnListsHelp.TabIndex = 7
        Me.btnListsHelp.Text = "Справка"
        Me.btnListsHelp.UseVisualStyleBackColor = True
        '
        'txtbWorkTypes
        '
        Me.txtbWorkTypes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbWorkTypes.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbWorkTypes.Location = New System.Drawing.Point(15, 325)
        Me.txtbWorkTypes.Multiline = True
        Me.txtbWorkTypes.Name = "txtbWorkTypes"
        Me.txtbWorkTypes.Size = New System.Drawing.Size(515, 75)
        Me.txtbWorkTypes.TabIndex = 6
        Me.txtbWorkTypes.Text = "трубопровода ХВС;трубопровода ГВС;трубопровода отопления"
        Me.txtbWorkTypes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWorkTypes
        '
        Me.lblWorkTypes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWorkTypes.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblWorkTypes.Location = New System.Drawing.Point(15, 295)
        Me.lblWorkTypes.Name = "lblWorkTypes"
        Me.lblWorkTypes.Size = New System.Drawing.Size(515, 25)
        Me.lblWorkTypes.TabIndex = 5
        Me.lblWorkTypes.Text = "Возможные типы проводимых работ"
        Me.lblWorkTypes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbNotionOrgs
        '
        Me.txtbNotionOrgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbNotionOrgs.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbNotionOrgs.Location = New System.Drawing.Point(15, 205)
        Me.txtbNotionOrgs.Multiline = True
        Me.txtbNotionOrgs.Name = "txtbNotionOrgs"
        Me.txtbNotionOrgs.Size = New System.Drawing.Size(515, 75)
        Me.txtbNotionOrgs.TabIndex = 4
        Me.txtbNotionOrgs.Text = "Нет(Н);Рога и Копыта (РК);Ромашка(Р);Котлованы, ямы и траншеи(КЯТ)"
        Me.txtbNotionOrgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNotionOrgs
        '
        Me.lblNotionOrgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotionOrgs.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblNotionOrgs.Location = New System.Drawing.Point(15, 175)
        Me.lblNotionOrgs.Name = "lblNotionOrgs"
        Me.lblNotionOrgs.Size = New System.Drawing.Size(515, 25)
        Me.lblNotionOrgs.TabIndex = 3
        Me.lblNotionOrgs.Text = "Возможные организации, которые требуют отдельного уведомления"
        Me.lblNotionOrgs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbMasterNames
        '
        Me.txtbMasterNames.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbMasterNames.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbMasterNames.Location = New System.Drawing.Point(15, 85)
        Me.txtbMasterNames.Margin = New System.Windows.Forms.Padding(15, 5, 15, 10)
        Me.txtbMasterNames.Multiline = True
        Me.txtbMasterNames.Name = "txtbMasterNames"
        Me.txtbMasterNames.Size = New System.Drawing.Size(515, 75)
        Me.txtbMasterNames.TabIndex = 2
        Me.txtbMasterNames.Text = "Иванов;Петров;Сидоров"
        Me.txtbMasterNames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMasterNames
        '
        Me.lblMasterNames.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMasterNames.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblMasterNames.Location = New System.Drawing.Point(15, 55)
        Me.lblMasterNames.Name = "lblMasterNames"
        Me.lblMasterNames.Size = New System.Drawing.Size(515, 25)
        Me.lblMasterNames.TabIndex = 1
        Me.lblMasterNames.Text = "Возможные фамилии людей, на которых будут открываться ордера"
        Me.lblMasterNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblListsInfo
        '
        Me.lblListsInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblListsInfo.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblListsInfo.Location = New System.Drawing.Point(15, 15)
        Me.lblListsInfo.Name = "lblListsInfo"
        Me.lblListsInfo.Size = New System.Drawing.Size(515, 25)
        Me.lblListsInfo.TabIndex = 0
        Me.lblListsInfo.Text = "Здесь отображаются значения в списках."
        Me.lblListsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbcSettingsP3
        '
        Me.tbcSettingsP3.Controls.Add(Me.tlpSettingsTemplates)
        Me.tbcSettingsP3.Controls.Add(Me.btnHelpTmplt)
        Me.tbcSettingsP3.Controls.Add(Me.lblTmpltsInfo)
        Me.tbcSettingsP3.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.tbcSettingsP3.Location = New System.Drawing.Point(4, 26)
        Me.tbcSettingsP3.Margin = New System.Windows.Forms.Padding(5)
        Me.tbcSettingsP3.Name = "tbcSettingsP3"
        Me.tbcSettingsP3.Padding = New System.Windows.Forms.Padding(5)
        Me.tbcSettingsP3.Size = New System.Drawing.Size(545, 465)
        Me.tbcSettingsP3.TabIndex = 2
        Me.tbcSettingsP3.Text = "Шаблоны"
        Me.tbcSettingsP3.UseVisualStyleBackColor = True
        '
        'tlpSettingsTemplates
        '
        Me.tlpSettingsTemplates.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpSettingsTemplates.ColumnCount = 2
        Me.tlpSettingsTemplates.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSettingsTemplates.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSettingsTemplates.Controls.Add(Me.lblTmpltDocumentsDateStr, 0, 0)
        Me.tlpSettingsTemplates.Controls.Add(Me.txtbTmpltDocumentsDateStr, 0, 1)
        Me.tlpSettingsTemplates.Controls.Add(Me.txtbTmpltWorkType, 1, 7)
        Me.tlpSettingsTemplates.Controls.Add(Me.txtbTmpltWorkEndDate, 1, 3)
        Me.tlpSettingsTemplates.Controls.Add(Me.lblTmpltWorkType, 1, 6)
        Me.tlpSettingsTemplates.Controls.Add(Me.txtbTmpltGreenEndDate, 0, 5)
        Me.tlpSettingsTemplates.Controls.Add(Me.txtbTmpltNotionNumber, 1, 5)
        Me.tlpSettingsTemplates.Controls.Add(Me.lblTmpltWorkEndDate, 1, 2)
        Me.tlpSettingsTemplates.Controls.Add(Me.lblTmpltNotionNumber, 1, 4)
        Me.tlpSettingsTemplates.Controls.Add(Me.txtbTmpltWorkStartDate, 0, 3)
        Me.tlpSettingsTemplates.Controls.Add(Me.txtbTmpltDocumentsDateD, 1, 1)
        Me.tlpSettingsTemplates.Controls.Add(Me.lblTmpltDocumentsDateD, 1, 0)
        Me.tlpSettingsTemplates.Controls.Add(Me.lblTmpltWorkStartDate, 0, 2)
        Me.tlpSettingsTemplates.Controls.Add(Me.lblTmpltFullAdress, 0, 6)
        Me.tlpSettingsTemplates.Controls.Add(Me.txtbTmpltFullAdress, 0, 7)
        Me.tlpSettingsTemplates.Controls.Add(Me.lblTmpltGreenEndDate, 0, 4)
        Me.tlpSettingsTemplates.Location = New System.Drawing.Point(0, 55)
        Me.tlpSettingsTemplates.Name = "tlpSettingsTemplates"
        Me.tlpSettingsTemplates.RowCount = 8
        Me.tlpSettingsTemplates.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tlpSettingsTemplates.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tlpSettingsTemplates.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tlpSettingsTemplates.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tlpSettingsTemplates.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tlpSettingsTemplates.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tlpSettingsTemplates.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tlpSettingsTemplates.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tlpSettingsTemplates.Size = New System.Drawing.Size(545, 355)
        Me.tlpSettingsTemplates.TabIndex = 1
        '
        'lblTmpltDocumentsDateStr
        '
        Me.lblTmpltDocumentsDateStr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTmpltDocumentsDateStr.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltDocumentsDateStr.Location = New System.Drawing.Point(15, 10)
        Me.lblTmpltDocumentsDateStr.Margin = New System.Windows.Forms.Padding(15, 10, 5, 10)
        Me.lblTmpltDocumentsDateStr.Name = "lblTmpltDocumentsDateStr"
        Me.lblTmpltDocumentsDateStr.Size = New System.Drawing.Size(252, 24)
        Me.lblTmpltDocumentsDateStr.TabIndex = 8
        Me.lblTmpltDocumentsDateStr.Text = "Дата подачи документов"
        Me.lblTmpltDocumentsDateStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbTmpltDocumentsDateStr
        '
        Me.txtbTmpltDocumentsDateStr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbTmpltDocumentsDateStr.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltDocumentsDateStr.Location = New System.Drawing.Point(15, 54)
        Me.txtbTmpltDocumentsDateStr.Margin = New System.Windows.Forms.Padding(15, 10, 5, 10)
        Me.txtbTmpltDocumentsDateStr.Name = "txtbTmpltDocumentsDateStr"
        Me.txtbTmpltDocumentsDateStr.Size = New System.Drawing.Size(252, 25)
        Me.txtbTmpltDocumentsDateStr.TabIndex = 2
        Me.txtbTmpltDocumentsDateStr.Text = "«дд»<месяц><гггг>"
        Me.txtbTmpltDocumentsDateStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbTmpltWorkStartDate
        '
        Me.txtbTmpltWorkStartDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbTmpltWorkStartDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltWorkStartDate.Location = New System.Drawing.Point(15, 142)
        Me.txtbTmpltWorkStartDate.Margin = New System.Windows.Forms.Padding(15, 10, 5, 10)
        Me.txtbTmpltWorkStartDate.Name = "txtbTmpltWorkStartDate"
        Me.txtbTmpltWorkStartDate.Size = New System.Drawing.Size(252, 25)
        Me.txtbTmpltWorkStartDate.TabIndex = 4
        Me.txtbTmpltWorkStartDate.Text = "<нр.дд.мм.гггг>"
        Me.txtbTmpltWorkStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTmpltWorkStartDate
        '
        Me.lblTmpltWorkStartDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTmpltWorkStartDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltWorkStartDate.Location = New System.Drawing.Point(15, 98)
        Me.lblTmpltWorkStartDate.Margin = New System.Windows.Forms.Padding(15, 10, 5, 10)
        Me.lblTmpltWorkStartDate.Name = "lblTmpltWorkStartDate"
        Me.lblTmpltWorkStartDate.Size = New System.Drawing.Size(252, 24)
        Me.lblTmpltWorkStartDate.TabIndex = 12
        Me.lblTmpltWorkStartDate.Text = "Дата начала работ"
        Me.lblTmpltWorkStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHelpTmplt
        '
        Me.btnHelpTmplt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelpTmplt.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.btnHelpTmplt.Location = New System.Drawing.Point(15, 425)
        Me.btnHelpTmplt.Name = "btnHelpTmplt"
        Me.btnHelpTmplt.Size = New System.Drawing.Size(515, 25)
        Me.btnHelpTmplt.TabIndex = 10
        Me.btnHelpTmplt.Text = "Справка"
        Me.btnHelpTmplt.UseVisualStyleBackColor = True
        '
        'txtbTmpltGreenEndDate
        '
        Me.txtbTmpltGreenEndDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbTmpltGreenEndDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltGreenEndDate.Location = New System.Drawing.Point(15, 230)
        Me.txtbTmpltGreenEndDate.Margin = New System.Windows.Forms.Padding(15, 10, 5, 10)
        Me.txtbTmpltGreenEndDate.Name = "txtbTmpltGreenEndDate"
        Me.txtbTmpltGreenEndDate.Size = New System.Drawing.Size(252, 25)
        Me.txtbTmpltGreenEndDate.TabIndex = 6
        Me.txtbTmpltGreenEndDate.Text = "<б.дд.мм.гггг>"
        Me.txtbTmpltGreenEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTmpltGreenEndDate
        '
        Me.lblTmpltGreenEndDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTmpltGreenEndDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltGreenEndDate.Location = New System.Drawing.Point(15, 186)
        Me.lblTmpltGreenEndDate.Margin = New System.Windows.Forms.Padding(15, 10, 5, 10)
        Me.lblTmpltGreenEndDate.Name = "lblTmpltGreenEndDate"
        Me.lblTmpltGreenEndDate.Size = New System.Drawing.Size(252, 24)
        Me.lblTmpltGreenEndDate.TabIndex = 16
        Me.lblTmpltGreenEndDate.Text = "Дата окончания благоустройства"
        Me.lblTmpltGreenEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbTmpltWorkEndDate
        '
        Me.txtbTmpltWorkEndDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbTmpltWorkEndDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltWorkEndDate.Location = New System.Drawing.Point(277, 142)
        Me.txtbTmpltWorkEndDate.Margin = New System.Windows.Forms.Padding(5, 10, 15, 10)
        Me.txtbTmpltWorkEndDate.Name = "txtbTmpltWorkEndDate"
        Me.txtbTmpltWorkEndDate.Size = New System.Drawing.Size(253, 25)
        Me.txtbTmpltWorkEndDate.TabIndex = 5
        Me.txtbTmpltWorkEndDate.Text = "<кр.дд.мм.гггг>"
        Me.txtbTmpltWorkEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTmpltWorkEndDate
        '
        Me.lblTmpltWorkEndDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTmpltWorkEndDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltWorkEndDate.Location = New System.Drawing.Point(277, 98)
        Me.lblTmpltWorkEndDate.Margin = New System.Windows.Forms.Padding(5, 10, 15, 10)
        Me.lblTmpltWorkEndDate.Name = "lblTmpltWorkEndDate"
        Me.lblTmpltWorkEndDate.Size = New System.Drawing.Size(253, 24)
        Me.lblTmpltWorkEndDate.TabIndex = 14
        Me.lblTmpltWorkEndDate.Text = "Дата окончания работ"
        Me.lblTmpltWorkEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbTmpltDocumentsDateD
        '
        Me.txtbTmpltDocumentsDateD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbTmpltDocumentsDateD.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltDocumentsDateD.Location = New System.Drawing.Point(277, 54)
        Me.txtbTmpltDocumentsDateD.Margin = New System.Windows.Forms.Padding(5, 10, 15, 10)
        Me.txtbTmpltDocumentsDateD.Name = "txtbTmpltDocumentsDateD"
        Me.txtbTmpltDocumentsDateD.Size = New System.Drawing.Size(253, 25)
        Me.txtbTmpltDocumentsDateD.TabIndex = 3
        Me.txtbTmpltDocumentsDateD.Text = "<п.дд.мм.гггг>"
        Me.txtbTmpltDocumentsDateD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTmpltDocumentsDateD
        '
        Me.lblTmpltDocumentsDateD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTmpltDocumentsDateD.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltDocumentsDateD.Location = New System.Drawing.Point(277, 10)
        Me.lblTmpltDocumentsDateD.Margin = New System.Windows.Forms.Padding(5, 10, 15, 10)
        Me.lblTmpltDocumentsDateD.Name = "lblTmpltDocumentsDateD"
        Me.lblTmpltDocumentsDateD.Size = New System.Drawing.Size(253, 24)
        Me.lblTmpltDocumentsDateD.TabIndex = 10
        Me.lblTmpltDocumentsDateD.Text = "Дата подачи документов"
        Me.lblTmpltDocumentsDateD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbTmpltWorkType
        '
        Me.txtbTmpltWorkType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbTmpltWorkType.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltWorkType.Location = New System.Drawing.Point(277, 318)
        Me.txtbTmpltWorkType.Margin = New System.Windows.Forms.Padding(5, 10, 15, 10)
        Me.txtbTmpltWorkType.Name = "txtbTmpltWorkType"
        Me.txtbTmpltWorkType.Size = New System.Drawing.Size(253, 25)
        Me.txtbTmpltWorkType.TabIndex = 9
        Me.txtbTmpltWorkType.Text = "<вид_работ>"
        Me.txtbTmpltWorkType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTmpltWorkType
        '
        Me.lblTmpltWorkType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTmpltWorkType.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltWorkType.Location = New System.Drawing.Point(277, 274)
        Me.lblTmpltWorkType.Margin = New System.Windows.Forms.Padding(5, 10, 15, 10)
        Me.lblTmpltWorkType.Name = "lblTmpltWorkType"
        Me.lblTmpltWorkType.Size = New System.Drawing.Size(253, 24)
        Me.lblTmpltWorkType.TabIndex = 5
        Me.lblTmpltWorkType.Text = "Вид работ"
        Me.lblTmpltWorkType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbTmpltFullAdress
        '
        Me.txtbTmpltFullAdress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbTmpltFullAdress.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltFullAdress.Location = New System.Drawing.Point(15, 318)
        Me.txtbTmpltFullAdress.Margin = New System.Windows.Forms.Padding(15, 10, 5, 10)
        Me.txtbTmpltFullAdress.Name = "txtbTmpltFullAdress"
        Me.txtbTmpltFullAdress.Size = New System.Drawing.Size(252, 25)
        Me.txtbTmpltFullAdress.TabIndex = 8
        Me.txtbTmpltFullAdress.Text = "<адрес>"
        Me.txtbTmpltFullAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTmpltFullAdress
        '
        Me.lblTmpltFullAdress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTmpltFullAdress.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltFullAdress.Location = New System.Drawing.Point(15, 274)
        Me.lblTmpltFullAdress.Margin = New System.Windows.Forms.Padding(15, 10, 5, 10)
        Me.lblTmpltFullAdress.Name = "lblTmpltFullAdress"
        Me.lblTmpltFullAdress.Size = New System.Drawing.Size(252, 24)
        Me.lblTmpltFullAdress.TabIndex = 3
        Me.lblTmpltFullAdress.Text = "Полный адрес"
        Me.lblTmpltFullAdress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbTmpltNotionNumber
        '
        Me.txtbTmpltNotionNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbTmpltNotionNumber.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltNotionNumber.Location = New System.Drawing.Point(277, 230)
        Me.txtbTmpltNotionNumber.Margin = New System.Windows.Forms.Padding(5, 10, 15, 10)
        Me.txtbTmpltNotionNumber.Name = "txtbTmpltNotionNumber"
        Me.txtbTmpltNotionNumber.Size = New System.Drawing.Size(253, 25)
        Me.txtbTmpltNotionNumber.TabIndex = 7
        Me.txtbTmpltNotionNumber.Text = "<номер>"
        Me.txtbTmpltNotionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTmpltNotionNumber
        '
        Me.lblTmpltNotionNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTmpltNotionNumber.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltNotionNumber.Location = New System.Drawing.Point(277, 186)
        Me.lblTmpltNotionNumber.Margin = New System.Windows.Forms.Padding(5, 10, 15, 10)
        Me.lblTmpltNotionNumber.Name = "lblTmpltNotionNumber"
        Me.lblTmpltNotionNumber.Size = New System.Drawing.Size(253, 24)
        Me.lblTmpltNotionNumber.TabIndex = 1
        Me.lblTmpltNotionNumber.Text = "Номер уведомления"
        Me.lblTmpltNotionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTmpltsInfo
        '
        Me.lblTmpltsInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTmpltsInfo.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltsInfo.Location = New System.Drawing.Point(15, 15)
        Me.lblTmpltsInfo.Name = "lblTmpltsInfo"
        Me.lblTmpltsInfo.Size = New System.Drawing.Size(515, 25)
        Me.lblTmpltsInfo.TabIndex = 0
        Me.lblTmpltsInfo.Text = "Здесь представлены фразы-шаблоны для образцов."
        Me.lblTmpltsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbcSettingsP4
        '
        Me.tbcSettingsP4.Controls.Add(Me.btnTablePastPath)
        Me.tbcSettingsP4.Controls.Add(Me.txtbTablePastPath)
        Me.tbcSettingsP4.Controls.Add(Me.lblTablePastPath)
        Me.tbcSettingsP4.Controls.Add(Me.btnTableCurrentPath)
        Me.tbcSettingsP4.Controls.Add(Me.txtbTableCurrentPath)
        Me.tbcSettingsP4.Controls.Add(Me.lblTableCurrentPath)
        Me.tbcSettingsP4.Controls.Add(Me.txtbTableHeaders)
        Me.tbcSettingsP4.Controls.Add(Me.lblTableHeaders)
        Me.tbcSettingsP4.Controls.Add(Me.lblTableInfo)
        Me.tbcSettingsP4.Controls.Add(Me.btnTableHelp)
        Me.tbcSettingsP4.Location = New System.Drawing.Point(4, 26)
        Me.tbcSettingsP4.Margin = New System.Windows.Forms.Padding(5)
        Me.tbcSettingsP4.Name = "tbcSettingsP4"
        Me.tbcSettingsP4.Padding = New System.Windows.Forms.Padding(5)
        Me.tbcSettingsP4.Size = New System.Drawing.Size(545, 465)
        Me.tbcSettingsP4.TabIndex = 3
        Me.tbcSettingsP4.Text = "Таблицы"
        Me.tbcSettingsP4.UseVisualStyleBackColor = True
        '
        'btnTablePastPath
        '
        Me.btnTablePastPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTablePastPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTablePastPath.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.btnTablePastPath.ForeColor = System.Drawing.Color.Transparent
        Me.btnTablePastPath.Location = New System.Drawing.Point(505, 325)
        Me.btnTablePastPath.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTablePastPath.MaximumSize = New System.Drawing.Size(25, 25)
        Me.btnTablePastPath.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btnTablePastPath.Name = "btnTablePastPath"
        Me.btnTablePastPath.Size = New System.Drawing.Size(25, 25)
        Me.btnTablePastPath.TabIndex = 9
        Me.btnTablePastPath.UseVisualStyleBackColor = True
        '
        'txtbTablePastPath
        '
        Me.txtbTablePastPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbTablePastPath.Location = New System.Drawing.Point(15, 325)
        Me.txtbTablePastPath.Name = "txtbTablePastPath"
        Me.txtbTablePastPath.Size = New System.Drawing.Size(475, 25)
        Me.txtbTablePastPath.TabIndex = 8
        Me.txtbTablePastPath.Text = "D:\Ордера2019.txt(.csv)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtbTablePastPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTablePastPath
        '
        Me.lblTablePastPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTablePastPath.Location = New System.Drawing.Point(15, 295)
        Me.lblTablePastPath.Name = "lblTablePastPath"
        Me.lblTablePastPath.Size = New System.Drawing.Size(515, 25)
        Me.lblTablePastPath.TabIndex = 7
        Me.lblTablePastPath.Text = "Путь к таблице за прошлый год"
        Me.lblTablePastPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTableCurrentPath
        '
        Me.btnTableCurrentPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTableCurrentPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTableCurrentPath.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.btnTableCurrentPath.ForeColor = System.Drawing.Color.Transparent
        Me.btnTableCurrentPath.Location = New System.Drawing.Point(505, 255)
        Me.btnTableCurrentPath.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTableCurrentPath.MaximumSize = New System.Drawing.Size(25, 25)
        Me.btnTableCurrentPath.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btnTableCurrentPath.Name = "btnTableCurrentPath"
        Me.btnTableCurrentPath.Size = New System.Drawing.Size(25, 25)
        Me.btnTableCurrentPath.TabIndex = 6
        Me.btnTableCurrentPath.UseVisualStyleBackColor = True
        '
        'txtbTableCurrentPath
        '
        Me.txtbTableCurrentPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbTableCurrentPath.Location = New System.Drawing.Point(15, 255)
        Me.txtbTableCurrentPath.Name = "txtbTableCurrentPath"
        Me.txtbTableCurrentPath.Size = New System.Drawing.Size(475, 25)
        Me.txtbTableCurrentPath.TabIndex = 5
        Me.txtbTableCurrentPath.Text = "D:\Ордера2020.txt(.csv)"
        Me.txtbTableCurrentPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTableCurrentPath
        '
        Me.lblTableCurrentPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTableCurrentPath.Location = New System.Drawing.Point(12, 225)
        Me.lblTableCurrentPath.Name = "lblTableCurrentPath"
        Me.lblTableCurrentPath.Size = New System.Drawing.Size(515, 25)
        Me.lblTableCurrentPath.TabIndex = 4
        Me.lblTableCurrentPath.Text = "Путь к таблице за текущий год"
        Me.lblTableCurrentPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbTableHeaders
        '
        Me.txtbTableHeaders.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbTableHeaders.Location = New System.Drawing.Point(15, 85)
        Me.txtbTableHeaders.Multiline = True
        Me.txtbTableHeaders.Name = "txtbTableHeaders"
        Me.txtbTableHeaders.Size = New System.Drawing.Size(515, 125)
        Me.txtbTableHeaders.TabIndex = 3
        Me.txtbTableHeaders.Text = resources.GetString("txtbTableHeaders.Text")
        Me.txtbTableHeaders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTableHeaders
        '
        Me.lblTableHeaders.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTableHeaders.Location = New System.Drawing.Point(15, 55)
        Me.lblTableHeaders.Name = "lblTableHeaders"
        Me.lblTableHeaders.Size = New System.Drawing.Size(515, 25)
        Me.lblTableHeaders.TabIndex = 2
        Me.lblTableHeaders.Text = "Заголовки столбцов в таблицах"
        Me.lblTableHeaders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTableInfo
        '
        Me.lblTableInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTableInfo.Location = New System.Drawing.Point(15, 15)
        Me.lblTableInfo.Name = "lblTableInfo"
        Me.lblTableInfo.Size = New System.Drawing.Size(515, 25)
        Me.lblTableInfo.TabIndex = 1
        Me.lblTableInfo.Text = "Здесь представлены параметры для работы с таблицами"
        Me.lblTableInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTableHelp
        '
        Me.btnTableHelp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTableHelp.Location = New System.Drawing.Point(15, 425)
        Me.btnTableHelp.Name = "btnTableHelp"
        Me.btnTableHelp.Size = New System.Drawing.Size(515, 25)
        Me.btnTableHelp.TabIndex = 10
        Me.btnTableHelp.Text = "Справка"
        Me.btnTableHelp.UseVisualStyleBackColor = True
        '
        'tbcSettingsP5
        '
        Me.tbcSettingsP5.Controls.Add(Me.btnTableExtraHelp)
        Me.tbcSettingsP5.Controls.Add(Me.txtbTableExtraOutTemplate)
        Me.tbcSettingsP5.Controls.Add(Me.lblTableExtraInfo)
        Me.tbcSettingsP5.Location = New System.Drawing.Point(4, 26)
        Me.tbcSettingsP5.Name = "tbcSettingsP5"
        Me.tbcSettingsP5.Size = New System.Drawing.Size(545, 465)
        Me.tbcSettingsP5.TabIndex = 4
        Me.tbcSettingsP5.Text = "Таблицы Доп"
        Me.tbcSettingsP5.UseVisualStyleBackColor = True
        '
        'btnTableExtraHelp
        '
        Me.btnTableExtraHelp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTableExtraHelp.Location = New System.Drawing.Point(15, 425)
        Me.btnTableExtraHelp.Name = "btnTableExtraHelp"
        Me.btnTableExtraHelp.Size = New System.Drawing.Size(515, 25)
        Me.btnTableExtraHelp.TabIndex = 3
        Me.btnTableExtraHelp.Text = "Справка"
        Me.btnTableExtraHelp.UseVisualStyleBackColor = True
        '
        'txtbTableExtraOutTemplate
        '
        Me.txtbTableExtraOutTemplate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbTableExtraOutTemplate.Location = New System.Drawing.Point(15, 55)
        Me.txtbTableExtraOutTemplate.Multiline = True
        Me.txtbTableExtraOutTemplate.Name = "txtbTableExtraOutTemplate"
        Me.txtbTableExtraOutTemplate.Size = New System.Drawing.Size(515, 350)
        Me.txtbTableExtraOutTemplate.TabIndex = 2
        Me.txtbTableExtraOutTemplate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTableExtraInfo
        '
        Me.lblTableExtraInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTableExtraInfo.Location = New System.Drawing.Point(15, 15)
        Me.lblTableExtraInfo.Name = "lblTableExtraInfo"
        Me.lblTableExtraInfo.Size = New System.Drawing.Size(515, 25)
        Me.lblTableExtraInfo.TabIndex = 0
        Me.lblTableExtraInfo.Text = "Здесь находится поле ввода для формата вывода части таблицы"
        Me.lblTableExtraInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSaveSettings.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.btnSaveSettings.Location = New System.Drawing.Point(15, 525)
        Me.btnSaveSettings.MinimumSize = New System.Drawing.Size(190, 25)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(269, 25)
        Me.btnSaveSettings.TabIndex = 1
        Me.btnSaveSettings.Text = "Сохранить настройки"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'fbdExamplesDirPath
        '
        Me.fbdExamplesDirPath.Description = "Выберете папку, в которой лежат образцы документов для подачи заявки"
        Me.fbdExamplesDirPath.ShowNewFolderButton = False
        '
        'fbdOpenActsDirPath
        '
        Me.fbdOpenActsDirPath.Description = "Выберете папку, в которой будут лежать документы для открытия заявок"
        '
        'fbdClosedActsDirPath
        '
        Me.fbdClosedActsDirPath.Description = "Выберете папку, в которой будут лежать документы для закрытия заявок"
        '
        'btnSettingsReset
        '
        Me.btnSettingsReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSettingsReset.Location = New System.Drawing.Point(299, 525)
        Me.btnSettingsReset.MinimumSize = New System.Drawing.Size(190, 25)
        Me.btnSettingsReset.Name = "btnSettingsReset"
        Me.btnSettingsReset.Size = New System.Drawing.Size(269, 25)
        Me.btnSettingsReset.TabIndex = 2
        Me.btnSettingsReset.Text = "Сбросить настройки"
        Me.btnSettingsReset.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(583, 565)
        Me.Controls.Add(Me.btnSettingsReset)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.tbcSettings)
        Me.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.MinimumSize = New System.Drawing.Size(599, 604)
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Окно настроек"
        Me.tbcSettings.ResumeLayout(False)
        Me.tbcSettingP1.ResumeLayout(False)
        Me.tbcSettingP1.PerformLayout()
        Me.tbcSettingsP2.ResumeLayout(False)
        Me.tbcSettingsP2.PerformLayout()
        Me.tbcSettingsP3.ResumeLayout(False)
        Me.tlpSettingsTemplates.ResumeLayout(False)
        Me.tlpSettingsTemplates.PerformLayout()
        Me.tbcSettingsP4.ResumeLayout(False)
        Me.tbcSettingsP4.PerformLayout()
        Me.tbcSettingsP5.ResumeLayout(False)
        Me.tbcSettingsP5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcSettings As TabControl
    Friend WithEvents tbcSettingP1 As TabPage
    Friend WithEvents tbcSettingsP2 As TabPage
    Friend WithEvents tbcSettingsP3 As TabPage
    Friend WithEvents lblTmpltsInfo As Label
    Friend WithEvents lblTmpltNotionNumber As Label
    Friend WithEvents txtbTmpltNotionNumber As TextBox
    Friend WithEvents lblTmpltFullAdress As Label
    Friend WithEvents txtbTmpltFullAdress As TextBox
    Friend WithEvents lblTmpltWorkType As Label
    Friend WithEvents txtbTmpltWorkType As TextBox
    Friend WithEvents lblTmpltDocumentsDateStr As Label
    Friend WithEvents txtbTmpltDocumentsDateStr As TextBox
    Friend WithEvents lblTmpltDocumentsDateD As Label
    Friend WithEvents txtbTmpltDocumentsDateD As TextBox
    Friend WithEvents lblTmpltWorkStartDate As Label
    Friend WithEvents txtbTmpltWorkStartDate As TextBox
    Friend WithEvents lblTmpltWorkEndDate As Label
    Friend WithEvents txtbTmpltWorkEndDate As TextBox
    Friend WithEvents lblTmpltGreenEndDate As Label
    Friend WithEvents txtbTmpltGreenEndDate As TextBox
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents btnHelpTmplt As Button
    Friend WithEvents lblPathsInfo As Label
    Friend WithEvents lblExamplesDirPath As Label
    Friend WithEvents txtbClosedActsDirPath As TextBox
    Friend WithEvents lblClosedActsDirPath As Label
    Friend WithEvents txtbOpenActsDirPath As TextBox
    Friend WithEvents lblOpenActsDirPath As Label
    Friend WithEvents txtbExamplesDirPath As TextBox
    Friend WithEvents btnPathsHepl As Button
    Friend WithEvents fbdExamplesDirPath As FolderBrowserDialog
    Friend WithEvents btnExamplesDirPath As Button
    Friend WithEvents fbdOpenActsDirPath As FolderBrowserDialog
    Friend WithEvents fbdClosedActsDirPath As FolderBrowserDialog
    Friend WithEvents btnClosedActsDirPath As Button
    Friend WithEvents btnOpenActsDirPath As Button
    Friend WithEvents lblListsInfo As Label
    Friend WithEvents lblMasterNames As Label
    Friend WithEvents txtbMasterNames As TextBox
    Friend WithEvents lblNotionOrgs As Label
    Friend WithEvents txtbNotionOrgs As TextBox
    Friend WithEvents lblWorkTypes As Label
    Friend WithEvents txtbWorkTypes As TextBox
    Friend WithEvents btnListsHelp As Button
    Friend WithEvents tbcSettingsP4 As TabPage
    Friend WithEvents btnTableHelp As Button
    Friend WithEvents lblTableInfo As Label
    Friend WithEvents lblTableHeaders As Label
    Friend WithEvents txtbTableHeaders As TextBox
    Friend WithEvents lblTableCurrentPath As Label
    Friend WithEvents txtbTableCurrentPath As TextBox
    Friend WithEvents btnTableCurrentPath As Button
    Friend WithEvents btnTablePastPath As Button
    Friend WithEvents txtbTablePastPath As TextBox
    Friend WithEvents lblTablePastPath As Label
    Friend WithEvents ofdTableCurrenPath As OpenFileDialog
    Friend WithEvents ofdTablePastPath As OpenFileDialog
    Friend WithEvents tbcSettingsP5 As TabPage
    Friend WithEvents lblTableExtraInfo As Label
    Friend WithEvents txtbTableExtraOutTemplate As TextBox
    Friend WithEvents btnTableExtraHelp As Button
    Friend WithEvents btnSettingsReset As Button
    Friend WithEvents tlpSettingsTemplates As TableLayoutPanel
End Class
