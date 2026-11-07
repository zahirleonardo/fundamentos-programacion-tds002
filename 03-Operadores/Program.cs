using System;

namespace _03_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leer dos números enteros
            Console.Write("Ingrese el primer número entero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número entero: ");
            int num2 = int.Parse(Console.ReadLine());

            // Cálculos con operadores
            int suma = num1 + num2;
            int resta = num1 - num2;
            int producto = num1 * num2;
            double divisionReal = (double)num1 / num2; // División real con casting
            int divisionEntera = num1 / num2;          // División entera
            int residuo = num1 % num2;                 // Residuo (módulo)
            bool esPar = (num1 % 2 == 0);              // Validación booleana si el primero es par

            // Mostrar resultados usando interpolación de cadenas ($"...")
            Console.WriteLine("\n--- RESULTADOS DE OPERACIONES ---");
            Console.WriteLine($"Suma ({num1} + {num2}) = {suma}");
            Console.WriteLine($"Resta ({num1} - {num2}) = {resta}");
            Console.WriteLine($"Producto ({num1} * {num2}) = {producto}");
            Console.WriteLine($"División real ({num1} / {num2}) = {divisionReal}");
            Console.WriteLine($"División entera ({num1} / {num2}) = {divisionEntera}");
            Console.WriteLine($"Residuo ({num1} % {num2}) = {residuo}");
            Console.WriteLine($"¿El primer número ({num1}) es par? -> {esPar}");
        }
    }
}

/*
 ==========================================
 PRUEBA DE ESCRITORIO (x = 10, y = 3)
 ==========================================
 Variables de entrada:
   x = 10
   y = 3

 Operaciones evaluadas paso a paso:
   1. int suma = x + y;             --> 10 + 3 = 13
   2. int resta = x - y;            --> 10 - 3 = 7
   3. int producto = x * y;         --> 10 * 3 = 30
   4. double divisionReal = (double)x / y; --> 10.0 / 3 = 3.3333...
   5. int divisionEntera = x / y;   --> 10 / 3 = 3
   6. int residuo = x % y;          --> 10 % 3 = 1 (el sobrante de dividir 10 entre 3)
   7. bool esPar = (x % 2 == 0);    --> 10 % 2 == 0 -> (0 == 0) -> true
 */