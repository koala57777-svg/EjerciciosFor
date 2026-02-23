int numerosingresados = 0;

for (int i=1; i<=5; i++)
{
    Console.WriteLine($"Ingrese su {i}° número: ");
    numerosingresados =int.Parse( Console.ReadLine() );
}

int cantidadpares = 0;
for (int j=1; j<=5; j++)
{
    if (numerosingresados % 2 == 0)
    {
        cantidadpares = j;
    }
}

Console.WriteLine($"La cantidad de pares son: {cantidadpares}");