using System;

namespace Evaluacion05
{
    class CajaRegistradora
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 1. CAJA REGISTRADORA ===");

            int cantidadProductos = 0;
            double subtotal = 0;
            double precio;

            // Lee precios hasta que el usuario escriba 0
            do
            {
                Console.Write("Ingrese el precio del producto (0 para terminar): ");
                if (double.TryParse(Console.ReadLine(), out precio))
                {
                    if (precio > 0)
                    {
                        subtotal += precio;
                        cantidadProductos++;
                    }
                    else if (precio < 0)
                    {
                        Console.WriteLine("Error: El precio no puede ser negativo.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Ingrese un valor numérico válido.");
                }

            } while (precio != 0);

            // Calcular ITBIS (18%) y total
            double itbis = subtotal * 0.18;
            double total = subtotal + itbis;

            // Mostrar resultados con formato N2
            Console.WriteLine("\n--- RESUMEN DE COMPRA ---");
            Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
            Console.WriteLine($"Subtotal: {subtotal:N2}");
            Console.WriteLine($"ITBIS (18%): {itbis:N2}");
            Console.WriteLine($"Total a pagar: {total:N2}");
        }
    }
}
