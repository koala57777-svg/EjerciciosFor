Console.WriteLine("Ponga la cantida de notas que necesita ingresar: ");
int cantidadNotas = int.Parse(Console.ReadLine());

double totalNotas = 0;
double Nota = 0;
int contador = 1;
for (int i = 1; i <= cantidadNotas; i++)
{
    Console.WriteLine($"Ingrese la {i}° nota: ");
    Nota = double.Parse(Console.ReadLine());
    totalNotas = totalNotas + Nota;
    contador = i;
}

if ((totalNotas / contador) >= 61)
{
    Console.WriteLine($"El promedio es: {totalNotas / contador} y el alumno esta aprobado");
}
else
{
    Console.WriteLine($"El promedio es: {totalNotas / contador} y el alumno esta reprobado");
}