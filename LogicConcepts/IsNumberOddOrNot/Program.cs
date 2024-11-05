var numberString = string.Empty;
do
{
    Console.WriteLine("Ingrese número entero o la palabra 'Salir' para salir: ");
    numberString = Console.ReadLine();  // "45"
    if (numberString!.ToLower() == "salir")
    {
        continue;
    }

    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número {numberInt}, es par.");
        }
        else
        {
            Console.WriteLine($"El número {numberInt}, es impar");
        }
    }
    else
    {
        Console.WriteLine($"Lo que ingresaste: {numberInt}, no es un número entero");
    }

} while (numberString!.ToLower() != "salir");
Console.WriteLine("Game Over");



