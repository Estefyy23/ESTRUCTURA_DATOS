
class Traductor_Ingles_Espanol
{
    static Dictionary<string, string> englishToSpanish = new Dictionary<string, string>
    {
        {"time", "tiempo"},
        {"person", "persona"},
        {"they work", "trabajan"},
        {"have", "tener"},
        {"year", "año"},
        {"way", "camino/forma"},
        {"day", "día"},
        {"thing", "cosa"},
        {"man", "hombre"},
        {"world", "mundo"},
        {"life", "vida"},
        {"hand", "mano"},
        {"part", "parte"},
        {"child", "niño/a"},
        {"eye", "ojo"},
        {"woman", "mujer"},
        {"place", "lugar"},
        {"work", "trabajo"},
        {"week", "semana"},
        {"case", "caso"},
        {"point", "punto/tema"},
        {"government", "gobierno"},
        {"company", "empresa/compañía"}
    };

    static Dictionary<string, string> spanishToEnglish = new Dictionary<string, string>
    {
        {"tiempo", "time"},
        {"persona", "person"},
        {"año", "year"},
        {"camino", "way"},
        {"forma", "way"},
        {"día", "day"},
        {"cosa", "thing"},
        {"hombre", "man"},
        {"mundo", "world"},
        {"vida", "life"},
        {"mano", "hand"},
        {"parte", "part"},
        {"niño", "child"},
        {"niña", "child"},
        {"ojo", "eye"},
        {"mujer", "woman"},
        {"lugar", "place"},
        {"trabajo", "work"},
        {"semana", "week"},
        {"caso", "case"},
        {"punto", "point"},
        {"tema", "point"},
        {"gobierno", "government"},
        {"empresa", "company"},
        {"compañía", "company"}
    };

    static void Main(string[] args)
    {
        MostrarCaratula();

        while (true)
        {
            Console.WriteLine("=========================== MENÚ ======================\n");
            Console.WriteLine("1. Traducir una frase\n");
            Console.WriteLine("2. Ingresar más palabras al diccionario\n");
            Console.WriteLine("0. Salir\n");
            Console.Write("\nSeleccione una opción: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                TranslatePhrase();
            }
            else if (option == "2")
            {
                AddWordToDictionary();
            }
            else if (option == "0")
            {
                Console.WriteLine("\nGracias por usar el traductor. ¡Hasta luego!");
                break;
            }
            else
            {
                Console.WriteLine("\nOpción no válida. Intente de nuevo.");
            }
        }
    }

    static void MostrarCaratula()
    {
        Console.WriteLine("======================================================");
        Console.WriteLine("             UNIVERSIDAD ESTATAL AMAZÓNICA           ");
        Console.WriteLine("            TRADUCTOR INGLÉS - ESPAÑOL               ");
        Console.WriteLine("               Programación en C#                    ");
        Console.WriteLine("                  Paralelo C                         ");
        Console.WriteLine("======================================================");
        Console.WriteLine("       Facultad de Ciencias de la vida      ");
        Console.WriteLine("            Fecha: 22 de Febrero de 2025             ");
        Console.WriteLine("======================================================\n");
    }

    static void TranslatePhrase()
    {
        Console.Write("\nIngrese la frase: ");
        string phrase = Console.ReadLine();
        string[] words = phrase.Split(' ');
        string translatedPhrase = "";

        foreach (string word in words)
        {
            string cleanedWord = word.ToLower().Trim(new char[] { '.', ',', '!', '?' });
            if (englishToSpanish.ContainsKey(cleanedWord))
            {
                translatedPhrase += englishToSpanish[cleanedWord] + " ";
            }
            else if (spanishToEnglish.ContainsKey(cleanedWord))
            {
                translatedPhrase += spanishToEnglish[cleanedWord] + " ";
            }
            else
            {
                translatedPhrase += word + " ";
            }
        }

        Console.WriteLine("\nSu frase traducida es: " + translatedPhrase.Trim());
    }

    static void AddWordToDictionary()
    {
        Console.Write("\nIngrese la palabra en inglés: ");
        string englishWord = Console.ReadLine().ToLower();
        Console.Write("Ingrese la traducción en español: ");
        string spanishWord = Console.ReadLine().ToLower();

        if (!englishToSpanish.ContainsKey(englishWord))
        {
            englishToSpanish.Add(englishWord, spanishWord);
            spanishToEnglish.Add(spanishWord, englishWord);
            Console.WriteLine("\nPalabra agregada correctamente.");
        }
        else
        {
            Console.WriteLine("\nLa palabra ya existe en el diccionario.");
        }
    }
}

