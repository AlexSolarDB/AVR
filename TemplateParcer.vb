'Костыльно-кустарны модуль для парсинга строки-шаблона кастномного вывода
'с вкладки настроек «Таблицы Доп».
'Часть функций будет пересекаться и дублироваться, что плохо.
'Но это сделано для какой-никакой универсальности (или попытки в неё)
'Выводы в файл должны осуществляться чем-то иным.

'@ – символ новой строки
'_ _ – обозначение заголовоков строки
'{} – обозначение границ условия
'{_header_=value} – пример условия
'{типданных} – пример условия типа данных

Imports System.IO
Imports System.Text.RegularExpressions

Module TemplateParcer

    'Переменная для поиска шаблона условия на основе регулярных выражений
    Private ConditionFormat As String = "\{_(.+?)_=(.+?)\}"
    '\ – здесь символ экранирования служебных {}
    '() – создаёт индексируемую группу для дальнейшего прямого обращения
    '. – любой сивол, кроме символа новой линии
    '+? – «lazy» поиск: ищет по минимуму, до тех пор, пока не наткнётся на конец группы (_=)

    'Переменная для поиска шаблона заголовков на основе регулярных выражений
    Private HeadersFormat As String = "_([^_]+)_"
    '() – создаёт индексируемую группу для дальнейшего прямого обращения
    '[] – создаёт «набор» символов
    '[^_] – все символы, кроме «_» попадают в набор
    '+ – «greedy» поиск всех символов по набору выше (пока не «_» собираем все символы)

    'Формат шаблона для указания типа данных в заголовке
    Private DataTypeHeadersFormat As String = "\{(.*?)\}"
    '\ – здесь символ экранирования служебных {}
    '() – создаёт индексируемую группу для дальнейшего прямого обращения
    '. – любой сивол, кроме символа новой линии
    '+? – «lazy» поиск: ищет по минимуму, до тех пор, пока не наткнётся на конец группы \}

    'Переменная для символа новой строки в рамках парсера
    Private NewLineSymbol As String = "@"

    'Метод для разделения строк по символам новой строки
    Public Function NLSplit(InString As String) As String()
        Return Split(InString, NewLineSymbol, -1, CompareMethod.Binary)
    End Function

    'Метод для разметки на «чистые» строки и строки с условиями
    Public Function StringMarker(SplittedString As String()) As Boolean()
        Dim MarkerList As Boolean() = {}
        For Each str As String In SplittedString
            If str.IndexOf("{") <> 0 = True Then
                Array.Resize(MarkerList, MarkerList.Length + 1)
                MarkerList(MarkerList.Length - 1) = False
            Else
                Array.Resize(MarkerList, MarkerList.Length + 1)
                MarkerList(MarkerList.Length - 1) = True
            End If
        Next
        Return MarkerList
    End Function

    'Метод вычлинения условий из строки-шаблона
    Private Function ConditionExtracter(ConditionString As String) As Dictionary(Of String, String)
        'Словарь для возврата пары «заголовок – значение»
        Dim ConditionPair As Dictionary(Of String, String) = New Dictionary(Of String, String)
        'Хранение результата поиска всех условий в строке
        Dim ConditionMatches As MatchCollection = Regex.Matches(ConditionString, ConditionFormat)
        'Цикл вычлинения всех пар условий
        For Each FoundConditionGroup As Match In ConditionMatches
            Dim header As String = FoundConditionGroup.Groups(1).Value.Trim()
            Dim value As String = FoundConditionGroup.Groups(2).Value.Trim()
            ConditionPair.Add(header, value)
        Next
        Return ConditionPair
    End Function

    'Метод удаления самих условий из строки (замена на пустую строку)
    Private Function ConditionReplacer(ConditionString As String, Condition As String) As String
        Return Regex.Replace(ConditionString, Condition, "")
    End Function

    'Метод проверки всех значений в ряде на соответсвие условиям
    Public Function ConditionMarker(ConditionString As String, tableRow As DataRow) As Boolean
        Dim Marker As Boolean = True
        Dim Conditions As Dictionary(Of String, String) = ConditionExtracter(ConditionString)
        For Each conditionPair In Conditions
            Try
                If tableRow(conditionPair.Key) = conditionPair.Value Then
                    Marker = Marker And True
                Else
                    Marker = Marker And False
                End If
            Catch ex As Exception
                Marker = False
                Exit For
            End Try
        Next
        Return Marker
    End Function

    'Метод замены шаблона заголовка столбца на его значение
    Private Function HeadersReplacer(unconditionedString As String, tableRow As DataRow) As String
        Dim resultString As String = unconditionedString
        Dim HeadersMatches As MatchCollection = Regex.Matches(resultString, HeadersFormat)
        Dim headerMatch As String
        Dim Header As String
        For Each foundHeadersGroup As Match In HeadersMatches
            headerMatch = foundHeadersGroup.Groups(0).Value
            Header = headerMatch.Trim("_")
            Try
                resultString = resultString.Replace(headerMatch, tableRow(Header))
            Catch ex As Exception
                resultString = ""
            End Try
        Next
        Return resultString
    End Function

    'Метод формирования итоговой строки для последющей записи
    Public Function ResultStringFormer(conditionedString As String, tableRow As DataRow) As String
        Dim unconditionedString As String = ConditionReplacer(conditionedString, ConditionFormat)
        Dim resultString As String = HeadersReplacer(unconditionedString, tableRow)
        Return resultString
    End Function

    'Метод записи в файл по кастомному обработчику через TemplateParcer
    Public Sub CustomTemplateWrite(DTable As DataTable, TemplateString As String, path As String)
        Dim SplittedString As String() = TemplateParcer.NLSplit(TemplateString)
        Dim StringMarkers As Boolean() = TemplateParcer.StringMarker(SplittedString)
        Dim counter As Integer = SplittedString.GetLowerBound(0)
        Using txtWriter As New StreamWriter(path)
            While counter <= SplittedString.GetUpperBound(0)
                Dim number As Integer = 1
                If StringMarkers(counter) = False Then
                    txtWriter.WriteLine(SplittedString(counter))
                Else
                    For Each tableRow As DataRow In DTable.Rows
                        Dim conditionMarker As Boolean = TemplateParcer.ConditionMarker(SplittedString(counter), tableRow)
                        If conditionMarker = True Then
                            Dim resultString As String = TemplateParcer.ResultStringFormer(SplittedString(counter), tableRow)
                            txtWriter.WriteLine(number.ToString("00. ") & resultString)
                            number = number + 1
                        End If
                    Next
                    txtWriter.WriteLine("")
                End If
                counter = counter + 1
            End While
        End Using
    End Sub

    'Метод разделения заголовков на само название и тип данных заголовка
    Public Function HeadersDtParcer(headersString As String) As Dictionary(Of String, String)
        'Разделение на заголовки
        Dim Headers As String() = Split(headersString, Settings.DelimeterSymbol, -1, CompareMethod.Binary)
        'Словарь для формирования пар «заголовок-тип данных»
        Dim HeaderPairs As New Dictionary(Of String, String)
        For Each conditionedHeader As String In Headers
            Dim DtMatch As Match = Regex.Match(conditionedHeader, DataTypeHeadersFormat)
            Dim dataType As String = DtMatch.Groups(0).Value.TrimEnd("}").TrimStart("{")
            Dim unconditionedHeader As String = ConditionReplacer(conditionedHeader, DataTypeHeadersFormat)
            HeaderPairs.Add(unconditionedHeader, dataType)
        Next
        Return HeaderPairs
    End Function

End Module
