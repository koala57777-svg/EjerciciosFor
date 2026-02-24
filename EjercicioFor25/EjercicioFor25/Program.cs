Console.WriteLine("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine();

string salida = "";

for (int i=1; i<= numero; i++)
{
    salida = salida + "*";
    Console.WriteLine(salida);
}

