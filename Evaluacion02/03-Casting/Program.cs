using System;

namespace _03_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir número con decimales
            Console.Write("Ingrese un número con decimales (ej. 95.75): ");
            double numeroDecimal = double.Parse(Console.ReadLine());

            // Casting explícito de double a int (elimina la parte decimal)
            int parteEntera = (int)numeroDecimal;

            Console.WriteLine("\n--- CASTING EXPLÍCITO ---");
            Console.WriteLine($"Número original (double): {numeroDecimal}");
            Console.WriteLine($"Parte entera obtenida con casting (int): {parteEntera}");

            // Demostración de casting implícito (de int a double, sin pérdida de datos)
            int enteroBase = 17;
            double decimalConvertido = enteroBase;

            Console.WriteLine("\n--- CASTING IMPLÍCITO ---");
            Console.WriteLine($"Valor entero original (int): {enteroBase}");
            Console.WriteLine($"Convertido automáticamente a (double): {decimalConvertido}");
        }
    }
}