using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Creamos un conjunto  de 500 ciudadanos con identificadores del 1 al 500
        HashSet<int> ciudadanos = new HashSet<int>(Enumerable.Range(1, 500));

        // Creamos un conjunto de 75 ciudadanos vacunados con Pfizer (ID del 1 al 75)
        HashSet<int> vacunadosPfizer = new HashSet<int>(Enumerable.Range(1, 75));

        // Creamos un conjunto de 75 ciudadanos vacunados con AstraZeneca (ID del 76 al 150)
        HashSet<int> vacunadosAstraZeneca = new HashSet<int>(Enumerable.Range(76, 75));

        // Diccionario para almacenar las categorías
        Dictionary<string, List<int>> categorias = new Dictionary<string, List<int>>()
        {
            { "No vacunados", new List<int>(ciudadanos.Except(vacunadosPfizer).Except(vacunadosAstraZeneca)) },
            { "Vacunados con ambas vacunas", new List<int>(vacunadosPfizer.Intersect(vacunadosAstraZeneca)) },
            { "Vacunados solo con Pfizer", new List<int>(vacunadosPfizer.Except(vacunadosAstraZeneca)) },
            { "Vacunados solo con AstraZeneca", new List<int>(vacunadosAstraZeneca.Except(vacunadosPfizer)) }
        };

        // Mostramos el resultados
        foreach (var categoria in categorias)
        {
            MostrarResultados(categoria.Key, categoria.Value.Count);
            MostrarPrimeros(categoria.Key, categoria.Value);
        }
    }

    // Método para mostrar el número de ciudadanos por cada categoría
    static void MostrarResultados(string categoria, int cantidad)
    {
        Console.WriteLine($"{categoria}: {cantidad} ciudadanos");
    }

    // Método para mostrar los primeros 10 ciudadanos de cada categoría
    static void MostrarPrimeros(string categoria, List<int> lista)
    {
        Console.WriteLine($"\nPrimeros 10 ciudadanos en la categoría '{categoria}':");
        foreach (var ciudadano in lista.Take(10))
        {
            Console.WriteLine($"ID: {ciudadano}");
        }
    }
}
