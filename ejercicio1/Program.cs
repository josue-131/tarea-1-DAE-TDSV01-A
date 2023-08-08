int cantidad = 10;
int cantidadProducto;
String nombreProducto;
double precioProducto, totalPagar, totalAcumulado = 0;

for(int i = 1; i <= cantidad; i++)
{

    Console.WriteLine("nombre del producto " + i);
    nombreProducto = Console.ReadLine();
    Console.WriteLine("precio del producto " + i);
    precioProducto = double.Parse(Console.ReadLine());
    Console.WriteLine("canttidad del producto " + i);
    cantidadProducto = int.Parse(Console.ReadLine());
    totalPagar = (cantidadProducto * precioProducto) * 1.13;
    totalAcumulado = totalAcumulado + totalPagar;

}
Console.WriteLine("El total a pagar es: " + totalAcumulado);
Console.ReadKey();
