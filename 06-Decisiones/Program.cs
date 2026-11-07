using System;

namespace _06_Decisiones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("    TAREA SEMANA 6: ESTRUCTURAS DE DECISIÓN ");
            Console.WriteLine("===========================================");

            // ==========================================
            // PARTE 1: CALIFICACIÓN
            // ==========================================
            Console.WriteLine("\n--- Parte 1: Evaluación de Calificación ---");
            Console.Write("Ingrese la nota numérica (0-100): ");
            string inputNota = Console.ReadLine();

            // Validar con int.TryParse y verificar rango
            if (int.TryParse(inputNota, out int nota) && nota >= 0 && nota <= 100)
            {
                // Determinar la letra con if - else if - else
                if (nota >= 90)
                {
                    Console.WriteLine($"Resultado: Calificación A ({nota} puntos)");
                }
                else if (nota >= 80)
                {
                    Console.WriteLine($"Resultado: Calificación B ({nota} puntos)");
                }
                else if (nota >= 70)
                {
                    Console.WriteLine($"Resultado: Calificación C ({nota} puntos)");
                }
                else
                {
                    Console.WriteLine($"Resultado: Calificación F ({nota} puntos)");
                }
            }
            else
            {
                Console.WriteLine("Error: Debe ingresar un número entero válido entre 0 y 100.");
            }

            // ==========================================
            // PARTE 2: CALCULADORA
            // ==========================================
            Console.WriteLine("\n--- Parte 2: Calculadora Básica ---");
            
            Console.Write("Ingrese el primer número: ");
            bool num1Valido = double.TryParse(Console.ReadLine(), out double num1);

            Console.Write("Ingrese el segundo número: ");
            bool num2Valido = double.TryParse(Console.ReadLine(), out double num2);

            if (num1Valido && num2Valido)
            {
                Console.WriteLine("\nOpciones de operación:");
                Console.WriteLine("1. Sumar (+)");
                Console.WriteLine("2. Restar (-)");
                Console.WriteLine("3. Multiplicar (*)");
                Console.WriteLine("4. Dividir (/)");
                Console.Write("Seleccione una opción (1-4): ");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    // Resolver la operación con switch
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                            break;
                        case 2:
                            Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                            break;
                        case 3:
                            Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                            break;
                        case 4:
                            // Validar división entre cero
                            if (num2 != 0)
                            {
                                Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
                            }
                            else
                            {
                                Console.WriteLine("Error: No es posible dividir entre cero.");
                            }
                            break;
                        default:
                            Console.WriteLine("Error: Opción no válida. Debe seleccionar del 1 al 4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar un número entero para seleccionar la opción.");
                }
            }
            else
            {
                Console.WriteLine("Error: Uno o ambos números ingresados no son válidos.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
