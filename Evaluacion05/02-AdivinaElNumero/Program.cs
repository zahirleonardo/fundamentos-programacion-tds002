using System;

namespace _02_AdivinaElNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroSecreto = Random.Shared.Next(1, 101);
            int intento = 0;
            int contadorIntentos = 0;

            Console.WriteLine("--- JUEGO: ADIVINA EL NÚMERO ---");
            Console.WriteLine("He pensado en un número del 1 al 100. ¡Intenta adivinarlo!\n");

            while (intento != numeroSecreto)
            {
                Console.Write("Ingresa tu suposición: ");
                intento = int.Parse(Console.ReadLine());
                contadorIntentos++;

                if (intento > numeroSecreto)
                {
                    Console.WriteLine("<< menor >>\n");
                }
                else if (intento < numeroSecreto)
                {
                    Console.WriteLine("<< mayor >>\n");
                }
                else
                {
                    Console.WriteLine($"\n¡Felicidades! Adivinaste el número en {contadorIntentos} intentos.");
                }
            }
        }
    }
}
