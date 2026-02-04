Imports System.IO
Imports Microsoft.VisualBasic.FileIO
'Класс для работы с csv файлами
Module csvFile

    'Метод склейки в строку заголовков столбцов
    Public Function ColumnsToStr(Table As System.Data.DataTable) As String
        Dim OutStr As String = ""
        For Each Column In Table.Columns
            OutStr = OutStr & Column.ToString().Trim(" ") & Settings.DelimeterSymbol
        Next
        Return OutStr.TrimEnd(Settings.DelimeterSymbol)
    End Function

    'Метод добавления заголовков в таблицу из внешней строки
    Public Function AddHeadrsFromStr(HeadersString As String, DTable As System.Data.DataTable) As Integer
        Dim Headers As String() = Split(HeadersString, Settings.DelimeterSymbol, -1, CompareMethod.Binary)
        For Each header As String In Headers
            If header = "" Then
                DTable.Columns.Add("Без заголовка")
            Else
                DTable.Columns.Add(header)
            End If
        Next
        Return Headers.Count
    End Function

    'Метод добавления заголовков в таблицу из внешней строки с типами данных (работать не будет из-за очень тупового считывания)
    Public Function AddHeadrsFromStrDT(HeadersString As String, DTable As System.Data.DataTable) As Integer
        Dim Headers As Dictionary(Of String, String) = TemplateParcer.HeadersDtParcer(HeadersString)
        For Each headerPair As KeyValuePair(Of String, String) In Headers
            Dim newColumn As New DataColumn(headerPair.Key)
            If headerPair.Value = Settings.ColumnDataTypes(0) Then
                newColumn.DataType = System.Type.GetType("System.Integer")
            ElseIf headerPair.Value = Settings.ColumnDataTypes(1) Then
                newColumn.DataType = System.Type.GetType("System.Decimal")
            ElseIf headerPair.Value = Settings.ColumnDataTypes(2) Then
                newColumn.DataType = System.Type.GetType("System.DateTime")
            Else
                newColumn.DataType = System.Type.GetType("System.String")
            End If
            DTable.Columns.Add(newColumn)
        Next
        Return Headers.Count
    End Function

    'Метод чтения CSV файла (по справке Microsoft)
    Public Sub csvRead(path As String)
        Using csvReader As New TextFieldParser(path)
            csvReader.TextFieldType = FieldType.Delimited
            csvReader.SetDelimiters(Settings.DelimeterSymbol)
            Dim currentRow As String()
            While Not csvReader.EndOfData
                Try
                    currentRow = csvReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        If currentField = "" Then
                            currentField = "--"
                        End If
                        MsgBox(currentField)
                    Next
                Catch ex As MalformedLineException
                    MsgBox("Строка " & ex.Message & " повреждена и будет пропущена.")
                End Try
            End While
        End Using
    End Sub

    'Метод чтения CSV файла в DataTable
    Public Function csvReadToDT(path As String) As DataTable
        'Создание DataTable
        Dim dt As New DataTable()
        'Блок чтения csv через встроенные методы
        Using csvReader As New TextFieldParser(path)
            csvReader.TextFieldType = FieldType.Delimited
            'Объявление символа-разделителя в csv файле
            csvReader.SetDelimiters(Settings.DelimeterSymbol)

            'Считываение первой строки файла как заголовков таблицы
            Dim dtHeaders As String() = csvReader.ReadFields()
            For Each dtColumnHeader In dtHeaders
                If dtColumnHeader = "" Then
                    dt.Columns.Add("--")
                Else
                    dt.Columns.Add(dtColumnHeader)
                End If
            Next

            'Получение количества столбцов к DataTable для дальнейшей проверки на соответствие полученному
            Dim dtColumnAmm As Integer = dt.Columns.Count

            'Считывание остальных строк файла
            Dim currentRow As String()
            'Считывание до конца файла построчно
            While Not csvReader.EndOfData
                Try
                    currentRow = csvReader.ReadFields()
                    dt.Rows.Add(currentRow)
                Catch ex1 As MalformedLineException
                    MsgBox("Строка " & ex1.Message & " повреждена и будет пропущена.")
                Catch ex2 As Exception
                    MsgBox(ex2.Message)
                End Try
            End While
        End Using
        Return dt
    End Function

    'Метод чтения CSV файла в DataTable без заголовков в самом файле
    Public Sub csvReadToDTWoHeaders(path As String, DTable As System.Data.DataTable, columnsCount As Integer)
        'Блок чтения csv через встроенные методы
        Using csvReader As New TextFieldParser(path)
            csvReader.TextFieldType = FieldType.Delimited
            'Объявление символа-разделителя в csv файле
            csvReader.SetDelimiters(Settings.DelimeterSymbol)

            'Считывание остальных строк файла
            Dim currentRow As String()
            'Считывание до конца файла построчно
            While Not csvReader.EndOfData
                Try
                    currentRow = csvReader.ReadFields()
                    Dim currentColumnsCount As Integer = currentRow.Count
                    'Если всё ОК, просто добавляем
                    If currentColumnsCount = columnsCount Then
                        DTable.Rows.Add(currentRow)
                        'Если слишком мало считано, добавляем в конец «--» для соотнесения размера
                    ElseIf currentColumnsCount < columnsCount Then
                        Do While currentRow.Count <> columnsCount
                            Array.Resize(currentRow, currentRow.Length + 1)
                            currentRow(currentRow.Length - 1) = "--"
                        Loop
                        DTable.Rows.Add(currentRow)
                        'Если слишком много считано, то отрезаем лишнее
                    ElseIf currentColumnsCount > columnsCount Then
                        Array.Resize(currentRow, columnsCount)
                        DTable.Rows.Add(currentRow)
                    End If

                Catch ex1 As MalformedLineException
                    MsgBox("Строка " & ex1.Message & " повреждена и будет пропущена.")
                Catch ex2 As Exception
                    MsgBox(ex2.Message)
                End Try
            End While
        End Using
    End Sub

    'Метод записи в CSV файла из DataTable
    Public Sub DTWriteToCsv(table As DataTable, path As String)
        Using csvWriter As New StreamWriter(path, append:=False)
            'Запись всех рядов по порядку
            For Each Row In table.AsEnumerable() 'Возвращает объект DataRow
                'Если весь ряд пустой, то удаляем его при записи
                If SomeChekers.RowBlackChkr(Row) <> SomeChekers.ReturnSymbol Then
                    csvWriter.WriteLine(String.Join(Settings.DelimeterSymbol, Row.ItemArray)) 'Row.ItemArray предоставляет весь ряд в виде массива
                End If
            Next
        End Using
    End Sub
End Module
