using System;

namespace _04_Secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constante de conversión de libras a kilogramos
            const double LIBRA_A_KG = 0.453592;

            // Pedir peso en libras
            Console.Write("Ingrese el peso en libras (lb): ");
            double libras = double.Parse(Console.ReadLine());

            // Pedir temperatura en Fahrenheit
            Console.Write("Ingrese la temperatura en grados Fahrenheit (°F): ");
            double fahrenheit = double.Parse(Console.ReadLine());

            // Realizar conversiones
            double kilogramos = libras * LIBRA_A_KG;
            double celsius = (fahrenheit - 32) * 5.0 / 9.0;

            // Mostrar resultados formateados a 2 decimales con interpolación
            Console.WriteLine("\n--- RESULTADO DE LA CONVERSIÓN ---");
            Console.WriteLine($"Peso: {libras} lb = {kilogramos:F2} kg");
            Console.WriteLine($"Temperatura: {fahrenheit} °F = {celsius:F2} °C");
        }
    }
}
    