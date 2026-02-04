Imports System.IO
Imports System.Reflection
Imports System.Text

Public Class csvDB

    'Переменная для считанной из настроек строки с заголовками
    Private TableHeadersString As String = ""
    'Перемменная для считанного из настроек пути с таблицей за текущий год
    Private TablePathCurrent As String = ""
    'Переменная для считанного из настроек пути с таблицей за прошлый год
    Private TablePathPast As String = ""
    'Переменая для считанного из настроек кастомного шаблона вывода
    Private TableCustomOutTemplate As String = ""

    'Переменная для хранения пути текущей загруженной таблицы
    Private CurrentTablePath As String = ""
    'Переменная для храненния количества считанных заголовков таблиц
    Private writtenHeadersCount As Integer = 0
    'Предсоздание таблицы для дальнейшей работы с ней
    Private table As New DataTable()

    'Служебная строка для оповещений
    Private TableNotLoaded As String = "Загрузите таблицу перед добавлением строк."

    'Функция выравнивания визуального представления таблицы по ширине
    Private Sub AutoDGVSize()
        For Each column In dgvCsv.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub

    'Функция включения двойного буффера для улучшения производительности формы в обход запрета не его изменение
    Private Sub EnableDoubleBuffering(dgv As DataGridView)
        'Получение класса типа System.Windows.Forms.DataGridView
        Dim dgvType As Type = dgv.GetType()
        'Поиск в классе нужного атрибута «DoubleBuffered» по флагам not shared/ not static и private/protected
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        'Устанавливаем для конкретного DataGridView найденный атрибут «DoubleBuffered» в состояние True. Nothing вместо индекса, так как нашли ровно один атрибут
        pi.SetValue(dgv, True, Nothing)
    End Sub

    '------------------------------------------------------------------------------------
    'Начало основного тела программы
    '------------------------------------------------------------------------------------

    'Блок кода отрабатывающий при загрузке формы
    Private Sub csvDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Подгрузка иконки 
        Me.Icon = My.Resources.Icon_AVR

        'Считываение параметров из файла настроек
        Dim TablesArray As String() = {"", "", "", ""}
        If IniFile.MultiRead(Settings.TablesGroup, Settings.TablesArgs, TablesArray, 8192, Settings.IniPath) = False Then
            MessageBox.Show("Были считаны не все параметры. Пожалуйста, перейдите в настройки и проверьте их правильность.")
        Else
            TableHeadersString = TablesArray(0)
            TablePathCurrent = TablesArray(1)
            TablePathPast = TablesArray(2)
            TableCustomOutTemplate = TablesArray(3)
        End If

        'Включение двойного буфера
        EnableDoubleBuffering(dgvCsv)

    End Sub

    'Блок кода, отрабатывающий при нажатии кнопки «Загрузить таблицу»
    Private Sub btnCsvLoad_Click(sender As Object, e As EventArgs) Handles btnCsvLoad.Click

        'Запрос у пользователя какую из таблиц загружать
        Dim TableNumber As Integer = MessageBox.Show("Загрузить таблицу за текущий год?", "Выбор таблицы", MessageBoxButtons.YesNo)
        'Обработка результата: если пользователь ответил «Да», то грузится таблица за год текущий. Если «нет» – за год прошлый.
        If TableNumber = DialogResult.Yes Then
            CurrentTablePath = TablePathCurrent
        ElseIf TableNumber = DialogResult.No Then
            CurrentTablePath = TablePathPast
        End If

        'Само считывание
        'Переменная для количества считанных столбцов (заголовков)
        If writtenHeadersCount = 0 Then
            'Если 0, ничего не считывалось ранее, поэтому создаём заголовки
            writtenHeadersCount = csvFile.AddHeadrsFromStr(TableHeadersString, table)
        Else
            'Если не 0, то ранее читалось, так что множим на ноль все строки старой таблицы
            table.Clear()
        End If

        'Читаем все строки специальной функцией
        csvFile.csvReadToDTWoHeaders(CurrentTablePath, table, writtenHeadersCount)

        dgvCsv.DataSource = table
        AutoDGVSize()
    End Sub

    'Блок кода, отрабатывающий при нажатии кнопки «Сохранить текущую таблицу»
    Private Sub btnSaveCsv_Click(sender As Object, e As EventArgs) Handles btnSaveCsv.Click
        'Проверка на наличие таблицы перед сохранением
        If CurrentTablePath = "" Then
            MessageBox.Show(TableNotLoaded)
            Exit Sub
        Else
            table = dgvCsv.DataSource
            csvFile.DTWriteToCsv(table, CurrentTablePath)
            MessageBox.Show("Успешно сохранено!")
        End If
    End Sub

    'Блок кода, отрабатывающий при нажатии кнопки «Добавить строку»
    Private Sub btnTableAddRow_Click(sender As Object, e As EventArgs) Handles btnTableAddRow.Click
        'Проверка на наличие таблицы при добавлении строк
        If CurrentTablePath = "" Then
            MessageBox.Show(TableNotLoaded)
            Exit Sub
        Else
            Dim TableRow As DataRow = table.NewRow()
            Dim inputColumn As String = ""
            For Each column As DataColumn In table.Columns
                inputColumn = InputBox(Prompt:=String.Format("Значение для столбца «{0}»", column.ToString()),
                                       Title:="Заполнение значений строки.",
                                       DefaultResponse:="--")
                If inputColumn = "" Then
                    Exit Sub
                Else
                    TableRow(column) = inputColumn
                End If
            Next
            table.Rows.Add(TableRow)
            AutoDGVSize()
        End If
    End Sub

    'Блок кода, обрабатывающий нажатие кнопки «Вывод части таблицы»
    Private Sub btnReportOut_Click(sender As Object, e As EventArgs) Handles btnReportOut.Click

        'Проверка на наличие таблицы перед выводом её части
        If CurrentTablePath = "" Then
            MessageBox.Show(TableNotLoaded)
            Exit Sub
        End If

        'Сохранение значений с DataGridView обратно в DataTable
        table = dgvCsv.DataSource

        'Если таки прошли дальше, то спрашиваем у пользователя строку с заголовками, по которым будет осуществлён вывод
        Dim OutResult As Integer = MessageBox.Show("Вывод по специальному шаблону из настроек?", "Выбор шаблона вывод", MessageBoxButtons.YesNo)
        If OutResult = DialogResult.No Then
            'Считывание шаблона, введённого пользователем
            Dim inputTemplate As String = InputBox(Prompt:="Введите заголовки столбцов, по которым будет осуществляться вывод.",
                                                   Title:="Выбор заголовков",
                                                   DefaultResponse:=TableHeadersString)
            'Выход, если пользователь ничего не указал, или нажал «Отмена»/закрыл окно
            If inputTemplate = "" Then
                MessageBox.Show("Шаблон для вывода не указан.")
                Exit Sub
            End If

            'Проверяем на наличие указанных заголовков
            Dim templateHeaders As String() = SomeChekers.HeadersChkr(table, Split(inputTemplate.Trim(Settings.DelimeterSymbol), Settings.DelimeterSymbol, -1, CompareMethod.Binary))
            If templateHeaders(0) = SomeChekers.ReturnSymbol Then
                MessageBox.Show("Один из заголовков указан неверно.")
                Exit Sub
            End If

            'Формируем путь файлу вывода
            Dim outPath As String = Path.Combine(CurrentTablePath.Replace(Path.GetFileName(CurrentTablePath), Path.GetFileNameWithoutExtension(CurrentTablePath) & " кратко.txt"))
            'Проверка его существования и создание, если отсутсвует
            If SomeChekers.FlChkr(outPath) = False Then
                File.Create(outPath)
            End If

            'Тупой, но рабочий способ создания строки для дальнейшей записи на основе массива с требуемыми заголовками
            Using txtWriter As New StreamWriter(outPath)
                Dim counter As Integer = 1
                'Обращаемся к каждой строчке в таблице
                For Each row In table.Rows
                    Dim outStringBuilder As New StringBuilder()
                    'Потом обращаемся к каждому заголовку в полученном шаблоне вывода
                    outStringBuilder.Append(String.Format("{0}. ", counter.ToString("00")))
                    For Each header As String In templateHeaders
                        outStringBuilder.Append(String.Format("{0} ", row(header).ToString()))
                    Next
                    counter = counter + 1
                    txtWriter.WriteLine(outStringBuilder.ToString())
                Next
            End Using

        ElseIf OutResult = DialogResult.Yes Then
            'Формируем путь файлу вывода
            Dim outPath As String = Path.Combine(CurrentTablePath.Replace(Path.GetFileName(CurrentTablePath), Path.GetFileNameWithoutExtension(CurrentTablePath) & " кратко.txt"))
            'Проверка его существования и создание, если отсутсвует
            If SomeChekers.FlChkr(outPath) = False Then
                File.Create(outPath)
            End If
            'Вызов функции обработки кастомных шаблонов
            TemplateParcer.CustomTemplateWrite(table, TableCustomOutTemplate, outPath)
        End If

        MessageBox.Show("Вывод завершён.")
    End Sub
End Class