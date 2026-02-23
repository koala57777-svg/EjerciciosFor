int numerosingresados = 0;
int cantidadpares = 0;
for (int i=1; i<=5; i++)
{
    Console.WriteLine($"Ingrese su {i}° número: ");
    numerosingresados =int.Parse( Console.ReadLine() );
    
    if (numerosingresados % 2 == 0)
    {
        cantidadpares = cantidadpares + 1;
    }
}

Console.WriteLine($"La cantidad de pares son: {cantidadpares}");