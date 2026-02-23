int numero = 0;
int numerostotales = 0;
for (int i=1; i<=5; i++)
{
    Console.WriteLine($"Ingrese su {i}° número: ");
    numero=int.Parse(Console.ReadLine()) + numero;
    numerostotales = i;
}
Console.WriteLine($"El promedio es: {numero/numerostotales}");