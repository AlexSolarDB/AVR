Imports System.IO

Public Class SettingsForm

    '------------------------------------------------------------------------------------
    'Начало основного тела программы
    '------------------------------------------------------------------------------------

    'Блок кода, отрабатывающий при загрузке формы
    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Служебные строки-ответы
        Dim WrongParams As String = "Были считаны не все параметры, пожалуйста, проверьте их правильность."

        'Подгрузка необходимых иконок
        Me.Icon = My.Resources.Icon_AVR
        btnExamplesDirPath.BackgroundImage = My.Resources.folder_ico_15_15
        btnOpenActsDirPath.BackgroundImage = My.Resources.folder_ico_15_15
        btnClosedActsDirPath.BackgroundImage = My.Resources.folder_ico_15_15
        btnTableCurrentPath.BackgroundImage = My.Resources.folder_ico_15_15
        btnTablePastPath.BackgroundImage = My.Resources.folder_ico_15_15

        'Подгрузка текста для вкладки «Таблицы Доп»
        txtbTableExtraOutTemplate.Text = Settings.WarningMsg

        'Проверка наличия файла настроей и создания по необходимости
        If SomeChekers.FlChkr(Settings.IniPath) = False Then
            File.Create(Settings.IniPath)
            MessageBox.Show("Файл настроек не обнаружен и будет создан." & vbCrLf & "Поля заполнены значениями по умолчанию. Пожалуйста, заполните их Вашими значениями.")
            Exit Sub
        End If

        'Считывание группы путей к папкам
        Dim PathsArray As String() = {"", "", ""}
        If IniFile.MultiRead(Settings.DirPathsGroup, Settings.DirPathsArgs, PathsArray, 1024, Settings.IniPath) = False Then
            MessageBox.Show(WrongParams)
            Exit Sub
        Else
            txtbExamplesDirPath.Text = PathsArray(0)
            txtbOpenActsDirPath.Text = PathsArray(1)
            txtbClosedActsDirPath.Text = PathsArray(2)
        End If

        'Считывание группы списков
        Dim ListsArray As String() = {"", "", ""}
        If IniFile.MultiRead(Settings.ListsGroup, Settings.ListsArgs, ListsArray, 4096, Settings.IniPath) = False Then
            MessageBox.Show(WrongParams)
            Exit Sub
        Else
            txtbMasterNames.Text = ListsArray(0)
            txtbNotionOrgs.Text = ListsArray(1)
            txtbWorkTypes.Text = ListsArray(2)
        End If

        'Считывание группы шаблонов
        Dim TemplatesArray As String() = {"", "", "", "", "", "", "", ""}
        If IniFile.MultiRead(Settings.TemplatesGroup, Settings.TemplatesArgs, TemplatesArray, 1024, Settings.IniPath) = False Then
            MessageBox.Show(WrongParams)
            Exit Sub
        Else
            txtbTmpltNotionNumber.Text = TemplatesArray(0)
            txtbTmpltFullAdress.Text = TemplatesArray(1)
            txtbTmpltWorkType.Text = TemplatesArray(2)
            txtbTmpltDocumentsDateStr.Text = TemplatesArray(3)
            txtbTmpltDocumentsDateD.Text = TemplatesArray(4)
            txtbTmpltWorkStartDate.Text = TemplatesArray(5)
            txtbTmpltWorkEndDate.Text = TemplatesArray(6)
            txtbTmpltGreenEndDate.Text = TemplatesArray(7)
        End If

        'Считываниие группы таблиц
        Dim TablesArray As String() = {"", "", "", ""}
        If IniFile.MultiRead(Settings.TablesGroup, Settings.TablesArgs, TablesArray, 4096, Settings.IniPath) = False Then
            MessageBox.Show(WrongParams)
        Else
            txtbTableHeaders.Text = TablesArray(0)
            txtbTableCurrentPath.Text = TablesArray(1)
            txtbTablePastPath.Text = TablesArray(2)
            txtbTableExtraOutTemplate.Text = TablesArray(3)
        End If

    End Sub

    'Блок кода, обрабатывающий нажатие кнопки-папки напротив поля «путь к папке с  образцами»
    Private Sub btnExamplesDirPath_Click(sender As Object, e As EventArgs) Handles btnExamplesDirPath.Click
        Using fbdExamplesDirPath
            If fbdExamplesDirPath.ShowDialog() = DialogResult.OK Then
                txtbExamplesDirPath.Text = fbdExamplesDirPath.SelectedPath
            End If
        End Using
    End Sub

    'Блок кода, обрабатывающий нажатие кнопки-папки напротив поля «путь к папке с документами открытия»
    Private Sub btnOpenActsDirPath_Click(sender As Object, e As EventArgs) Handles btnOpenActsDirPath.Click
        Using fbdOpenActsDirPath
            If fbdOpenActsDirPath.ShowDialog() = DialogResult.OK Then
                txtbOpenActsDirPath.Text = fbdOpenActsDirPath.SelectedPath
            End If
        End Using
    End Sub

    'Блок кода, обрабатывающий нажатие кнопки-папки напротив поля «путь к папке с документами закрытия»
    Private Sub btnClosedActsDirPath_Click(sender As Object, e As EventArgs) Handles btnClosedActsDirPath.Click
        Using fbdClosedActsDirPath
            If fbdClosedActsDirPath.ShowDialog() = DialogResult.OK Then
                txtbClosedActsDirPath.Text = fbdClosedActsDirPath.SelectedPath
            End If
        End Using
    End Sub

    'Блок кода, обрабатывающий нажатие кнопки-папки напротив поля «путь к таблице за текущий год»
    Private Sub btnTableCurrentPath_Click(sender As Object, e As EventArgs) Handles btnTableCurrentPath.Click
        Using ofdTableCurrenPath
            ofdTableCurrenPath.InitialDirectory = System.Windows.Forms.Application.StartupPath
            ofdTableCurrenPath.Filter = "Таблицеподобные файлы (*.txt;*.csv)|*.txt;*.csv"
            If ofdTableCurrenPath.ShowDialog() = DialogResult.OK Then
                txtbTableCurrentPath.Text = ofdTableCurrenPath.FileName
            End If
        End Using
    End Sub

    'Блок кода, обрабатывающий нажатие кнопки-папки напротив поля «путь к таблице за прошлый год»
    Private Sub btnTablePastPath_Click(sender As Object, e As EventArgs) Handles btnTablePastPath.Click
        Using ofdTablePastPath
            ofdTablePastPath.InitialDirectory = System.Windows.Forms.Application.StartupPath
            ofdTablePastPath.Filter = "Таблицеподобные файлы (*.txt;*.csv)|*.txt;*.csv"
            If ofdTablePastPath.ShowDialog() = DialogResult.OK Then
                txtbTablePastPath.Text = ofdTablePastPath.FileName
            End If
        End Using
    End Sub

    'Блок кода, обрабатывающий нажатие кнопки «Справка» во вкладке «Пути»
    Private Sub btnPathsHepl_Click(sender As Object, e As EventArgs) Handles btnPathsHepl.Click
        MessageBox.Show("   На этой вкладке настроек представлены поля, в которых указаны пути, по которым расположены папки для документов." & vbCrLf &
                        "Изначально, поля будут содержать примеры путей. Вы вольны вписать Ваши пути в соответствующее поле (без кавычек) или выбрать их с помощью кнопок с изображением папки." & vbCrLf &
                        "Ожидается, что папка с образцами документов была подготовлена заранее, так что создать новую для этих целей нельзя." & vbCrLf &
                        "Папки для хранения документов для открытия и закрытия заявок могут быть изначально пустыми, так что заранее создать новые папки можно.")
    End Sub

    'Блок кода, обрабатывающий нажатие кнопки «Справка» во вкладке «Списки»
    Private Sub btnListsHelp_Click(sender As Object, e As EventArgs) Handles btnListsHelp.Click
        MessageBox.Show("   На этой вкладке настроек представлены поля, заполнение которых определит выбираемые элементы в соответствующих списках." & vbCrLf &
                        "Изначально в полях представлены образцы, в соответствии с которыми будет необходимо их заполнить Вашими значеними." & vbCrLf &
                        "Обратите внимание, что необходимо строго соблюдать изначальное оформление шаблонов (разделение через точку с запятой, без пробелов)." & vbCrLf &
                        "   Отдельно следует отметить следующее: фамилии в поле, названия папок в папке с образцами и фамилии в названии файлов с приказом должны совпадать;" & vbCrLf &
                        "Названия организаций обязательно должны иметь сокращённый вариант в скобках; начинаться с «Нет(Н)» и не повторяться в сокращениях." & vbCrLf &
                        "Сокращённые названия организаций должны находится в конце имени с файлом-уведомлением, например, «Уведомление_РК.docx»." & vbCrLf &
                        "   Виды выполняемых работ ограницены лишь согласованием с тем, на что заменяется шаблон при подготовке документов.")
    End Sub

    'Блок кода, обрабатывающий нажатие кнопки «Справка» во вкладке «Шаблоны»
    Private Sub btnHelpTmplt_Click(sender As Object, e As EventArgs) Handles btnHelpTmplt.Click
        MessageBox.Show("   На этой вкладке настроек представлены поля, заполнение которых определит строки-шаблоны в документах." & vbCrLf &
                        "Именно эти строки должны быть в документах-образцах на соответсвующих местах (совпадение строк в полях и внутри документов обязательно)." & vbCrLf &
                        "Изначально будут отображаться строки-шаблоны, представленные в предоставленных образцах. Однако Вы выольны их изменять, пока сохраняется условие выше.")
    End Sub

    'Блок кода, обрабатывающий нажатие кнопки «Справка» во вкладке «Таблицы»
    Private Sub btnTableHelp_Click(sender As Object, e As EventArgs) Handles btnTableHelp.Click
        MessageBox.Show("   На этой вкладке настроек предствалены поля, заполнение которых необходимо для корректной работы окна с таблицами." & vbCrLf &
            "   В поле для заголовков необходимо вписать через точку с запятой заголовки столбцов, которые будут использоваться в обоих таблицах. После последнего заголовка точка с зяпятой не ставится." & vbCrLf &
            "   В поле для пути таблицы за текущий год необходимо вписать (или выбрать кнопкой справа) путь к таблице, которая будет использоваться под ордера (заявки) в текущем году. Аналогично для поля для пути таблицы за прошлый год." & vbCrLf &
            "Если такое разделение на таблицы не требуется, то один и тот же путь выбирается в обоих полях.")
    End Sub

    'Блок кода, обрабатывающий нажатие кнопки «Справка» во вкладке «Таблицы Доп»
    Private Sub btnTableExtraHelp_Click(sender As Object, e As EventArgs) Handles btnTableExtraHelp.Click
        MessageBox.Show("   Поле на этой вкладке необходимо для определения собственного шаблона вывода в текстовый файл из таблицы в форме «Работа с таблицами»." & vbCrLf &
                        "Более подробно процесс написания шаблона описан документации на Github. Изменяйте это поле на свой страх и риск.")
    End Sub

    'Блок кода, обрабатывающий при нажатии на кнопку «Сохранить настройки»
    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click

        'Служебные строки-ответы
        Dim WrongPaths As String = "Сколько-то из указанных путей некорректны."
        Dim WriteFailed As String = "Не удалось записать в файл настроек сколько-то заполненных полей."
        Dim BlankFields As String = "Сколько-то из полей незаполнено."

        'Проверка на существование (возможность доступа) папок по указанным путям с последующей записью (вкладка «Пути»)
        Dim PathsArray As String() = {txtbExamplesDirPath.Text, txtbOpenActsDirPath.Text, txtbClosedActsDirPath.Text}
        If SomeChekers.MltDrChkr(PathsArray) = True Then
            If IniFile.MultiWrite(Settings.DirPathsGroup, Settings.DirPathsArgs, PathsArray, Settings.IniPath) = False Then
                MessageBox.Show(WriteFailed)
                Exit Sub
            End If
        Else
            MessageBox.Show(WrongPaths)
            Exit Sub
        End If

        'Проверка на пустоту полей на вкладке «списки» с последующей записью (вкладка «Списки»)
        Dim ListsArray As String() = {txtbMasterNames.Text, txtbNotionOrgs.Text, txtbWorkTypes.Text}
        If SomeChekers.MltNtBlkChkr(ListsArray) = True Then
            If IniFile.MultiWrite(Settings.ListsGroup, Settings.ListsArgs, ListsArray, Settings.IniPath) = False Then
                MessageBox.Show(WriteFailed)
                Exit Sub
            End If
        Else
            MessageBox.Show(BlankFields)
        End If

        'Проверка  на пустоту полей на вкладке «шаблоны» с последующей записью (вкладка «Шаблоны»)
        Dim TemplatesArray As String() = {
        txtbTmpltNotionNumber.Text,
        txtbTmpltFullAdress.Text,
        txtbTmpltWorkType.Text,
        txtbTmpltDocumentsDateStr.Text,
        txtbTmpltDocumentsDateD.Text,
        txtbTmpltWorkStartDate.Text,
        txtbTmpltWorkEndDate.Text,
        txtbTmpltGreenEndDate.Text
        }

        If SomeChekers.MltNtBlkChkr(TemplatesArray) = True Then
            If IniFile.MultiWrite(Settings.TemplatesGroup, Settings.TemplatesArgs, TemplatesArray, Settings.IniPath) = False Then
                MessageBox.Show(WriteFailed)
                Exit Sub
            End If
        Else
            MessageBox.Show(BlankFields)
        End If

        'Запись в файл настроек строки с заголовками таблиц
        Dim TableArray As String() = {
        txtbTableHeaders.Text,
        txtbTableCurrentPath.Text,
        txtbTablePastPath.Text,
        txtbTableExtraOutTemplate.Text
        }

        'Проверка на пустоту требуемых полей
        If SomeChekers.MltNtBlkChkr(TableArray) = True Then
            'Проверка на доступность файлов по указанным путям
            If SomeChekers.MltFlWDChkr({TableArray(1), TableArray(2)}) = True Then
                'Проверка на запись всех параметров
                If IniFile.MultiWrite(Settings.TablesGroup, Settings.TablesArgs, TableArray, Settings.IniPath) = False Then
                    MessageBox.Show(WriteFailed)
                    Exit Sub
                End If
            Else
                MessageBox.Show(WrongPaths)
                Exit Sub
            End If
        Else
            MessageBox.Show(BlankFields)
            Exit Sub
        End If

        'Если добрались сюда, то успешное завершение
        MessageBox.Show("Настройки успешно сохранены.")
        'Завершение с положительным результатом
        Me.DialogResult = DialogResult.OK

    End Sub

    'Блок кода, обрабатывающий нажатие кнопки «Сбросить настройки»
    Private Sub btnSettingsReset_Click(sender As Object, e As EventArgs) Handles btnSettingsReset.Click
        Dim Result As Integer = MessageBox.Show("Точно сбросить все настройки? Файл с настройками будет удалён, форма будет перезапущена, и все настройки вернуться на значения по умолчанию.",
                                                "Сброс настроек", MessageBoxButtons.YesNo
                                                )
        If Result = DialogResult.Yes Then
            'Если пользователь ответил «Да», удаляется файл настроек и полностью перезапускается форма
            File.Delete(Settings.IniPath)
            Me.Controls.Clear()
            InitializeComponent()
            SettingsForm_Load(e, e)
        End If

    End Sub

End Class