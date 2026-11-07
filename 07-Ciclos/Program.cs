using System;

namespace _07_Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("    TAREA SEMANA 7: CICLOS WHILE Y DO-WHILE ");
            Console.WriteLine("===========================================");

            int numero = 0;
            bool entradaValida = false;

            // 1. Pedir un número entre 1 y 12 validado con do-while
            do
            {
                Console.Write("\nIngrese un número entero entre 1 y 12: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numero))
                {
                    if (numero >= 1 && numero <= 12)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: El número debe estar estrictamente en el rango de 1 a 12.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar un valor numérico entero válido.");
                }

            } while (!entradaValida);

            Console.WriteLine($"\n¡Número aceptado! Generando la tabla del {numero}...");
            Console.WriteLine("-------------------------------------------");

            // 2. Mostrar la tabla de multiplicar del 1 al 12 con while y un contador
            int contador = 1;
            int sumaTotal = 0; // Acumulador para sumar los resultados

            while (contador <= 12)
            {
                int resultado = numero * contador;
                Console.WriteLine($"{numero} x {contador} = {resultado}");
                
                // 3. Acumular el resultado de cada multiplicación
                sumaTotal += resultado;
                
                contador++;
            }

            Console.WriteLine("-------------------------------------------");
            // Mostrar la suma total de todos los resultados
            Console.WriteLine($"Suma total de todos los resultados: {sumaTotal}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}