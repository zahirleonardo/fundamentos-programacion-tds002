using System;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constante solicitada
            const int ANIO_ACTUAL = 2026;

            // Pedir y leer nombre (string)
            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            // Pedir y leer edad (int)
            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            // Pedir y leer estatura (double)
            Console.Write("Ingresa tu estatura en metros (ej. 1.75): ");
            double estatura = double.Parse(Console.ReadLine());

            // Calcular el año de nacimiento
            int anioNacimiento = ANIO_ACTUAL - edad;

            // Mostrar el resultado usando interpolación de cadenas ($"...")
            Console.WriteLine("\n--- DATOS PERSONALES ---");
            Console.WriteLine($"Hola, {nombre}. Tienes {edad} años, miden {estatura}m y naciste aproximadamente en el año {anioNacimiento}.");
        }
    }
}
