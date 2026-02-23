Console.WriteLine("Ponga la cantida de ventas que necesita ingresar: ");
int cantidadVentas = int.Parse(Console.ReadLine());

double totalVentas = 0;
double venta = 0;

for(int i=1; i<=cantidadVentas; i++)
{
    Console.WriteLine($"Ingrese el monto de la {i}° venta (Q): ");
    venta = double.Parse(Console.ReadLine());
    totalVentas = totalVentas + venta;
}

Console.WriteLine($"El total de ventas fue: Q {totalVentas}");