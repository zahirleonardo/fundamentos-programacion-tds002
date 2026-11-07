using System;

namespace _02_Factura
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ITBIS = 0.18; // 18% constante

            // Entrada de datos
            Console.Write("Ingrese el nombre del producto: ");
            string producto = Console.ReadLine();

            Console.Write("Ingrese la cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio unitario: ");
            double precio = double.Parse(Console.ReadLine());

            // Procesos
            double subtotal = cantidad * precio;
            double montoItbis = subtotal * ITBIS;
            double total = subtotal + montoItbis;

            // Salida con factura en columnas alineadas
            Console.WriteLine("\n==============================");
            Console.WriteLine("          FACTURA             ");
            Console.WriteLine("==============================");
            Console.WriteLine($"{"Producto:",-15} {producto}");
            Console.WriteLine($"{"Cantidad:",-15} {cantidad}");
            Console.WriteLine($"{"Precio Unit.:",-15} {precio,10:N2}");
            Console.WriteLine($"{"Subtotal:",-15} {subtotal,10:N2}");
            Console.WriteLine($"{"ITBIS (18%):",-15} {montoItbis,10:N2}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{"TOTAL:",-15} {total,10:N2}");
            Console.WriteLine("==============================");
        }
    }
}