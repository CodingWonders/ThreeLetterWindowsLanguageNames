Imports System.Globalization
Module Module1

    Public Sub Main()
        Console.WriteLine("Three Letter Windows Language Names! (taken from CultureInfo.ThreeLetterWindowsLanguageName)")
        Console.WriteLine("-------------------------------------------------------------------------------------------")
        Console.WriteLine("CULTURE ISO ISO WIN DISPLAYNAME                              ENGLISHNAME")
        Dim ci As CultureInfo
        For Each ci In CultureInfo.GetCultures(CultureTypes.NeutralCultures)
            Console.Write("{0,-7}", ci.Name)
            Console.Write(" {0,-3}", ci.TwoLetterISOLanguageName)
            Console.Write(" {0,-3}", ci.ThreeLetterISOLanguageName)
            Console.Write(" {0,-3}", ci.ThreeLetterWindowsLanguageName)
            Console.Write(" {0,-40}", ci.DisplayName)
            Console.WriteLine(" {0,-40}", ci.EnglishName)
        Next
        Console.ReadKey()
        End
    End Sub

End Module
