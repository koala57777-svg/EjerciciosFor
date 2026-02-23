using System.Timers;

int numerosingresados = 0 ;
int numeromayor = int.MinValue;
for (int i=1; i<=5; i++)
{
    Console.WriteLine($"Ingrese su {i}° número: ");
    numerosingresados =int.Parse(Console.ReadLine());
   if (numerosingresados> numeromayor)
    {
        numeromayor = numerosingresados;
    }

}

Console.WriteLine($"El número mayor es {numeromayor}");
