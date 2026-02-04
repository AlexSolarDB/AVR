Imports System.Runtime.InteropServices
Imports System.Text

'Модуль для работы с ini файлами
Module IniFile

    'Песвдостандартная функция записи в INI файл.
    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Private Function WritePrivateProfileString(lpAppName As String, lpKeyName As String, lpString As String, lpFileName As String) As Boolean
    End Function

    'Псевдостандартная функция чтения из INI файла.
    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode, SetLastError:=True)>
    Private Function GetPrivateProfileString(lpAppName As String, lpKeyName As String, lpDefault As String, lpReturnedString As System.Text.StringBuilder, nSize As Integer, lpFileName As String) As Integer
    End Function

    'Метод записи в ini файл одного параметра
    Public Function SingleWrite(GroupName As String, ArgName As String, Arg As String, iniPath As String) As Boolean
        Dim result As Boolean = True
        Return result = result And WritePrivateProfileString(GroupName, ArgName, Arg, iniPath)
    End Function

    'Метод записи в ini файл нескольких параметров
    Public Function MultiWrite(GroupName As String, ArgsNames As String(), Args As String(), iniPath As String) As Boolean
        Dim result As Boolean = True
        For i = 0 To Args.Count - 1
            result = result And WritePrivateProfileString(GroupName, ArgsNames(i), Args(i), iniPath)
        Next
        Return result
    End Function

    'Метод чтения из ini файла одного параметра
    Public Function SingleRead(GroupName As String, ArgName As String, Arg As String, bufferSize As Integer, iniPath As String) As Boolean
        Dim result As Boolean = True
        Dim buffer As New StringBuilder(bufferSize)
        Return result = result And GetPrivateProfileString(GroupName, ArgName, "", buffer, buffer.Capacity, iniPath)
    End Function

    'Метод чтения из ini файла нескольких параметров
    Public Function MultiRead(GroupName As String, ArgsNames As String(), Args As String(), bufferSize As Integer, iniPath As String) As Boolean
        Dim result As Boolean = True
        Dim buffer As New StringBuilder(bufferSize)
        For i = 0 To Args.Count - 1
            buffer.Clear()
            result = result And GetPrivateProfileString(GroupName, ArgsNames(i), "", buffer, buffer.Capacity, iniPath)
            Args(i) = buffer.ToString()
        Next
        Return result
    End Function

End Module
