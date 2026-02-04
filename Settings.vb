Module Settings
    Public ReadOnly Property IniPath As String
        Get
            Return IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "settings.ini")
        End Get
    End Property

    Public ReadOnly Property WarningMsg As String
        Get
            Return "Справка от разработчика прочтена, и мои действия осознаны."
        End Get
    End Property

    'Переменная для названия группы путей к различным файлам в ini
    Public ReadOnly Property DirPathsGroup As String
        Get
            Return "Paths"
        End Get
    End Property

    'Массив с названиями параметров
    Public ReadOnly Property DirPathsArgs As String()
        Get
            Return {"ExamplesDirPath", "OpenActsDirPath", "ClosedActsDirPath"}
        End Get
    End Property

    'Переменная для названия группы вкладки списков
    Public ReadOnly Property ListsGroup As String
        Get
            Return "Lists"
        End Get
    End Property

    'Массив с названиями параметров
    Public ReadOnly Property ListsArgs As String()
        Get
            Return {"MasterNames", "NotionOrgs", "WorkTypes"}
        End Get
    End Property

    'Переменная для группы вкладки шаблонов
    Public ReadOnly Property TemplatesGroup As String
        Get
            Return "Templates"
        End Get
    End Property

    'Массив с названиями параметров
    Public ReadOnly Property TemplatesArgs As String()
        Get
            Return {
    "tmpltNotionNumber",
    "tmpltFullAdress",
    "tmpltWorkTtype",
    "tmpltDocumentsDateStr",
    "tmpltDocumentsDateD",
    "tmpltWorkStartDate",
    "tmpltWorkEndDate",
    "tmpltGreenEndDate"
    }
        End Get
    End Property

    'Переменная для группы вкладки «Таблицы»
    Public ReadOnly Property TablesGroup As String
        Get
            Return "Tables"
        End Get
    End Property

    'Массив с названиями параметров
    Public ReadOnly Property TablesArgs As String()
        Get
            Return {
                "Headers",
                "CurrentPath",
                "PastPath",
                "OutTemplate"
                }
        End Get
    End Property

    'Стандартный символ-делитель для файлов и строк
    Public ReadOnly Property DelimeterSymbol As String
        Get
            Return ";"
        End Get
    End Property

    'Типы данных для заголовков столбцов в таблицах
    Public ReadOnly Property ColumnDataTypes As String()
        Get
            Return {
                "цч",
                "дч",
                "дт"
                }
        End Get
    End Property

End Module
