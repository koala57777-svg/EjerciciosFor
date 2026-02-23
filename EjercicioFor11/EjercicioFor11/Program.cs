Console.WriteLine("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());

for (int i=1; i<=10; i++)
{
    Console.WriteLine($"{i} x {numero}= {i*numero}");
}