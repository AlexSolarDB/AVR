Imports System.IO

'Модуль для функций, которые осуществляют некоторые проверки
Module SomeChekers

    'Символ возврата для всего модуля
    Private rtnSymbol As String = "^"

    'Возвращаемый символ по умолчанию
    Public ReadOnly Property ReturnSymbol As String
        Get
            Return rtnSymbol
        End Get
    End Property

    'Функция поиска запрещённых символов в строке
    Private Function WrongCharsDetector(inStr As String, exceptionChars As String()) As Boolean
        Dim exceptAmm As Integer
        For Each i In exceptionChars
            exceptAmm += inStr.IndexOf(i)
        Next
        If exceptAmm <> -(exceptionChars.Count) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Метод для анализа строк на запрещённые символы
    Public Function StrChkr(inStr As String, exceptionChars As String()) As String
        If WrongCharsDetector(inStr, exceptionChars) = False Then
            Return inStr
        Else
            Return ReturnSymbol
        End If
    End Function

    'Метод проверки существования одного файла
    Public Function FlChkr(filePath As String) As Boolean
        Return File.Exists(filePath)
    End Function

    'Метод проверки существования нескольких файлов в одной папке
    Public Function MltFlChkr(filePaths As String(), dirPath As String) As Boolean
        Dim result As Boolean = True
        For Each p As String In filePaths
            result = result And FlChkr(Path.Combine(dirPath, p))
        Next
        Return result
    End Function

    'Метод проверки существования нескольких фалов по абсолютным путям
    Public Function MltFlWDChkr(filePaths As String()) As Boolean
        Dim result As Boolean = True
        For Each p As String In filePaths
            result = result And FlChkr(p)
        Next
        Return result
    End Function

    'Метод проверки существования одной папки
    Public Function DrChkr(dirPath As String) As Boolean
        Return Directory.Exists(dirPath)
    End Function

    'Метод проверки на существование неспольких папок
    Public Function MltDrChkr(dirPaths As String()) As Boolean
        Dim result As Boolean = True
        For Each path As String In dirPaths
            result = result And DrChkr(path)
        Next
        Return result
    End Function

    'Метод проверки на пустоту одного поля
    Public Function NtBlkChkr(inStr As String) As Boolean
        If inStr = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    'Метод проверки на пустоту нескольких полей
    Public Function MltNtBlkChkr(inStrs As String()) As Boolean
        Dim result As Boolean = True
        For Each strg In inStrs
            result = result And NtBlkChkr(strg)
        Next
        Return result
    End Function

    'Метод проверки на существования выбранного элемента в одном списке
    Public Function LstSlctItmChkr(selectedItem As String) As Boolean
        If selectedItem IsNot Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    'Метод проверки на существования выбранного элемента в нескольких списках
    Public Function MltLstSlctItmChkr(selectedItems As String()) As Boolean
        Dim result As Boolean = True
        For Each item In selectedItems
            result = result And LstSlctItmChkr(item)
        Next
        Return result
    End Function

    'Функция проверки наличия заголовков в таблице
    Public Function HeadersChkr(DTable As System.Data.DataTable, Headers As String()) As String()
        Dim searchResult As Boolean = True
        'Поиск всех заголовков в таблице
        For Each header As String In Headers
            searchResult = searchResult And DTable.Columns.Contains(header)
        Next
        'Проерка результатов поиска: если результат 0, то хотябы один заголовок не наёшлся, так что весь шаблон мусор
        If searchResult = False Then
            Return {SomeChekers.ReturnSymbol}
        Else
            Return Headers
        End If
    End Function

    'Метод проверки на пустоту всего ряда DataTable
    Public Function RowBlackChkr(dtRow As DataRow) As String
        Dim result As String = ""
        For Each item In dtRow.ItemArray
            result = result & item
        Next
        If result = "" Then
            Return rtnSymbol
        Else
            Return result
        End If
    End Function

End Module
