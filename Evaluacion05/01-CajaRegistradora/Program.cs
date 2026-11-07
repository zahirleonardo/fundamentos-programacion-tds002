using System;

namespace _01_CajaRegistradora
{
    class Program
    {
        static void Main(string[] args)
        {
            double subtotal = 0;
            int cantidadProductos = 0;
            double precio;

            Console.WriteLine("--- CAJA REGISTRADORA ---");

            do
            {
                Console.Write("Ingrese el precio del producto (0 para terminar): ");
                precio = double.Parse(Console.ReadLine());

                if (precio > 0)
                {
                    subtotal += precio;
                    cantidadProductos++;
                }
            } while (precio != 0);

            double itbis = subtotal * 0.18;
            double total = subtotal + itbis;

            Console.WriteLine("\n==============================");
            Console.WriteLine("      FACTURA DE COMPRA       ");
            Console.WriteLine("==============================");
            Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
            Console.WriteLine($"Subtotal:              {subtotal,10:N2}");
            Console.WriteLine($"ITBIS (18%):           {itbis,10:N2}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"TOTAL:                 {total,10:N2}");
            Console.WriteLine("==============================");
        }
    }
}