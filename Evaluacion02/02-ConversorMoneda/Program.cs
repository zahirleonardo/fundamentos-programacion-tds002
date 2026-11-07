using System;

namespace _02_ConversorMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constante con la tasa de cambio del día (DOP a USD)
            const double TASA_USD = 60.0;

            // Pedir monto en pesos
            Console.Write("Ingrese el monto en pesos (DOP): ");
            double montoPesos = double.Parse(Console.ReadLine());

            // Calcular equivalente en dólares
            double montoDolares = montoPesos / TASA_USD;

            // Mostrar resultados con interpolación
            Console.WriteLine("\n--- CONVERSOR DE MONEDA ---");
            Console.WriteLine($"Monto ingresado: {montoPesos} DOP");
            Console.WriteLine($"Tasa de cambio aplicada: {TASA_USD} DOP por USD");
            Console.WriteLine($"Equivalente en dólares: ${montoDolares:F2} USD");
        }
    }
}
