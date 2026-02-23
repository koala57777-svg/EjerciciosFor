int numero = 0;
for (int i=1; i<=3; i++)
{
    Console.WriteLine($"Ingrese su {i}° número: ");
    numero =  int.Parse( Console.ReadLine()) + numero;
}

Console.WriteLine($"La suma de los números es: {numero}");