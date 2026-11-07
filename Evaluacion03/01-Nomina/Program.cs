using System;

namespace _01_Nomina
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de datos
            Console.Write("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese las horas trabajadas: ");
            double horasTrabajadas = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el pago por hora: ");
            double pagoPorHora = double.Parse(Console.ReadLine());

            // Procesos y cálculos
            double salarioBruto = horasTrabajadas * pagoPorHora;
            double afp = salarioBruto * 0.0287; // 2.87%
            double sfs = salarioBruto * 0.0304; // 3.04%
            double salarioNeto = salarioBruto - (afp + sfs);

            // Salida con nombre en MAYÚSCULAS y montos con formato N2
            Console.WriteLine("\n--- NÓMINA DE EMPLEADO ---");
            Console.WriteLine($"Empleado: {nombre.ToUpper()}");
            Console.WriteLine($"Salario Bruto: {salarioBruto:N2}");
            Console.WriteLine($"Descuento AFP (2.87%): {afp:N2}");
            Console.WriteLine($"Descuento SFS (3.04%): {sfs:N2}");
            Console.WriteLine($"Salario Neto: {salarioNeto:N2}");
        }
    }
}