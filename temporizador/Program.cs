using System;
using System.Diagnostics;
using System.Threading;

namespace TemporizadorApagado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Configurar temporizador para apagar la computadora");
            Console.WriteLine("2. Detener apagado programado");
            Console.Write("Seleccione una opción (1/2): ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese la cantidad de minutos para apagar la computadora: ");
                int minutos = int.Parse(Console.ReadLine());

                int segundos = minutos * 60;

                Console.WriteLine($"La computadora se apagará en {minutos} minutos...");

                Thread.Sleep(segundos * 1000);

                Process.Start("shutdown", "/s /f /t 0");
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Deteniendo el apagado programado...");
                Process.Start("shutdown", "/a");
            }
            else
            {
                Console.WriteLine("Opción no válida. Saliendo del programa.");
            }
        }
    }
}

