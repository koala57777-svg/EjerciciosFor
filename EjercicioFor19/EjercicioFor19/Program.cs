using System.Timers;

int numerosingresados = 0;
int numeromenor = int.MaxValue;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Ingrese su {i}° número: ");
    numerosingresados = int.Parse(Console.ReadLine());
    if (numerosingresados < numeromenor)
    {
        numeromenor = numerosingresados;
    }

}

Console.WriteLine($"El número mayor es {numeromenor}");