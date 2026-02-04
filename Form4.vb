

Public Class WelcomeForm

    'Переменная для результата проверки сущесвоования файла настроек
    Private IniFlag As Boolean

    '------------------------------------------------------------------------------------
    'Начало основного тела программы
    '------------------------------------------------------------------------------------

    'Блок кода, отрабатывающий при загрузке формы
    Private Sub WelcomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Подгрузка необходимых иконок
        Me.Icon = My.Resources.Icon_AVR

        'Сохранение результата проверкаи на существование файла настроек
        IniFlag = SomeChekers.FlChkr(Settings.IniPath)

    End Sub

    'Блок кода, обрабатывающий нажатие кнопки «работа с документами»
    Private Sub btnWelcomeDocs_Click(sender As Object, e As EventArgs) Handles btnWelcomeDocs.Click
        If IniFlag = True Then
            MainForm.ShowDialog()
        ElseIf IniFlag = False Then
            MessageBox.Show("   Файл настроек не обнаружен, что делает дальнейшее использование формы бессмысленным." & vbCrLf &
                            "Пожалуйста, перейдите в настройки и заполните соответствующие поля.")
        End If
    End Sub

    'Блок кода, обрабатывающий нажатие кнопки «работа с таблицами»
    Private Sub btnWelcomeTable_Click(sender As Object, e As EventArgs) Handles btnWelcomeTable.Click
        If IniFlag = True Then
            csvDB.ShowDialog()
        ElseIf IniFlag = False Then
            MessageBox.Show("   Файл настроек не обнаружен, что делает дальнейшее использование формы бессмысленным." & vbCrLf &
                            "Пожалуйста, перейдите в настройки и заполните соответствующие поля.")
        End If
    End Sub

    'Блок кода, обрабатывающий нажатие кнопки «настройки»
    Private Sub btnWelcomeSettings_Click(sender As Object, e As EventArgs) Handles btnWelcomeSettings.Click
        SettingsForm.ShowDialog()
    End Sub

End Class