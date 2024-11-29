using Utils;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    // Data input
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();
    Console.WriteLine("*** OPERACIONES EN UN ARREGLO ***");
    var n = ConsoleExtension.GetInt("Cuantas posiciones quieres en el arreglo: ");
    var numbers = new int[n];

    // Do process
    FillAray(numbers);
    // var sum = GetSum(numbers);

    // Show results

    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Yellow;

    ShowArray(numbers);
    Console.WriteLine($"La sumatoria es: {numbers.Sum(),30:N0}");
    Console.WriteLine($"El promedio es: {numbers.Average(),30:N2}");

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;


    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]i, [N]o?", options);
        Console.WriteLine();
        Console.WriteLine();
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

//double GetSum(int[] numbers)
//{
//    double sum = 0;
//    foreach (int number in numbers)
//    {
//       sum += number;
//    }
//    return sum;
//}

void ShowArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write($"{number,10:0}");
    }
    Console.WriteLine();
}

void FillAray(int[] numbers)
{
    var random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(0, 100);
    }
}


