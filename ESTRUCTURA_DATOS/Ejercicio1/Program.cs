
using System;

namespace FigurasGeometricasSimples{
    public class Circulo
    {
        public double Radio { get; set; }

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }

    public class Cuadrado
    {
        public double Lado { get; set; }

        public double CalcularArea()
        {
            return Lado * Lado;
        }

        public double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Círculo
            Circulo circulo = new Circulo();
            Console.Write("Ingrese el radio del círculo: ");
            circulo.Radio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Área del círculo: {circulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro():F2}");

            // Cuadrado
            Cuadrado cuadrado = new Cuadrado();
            Console.Write("\nIngrese el lado del cuadrado: ");
            cuadrado.Lado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del cuadrado: {cuadrado.CalcularPerimetro():F2}");
        }
    }
}
