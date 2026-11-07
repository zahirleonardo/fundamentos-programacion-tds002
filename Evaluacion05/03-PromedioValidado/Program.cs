using System;

namespace _03_PromedioValidado
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumaNotas = 0;
            int cantidadNotas = 0;
            double notaMayor = 0;
            double notaMenor = 100;
            string entrada;
            double nota;

            Console.WriteLine("--- PROMEDIO VALIDADO DE NOTAS ---");
            Console.WriteLine("Ingresa notas de 0 a 100. Escribe -1 para terminar.\n");

            do
            {
                Console.Write("Ingrese una nota (-1 para salir): ");
                entrada = Console.ReadLine();

                if (double.TryParse(entrada, out nota))
                {
                    if (nota == -1)
                    {
                        break;
                    }

                    if (nota >= 0 && nota <= 100)
                    {
                        sumaNotas += nota;
                        cantidadNotas++;

                        if (cantidadNotas == 1)
                        {
                            notaMayor = nota;
                            notaMenor = nota;
                        }
                        else
                        {
                            if (nota > notaMayor) notaMayor = nota;
                            if (nota < notaMenor) notaMenor = nota;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: La nota debe estar entre 0 y 100.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Entrada no válida. Ingrese un número.");
                }

            } while (true);

            if (cantidadNotas > 0)
            {
                double promedio = sumaNotas / cantidadNotas;

                Console.WriteLine("\n==============================");
                Console.WriteLine("       RESULTADOS FINALES     ");
                Console.WriteLine("==============================");
                Console.WriteLine($"Notas ingresadas: {cantidadNotas}");
                Console.WriteLine($"Promedio:         {promedio:N2}");
                Console.WriteLine($"Nota más alta:    {notaMayor:N2}");
                Console.WriteLine($"Nota más baja:    {notaMenor:N2}");
                Console.WriteLine("==============================");
            }
            else
            {
                Console.WriteLine("\nNo se registraron notas válidas.");
            }
        }
    }
}
