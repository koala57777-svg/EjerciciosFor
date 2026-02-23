int numero=0;
int cantidad = 0;
for (int i=1; i<=5; i++)
{
    Console.WriteLine($"Ingrese su {i}° número: ");
    numero=int.Parse( Console.ReadLine() );
    if (numero > 10)
    {
        cantidad = cantidad + 1;
    }

}

Console.WriteLine($"Cantidad de números que son mayores a 10 son: {cantidad}");

