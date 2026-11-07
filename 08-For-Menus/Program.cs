using System;

namespace _08_For_Menus
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("\n==================================");
                Console.WriteLine("          MENÚ PRINCIPAL          ");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Mostrar tablas de multiplicar (1 al 10)");
                Console.WriteLine("2. Dibujar triángulo de asteriscos");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("\n--- TABLAS DE MULTIPLICAR (1 al 10) ---");
                            for (int i = 1; i <= 10; i++)
                            {
                                Console.WriteLine($"\nTabla del {i}:");
                                for (int j = 1; j <= 10; j++)
                                {
                                    int resultado = i * j;
                                    Console.WriteLine($"{i} x {j,2} = {resultado,4}");
                                }
                            }
                            break;

                        case 2:
                            Console.WriteLine("\n--- TRIÁNGULO DE ASTERISCOS ---");
                            Console.Write("Ingrese el número de filas: ");
                            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                            {
                                for (int i = 1; i <= n; i++)
                                {
                                    for (int j = 1; j <= i; j++)
                                    {
                                        Console.Write("* ");
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Por favor, ingrese un número entero positivo válido.");
                            }
                            break;

                        case 0:
                            Console.WriteLine("\nSaliendo del programa... ¡Hasta luego!");
                            break;

                        default:
                            Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Ingrese un número.");
                    opcion = -1; // Para evitar que salga por error si ingresan letras
                }

            } while (opcion != 0);
        }
    }
}