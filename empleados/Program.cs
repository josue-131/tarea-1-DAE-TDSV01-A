using System;

namespace RegistroEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[5];
            string[] dui = new string[5];
            string[] nit = new string[5];
            double[] salarioPorHora = new double[5];
            double[] horasTrabajadas = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese los datos del empleado {i + 1}:");
                Console.Write("Nombre completo: ");
                nombres[i] = Console.ReadLine();
                Console.Write("DUI: ");
                dui[i] = Console.ReadLine();
                Console.Write("NIT: ");
                nit[i] = Console.ReadLine();
                Console.Write("Salario por hora: ");
                salarioPorHora[i] = double.Parse(Console.ReadLine());
                Console.Write("Horas trabajadas: ");
                horasTrabajadas[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("\nListado de empleados:");

            Console.WriteLine($"{"Nombre",-20} {"DUI",-15} {"NIT",-15} {"Salario Total",-15}");
            Console.WriteLine(new string('-', 65));

            for (int i = 0; i < 5; i++)
            {
                double salarioTotal = salarioPorHora[i] * horasTrabajadas[i];
                Console.WriteLine($"{nombres[i],-20} {dui[i],-15} {nit[i],-15} ${salarioTotal:N2}", -15);
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
