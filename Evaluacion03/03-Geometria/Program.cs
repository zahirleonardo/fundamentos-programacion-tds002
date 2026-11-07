using System;

namespace _03_Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada para el círculo
            Console.Write("Ingrese el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());

            // Cálculos del círculo usando Math.PI y Math.Pow
            double areaCirculo = Math.PI * Math.Pow(radio, 2);
            double circunferencia = 2 * Math.PI * radio;

            // Entrada para el triángulo rectángulo
            Console.Write("Ingrese el cateto A del triángulo: ");
            double catetoA = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el cateto B del triángulo: ");
            double catetoB = double.Parse(Console.ReadLine());

            // Cálculo de la hipotenusa usando Math.Sqrt y Math.Pow
            double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

            // Salida con formato de 2 decimales
            Console.WriteLine("\n--- RESULTADOS GEOMÉTRICOS ---");
            Console.WriteLine($"Área del círculo: {areaCirculo:F2}");
            Console.WriteLine($"Circunferencia del círculo: {circunferencia:F2}");
            Console.WriteLine($"Hipotenusa del triángulo: {hipotenusa:F2}");
        }
    }
}