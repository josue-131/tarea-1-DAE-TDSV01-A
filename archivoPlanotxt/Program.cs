using System;
using System.IO;

namespace LeerArchivoTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la ruta del archivo de texto (txt): ");
            string rutaArchivo = Console.ReadLine();

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    Console.WriteLine("\nContenido del archivo:\n");
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        Console.WriteLine(linea);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

