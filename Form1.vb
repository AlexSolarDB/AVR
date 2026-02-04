Imports System.IO
Imports System.IO.Compression
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word

Public Class MainForm

    'Боковые и нижняя границы: 8
    'Верхняя граница: 31

    'Массив для считанных параметов
    Private PathsArray As String() = {"", "", ""}

    'Массив для считанных параметров
    Private ListsArray As String() = {"", "", ""}
    'Массив для сокращений названий организаций
    Private NotionOrgsShort As String() = {}

    'Массив для считанных параметров
    Private TemplatesArray As String() = {"", "", "", "", "", "", "", ""}

    'Функция-парсер даты (скорее проверки на введение даты)
    Private Function DateParcer(inStr As String, dFormat As String) As String
        Dim parcedDate As Date
        If Date.TryParse(inStr, parcedDate) <> True Then
            Return SomeChekers.ReturnSymbol
        Else
            Return parcedDate.ToString(dFormat)
        End If
    End Function

    'Функция-парсер строк вида «сс;сс;сс»
    Private Function StringParcerList(inStr As String, delChar As String) As String()
        Dim parcedString As String() = Split(inStr, delChar, -1, CompareMethod.Binary)
        If parcedString(0) = "" Or parcedString(0) = inStr Then
            Return {SomeChekers.ReturnSymbol}
        Else
            Return parcedString
        End If
    End Function

    'Функция-парсер выделения символов в скобках
    Private Function StringCutBrackets(inStrings As String) As String
        Dim leftBorder As Integer = inStrings.IndexOf("(") + 1
        Dim rightBorder As Integer = inStrings.IndexOf(")")
        Return inStrings.Substring(leftBorder, rightBorder - leftBorder)
    End Function

    'Функция проверки на Integer
    Private Function IntParcer(inStr As String) As String
        Dim tempInt As Integer
        If Int32.TryParse(inStr, tempInt) <> True Then
            Return SomeChekers.ReturnSymbol
        Else
            Return inStr
        End If
    End Function

    'Функция преведения даты к формату «дд» месяц гггг
    Private Function DateTransformer(inStr As String, MonthsArr As String()) As String
        Dim RawDate As Date = Date.Parse(inStr)
        Return String.Format("«{0}» {1} {2}", RawDate.Day.ToString("00"), MonthsArr(RawDate.Month), RawDate.Year.ToString())
    End Function

    'Функция копирования выбранных файлов
    Private Sub ChoosenFilesCopy(outFolder As String, distFolder As String, neededFiles As String(), creationFlag As Boolean)
        If creationFlag = True Then
            If Directory.Exists(distFolder) = True Then
                MessageBox.Show(String.Format("Папка «{0}» уже существует. Проверьте правильность введённых Вами данных", distFolder))
                Exit Sub
            Else
                Directory.CreateDirectory(distFolder)
            End If
        End If

        If Directory.Exists(outFolder) = False Then
            MessageBox.Show(String.Format("Папка «{0}» не существует. Проверьте правильность введённых Вами данных", outFolder))
            Exit Sub
        End If

        Dim counter As Integer = 0
        For Each fileName In neededFiles
            Dim fullPathIn As String = Path.Combine(outFolder, fileName)
            If File.Exists(fullPathIn) = True Then
                File.Copy(fullPathIn, Path.Combine(distFolder, fileName), overwrite:=True)
                counter += 1
            Else
                Continue For
            End If
        Next

    End Sub

    'Функция поиска и замены строк по шаблону для Word
    Private Function StringReplace(docSelection As Microsoft.Office.Interop.Word.Selection, tmpltString As String, userString As String,
                                   FdEtParams As (MatchCase As Boolean, MatchWholeWord As Boolean, MatchWildcards As Boolean,
                                   MatchSoundsLike As Boolean, MatchAllWordsForms As Boolean, Forward As Boolean,
                                   Wrap As Integer, Format As Boolean, Replace As Integer))

        Return docSelection.Find.Execute(tmpltString, FdEtParams.MatchCase, FdEtParams.MatchWholeWord, FdEtParams.MatchWildcards,
                                         FdEtParams.MatchSoundsLike, FdEtParams.MatchAllWordsForms, FdEtParams.Forward,
                                         FdEtParams.Wrap, FdEtParams.Format, userString, FdEtParams.Replace)
    End Function

    'Функция редактирования документа Word (поиск и замена строк)
    Private Sub DocEdit(WordApp As Word.Application, dirPath As String, edFileName As String, strsArray As String(,),
                             FdEtParams As (MatchCase As Boolean, MatchWholeWord As Boolean, MatchWildcards As Boolean,
                                   MatchSoundsLike As Boolean, MatchAllWordsForms As Boolean, Forward As Boolean,
                                   Wrap As Integer, Format As Boolean, Replace As Integer),
                             DtCsParams As (SaveChanges As Integer, OriginalFormat As Integer))

        Dim Document As Word.Document = WordApp.Documents.Open(dirPath & "\" & edFileName)
        Dim Selection As Word.Selection = WordApp.Selection
        For i As Integer = 0 To strsArray.GetLength(1) - 1
            StringReplace(Selection, strsArray(0, i), strsArray(1, i), FdEtParams)
        Next
        Document.Close(DtCsParams.SaveChanges, DtCsParams.OriginalFormat)

    End Sub

    'Функция удаление файла из архива
    Private Sub DelFromArchive(archPath As String, delFileName As String)
        Using archive As ZipArchive = ZipFile.Open(archPath, ZipArchiveMode.Update)
            Dim File As Object = archive.GetEntry(delFileName)
            If File IsNot Nothing Then
                File.Delete()
                Exit Sub
            Else
                MessageBox.Show(String.Format("Файл «{0}» не найден.", delFileName))
                Exit Sub
            End If
        End Using
    End Sub

    'Функция удаления файла(-ов) из папки
    Private Sub DelFiles(dirPath As String, delFilesNames As String())
        If Directory.Exists(dirPath) = False Then
            MessageBox.Show(String.Format("Папка{0}«{1}»{2}не существует.", vbCrLf, dirPath, vbCrLf))
            Exit Sub
        End If

        For Each FileName As String In delFilesNames
            Dim filePath As String = Path.Combine(dirPath, FileName)
            If File.Exists(filePath) = True Then
                File.Delete(filePath)
            Else
                Continue For
            End If
        Next
    End Sub

    '------------------------------------------------------------------------------------
    'Начало основного тела программы
    '------------------------------------------------------------------------------------

    'Блок кода, отрабатывающий при загрузке программы
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Подгрузка необходимых иконок
        Me.Icon = My.Resources.Icon_AVR

        'Проверка на существоание файла настроек
        If SomeChekers.FlChkr(Settings.IniPath) = False Then
            MessageBox.Show("Файл настроек не обнаружен. Пожалуйста, перейдите в настройки и заполните их.")
            Exit Sub
        End If

        'Считывание из ini необходимых параметров
        'Путей к папкам
        If IniFile.MultiRead(Settings.DirPathsGroup, Settings.DirPathsArgs, PathsArray, 1024, Settings.IniPath) = False Then
            MessageBox.Show("Были считаны не все параметры.  Пожалуйста, проверьте правильность введённых настроек и перезапустите программу.")
            Exit Sub
        Else
            If SomeChekers.MltDrChkr(PathsArray) = False Then
                MessageBox.Show("Сколько-то из считанных путей оказались некорректрыми. Пожалуйста, проверьте правильность введённых настроек и перезапустите программу.")
                Exit Sub
            End If
        End If

        'Строк-заполнителей списков
        If IniFile.MultiRead(Settings.ListsGroup, Settings.ListsArgs, ListsArray, 4096, Settings.IniPath) = False Then
            MessageBox.Show("Были считаны не все параметры. Пожалуйста, проверьте правильность введённых настроек и перезапустите программу.")
            Exit Sub
        Else
            Dim MasterNames As String() = StringParcerList(ListsArray(0), ";")
            Dim NotionOrgs As String() = StringParcerList(ListsArray(1), ";")
            Dim WorkTypes As String() = StringParcerList(ListsArray(2), ";")
            If SomeChekers.StrChkr(MasterNames(0) & NotionOrgs(0) & WorkTypes(0), {SomeChekers.ReturnSymbol}) = SomeChekers.ReturnSymbol Then
                MessageBox.Show("Сколько-то из строк во вкладке «Списки» не соответсвуют шаблону. Пожалуйста, проверьте правильность введённых настроек и перезапустите программу.")
                Exit Sub
            ElseIf NotionOrgs(0) <> "Нет(Н)" Then
                MessageBox.Show("В названиях организаций первым идёт не «Нет(Н)». Пожалуйста, проверьте правильность введённых настроек и перезапустите программу.")
                Exit Sub
            Else
                lstMasteNames.Items.AddRange(MasterNames)
                lstNotionOrgs.Items.AddRange(NotionOrgs)
                lstWorkType.Items.AddRange(WorkTypes)
            End If
        End If

        'Строк-шаблонов
        If IniFile.MultiRead(Settings.TemplatesGroup, Settings.TemplatesArgs, TemplatesArray, 1024, Settings.IniPath) = False Then
            MessageBox.Show("Были считаны не все параметры. Пожалуйста, проверьте правильность введённых настроек и перезапустите программу.")
            Exit Sub
        End If

    End Sub

    'Блок кода, обрабатывающий нажатие на кнопку «Подготовить документы»
    Private Sub btnSubmitForm_Click(sender As Object, e As EventArgs) Handles btnSubmitForm.Click
        'Проверка на существоания запущенного экземпляра приложения MS Word
        If Process.GetProcessesByName("WINWORD").Length > 0 Then
            MessageBox.Show("Приложение MS Word уже запущено. Оно будет запущено ещё раз, но невидимо для глаз. Не переживайте, запущенный экземпляр приложения будет закрыт.")
        Else
            'Проверка на существование установленного приложения MS Word
            Try
                Dim Wrd As New Word.Application
                Wrd.Quit()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(Wrd)
                Wrd = Nothing
            Catch ex As Exception
                MessageBox.Show("Программа MS Word не установлена, так что дальнейшая работа с этой программой бессмыслена и она будет закрыта")
                System.Windows.Forms.Application.Exit()
            End Try
        End If

        'Сохранение значений с формы
        Dim AllValues As New Dictionary(Of String, String) From {
            {"WorkStartDate", txtbWorkStartDate.Text},
            {"WorkEndDate", txtbWorkEndDate.Text},
            {"GreenEndDate", txtbGreenEndDate.Text},
            {"DocumentsDateD", txtbDocumentsDate.Text},
            {"ShortAdress", txtbShortAdress.Text},
            {"FullAdress", txtbFullAdress.Text},
            {"NotionNumber", txtbNotionNumber.Text},
            {"MasterName", lstMasteNames.SelectedItem},
            {"NotionOrgs", lstNotionOrgs.SelectedItem},
            {"WorkType", lstWorkType.SelectedItem}
        }


        'Проверка на заполненнонсть полей
        Dim CheckAllResultB As Boolean = SomeChekers.MltLstSlctItmChkr(AllValues.Values.Skip(7).Take(3).ToArray()) And SomeChekers.MltNtBlkChkr(AllValues.Values.Take(7).ToArray())
        If CheckAllResultB = False Then
            MessageBox.Show("Для продолжения работы заполнте все и поля и выберите по значению из каждого списка.")
            Exit Sub
        End If

        'Запрещённые символы при создании папаки
        Dim ExceptionCharsList As String() = {
            "\",
            "/",
            ":",
            "*",
            "?",
            Chr(34),
            "<",
            ">",
            "|",
            "."
            }

        'Костыль для месяцев в родительном падеже, так как локаль не работает
        Dim MonthsArr As String() = {
            "",
            "января",
            "февраля",
            "марта",
            "апреля",
            "мая",
            "июня",
            "июля",
            "августа",
            "сентября",
            "октября",
            "ноября",
            "декабря"
        }

        'Блок считывания данных с формы
        AllValues("WorkStartDate") = DateParcer(AllValues("WorkStartDate"), "dd.MM.yyyy")
        AllValues("WorkEndDate") = DateParcer(AllValues("WorkEndDate"), "dd.MM.yyyy")
        AllValues("GreenEndDate") = DateParcer(AllValues("GreenEndDate"), "dd.MM.yyyy")
        AllValues("DocumentsDateD") = DateParcer(AllValues("DocumentsDateD"), "dd.MM.yyyy")
        AllValues("ShortAdress") = SomeChekers.StrChkr(AllValues("ShortAdress"), ExceptionCharsList)
        AllValues("NotionNumber") = IntParcer(AllValues("NotionNumber"))

        'Проверка на соответсвие введёных данных формату даты
        Dim CheckAllResultS As String = SomeChekers.StrChkr(AllValues("WorkStartDate") & AllValues("WorkEndDate") & AllValues("GreenEndDate") & AllValues("DocumentsDateD"), {SomeChekers.ReturnSymbol})
        If CheckAllResultS = SomeChekers.ReturnSymbol Then
            MessageBox.Show("В одном из полей (или во всех полях) требующих дату, укзано значение, отличное от требуемого.")
            Exit Sub
        End If

        'Проверка на запрещённые системой символы при создании папки
        If AllValues("ShortAdress") = SomeChekers.ReturnSymbol Then
            MessageBox.Show("В поле для короткого адреса введены символы, запрещённые к содержанию в имени папки.")
            Exit Sub
        End If

        'Проверка на введение номера телефонограммы
        If AllValues("NotionNumber") = SomeChekers.ReturnSymbol Then
            MessageBox.Show("Вместо номера телефонограммы укзано значение, отличное от требуемого.")
            Exit Sub
        End If

        'Дополнительные преобразования с датами
        AllValues.Add("WorkStartDateDir", DateParcer(AllValues("WorkStartDate"), "yyyy.MM.dd"))
        AllValues.Add("DocumentsDateDir", DateParcer(AllValues("DocumentsDateD"), "yyyy.MM.dd"))
        AllValues.Add("DocumentsDateStr", DateTransformer(AllValues("DocumentsDateD"), MonthsArr))

        'Создание путей для папок документов
        AllValues.Add("FullExamplesPath", Path.Combine(PathsArray(0), AllValues("MasterName")))
        AllValues.Add("FullOpenPath", Path.Combine(PathsArray(1), AllValues("WorkStartDateDir") & " (" & AllValues("DocumentsDateDir") & ") " & AllValues("ShortAdress")))
        AllValues.Add("FullClosedPath", Path.Combine(PathsArray(2), AllValues("WorkStartDateDir") & " () " & AllValues("ShortAdress")))

        'Создание путей для архива
        AllValues.Add("ArchivePath", Path.Combine(AllValues("FullOpenPath"), AllValues("WorkStartDateDir") & " " & AllValues("ShortAdress") & ".zip"))
        AllValues.Add("TempArchivePath", Path.Combine(PathsArray(1), AllValues("WorkStartDateDir") & " " & AllValues("ShortAdress") & ".zip"))

        'Проверка на существование предполагаемых к созданию папок
        If SomeChekers.MltDrChkr({AllValues("FullOpenPath"), AllValues("FullClosedPath")}) = True Then
            MessageBox.Show("Предполагаемые папки для хранения результата работы программы уже существуют. Пожалуйста, измените или поле с коротким адресом, или поле с датой начала работ, или поле с датой подачи докуметов.")
            Exit Sub
        End If

        'Проверка на существование папки с образцами для указанного мастера
        If SomeChekers.DrChkr(AllValues("FullExamplesPath")) = False Then
            MessageBox.Show(String.Format("Папка «{0}» не существует.{1}Пожалуйста, проверьте правильность указанной фамилии или наличие папки образцов с названием в виде соответвующей фамилии.", AllValues("FllExamplesPath")))
            Exit Sub
        End If

        'Блок копипрования нужных файлов
        'Массив с именами необходимых для копирования файлов (и для редактирования)
        Dim neededFilesOpen As String() = {
            "Гарантийное_письмо.docx",
            "Уведомление_ЕДДС.docx",
            "Приказ_" & AllValues("MasterName") & ".docx",
            "Уведомление_организаций_" & StringCutBrackets(AllValues("NotionOrgs")) & ".docx",
            "Номер_заявки.txt"
        }

        'Проверка на существование необходимых файлов
        If SomeChekers.MltFlChkr(neededFilesOpen, AllValues("FullExamplesPath")) = False Then
            MessageBox.Show(String.Format("В папке с образцами находятся не все необходимые файлы. Пожалуйста, проверьте содержимое папки «{0}».", AllValues("FullExamplesPath")))
            Exit Sub
        End If

        'Копирование необходимых файлов по составленному списку для открытия
        ChoosenFilesCopy(AllValues("FullExamplesPath"), AllValues("FullOpenPath"), neededFilesOpen, True)
        ChoosenFilesCopy(AllValues("FullExamplesPath"), AllValues("FullClosedPath"), neededFilesOpen.Skip(4).Take(1).ToArray(), True)

        'Блок формирования массивов соотвествия для поиска и замены в каждом файле
        'Массив для гарантийного письма
        Dim gpReplaseArr(,) As String = {
           {TemplatesArray(3), TemplatesArray(2), TemplatesArray(1), TemplatesArray(7)},
           {AllValues("DocumentsDateStr"), AllValues("WorkType"), AllValues("FullAdress"), AllValues("GreenEndDate")}
        }

        'Массив для приказа
        Dim orderReplaceArr(,) As String = {
           {TemplatesArray(3), TemplatesArray(2), TemplatesArray(1)},
           {AllValues("DocumentsDateStr"), AllValues("WorkType"), AllValues("FullAdress")}
        }

        'Массив для уведомлений
        Dim notionReplaceArr(,) As String = {
           {TemplatesArray(0), TemplatesArray(4), TemplatesArray(2), TemplatesArray(5), TemplatesArray(6), TemplatesArray(1)},
          {AllValues("NotionNumber"), AllValues("DocumentsDateD"), AllValues("WorkType"), AllValues("WorkStartDate"), AllValues("WorkEndDate"), AllValues("FullAdress")}
        }

        'Блок переменных для работы с Word
        'Блок переменных для параметров замены
        Dim ReplaceParams As (
            MatchCase As Boolean,
            MatchWholeWord As Boolean,
            MatchWildcards As Boolean,
            MatchSoudsLike As Boolean,
            MatchallWordForms As Boolean,
            Forward As Boolean,
            Wrap As Integer,
            Format As Boolean,
            Replace As Integer
        ) = (
            MatchCase:=False,
            MatchWholeWord:=True,
            MatchWildcards:=False,
            MatchSoudsLike:=False,
            MatchallWordForms:=False,
            Forward:=True,
            Wrap:=1,
            Format:=False,
            Replace:=2
        )

        'MatchCase         Влияние регистра
        'MatchWholeWord    Поиск по целому слову
        'MatchWildcards    Специальные операторы поиска
        'MatchSoudsLike    Поиск похожих по звучанию
        'MatchallWordForms Поиск всех форм слова
        'Forward           Поиск вперёд(?)
        'Wrap              Происходящее при поиске не с начала документа
        'Format            Поиск по форматированию
        'Replace           Кол-во замен (0 - нет, 1 - первую, 2 - все)

        'Блок параметров закрытия файлов
        Dim CloseFileParams As (
            Savechanges As Integer,
            OriginalFormat As Integer
        ) = (
            Savechanges:=-1,
            OriginalFormat:=1
        )

        'Savechanges    Сохрание изменений (0 - без сохранения, -1 - сохранение без запроса, -2 - сохранение с запросом)
        'OriginalFormat Формат документа (0 - MS Word, 1 - исходный, 2 - запрос у пользователя)

        'Работа с Word
        'Запуск Word
        Dim WordApp As New Microsoft.Office.Interop.Word.Application

        'Редактирование гарантийного письма
        DocEdit(WordApp, AllValues("FullOpenPath"), neededFilesOpen(0), gpReplaseArr, ReplaceParams, CloseFileParams)
        'Редактирование уведомления ЕДДС
        DocEdit(WordApp, AllValues("FullOpenPath"), neededFilesOpen(1), notionReplaceArr, ReplaceParams, CloseFileParams)
        'Редактирование приказа о назначении ответственного за проведения работ
        DocEdit(WordApp, AllValues("FullOpenPath"), neededFilesOpen(2), orderReplaceArr, ReplaceParams, CloseFileParams)
        'Редактирование уведомления организаций
        DocEdit(WordApp, AllValues("FullOpenPath"), neededFilesOpen(3), notionReplaceArr, ReplaceParams, CloseFileParams)


        'Закрытие приложения Word
        WordApp.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(WordApp)
        WordApp = Nothing

        'Создание временного архива с отредактированными файлами
        ZipFile.CreateFromDirectory(AllValues("FullOpenPath"), AllValues("TempArchivePath"), Compression.CompressionLevel.Optimal, False)
        'Удаление ненужного файла «Номер_заявки.txt»
        DelFromArchive(AllValues("TempArchivePath"), neededFilesOpen(4))
        'Перемещение временного архива в папку для документов
        File.Move(AllValues("TempArchivePath"), AllValues("ArchivePath"))
        'Удаление редактированных файлов
        DelFiles(AllValues("FullOpenPath"), neededFilesOpen.Take(4).ToArray())

        'Очистка массивов дабы минимизировать накопление оперативы (помогает не особо, но чутка)
        AllValues.Clear()
        Erase ExceptionCharsList, MonthsArr, neededFilesOpen, gpReplaseArr, orderReplaceArr, notionReplaceArr

        MessageBox.Show("Документы подготовлены. Можете закрыть программу или, изменив поле(-я), подготовить ещё один комплект документов.")

    End Sub

End Class