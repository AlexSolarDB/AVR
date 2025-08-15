Imports System.Drawing.Text
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports Microsoft.Office.Core

Public Class SettingsForm

    Private SettingsFileName As String = "settings.ini" 'Название файла натроек
    Private IniPath As String = IO.Path.Combine(System.Windows.Forms.Application.StartupPath, SettingsFileName) 'Полный путь в файлам настроек

    Private DirPathsGroup As String = "Paths" 'Переменная для названия группы путей к различным файлам в ini
    'Массив с названиями параметров
    Private DirPathsArgs As String() = {"ExamplesDirPath", "OpenActsDirPath", "ClosedActsDirPath"}

    Private ListsGroup As String = "Lists" 'Переменная для названия группы вкладки списков
    'Массив с названиями параметров
    Private ListsArgs As String() = {"MasterNames", "NotionOrgs", "WorkTypes"}

    Private TemplatesGroup As String = "Templates" 'Переменная для группы вкладки шаблонов
    'Массив с названиями параметров
    Private TemplatesArgs As String() = {
    "tmpltNotionNumber",
    "tmpltFullAdress",
    "tmpltWorkTtype",
    "tmpltDocumentsDateStr",
    "tmpltDocumentsDateD",
    "tmpltWorkStartDate",
    "tmpltWorkEndDate",
    "tmpltGreenEndDate"
    }

    'Песвдостандартная функция записи в INI файл.
    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Private Shared Function WritePrivateProfileString(lpAppName As String, lpKeyName As String, lpString As String, lpFileName As String) As Boolean
    End Function

    'Псевдостандартная функция чтения из INI файла.
    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode, SetLastError:=True)>
    Private Shared Function GetPrivateProfileString(lpAppName As String, lpKeyName As String, lpDefault As String, lpReturnedString As System.Text.StringBuilder, nSize As Integer, lpFileName As String) As Integer
    End Function

    'Функция записи в ini файл нескольких параметров (тупая, но рабочая)
    Private Function MultiIniWriteDumb(GroupName As String, ArgsNames As String(), Args As String(), iniPath As String) As Boolean
        Dim result As Boolean = True
        For i = 0 To Args.Count - 1
            result = result And WritePrivateProfileString(GroupName, ArgsNames(i), Args(i), iniPath)
        Next
        Return result
    End Function

    'Функция чтения из ini файла нескольких параметров (тупая, но рабочая)
    Private Function MultiIniReadDumb(GroupName As String, ArgsNames As String(), Args As String(), iniPath As String, bufferSize As Integer) As Boolean
        Dim result As Boolean = True
        Dim buffer As New StringBuilder(bufferSize)
        For i = 0 To Args.Count - 1
            result = result And GetPrivateProfileString(GroupName, ArgsNames(i), "", buffer, buffer.Capacity, iniPath)
            Args(i) = buffer.ToString()
        Next
        Return result
    End Function

    'Функция проверки существования папки
    Private Function DirCheck(DirPath As String) As Boolean
        Return Directory.Exists(DirPath)
    End Function

    'Проверка на существование неспольких папок
    Private Function MultiDirCheker(DirPaths As String()) As Boolean
        Dim result As Boolean = True
        For Each path As String In DirPaths
            result = result And DirCheck(path)
        Next
        Return result
    End Function

    'Функция проверки на пустоту поля
    Private Function NotBlankCheker(inStr As String) As Boolean
        If inStr = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    'Проверка на пустоту нескольких полей
    Private Function MultiNotBlankCheker(inStrs As String()) As Boolean
        Dim result As Boolean = True
        For Each strg In inStrs
            result = result And NotBlankCheker(strg)
        Next
        Return result
    End Function

    'Блок кода, отрабатывающий при загрузке формы
    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Подгрузка необходимых иконок
        Me.Icon = My.Resources.Icon_AVR
        btnExamplesDirPath.BackgroundImage = My.Resources.folder_ico_15_15
        btnOpenActsDirPath.BackgroundImage = My.Resources.folder_ico_15_15
        btnClosedActsDirPath.BackgroundImage = My.Resources.folder_ico_15_15

        'Проверка наличия файла настроей и создания по необходимости
        If File.Exists(IniPath) = False Then
            File.Create(IniPath)
            MessageBox.Show("Файл настроек не обнаружен и будет создан." & Chr(10) & "Поля заполнены значениями-образцами. Пожалуйста, заполните их Вашими значениями.")
            Exit Sub
        End If

        'Считывание группы путей к папкам
        Dim PathsArray As String() = {"", "", ""}
        If MultiIniReadDumb(DirPathsGroup, DirPathsArgs, PathsArray, IniPath, 1024) = False Then
            MessageBox.Show("Были считаны не все параметры, пожалуйста, попробуйте перезапустить программу.")
            Exit Sub
        Else
            txtbExamplesDirPath.Text = PathsArray(0)
            txtbOpenActsDirPath.Text = PathsArray(1)
            txtbClosedActsDirPath.Text = PathsArray(2)
        End If

        'Считывание группы списков
        Dim ListsArray As String() = {"", "", ""}
        If MultiIniReadDumb(ListsGroup, ListsArgs, ListsArray, IniPath, 4096) = False Then
            MessageBox.Show("Были считаны не все параметры, пожалуйста, попробуйте перезапустить программу.")
            Exit Sub
        Else
            txtbMasterNames.Text = ListsArray(0)
            txtbNotionOrgs.Text = ListsArray(1)
            txtbWorkTypes.Text = ListsArray(2)
        End If

        'Считывание группы шаблонов
        Dim TemplatesArray As String() = {"", "", "", "", "", "", "", ""}
        If MultiIniReadDumb(TemplatesGroup, TemplatesArgs, TemplatesArray, IniPath, 1024) = False Then
            MessageBox.Show("Были считаны не все параметры, пожалуйста, попробуйте перезапустить программу.")
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

    End Sub

    'Блок кода, отрабатывающий при нажатии на кнопку-папку напротив поля «путь к папке с  образцами»
    Private Sub btnExamplesDirPath_Click(sender As Object, e As EventArgs) Handles btnExamplesDirPath.Click
        Using fbdExamplesDirPath
            If fbdExamplesDirPath.ShowDialog() = DialogResult.OK Then
                txtbExamplesDirPath.Text = fbdExamplesDirPath.SelectedPath
            End If
        End Using
    End Sub

    'Блок кода, отрабатывающий при нажатии на кнопку-папку напротив поля «путь к папке с документами открытия»
    Private Sub btnOpenActsDirPath_Click(sender As Object, e As EventArgs) Handles btnOpenActsDirPath.Click
        Using fbdOpenActsDirPath
            If fbdOpenActsDirPath.ShowDialog() = DialogResult.OK Then
                txtbOpenActsDirPath.Text = fbdOpenActsDirPath.SelectedPath
            End If
        End Using
    End Sub

    'Блок кода, отрабатывающий при нажатии на кнопку-папку напротив поля «путь к папке с документами закрытия»
    Private Sub btnClosedActsDirPath_Click(sender As Object, e As EventArgs) Handles btnClosedActsDirPath.Click
        Using fbdClosedActsDirPath
            If fbdClosedActsDirPath.ShowDialog() = DialogResult.OK Then
                txtbClosedActsDirPath.Text = fbdClosedActsDirPath.SelectedPath
            End If
        End Using
    End Sub

    'Блок кода, отрабатывабщий при нажатии «Справка» во вкладке «Пути»
    Private Sub btnPathsHepl_Click(sender As Object, e As EventArgs) Handles btnPathsHepl.Click
        MessageBox.Show("На этой вкладке настроек представлены поля, в которых указаны пути, по которым расположены папки для документов." & Chr(10) &
                        "Изначально, поля будут содержать примеры путей. Вы вольны вписать Ваши пути в соответствующее поле (без кавычек) или выбрать их с помощью кнопок с изображением папки." & Chr(10) &
                        "Ожидается, что папка с образцами документов была подготовлена заранее, так что создать новую для этих целей нельзя." & Chr(10) &
                        "Папки для хранения документов для открытия и закрытия заявок могут быть изначально пустыми, так что создать новые папки можно.")
    End Sub

    'Блок кода, отрабатывающий при нажатии «Справка» во вкладке «Списки»
    Private Sub btnListsHelp_Click(sender As Object, e As EventArgs) Handles btnListsHelp.Click
        MessageBox.Show("На этой вкладке настроек представлены поля, заполнение которых определит выбираемые элементы в соответствующих списках." & Chr(10) &
                        "Изначально в полях представлены образцы, в соответствии с которыми будет необходимо их заполнить Вашими значеними." & Chr(10) &
                        "Обратите внимание, что необходимо строго соблюдать изначальное оформление шаблонов (разделение через точку с запятой, без пробелов)." & Chr(10) &
                        "Отдельно следует отметить следующее: фамилии в поле, названия папок в папке с образцами и фамилии в названии файлов с приказом должны совпадать;" & Chr(10) &
                        "Названия организаций обязательно должны иметь сокращённый вариант в скобках; начинаться с «Нет(Н)» и не повторяться в сокращениях." & Chr(10) &
                        "Сокращённые названия организаций должны находится в конце имени с файлом-уведомлением, например, «Уведомление_РК.docx»." & Chr(10) &
                        "Виды выполняемых работ ограницены лишь согласованием с тем, на что заменяется шаблон при подготовке документов.")
    End Sub

    'Блок кода, отрабатыващий при нажатии на кнопку «Справка» во вкладке «Шаблоны»
    Private Sub btnHelpTmplt_Click(sender As Object, e As EventArgs) Handles btnHelpTmplt.Click
        MessageBox.Show("На этой вкладке настроек представлены поля, заполнение которых определит строки-шаблоны в документах." & Chr(10) &
                        "Именно эти строки должны быть в документах-образцах на соответсвующих местах (совпадение строк в полях и внутри документов обязательно)." & Chr(10) &
                        "Изначально будут отображаться строки-шаблоны, представленные в предоставленных образцах. Однако Вы выольны их изменять, пока сохраняется условие выше.")
    End Sub

    'Блок кода, отрабатывающий при нажатии на кнопку «Сохранить настройки»
    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click

        'Проверка на существование (возможность доступа) папок по указанным путям с последующей записью
        Dim PathsArray As String() = {txtbExamplesDirPath.Text, txtbOpenActsDirPath.Text, txtbClosedActsDirPath.Text}
        If MultiDirCheker(PathsArray) = True Then
            If MultiIniWriteDumb(DirPathsGroup, DirPathsArgs, PathsArray, IniPath) = False Then
                MessageBox.Show("Не удалось записать в файл настроек сколько-то путей.")
                Exit Sub
            End If
        Else
            MessageBox.Show("Сколько-то из указанных путей некорректны.")
            Exit Sub
        End If

        'Проверка на пустоту полей на вкладке «списки» с последующей записью
        Dim ListsArray As String() = {txtbMasterNames.Text, txtbNotionOrgs.Text, txtbWorkTypes.Text}
        If MultiNotBlankCheker(ListsArray) = True Then
            If MultiIniWriteDumb(ListsGroup, ListsArgs, ListsArray, IniPath) = False Then
                MessageBox.Show("Не удалось записать в файл настроек сколько-то заполненных полей.")
                Exit Sub
            End If
        Else
            MessageBox.Show("Сколько-то из полей не заполнено.")
        End If

        'Проверка  на пустоту полей на вкладке «шаблоны» с последующей записью
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
        If MultiNotBlankCheker(TemplatesArray) = True Then
            If MultiIniWriteDumb(TemplatesGroup, TemplatesArgs, TemplatesArray, IniPath) = False Then
                MessageBox.Show("Не удалось записать в файл настроек сколько-то заполненных полей.")
                Exit Sub
            End If
        Else
            MessageBox.Show("Сколько-то полей не заполнено.")
        End If

        'Если добрались сюда, то успешное завершение
        MessageBox.Show("Настройки успешно сохранены.")
        'Завершение с положительным результатом
        Me.DialogResult = DialogResult.OK

    End Sub

End Class