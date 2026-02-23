Console.WriteLine("Ingrese la cantidad de números que quiere ingresar: ");
int cantidaddenumeros = int.Parse(Console.ReadLine());
int numerosingresados = 0;
int cuantosnegativos = 0;

for (int i = 1; i <= cantidaddenumeros; i++)
{
    Console.WriteLine($"Ingrese su {i}° número: ");
    numerosingresados = int.Parse(Console.ReadLine());

    if (numerosingresados < 0)
    {
        cuantosnegativos = cuantosnegativos + 1;
    }

}


Console.WriteLine($"La cantidad de números que son negativos son: {cuantosnegativos}");