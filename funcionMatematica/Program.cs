using System;

namespace SolucionEcuacionCuadratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de c: ");
            double c = double.Parse(Console.ReadLine());

            double discriminante = b * b - 4 * a * c;

            if (discriminante >= 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                Console.WriteLine($"x1 = {x1:N2}");
                Console.WriteLine($"x2 = {x2:N2}");
            }
            else
            {
                double parteReal = -b / (2 * a);
                double parteImaginaria = Math.Sqrt(-discriminante) / (2 * a);

                Console.WriteLine($"x1 = {parteReal:N2} + {parteImaginaria:N2}i");
                Console.WriteLine($"x2 = {parteReal:N2} - {parteImaginaria:N2}i");
            }

            Console.ReadKey(); // Esperar a que el usuario presione una tecla para salir
        }
    }
}
