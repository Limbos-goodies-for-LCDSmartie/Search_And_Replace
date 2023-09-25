Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Text
'Namespace sandr
Public Class LCDSmartie
    Public iniName As String = "omit.ini"

    Public Function function1(param1 As String, param2 As String) As String

        If LCase(param1) = "about" Or LCase(param2) = "about" Then
            Return " will replace any string located under [Search1] with [Replace1] values"
            ' Return Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(param1, Find1, Replacement1), Find2, Replacement2), Find3, Replacement3), Find4, Replacement4), Find5, Replacement5), Find6, Replacement6), Find7, Replacement7), Find8, Replacement8), Find9, Replacement9), Find10, Replacement10), Find11, Replacement11), Find12, Replacement12), Find13, Replacement13), Find14, Replacement14), Find15, Replacement15), Find16, Replacement16), Find17, Replacement17), Find18, Replacement18), Find19, Replacement19), Find20, Replacement20), Find21, Replacement21), Find22, Replacement22), Find23, Replacement23), Find24, Replacement24), Find25, Replacement25), Find26, Replacement26), Find27, Replacement27), Find28, Replacement28), Find29, Replacement29), Find30, Replacement30), Find31, Replacement31), Find32, Replacement32), Find33, Replacement33), Find34, Replacement34), Find35, Replacement35), Find36, Replacement36), Find37, Replacement37), Find38, Replacement38), Find39, Replacement39), Find40, Replacement40)
        End If
        If param2.EndsWith(".ini") Then
            iniName = param2
        Else
            iniName = "omit.ini"
        End If

        Dim INIPath As String = getPath()
        Dim Find1 As String = INIRead(INIPath, "Search1", 1)
        Dim Find2 As String = INIRead(INIPath, "Search1", 2)
        Dim Find3 As String = INIRead(INIPath, "Search1", 3)
        Dim Find4 As String = INIRead(INIPath, "Search1", 4)
        Dim Find5 As String = INIRead(INIPath, "Search1", 5)
        Dim Find6 As String = INIRead(INIPath, "Search1", 6)
        Dim Find7 As String = INIRead(INIPath, "Search1", 7)
        Dim Find8 As String = INIRead(INIPath, "Search1", "8")
        Dim Find9 As String = INIRead(INIPath, "Search1", "9")
        Dim Find10 As String = INIRead(INIPath, "Search1", "10")
        Dim Find11 As String = INIRead(INIPath, "Search1", "11")
        Dim Find12 As String = INIRead(INIPath, "Search1", "12")
        Dim Find13 As String = INIRead(INIPath, "Search1", "13")
        Dim Find14 As String = INIRead(INIPath, "Search1", "14")
        Dim Find15 As String = INIRead(INIPath, "Search1", "15")
        Dim Find16 As String = INIRead(INIPath, "Search1", "16")
        Dim Find17 As String = INIRead(INIPath, "Search1", "17")
        Dim Find18 As String = INIRead(INIPath, "Search1", "18")
        Dim Find19 As String = INIRead(INIPath, "Search1", "19")
        Dim Find20 As String = INIRead(INIPath, "Search1", "20")
        Dim Find21 As String = INIRead(INIPath, "Search1", "21")
        Dim Find22 As String = INIRead(INIPath, "Search1", "22")
        Dim Find23 As String = INIRead(INIPath, "Search1", "23")
        Dim Find24 As String = INIRead(INIPath, "Search1", "24")
        Dim Find25 As String = INIRead(INIPath, "Search1", "25")
        Dim Find26 As String = INIRead(INIPath, "Search1", "26")
        Dim Find27 As String = INIRead(INIPath, "Search1", "27")
        Dim Find28 As String = INIRead(INIPath, "Search1", "28")
        Dim Find29 As String = INIRead(INIPath, "Search1", "29")
        Dim Find30 As String = INIRead(INIPath, "Search1", "30")
        Dim Find31 As String = INIRead(INIPath, "Search1", "31")
        Dim Find32 As String = INIRead(INIPath, "Search1", "32")
        Dim Find33 As String = INIRead(INIPath, "Search1", "33")
        Dim Find34 As String = INIRead(INIPath, "Search1", "34")
        Dim Find35 As String = INIRead(INIPath, "Search1", "35")
        Dim Find36 As String = INIRead(INIPath, "Search1", "36")
        Dim Find37 As String = INIRead(INIPath, "Search1", "37")
        Dim Find38 As String = INIRead(INIPath, "Search1", "38")
        Dim Find39 As String = INIRead(INIPath, "Search1", "39")
        Dim Find40 As String = INIRead(INIPath, "Search1", "40")

        Dim Replacement1 As String = INIRead(INIPath, "Replace1", "1")
        Dim Replacement2 As String = INIRead(INIPath, "Replace1", "2")
        Dim Replacement3 As String = INIRead(INIPath, "Replace1", "3")
        Dim Replacement4 As String = INIRead(INIPath, "Replace1", "4")
        Dim Replacement5 As String = INIRead(INIPath, "Replace1", "5")
        Dim Replacement6 As String = INIRead(INIPath, "Replace1", "6")
        Dim Replacement7 As String = INIRead(INIPath, "Replace1", "7")
        Dim Replacement8 As String = INIRead(INIPath, "Replace1", "8")
        Dim Replacement9 As String = INIRead(INIPath, "Replace1", "9")
        Dim Replacement10 As String = INIRead(INIPath, "Replace1", "10")
        Dim Replacement11 As String = INIRead(INIPath, "Replace1", "11")
        Dim Replacement12 As String = INIRead(INIPath, "Replace1", "12")
        Dim Replacement13 As String = INIRead(INIPath, "Replace1", "13")
        Dim Replacement14 As String = INIRead(INIPath, "Replace1", "14")
        Dim Replacement15 As String = INIRead(INIPath, "Replace1", "15")
        Dim Replacement16 As String = INIRead(INIPath, "Replace1", "16")
        Dim Replacement17 As String = INIRead(INIPath, "Replace1", "17")
        Dim Replacement18 As String = INIRead(INIPath, "Replace1", "18")
        Dim Replacement19 As String = INIRead(INIPath, "Replace1", "19")
        Dim Replacement20 As String = INIRead(INIPath, "Replace1", "20")
        Dim Replacement21 As String = INIRead(INIPath, "Replace1", "21")
        Dim Replacement22 As String = INIRead(INIPath, "Replace1", "22")
        Dim Replacement23 As String = INIRead(INIPath, "Replace1", "23")
        Dim Replacement24 As String = INIRead(INIPath, "Replace1", "24")
        Dim Replacement25 As String = INIRead(INIPath, "Replace1", "25")
        Dim Replacement26 As String = INIRead(INIPath, "Replace1", "26")
        Dim Replacement27 As String = INIRead(INIPath, "Replace1", "27")
        Dim Replacement28 As String = INIRead(INIPath, "Replace1", "28")
        Dim Replacement29 As String = INIRead(INIPath, "Replace1", "29")
        Dim Replacement30 As String = INIRead(INIPath, "Replace1", "30")
        Dim Replacement31 As String = INIRead(INIPath, "Replace1", "31")
        Dim Replacement32 As String = INIRead(INIPath, "Replace1", "32")
        Dim Replacement33 As String = INIRead(INIPath, "Replace1", "33")
        Dim Replacement34 As String = INIRead(INIPath, "Replace1", "34")
        Dim Replacement35 As String = INIRead(INIPath, "Replace1", "35")
        Dim Replacement36 As String = INIRead(INIPath, "Replace1", "36")
        Dim Replacement37 As String = INIRead(INIPath, "Replace1", "37")
        Dim Replacement38 As String = INIRead(INIPath, "Replace1", "38")
        Dim Replacement39 As String = INIRead(INIPath, "Replace1", "39")
        Dim Replacement40 As String = INIRead(INIPath, "Replace1", "40")



        Dim ConvertedText As String = param1


            ConvertedText = Replace(param1, Find1, Replacement1)
            ConvertedText = Replace(ConvertedText, Find2, Replacement2)
            ConvertedText = Replace(ConvertedText, Find3, Replacement3)
            ConvertedText = Replace(ConvertedText, Find4, Replacement4)
            ConvertedText = Replace(ConvertedText, Find5, Replacement5)
            ConvertedText = Replace(ConvertedText, Find6, Replacement6)
            ConvertedText = Replace(ConvertedText, Find7, Replacement7)
            ConvertedText = Replace(ConvertedText, Find8, Replacement8)
            ConvertedText = Replace(ConvertedText, Find9, Replacement9)
            ConvertedText = Replace(ConvertedText, Find10, Replacement10)
            ConvertedText = Replace(ConvertedText, Find11, Replacement11)
            ConvertedText = Replace(ConvertedText, Find12, Replacement12)
            ConvertedText = Replace(ConvertedText, Find13, Replacement13)
            ConvertedText = Replace(ConvertedText, Find14, Replacement14)
            ConvertedText = Replace(ConvertedText, Find15, Replacement15)
            ConvertedText = Replace(ConvertedText, Find16, Replacement16)
            ConvertedText = Replace(ConvertedText, Find17, Replacement17)
            ConvertedText = Replace(ConvertedText, Find18, Replacement18)
            ConvertedText = Replace(ConvertedText, Find19, Replacement19)
            ConvertedText = Replace(ConvertedText, Find20, Replacement20)
            ConvertedText = Replace(ConvertedText, Find21, Replacement21)
            ConvertedText = Replace(ConvertedText, Find22, Replacement22)
            ConvertedText = Replace(ConvertedText, Find23, Replacement23)
            ConvertedText = Replace(ConvertedText, Find24, Replacement24)
            ConvertedText = Replace(ConvertedText, Find25, Replacement25)
            ConvertedText = Replace(ConvertedText, Find26, Replacement26)
            ConvertedText = Replace(ConvertedText, Find27, Replacement27)
            ConvertedText = Replace(ConvertedText, Find28, Replacement28)
            ConvertedText = Replace(ConvertedText, Find29, Replacement29)
            ConvertedText = Replace(ConvertedText, Find30, Replacement30)
            ConvertedText = Replace(ConvertedText, Find31, Replacement31)
            ConvertedText = Replace(ConvertedText, Find32, Replacement32)
            ConvertedText = Replace(ConvertedText, Find33, Replacement33)
            ConvertedText = Replace(ConvertedText, Find34, Replacement34)
            ConvertedText = Replace(ConvertedText, Find35, Replacement35)
            ConvertedText = Replace(ConvertedText, Find36, Replacement36)
            ConvertedText = Replace(ConvertedText, Find37, Replacement37)
            ConvertedText = Replace(ConvertedText, Find38, Replacement38)
            ConvertedText = Replace(ConvertedText, Find39, Replacement39)
            ConvertedText = Replace(ConvertedText, Find40, Replacement40)


            Return ConvertedText

    End Function

    Public Function function2(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Or LCase(param2) = "about" Then
            Return " will replace any string located under [Search2] with [Replace2] values"
        End If
        If param2.EndsWith(".ini") Then
            iniName = param2
        Else
            iniName = "omit.ini"
        End If

        Dim INIPath As String = getPath()
        Dim Find1 As String = INIRead(INIPath, "Search2", "1")
        Dim Find2 As String = INIRead(INIPath, "Search2", "2")
        Dim Find3 As String = INIRead(INIPath, "Search2", "3")
        Dim Find4 As String = INIRead(INIPath, "Search2", "4")
        Dim Find5 As String = INIRead(INIPath, "Search2", "5")
        Dim Find6 As String = INIRead(INIPath, "Search2", "6")
        Dim Find7 As String = INIRead(INIPath, "Search2", "7")
        Dim Find8 As String = INIRead(INIPath, "Search2", "8")
        Dim Find9 As String = INIRead(INIPath, "Search2", "9")
        Dim Find10 As String = INIRead(INIPath, "Search2", "10")
        Dim Find11 As String = INIRead(INIPath, "Search2", "11")
        Dim Find12 As String = INIRead(INIPath, "Search2", "12")
        Dim Find13 As String = INIRead(INIPath, "Search2", "13")
        Dim Find14 As String = INIRead(INIPath, "Search2", "14")
        Dim Find15 As String = INIRead(INIPath, "Search2", "15")
        Dim Find16 As String = INIRead(INIPath, "Search2", "16")
        Dim Find17 As String = INIRead(INIPath, "Search2", "17")
        Dim Find18 As String = INIRead(INIPath, "Search2", "18")
        Dim Find19 As String = INIRead(INIPath, "Search2", "19")
        Dim Find20 As String = INIRead(INIPath, "Search2", "20")
        Dim Find21 As String = INIRead(INIPath, "Search2", "21")
        Dim Find22 As String = INIRead(INIPath, "Search2", "22")
        Dim Find23 As String = INIRead(INIPath, "Search2", "23")
        Dim Find24 As String = INIRead(INIPath, "Search2", "24")
        Dim Find25 As String = INIRead(INIPath, "Search2", "25")
        Dim Find26 As String = INIRead(INIPath, "Search2", "26")
        Dim Find27 As String = INIRead(INIPath, "Search2", "27")
        Dim Find28 As String = INIRead(INIPath, "Search2", "28")
        Dim Find29 As String = INIRead(INIPath, "Search2", "29")
        Dim Find30 As String = INIRead(INIPath, "Search2", "30")
        Dim Find31 As String = INIRead(INIPath, "Search2", "31")
        Dim Find32 As String = INIRead(INIPath, "Search2", "32")
        Dim Find33 As String = INIRead(INIPath, "Search2", "33")
        Dim Find34 As String = INIRead(INIPath, "Search2", "34")
        Dim Find35 As String = INIRead(INIPath, "Search2", "35")
        Dim Find36 As String = INIRead(INIPath, "Search2", "36")
        Dim Find37 As String = INIRead(INIPath, "Search2", "37")
        Dim Find38 As String = INIRead(INIPath, "Search2", "38")
        Dim Find39 As String = INIRead(INIPath, "Search2", "39")
        Dim Find40 As String = INIRead(INIPath, "Search2", "40")

        Dim Replacement1 As String = INIRead(INIPath, "Replace2", "1")
        Dim Replacement2 As String = INIRead(INIPath, "Replace2", "2")
        Dim Replacement3 As String = INIRead(INIPath, "Replace2", "3")
        Dim Replacement4 As String = INIRead(INIPath, "Replace2", "4")
        Dim Replacement5 As String = INIRead(INIPath, "Replace2", "5")
        Dim Replacement6 As String = INIRead(INIPath, "Replace2", "6")
        Dim Replacement7 As String = INIRead(INIPath, "Replace2", "7")
        Dim Replacement8 As String = INIRead(INIPath, "Replace2", "8")
        Dim Replacement9 As String = INIRead(INIPath, "Replace2", "9")
        Dim Replacement10 As String = INIRead(INIPath, "Replace2", "10")
        Dim Replacement11 As String = INIRead(INIPath, "Replace2", "11")
        Dim Replacement12 As String = INIRead(INIPath, "Replace2", "12")
        Dim Replacement13 As String = INIRead(INIPath, "Replace2", "13")
        Dim Replacement14 As String = INIRead(INIPath, "Replace2", "14")
        Dim Replacement15 As String = INIRead(INIPath, "Replace2", "15")
        Dim Replacement16 As String = INIRead(INIPath, "Replace2", "16")
        Dim Replacement17 As String = INIRead(INIPath, "Replace2", "17")
        Dim Replacement18 As String = INIRead(INIPath, "Replace2", "18")
        Dim Replacement19 As String = INIRead(INIPath, "Replace2", "19")
        Dim Replacement20 As String = INIRead(INIPath, "Replace2", "20")
        Dim Replacement21 As String = INIRead(INIPath, "Replace2", "21")
        Dim Replacement22 As String = INIRead(INIPath, "Replace2", "22")
        Dim Replacement23 As String = INIRead(INIPath, "Replace2", "23")
        Dim Replacement24 As String = INIRead(INIPath, "Replace2", "24")
        Dim Replacement25 As String = INIRead(INIPath, "Replace2", "25")
        Dim Replacement26 As String = INIRead(INIPath, "Replace2", "26")
        Dim Replacement27 As String = INIRead(INIPath, "Replace2", "27")
        Dim Replacement28 As String = INIRead(INIPath, "Replace2", "28")
        Dim Replacement29 As String = INIRead(INIPath, "Replace2", "29")
        Dim Replacement30 As String = INIRead(INIPath, "Replace2", "30")
        Dim Replacement31 As String = INIRead(INIPath, "Replace2", "31")
        Dim Replacement32 As String = INIRead(INIPath, "Replace2", "32")
        Dim Replacement33 As String = INIRead(INIPath, "Replace2", "33")
        Dim Replacement34 As String = INIRead(INIPath, "Replace2", "34")
        Dim Replacement35 As String = INIRead(INIPath, "Replace2", "35")
        Dim Replacement36 As String = INIRead(INIPath, "Replace2", "36")
        Dim Replacement37 As String = INIRead(INIPath, "Replace2", "37")
        Dim Replacement38 As String = INIRead(INIPath, "Replace2", "38")
        Dim Replacement39 As String = INIRead(INIPath, "Replace2", "39")
        Dim Replacement40 As String = INIRead(INIPath, "Replace2", "40")


        Dim ConvertedText As String = param1


        ConvertedText = Replace(param1, Find1, Replacement1)
        ConvertedText = Replace(ConvertedText, Find2, Replacement2)
        ConvertedText = Replace(ConvertedText, Find3, Replacement3)
        ConvertedText = Replace(ConvertedText, Find4, Replacement4)
        ConvertedText = Replace(ConvertedText, Find5, Replacement5)
        ConvertedText = Replace(ConvertedText, Find6, Replacement6)
        ConvertedText = Replace(ConvertedText, Find7, Replacement7)
        ConvertedText = Replace(ConvertedText, Find8, Replacement8)
        ConvertedText = Replace(ConvertedText, Find9, Replacement9)
        ConvertedText = Replace(ConvertedText, Find10, Replacement10)
        ConvertedText = Replace(ConvertedText, Find11, Replacement11)
        ConvertedText = Replace(ConvertedText, Find12, Replacement12)
        ConvertedText = Replace(ConvertedText, Find13, Replacement13)
        ConvertedText = Replace(ConvertedText, Find14, Replacement14)
        ConvertedText = Replace(ConvertedText, Find15, Replacement15)
        ConvertedText = Replace(ConvertedText, Find16, Replacement16)
        ConvertedText = Replace(ConvertedText, Find17, Replacement17)
        ConvertedText = Replace(ConvertedText, Find18, Replacement18)
        ConvertedText = Replace(ConvertedText, Find19, Replacement19)
        ConvertedText = Replace(ConvertedText, Find20, Replacement20)
        ConvertedText = Replace(ConvertedText, Find21, Replacement21)
        ConvertedText = Replace(ConvertedText, Find22, Replacement22)
        ConvertedText = Replace(ConvertedText, Find23, Replacement23)
        ConvertedText = Replace(ConvertedText, Find24, Replacement24)
        ConvertedText = Replace(ConvertedText, Find25, Replacement25)
        ConvertedText = Replace(ConvertedText, Find26, Replacement26)
        ConvertedText = Replace(ConvertedText, Find27, Replacement27)
        ConvertedText = Replace(ConvertedText, Find28, Replacement28)
        ConvertedText = Replace(ConvertedText, Find29, Replacement29)
        ConvertedText = Replace(ConvertedText, Find30, Replacement30)
        ConvertedText = Replace(ConvertedText, Find31, Replacement31)
        ConvertedText = Replace(ConvertedText, Find32, Replacement32)
        ConvertedText = Replace(ConvertedText, Find33, Replacement33)
        ConvertedText = Replace(ConvertedText, Find34, Replacement34)
        ConvertedText = Replace(ConvertedText, Find35, Replacement35)
        ConvertedText = Replace(ConvertedText, Find36, Replacement36)
        ConvertedText = Replace(ConvertedText, Find37, Replacement37)
        ConvertedText = Replace(ConvertedText, Find38, Replacement38)
        ConvertedText = Replace(ConvertedText, Find39, Replacement39)
        ConvertedText = Replace(ConvertedText, Find40, Replacement40)


        Return ConvertedText


    End Function
        Public Function function3(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Or LCase(param2) = "about" Then
            Return " will replace any string located under [Search1] with [Replace1] values"
        End If

        If param2.EndsWith(".ini") Then
            iniName = param2
        Else
            iniName = "omit.ini"
        End If

        Dim INIPath As String = getPath()
        Dim Find1 As String = LCase(INIRead(INIPath, "Search1", "1"))
        Dim Find2 As String = LCase(INIRead(INIPath, "Search1", "2"))
        Dim Find3 As String = LCase(INIRead(INIPath, "Search1", "3"))
        Dim Find4 As String = LCase(INIRead(INIPath, "Search1", "4"))
        Dim Find5 As String = LCase(INIRead(INIPath, "Search1", "5"))
        Dim Find6 As String = LCase(INIRead(INIPath, "Search1", "6"))
        Dim Find7 As String = LCase(INIRead(INIPath, "Search1", "7"))
        Dim Find8 As String = LCase(INIRead(INIPath, "Search1", "8"))
        Dim Find9 As String = LCase(INIRead(INIPath, "Search1", "9"))
        Dim Find10 As String = LCase(INIRead(INIPath, "Search1", "10"))
        Dim Find11 As String = LCase(INIRead(INIPath, "Search1", "11"))
        Dim Find12 As String = LCase(INIRead(INIPath, "Search1", "13"))
        Dim Find13 As String = LCase(INIRead(INIPath, "Search1", "13"))
        Dim Find14 As String = LCase(INIRead(INIPath, "Search1", "14"))
        Dim Find15 As String = LCase(INIRead(INIPath, "Search1", "15"))
        Dim Find16 As String = LCase(INIRead(INIPath, "Search1", "16"))
        Dim Find17 As String = LCase(INIRead(INIPath, "Search1", "17"))
        Dim Find18 As String = LCase(INIRead(INIPath, "Search1", "18"))
        Dim Find19 As String = LCase(INIRead(INIPath, "Search1", "19"))
        Dim Find20 As String = LCase(INIRead(INIPath, "Search1", "20"))
        Dim Find21 As String = LCase(INIRead(INIPath, "Search1", "21"))
        Dim Find22 As String = LCase(INIRead(INIPath, "Search1", "22"))
        Dim Find23 As String = LCase(INIRead(INIPath, "Search1", "23"))
        Dim Find24 As String = LCase(INIRead(INIPath, "Search1", "24"))
        Dim Find25 As String = LCase(INIRead(INIPath, "Search1", "25"))
        Dim Find26 As String = LCase(INIRead(INIPath, "Search1", "26"))
        Dim Find27 As String = LCase(INIRead(INIPath, "Search1", "27"))
        Dim Find28 As String = LCase(INIRead(INIPath, "Search1", "28"))
        Dim Find29 As String = LCase(INIRead(INIPath, "Search1", "29"))
        Dim Find30 As String = LCase(INIRead(INIPath, "Search1", "30"))
        Dim Find31 As String = LCase(INIRead(INIPath, "Search1", "31"))
        Dim Find32 As String = LCase(INIRead(INIPath, "Search1", "32"))
        Dim Find33 As String = LCase(INIRead(INIPath, "Search1", "33"))
        Dim Find34 As String = LCase(INIRead(INIPath, "Search1", "34"))
        Dim Find35 As String = LCase(INIRead(INIPath, "Search1", "35"))
        Dim Find36 As String = LCase(INIRead(INIPath, "Search1", "36"))
        Dim Find37 As String = LCase(INIRead(INIPath, "Search1", "37"))
        Dim Find38 As String = LCase(INIRead(INIPath, "Search1", "38"))
        Dim Find39 As String = LCase(INIRead(INIPath, "Search1", "39"))
        Dim Find40 As String = LCase(INIRead(INIPath, "Search1", "40"))

        Dim Replacement1 As String = LCase(INIRead(INIPath, "Replace1", "1"))
        Dim Replacement2 As String = LCase(INIRead(INIPath, "Replace1", "2"))
        Dim Replacement3 As String = LCase(INIRead(INIPath, "Replace1", "3"))
        Dim Replacement4 As String = LCase(INIRead(INIPath, "Replace1", "4"))
        Dim Replacement5 As String = LCase(INIRead(INIPath, "Replace1", "5"))
        Dim Replacement6 As String = LCase(INIRead(INIPath, "Replace1", "6"))
        Dim Replacement7 As String = LCase(INIRead(INIPath, "Replace1", "7"))
        Dim Replacement8 As String = LCase(INIRead(INIPath, "Replace1", "8"))
        Dim Replacement9 As String = LCase(INIRead(INIPath, "Replace1", "9"))
        Dim Replacement10 As String = LCase(INIRead(INIPath, "Replace1", "10"))
        Dim Replacement11 As String = LCase(INIRead(INIPath, "Replace1", "11"))
        Dim Replacement12 As String = LCase(INIRead(INIPath, "Replace1", "12"))
        Dim Replacement13 As String = LCase(INIRead(INIPath, "Replace1", "13"))
        Dim Replacement14 As String = LCase(INIRead(INIPath, "Replace1", "14"))
        Dim Replacement15 As String = LCase(INIRead(INIPath, "Replace1", "15"))
        Dim Replacement16 As String = LCase(INIRead(INIPath, "Replace1", "16"))
        Dim Replacement17 As String = LCase(INIRead(INIPath, "Replace1", "17"))
        Dim Replacement18 As String = LCase(INIRead(INIPath, "Replace1", "18"))
        Dim Replacement19 As String = LCase(INIRead(INIPath, "Replace1", "19"))
        Dim Replacement20 As String = LCase(INIRead(INIPath, "Replace1", "20"))
        Dim Replacement21 As String = LCase(INIRead(INIPath, "Replace1", "21"))
        Dim Replacement22 As String = LCase(INIRead(INIPath, "Replace1", "22"))
        Dim Replacement23 As String = LCase(INIRead(INIPath, "Replace1", "23"))
        Dim Replacement24 As String = LCase(INIRead(INIPath, "Replace1", "24"))
        Dim Replacement25 As String = LCase(INIRead(INIPath, "Replace1", "25"))
        Dim Replacement26 As String = LCase(INIRead(INIPath, "Replace1", "26"))
        Dim Replacement27 As String = LCase(INIRead(INIPath, "Replace1", "27"))
        Dim Replacement28 As String = LCase(INIRead(INIPath, "Replace1", "28"))
        Dim Replacement29 As String = LCase(INIRead(INIPath, "Replace1", "29"))
        Dim Replacement30 As String = LCase(INIRead(INIPath, "Replace1", "30"))
        Dim Replacement31 As String = LCase(INIRead(INIPath, "Replace1", "31"))
        Dim Replacement32 As String = LCase(INIRead(INIPath, "Replace1", "32"))
        Dim Replacement33 As String = LCase(INIRead(INIPath, "Replace1", "33"))
        Dim Replacement34 As String = LCase(INIRead(INIPath, "Replace1", "34"))
        Dim Replacement35 As String = LCase(INIRead(INIPath, "Replace1", "35"))
        Dim Replacement36 As String = LCase(INIRead(INIPath, "Replace1", "36"))
        Dim Replacement37 As String = LCase(INIRead(INIPath, "Replace1", "37"))
        Dim Replacement38 As String = LCase(INIRead(INIPath, "Replace1", "38"))
        Dim Replacement39 As String = LCase(INIRead(INIPath, "Replace1", "39"))
        Dim Replacement40 As String = LCase(INIRead(INIPath, "Replace1", "40"))

        Dim ConvertedText As String = param1


        ConvertedText = Replace(param1, Find1, Replacement1)
        ConvertedText = Replace(ConvertedText, Find2, Replacement2)
        ConvertedText = Replace(ConvertedText, Find3, Replacement3)
        ConvertedText = Replace(ConvertedText, Find4, Replacement4)
        ConvertedText = Replace(ConvertedText, Find5, Replacement5)
        ConvertedText = Replace(ConvertedText, Find6, Replacement6)
        ConvertedText = Replace(ConvertedText, Find7, Replacement7)
        ConvertedText = Replace(ConvertedText, Find8, Replacement8)
        ConvertedText = Replace(ConvertedText, Find9, Replacement9)
        ConvertedText = Replace(ConvertedText, Find10, Replacement10)
        ConvertedText = Replace(ConvertedText, Find11, Replacement11)
        ConvertedText = Replace(ConvertedText, Find12, Replacement12)
        ConvertedText = Replace(ConvertedText, Find13, Replacement13)
        ConvertedText = Replace(ConvertedText, Find14, Replacement14)
        ConvertedText = Replace(ConvertedText, Find15, Replacement15)
        ConvertedText = Replace(ConvertedText, Find16, Replacement16)
        ConvertedText = Replace(ConvertedText, Find17, Replacement17)
        ConvertedText = Replace(ConvertedText, Find18, Replacement18)
        ConvertedText = Replace(ConvertedText, Find19, Replacement19)
        ConvertedText = Replace(ConvertedText, Find20, Replacement20)
        ConvertedText = Replace(ConvertedText, Find21, Replacement21)
        ConvertedText = Replace(ConvertedText, Find22, Replacement22)
        ConvertedText = Replace(ConvertedText, Find23, Replacement23)
        ConvertedText = Replace(ConvertedText, Find24, Replacement24)
        ConvertedText = Replace(ConvertedText, Find25, Replacement25)
        ConvertedText = Replace(ConvertedText, Find26, Replacement26)
        ConvertedText = Replace(ConvertedText, Find27, Replacement27)
        ConvertedText = Replace(ConvertedText, Find28, Replacement28)
        ConvertedText = Replace(ConvertedText, Find29, Replacement29)
        ConvertedText = Replace(ConvertedText, Find30, Replacement30)
        ConvertedText = Replace(ConvertedText, Find31, Replacement31)
        ConvertedText = Replace(ConvertedText, Find32, Replacement32)
        ConvertedText = Replace(ConvertedText, Find33, Replacement33)
        ConvertedText = Replace(ConvertedText, Find34, Replacement34)
        ConvertedText = Replace(ConvertedText, Find35, Replacement35)
        ConvertedText = Replace(ConvertedText, Find36, Replacement36)
        ConvertedText = Replace(ConvertedText, Find37, Replacement37)
        ConvertedText = Replace(ConvertedText, Find38, Replacement38)
        ConvertedText = Replace(ConvertedText, Find39, Replacement39)
        ConvertedText = Replace(ConvertedText, Find40, Replacement40)

        Return ConvertedText

    End Function

        Public Function function4(param1 As String, param2 As String) As String
            If LCase(param1) = "about" Or LCase(param2) = "about" Then
                Return " will replace any string located under [Search2] with [Replace2] values"
            End If
        If param2.EndsWith(".ini") Then
            iniName = param2
        Else
            iniName = "omit.ini"
        End If

        Dim INIPath As String = getPath()
        Dim Find1 As String = LCase(INIRead(INIPath, "Search2", "1"))
        Dim Find2 As String = LCase(INIRead(INIPath, "Search2", "2"))
        Dim Find3 As String = LCase(INIRead(INIPath, "Search2", "3"))
        Dim Find4 As String = LCase(INIRead(INIPath, "Search2", "4"))
        Dim Find5 As String = LCase(INIRead(INIPath, "Search2", "5"))
        Dim Find6 As String = LCase(INIRead(INIPath, "Search2", "6"))
        Dim Find7 As String = LCase(INIRead(INIPath, "Search2", "7"))
        Dim Find8 As String = LCase(INIRead(INIPath, "Search2", "8"))
        Dim Find9 As String = LCase(INIRead(INIPath, "Search2", "9"))
        Dim Find10 As String = LCase(INIRead(INIPath, "Search2", "10"))
        Dim Find11 As String = LCase(INIRead(INIPath, "Search2", "11"))
        Dim Find12 As String = LCase(INIRead(INIPath, "Search2", "13"))
        Dim Find13 As String = LCase(INIRead(INIPath, "Search2", "13"))
        Dim Find14 As String = LCase(INIRead(INIPath, "Search2", "14"))
        Dim Find15 As String = LCase(INIRead(INIPath, "Search2", "15"))
        Dim Find16 As String = LCase(INIRead(INIPath, "Search2", "16"))
        Dim Find17 As String = LCase(INIRead(INIPath, "Search2", "17"))
        Dim Find18 As String = LCase(INIRead(INIPath, "Search2", "18"))
        Dim Find19 As String = LCase(INIRead(INIPath, "Search2", "19"))
        Dim Find20 As String = LCase(INIRead(INIPath, "Search2", "20"))
        Dim Find21 As String = LCase(INIRead(INIPath, "Search2", "21"))
        Dim Find22 As String = LCase(INIRead(INIPath, "Search2", "22"))
        Dim Find23 As String = LCase(INIRead(INIPath, "Search2", "23"))
        Dim Find24 As String = LCase(INIRead(INIPath, "Search2", "24"))
        Dim Find25 As String = LCase(INIRead(INIPath, "Search2", "25"))
        Dim Find26 As String = LCase(INIRead(INIPath, "Search2", "26"))
        Dim Find27 As String = LCase(INIRead(INIPath, "Search2", "27"))
        Dim Find28 As String = LCase(INIRead(INIPath, "Search2", "28"))
        Dim Find29 As String = LCase(INIRead(INIPath, "Search2", "29"))
        Dim Find30 As String = LCase(INIRead(INIPath, "Search2", "30"))
        Dim Find31 As String = LCase(INIRead(INIPath, "Search2", "31"))
        Dim Find32 As String = LCase(INIRead(INIPath, "Search2", "32"))
        Dim Find33 As String = LCase(INIRead(INIPath, "Search2", "33"))
        Dim Find34 As String = LCase(INIRead(INIPath, "Search2", "34"))
        Dim Find35 As String = LCase(INIRead(INIPath, "Search2", "35"))
        Dim Find36 As String = LCase(INIRead(INIPath, "Search2", "36"))
        Dim Find37 As String = LCase(INIRead(INIPath, "Search2", "37"))
        Dim Find38 As String = LCase(INIRead(INIPath, "Search2", "38"))
        Dim Find39 As String = LCase(INIRead(INIPath, "Search2", "39"))
        Dim Find40 As String = LCase(INIRead(INIPath, "Search2", "40"))

        Dim Replacement1 As String = LCase(INIRead(INIPath, "Replace2", "1"))
        Dim Replacement2 As String = LCase(INIRead(INIPath, "Replace2", "2"))
        Dim Replacement3 As String = LCase(INIRead(INIPath, "Replace2", "3"))
        Dim Replacement4 As String = LCase(INIRead(INIPath, "Replace2", "4"))
        Dim Replacement5 As String = LCase(INIRead(INIPath, "Replace2", "5"))
        Dim Replacement6 As String = LCase(INIRead(INIPath, "Replace2", "6"))
        Dim Replacement7 As String = LCase(INIRead(INIPath, "Replace2", "7"))
        Dim Replacement8 As String = LCase(INIRead(INIPath, "Replace2", "8"))
        Dim Replacement9 As String = LCase(INIRead(INIPath, "Replace2", "9"))
        Dim Replacement10 As String = LCase(INIRead(INIPath, "Replace2", "10"))
        Dim Replacement11 As String = LCase(INIRead(INIPath, "Replace2", "11"))
        Dim Replacement12 As String = LCase(INIRead(INIPath, "Replace2", "12"))
        Dim Replacement13 As String = LCase(INIRead(INIPath, "Replace2", "13"))
        Dim Replacement14 As String = LCase(INIRead(INIPath, "Replace2", "14"))
        Dim Replacement15 As String = LCase(INIRead(INIPath, "Replace2", "15"))
        Dim Replacement16 As String = LCase(INIRead(INIPath, "Replace2", "16"))
        Dim Replacement17 As String = LCase(INIRead(INIPath, "Replace2", "17"))
        Dim Replacement18 As String = LCase(INIRead(INIPath, "Replace2", "18"))
        Dim Replacement19 As String = LCase(INIRead(INIPath, "Replace2", "19"))
        Dim Replacement20 As String = LCase(INIRead(INIPath, "Replace2", "20"))
        Dim Replacement21 As String = LCase(INIRead(INIPath, "Replace2", "21"))
        Dim Replacement22 As String = LCase(INIRead(INIPath, "Replace2", "22"))
        Dim Replacement23 As String = LCase(INIRead(INIPath, "Replace2", "23"))
        Dim Replacement24 As String = LCase(INIRead(INIPath, "Replace2", "24"))
        Dim Replacement25 As String = LCase(INIRead(INIPath, "Replace2", "25"))
        Dim Replacement26 As String = LCase(INIRead(INIPath, "Replace2", "26"))
        Dim Replacement27 As String = LCase(INIRead(INIPath, "Replace2", "27"))
        Dim Replacement28 As String = LCase(INIRead(INIPath, "Replace2", "28"))
        Dim Replacement29 As String = LCase(INIRead(INIPath, "Replace2", "29"))
        Dim Replacement30 As String = LCase(INIRead(INIPath, "Replace2", "30"))
        Dim Replacement31 As String = LCase(INIRead(INIPath, "Replace2", "31"))
        Dim Replacement32 As String = LCase(INIRead(INIPath, "Replace2", "32"))
        Dim Replacement33 As String = LCase(INIRead(INIPath, "Replace2", "33"))
        Dim Replacement34 As String = LCase(INIRead(INIPath, "Replace2", "34"))
        Dim Replacement35 As String = LCase(INIRead(INIPath, "Replace2", "35"))
        Dim Replacement36 As String = LCase(INIRead(INIPath, "Replace2", "36"))
        Dim Replacement37 As String = LCase(INIRead(INIPath, "Replace2", "37"))
        Dim Replacement38 As String = LCase(INIRead(INIPath, "Replace2", "38"))
        Dim Replacement39 As String = LCase(INIRead(INIPath, "Replace2", "39"))
        Dim Replacement40 As String = LCase(INIRead(INIPath, "Replace2", "40"))


        Dim ConvertedText As String = param1


        ConvertedText = Replace(param1, Find1, Replacement1)
        ConvertedText = Replace(ConvertedText, Find2, Replacement2)
        ConvertedText = Replace(ConvertedText, Find3, Replacement3)
        ConvertedText = Replace(ConvertedText, Find4, Replacement4)
        ConvertedText = Replace(ConvertedText, Find5, Replacement5)
        ConvertedText = Replace(ConvertedText, Find6, Replacement6)
        ConvertedText = Replace(ConvertedText, Find7, Replacement7)
        ConvertedText = Replace(ConvertedText, Find8, Replacement8)
        ConvertedText = Replace(ConvertedText, Find9, Replacement9)
        ConvertedText = Replace(ConvertedText, Find10, Replacement10)
        ConvertedText = Replace(ConvertedText, Find11, Replacement11)
        ConvertedText = Replace(ConvertedText, Find12, Replacement12)
        ConvertedText = Replace(ConvertedText, Find13, Replacement13)
        ConvertedText = Replace(ConvertedText, Find14, Replacement14)
        ConvertedText = Replace(ConvertedText, Find15, Replacement15)
        ConvertedText = Replace(ConvertedText, Find16, Replacement16)
        ConvertedText = Replace(ConvertedText, Find17, Replacement17)
        ConvertedText = Replace(ConvertedText, Find18, Replacement18)
        ConvertedText = Replace(ConvertedText, Find19, Replacement19)
        ConvertedText = Replace(ConvertedText, Find20, Replacement20)
        ConvertedText = Replace(ConvertedText, Find21, Replacement21)
        ConvertedText = Replace(ConvertedText, Find22, Replacement22)
        ConvertedText = Replace(ConvertedText, Find23, Replacement23)
        ConvertedText = Replace(ConvertedText, Find24, Replacement24)
        ConvertedText = Replace(ConvertedText, Find25, Replacement25)
        ConvertedText = Replace(ConvertedText, Find26, Replacement26)
        ConvertedText = Replace(ConvertedText, Find27, Replacement27)
        ConvertedText = Replace(ConvertedText, Find28, Replacement28)
        ConvertedText = Replace(ConvertedText, Find29, Replacement29)
        ConvertedText = Replace(ConvertedText, Find30, Replacement30)
        ConvertedText = Replace(ConvertedText, Find31, Replacement31)
        ConvertedText = Replace(ConvertedText, Find32, Replacement32)
        ConvertedText = Replace(ConvertedText, Find33, Replacement33)
        ConvertedText = Replace(ConvertedText, Find34, Replacement34)
        ConvertedText = Replace(ConvertedText, Find35, Replacement35)
        ConvertedText = Replace(ConvertedText, Find36, Replacement36)
        ConvertedText = Replace(ConvertedText, Find37, Replacement37)
        ConvertedText = Replace(ConvertedText, Find38, Replacement38)
        ConvertedText = Replace(ConvertedText, Find39, Replacement39)
        ConvertedText = Replace(ConvertedText, Find40, Replacement40)


        Return ConvertedText

    End Function




    Public Function getPath() As String

        Dim dllPath As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
        ' Return the path to the INI file
        '   Return Path.Combine(dllPath, "omit.ini")
        Return Path.Combine(dllPath, iniName)
    End Function




    Public Function function19(param1 As String, param2 As String) As String

        If LCase(param1) = "about" Or LCase(param2) = "about" Then

            Return " returns path with no parameters, set ini as param 1 to get ini path"
        ElseIf LCase(param1) = "ini" Or LCase(param2) = "ini" Then
            If File.Exists(getPath()) Then
                Return "FOUND: " & getPath()
            Else
                Return "MISSING: " & getPath()
            End If

        Else
                Dim dllPath As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
            Return dllPath
        End If


        End Function

        Public Function function20(param1 As String, param2 As String) As String

            If LCase(param1) = "about" Or LCase(param2) = "about" Then
                Return " georgousis.info "
            Else
            Return "*  search and replace plugin ver. 3.2 by Nikos Georgousis."
        End If


        End Function

    Public Function GetMinRefreshInterval() As Integer
        Return 200
    End Function

    Public Function SmartieInfo()

        Return "Developer:Nikos Georgousis (Limbo)" & vbNewLine & "Version:3.2"

    End Function

    Public Function SmartieDemo()
        Dim demolist As New StringBuilder()

        demolist.AppendLine("Search and Replace plugin for LCD Smartie")
        demolist.AppendLine("This plugin searches for a text and replaces it with another")
        demolist.AppendLine("")
        demolist.AppendLine("------ Function1 ------")
        demolist.AppendLine("Replace any macth text on [Search1] field with the [Replace1] under the same line number.")
        demolist.AppendLine("Example :  $dll(sandr,2,replacethis,  )")
        demolist.AppendLine("")
        demolist.AppendLine("------ Function2 ------")
        demolist.AppendLine("Replace any macth text on [Search2] field with the [Replace2] under the same line number.")
        demolist.AppendLine("Example :  $dll(sandr,2,aaaa,  )")
        demolist.AppendLine("")
        demolist.AppendLine("------ Function3 ------")
        demolist.AppendLine("Replace any macth text on [Search1] field with the [Replace1] under the same line number. Case Insensitive Match")
        demolist.AppendLine("Example :  $dll(sandr,3,hello world,  )")
        demolist.AppendLine("")
        demolist.AppendLine("------ Function4 ------")
        demolist.AppendLine("Replace any macth text on [Search1] field with the [Replace1] under the same line number. Case Insensitive Match")
        demolist.AppendLine("Example :  $dll(sandr,4,HI,  )")
        demolist.AppendLine("")
        demolist.AppendLine("------ Function19 ------")
        demolist.AppendLine("This function returns the path of the ini and check if can be found")
        demolist.AppendLine("Check if INI exists:  $dll(sandr,19,ini , )")
        demolist.AppendLine("Get plugins folder:  $dll(sandr,19, , )")
        demolist.AppendLine("")
        demolist.AppendLine("------ Function20 ------")
        demolist.AppendLine("Returns credits")
        demolist.AppendLine("")
        demolist.AppendLine("---------------------------------------------------------------------------------------------------------------")
        demolist.AppendLine("Parameter 2 is optional and it can be used to pass ini filename if you want to use different file e.g. repl.ini ")
        demolist.AppendLine("---------------------------------------------------------------------------------------------------------------")
        demolist.AppendLine("Requires omit.ini file to be placed on plugins folder")
        demolist.AppendLine(">>>  EXAMPLE INI   <<<")
        demolist.AppendLine("")
        demolist.AppendLine(" [Search1] ")
        demolist.AppendLine(" 1=replacethis")
        demolist.AppendLine(" 2=Hi")
        demolist.AppendLine(" 3=aaaa")
        demolist.AppendLine(" 4=Hello World")
        demolist.AppendLine(" 5=$")
        demolist.AppendLine(" 6=HI")
        demolist.AppendLine("")
        demolist.AppendLine(" [Replace1]")
        demolist.AppendLine(" 1=With This?")
        demolist.AppendLine(" 2=Hello")
        demolist.AppendLine(" 3=You are rocking")
        demolist.AppendLine(" 4=I hope you Like it")
        demolist.AppendLine(" 5= \ ")
        demolist.AppendLine(" 6=Well, Hello")
        demolist.AppendLine("")
        demolist.AppendLine(" [Search2] ")
        demolist.AppendLine(" 1=replacethis")
        demolist.AppendLine(" 2=Hi")
        demolist.AppendLine(" 3=aaaa")
        demolist.AppendLine(" 4=Hello World")
        demolist.AppendLine(" 5=$")
        demolist.AppendLine(" 6=HI")
        demolist.AppendLine("")
        demolist.AppendLine(" [Replace2]")
        demolist.AppendLine(" 1=With This?")
        demolist.AppendLine(" 2=Hello")
        demolist.AppendLine(" 3=You are rocking")
        demolist.AppendLine(" 4=I hope you Like it")
        demolist.AppendLine(" 5= \ ")
        demolist.AppendLine(" 6=Well, Hello")
        demolist.AppendLine("")
        demolist.AppendLine("------------------------------------------------------------------------------------------------------------------")
        demolist.AppendLine(" *** Visit ***")
        demolist.AppendLine("> Home page")
        demolist.AppendLine("https://lcdsmartie.sourceforge.net")
        demolist.AppendLine("> Forums")
        demolist.AppendLine("https://www.lcdsmartie.org")
        demolist.AppendLine("> Active development branch (latest version)")
        demolist.AppendLine("https://github.com/stokie-ant/lcdsmartie-laz")
        demolist.AppendLine("")


        Dim result As String = demolist.ToString()
        Return result
    End Function




End Class
'End Namespace




