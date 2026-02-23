int numero=0;

for (int i=1; i<=5; i++)
{
    Console.WriteLine($"Ingrese su {i}° número: ");
    numero=int.Parse( Console.ReadLine() );
 
}

int cantidad = 0;
for (int j=1; j<=5; j++)
{
    if (numero>10)
    {
        cantidad = j;
    }
}

Console.WriteLine($"Cantidad que son mayores a 10 son: {cantidad}");

