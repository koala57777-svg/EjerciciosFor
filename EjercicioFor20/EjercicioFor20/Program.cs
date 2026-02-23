Console.WriteLine("Ingrese la cantidad de números que quiere ingresar: ");
int cantidadnumeros = int.Parse(Console.ReadLine());
int numerosingresados = 0;
int cuantospositivos = 0;

for (int i=1; i<=cantidadnumeros; i++)
{
    Console.WriteLine($"Ingrese su {i}° número: ");
    numerosingresados= int.Parse(Console.ReadLine());

    if (numerosingresados > 0)
    {
        cuantospositivos=cuantospositivos+1;
    }
    
}


Console.WriteLine($"La cantidad de números que son positivos son: {cuantospositivos}");