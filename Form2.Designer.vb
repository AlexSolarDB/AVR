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
        Me.btnHelpTmplt = New System.Windows.Forms.Button()
        Me.txtbTmpltGreenEndDate = New System.Windows.Forms.TextBox()
        Me.lblTmpltGreenEndDate = New System.Windows.Forms.Label()
        Me.txtbTmpltWorkEndDate = New System.Windows.Forms.TextBox()
        Me.lblTmpltWorkEndDate = New System.Windows.Forms.Label()
        Me.txtbTmpltWorkStartDate = New System.Windows.Forms.TextBox()
        Me.lblTmpltWorkStartDate = New System.Windows.Forms.Label()
        Me.txtbTmpltDocumentsDateD = New System.Windows.Forms.TextBox()
        Me.lblTmpltDocumentsDateD = New System.Windows.Forms.Label()
        Me.txtbTmpltDocumentsDateStr = New System.Windows.Forms.TextBox()
        Me.lblTmpltDocumentsDateStr = New System.Windows.Forms.Label()
        Me.txtbTmpltWorkType = New System.Windows.Forms.TextBox()
        Me.lblTmpltWorkType = New System.Windows.Forms.Label()
        Me.txtbTmpltFullAdress = New System.Windows.Forms.TextBox()
        Me.lblTmpltFullAdress = New System.Windows.Forms.Label()
        Me.txtbTmpltNotionNumber = New System.Windows.Forms.TextBox()
        Me.lblTmpltNotionNumber = New System.Windows.Forms.Label()
        Me.lblTmpltsInfo = New System.Windows.Forms.Label()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.fbdExamplesDirPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.fbdOpenActsDirPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.fbdClosedActsDirPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.tbcSettings.SuspendLayout()
        Me.tbcSettingP1.SuspendLayout()
        Me.tbcSettingsP2.SuspendLayout()
        Me.tbcSettingsP3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcSettings
        '
        Me.tbcSettings.Controls.Add(Me.tbcSettingP1)
        Me.tbcSettings.Controls.Add(Me.tbcSettingsP2)
        Me.tbcSettings.Controls.Add(Me.tbcSettingsP3)
        Me.tbcSettings.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.tbcSettings.Location = New System.Drawing.Point(15, 15)
        Me.tbcSettings.Name = "tbcSettings"
        Me.tbcSettings.SelectedIndex = 0
        Me.tbcSettings.Size = New System.Drawing.Size(553, 495)
        Me.tbcSettings.TabIndex = 0
        '
        'tbcSettingP1
        '
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
        Me.tbcSettingP1.UseVisualStyleBackColor = True
        '
        'btnClosedActsDirPath
        '
        Me.btnClosedActsDirPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClosedActsDirPath.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.btnClosedActsDirPath.ForeColor = System.Drawing.Color.Transparent
        Me.btnClosedActsDirPath.Location = New System.Drawing.Point(505, 225)
        Me.btnClosedActsDirPath.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClosedActsDirPath.Name = "btnClosedActsDirPath"
        Me.btnClosedActsDirPath.Size = New System.Drawing.Size(25, 25)
        Me.btnClosedActsDirPath.TabIndex = 9
        Me.btnClosedActsDirPath.UseVisualStyleBackColor = True
        '
        'btnOpenActsDirPath
        '
        Me.btnOpenActsDirPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOpenActsDirPath.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.btnOpenActsDirPath.ForeColor = System.Drawing.Color.Transparent
        Me.btnOpenActsDirPath.Location = New System.Drawing.Point(505, 155)
        Me.btnOpenActsDirPath.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOpenActsDirPath.Name = "btnOpenActsDirPath"
        Me.btnOpenActsDirPath.Size = New System.Drawing.Size(25, 25)
        Me.btnOpenActsDirPath.TabIndex = 6
        Me.btnOpenActsDirPath.UseVisualStyleBackColor = True
        '
        'btnExamplesDirPath
        '
        Me.btnExamplesDirPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExamplesDirPath.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.btnExamplesDirPath.ForeColor = System.Drawing.Color.Transparent
        Me.btnExamplesDirPath.Location = New System.Drawing.Point(505, 85)
        Me.btnExamplesDirPath.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExamplesDirPath.Name = "btnExamplesDirPath"
        Me.btnExamplesDirPath.Size = New System.Drawing.Size(25, 25)
        Me.btnExamplesDirPath.TabIndex = 3
        Me.btnExamplesDirPath.UseVisualStyleBackColor = True
        '
        'btnPathsHepl
        '
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
        Me.lblPathsInfo.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblPathsInfo.Location = New System.Drawing.Point(16, 16)
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
        Me.tbcSettingsP3.Controls.Add(Me.btnHelpTmplt)
        Me.tbcSettingsP3.Controls.Add(Me.txtbTmpltGreenEndDate)
        Me.tbcSettingsP3.Controls.Add(Me.lblTmpltGreenEndDate)
        Me.tbcSettingsP3.Controls.Add(Me.txtbTmpltWorkEndDate)
        Me.tbcSettingsP3.Controls.Add(Me.lblTmpltWorkEndDate)
        Me.tbcSettingsP3.Controls.Add(Me.txtbTmpltWorkStartDate)
        Me.tbcSettingsP3.Controls.Add(Me.lblTmpltWorkStartDate)
        Me.tbcSettingsP3.Controls.Add(Me.txtbTmpltDocumentsDateD)
        Me.tbcSettingsP3.Controls.Add(Me.lblTmpltDocumentsDateD)
        Me.tbcSettingsP3.Controls.Add(Me.txtbTmpltDocumentsDateStr)
        Me.tbcSettingsP3.Controls.Add(Me.lblTmpltDocumentsDateStr)
        Me.tbcSettingsP3.Controls.Add(Me.txtbTmpltWorkType)
        Me.tbcSettingsP3.Controls.Add(Me.lblTmpltWorkType)
        Me.tbcSettingsP3.Controls.Add(Me.txtbTmpltFullAdress)
        Me.tbcSettingsP3.Controls.Add(Me.lblTmpltFullAdress)
        Me.tbcSettingsP3.Controls.Add(Me.txtbTmpltNotionNumber)
        Me.tbcSettingsP3.Controls.Add(Me.lblTmpltNotionNumber)
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
        'btnHelpTmplt
        '
        Me.btnHelpTmplt.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.btnHelpTmplt.Location = New System.Drawing.Point(15, 425)
        Me.btnHelpTmplt.Name = "btnHelpTmplt"
        Me.btnHelpTmplt.Size = New System.Drawing.Size(515, 25)
        Me.btnHelpTmplt.TabIndex = 18
        Me.btnHelpTmplt.Text = "Справка"
        Me.btnHelpTmplt.UseVisualStyleBackColor = True
        '
        'txtbTmpltGreenEndDate
        '
        Me.txtbTmpltGreenEndDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltGreenEndDate.Location = New System.Drawing.Point(16, 225)
        Me.txtbTmpltGreenEndDate.Name = "txtbTmpltGreenEndDate"
        Me.txtbTmpltGreenEndDate.Size = New System.Drawing.Size(250, 25)
        Me.txtbTmpltGreenEndDate.TabIndex = 17
        Me.txtbTmpltGreenEndDate.Text = "<б.дд.мм.гггг>"
        Me.txtbTmpltGreenEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTmpltGreenEndDate
        '
        Me.lblTmpltGreenEndDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltGreenEndDate.Location = New System.Drawing.Point(15, 195)
        Me.lblTmpltGreenEndDate.Name = "lblTmpltGreenEndDate"
        Me.lblTmpltGreenEndDate.Size = New System.Drawing.Size(250, 25)
        Me.lblTmpltGreenEndDate.TabIndex = 16
        Me.lblTmpltGreenEndDate.Text = "Дата окончания благоустройства"
        Me.lblTmpltGreenEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbTmpltWorkEndDate
        '
        Me.txtbTmpltWorkEndDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltWorkEndDate.Location = New System.Drawing.Point(281, 155)
        Me.txtbTmpltWorkEndDate.Name = "txtbTmpltWorkEndDate"
        Me.txtbTmpltWorkEndDate.Size = New System.Drawing.Size(250, 25)
        Me.txtbTmpltWorkEndDate.TabIndex = 15
        Me.txtbTmpltWorkEndDate.Text = "<кр.дд.мм.гггг>"
        Me.txtbTmpltWorkEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTmpltWorkEndDate
        '
        Me.lblTmpltWorkEndDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltWorkEndDate.Location = New System.Drawing.Point(280, 125)
        Me.lblTmpltWorkEndDate.Name = "lblTmpltWorkEndDate"
        Me.lblTmpltWorkEndDate.Size = New System.Drawing.Size(250, 25)
        Me.lblTmpltWorkEndDate.TabIndex = 14
        Me.lblTmpltWorkEndDate.Text = "Дата окончания работ"
        Me.lblTmpltWorkEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbTmpltWorkStartDate
        '
        Me.txtbTmpltWorkStartDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltWorkStartDate.Location = New System.Drawing.Point(16, 155)
        Me.txtbTmpltWorkStartDate.Name = "txtbTmpltWorkStartDate"
        Me.txtbTmpltWorkStartDate.Size = New System.Drawing.Size(250, 25)
        Me.txtbTmpltWorkStartDate.TabIndex = 13
        Me.txtbTmpltWorkStartDate.Text = "<нр.дд.мм.гггг>"
        Me.txtbTmpltWorkStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTmpltWorkStartDate
        '
        Me.lblTmpltWorkStartDate.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltWorkStartDate.Location = New System.Drawing.Point(15, 125)
        Me.lblTmpltWorkStartDate.Name = "lblTmpltWorkStartDate"
        Me.lblTmpltWorkStartDate.Size = New System.Drawing.Size(250, 25)
        Me.lblTmpltWorkStartDate.TabIndex = 12
        Me.lblTmpltWorkStartDate.Text = "Дата начала работ"
        Me.lblTmpltWorkStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbTmpltDocumentsDateD
        '
        Me.txtbTmpltDocumentsDateD.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltDocumentsDateD.Location = New System.Drawing.Point(281, 85)
        Me.txtbTmpltDocumentsDateD.Name = "txtbTmpltDocumentsDateD"
        Me.txtbTmpltDocumentsDateD.Size = New System.Drawing.Size(250, 25)
        Me.txtbTmpltDocumentsDateD.TabIndex = 11
        Me.txtbTmpltDocumentsDateD.Text = "<п.дд.мм.гггг>"
        Me.txtbTmpltDocumentsDateD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTmpltDocumentsDateD
        '
        Me.lblTmpltDocumentsDateD.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltDocumentsDateD.Location = New System.Drawing.Point(280, 55)
        Me.lblTmpltDocumentsDateD.Name = "lblTmpltDocumentsDateD"
        Me.lblTmpltDocumentsDateD.Size = New System.Drawing.Size(250, 25)
        Me.lblTmpltDocumentsDateD.TabIndex = 10
        Me.lblTmpltDocumentsDateD.Text = "Дата подачи документов"
        Me.lblTmpltDocumentsDateD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbTmpltDocumentsDateStr
        '
        Me.txtbTmpltDocumentsDateStr.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltDocumentsDateStr.Location = New System.Drawing.Point(16, 85)
        Me.txtbTmpltDocumentsDateStr.Name = "txtbTmpltDocumentsDateStr"
        Me.txtbTmpltDocumentsDateStr.Size = New System.Drawing.Size(250, 25)
        Me.txtbTmpltDocumentsDateStr.TabIndex = 9
        Me.txtbTmpltDocumentsDateStr.Text = "«дд»<месяц><гггг>"
        Me.txtbTmpltDocumentsDateStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTmpltDocumentsDateStr
        '
        Me.lblTmpltDocumentsDateStr.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltDocumentsDateStr.Location = New System.Drawing.Point(15, 55)
        Me.lblTmpltDocumentsDateStr.Name = "lblTmpltDocumentsDateStr"
        Me.lblTmpltDocumentsDateStr.Size = New System.Drawing.Size(250, 25)
        Me.lblTmpltDocumentsDateStr.TabIndex = 8
        Me.lblTmpltDocumentsDateStr.Text = "Дата подачи документов"
        Me.lblTmpltDocumentsDateStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbTmpltWorkType
        '
        Me.txtbTmpltWorkType.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltWorkType.Location = New System.Drawing.Point(281, 295)
        Me.txtbTmpltWorkType.Name = "txtbTmpltWorkType"
        Me.txtbTmpltWorkType.Size = New System.Drawing.Size(250, 25)
        Me.txtbTmpltWorkType.TabIndex = 6
        Me.txtbTmpltWorkType.Text = "<вид_работ>"
        Me.txtbTmpltWorkType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTmpltWorkType
        '
        Me.lblTmpltWorkType.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltWorkType.Location = New System.Drawing.Point(280, 265)
        Me.lblTmpltWorkType.Name = "lblTmpltWorkType"
        Me.lblTmpltWorkType.Size = New System.Drawing.Size(250, 25)
        Me.lblTmpltWorkType.TabIndex = 5
        Me.lblTmpltWorkType.Text = "Вид работ"
        Me.lblTmpltWorkType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbTmpltFullAdress
        '
        Me.txtbTmpltFullAdress.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltFullAdress.Location = New System.Drawing.Point(16, 295)
        Me.txtbTmpltFullAdress.Name = "txtbTmpltFullAdress"
        Me.txtbTmpltFullAdress.Size = New System.Drawing.Size(250, 25)
        Me.txtbTmpltFullAdress.TabIndex = 4
        Me.txtbTmpltFullAdress.Text = "<адрес>"
        Me.txtbTmpltFullAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTmpltFullAdress
        '
        Me.lblTmpltFullAdress.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltFullAdress.Location = New System.Drawing.Point(15, 265)
        Me.lblTmpltFullAdress.Name = "lblTmpltFullAdress"
        Me.lblTmpltFullAdress.Size = New System.Drawing.Size(250, 25)
        Me.lblTmpltFullAdress.TabIndex = 3
        Me.lblTmpltFullAdress.Text = "Полный адрес"
        Me.lblTmpltFullAdress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbTmpltNotionNumber
        '
        Me.txtbTmpltNotionNumber.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.txtbTmpltNotionNumber.Location = New System.Drawing.Point(281, 225)
        Me.txtbTmpltNotionNumber.Name = "txtbTmpltNotionNumber"
        Me.txtbTmpltNotionNumber.Size = New System.Drawing.Size(250, 25)
        Me.txtbTmpltNotionNumber.TabIndex = 2
        Me.txtbTmpltNotionNumber.Text = "<номер>"
        Me.txtbTmpltNotionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTmpltNotionNumber
        '
        Me.lblTmpltNotionNumber.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltNotionNumber.Location = New System.Drawing.Point(280, 195)
        Me.lblTmpltNotionNumber.Name = "lblTmpltNotionNumber"
        Me.lblTmpltNotionNumber.Size = New System.Drawing.Size(250, 25)
        Me.lblTmpltNotionNumber.TabIndex = 1
        Me.lblTmpltNotionNumber.Text = "Номер уведомления"
        Me.lblTmpltNotionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTmpltsInfo
        '
        Me.lblTmpltsInfo.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.lblTmpltsInfo.Location = New System.Drawing.Point(15, 15)
        Me.lblTmpltsInfo.Name = "lblTmpltsInfo"
        Me.lblTmpltsInfo.Size = New System.Drawing.Size(515, 25)
        Me.lblTmpltsInfo.TabIndex = 0
        Me.lblTmpltsInfo.Text = "Здесь представлены фразы-шаблоны для образцов."
        Me.lblTmpltsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.btnSaveSettings.Location = New System.Drawing.Point(17, 525)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(553, 25)
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
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(583, 565)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.tbcSettings)
        Me.Font = New System.Drawing.Font("Maple Mono", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(599, 604)
        Me.MinimumSize = New System.Drawing.Size(599, 604)
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Окно настроек"
        Me.tbcSettings.ResumeLayout(False)
        Me.tbcSettingP1.ResumeLayout(False)
        Me.tbcSettingP1.PerformLayout()
        Me.tbcSettingsP2.ResumeLayout(False)
        Me.tbcSettingsP2.PerformLayout()
        Me.tbcSettingsP3.ResumeLayout(False)
        Me.tbcSettingsP3.PerformLayout()
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
End Class
