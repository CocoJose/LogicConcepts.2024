using Utils;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    // Data input
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();
    Console.WriteLine("*** PARES E IMPARES EN ARREGLO ***");
    var n = ConsoleExtension.GetInt("Cuantas posiciones quieres en el arreglo: ");
    var numbers = new int[n];

    // Do process
    FillAray(numbers);
    var sum = GetSumEven(numbers);
    var prod = GetProdOdd(numbers);

    // Show results

    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Yellow;

    ShowArray(numbers);
    Console.WriteLine($"La sumatoria es: {sum,30:N0}");
    Console.WriteLine($"La productoria es: {prod,30:N0}");

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;


    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]i, [N]o?", options);
        Console.WriteLine();
        Console.WriteLine();
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

int GetProdOdd(int[] numbers)
{
    var prod = 1;
    foreach (int number in numbers)
    {
        if (number % 2 != 0)
        {
            prod *= number;
        }
    }
    return prod;
}

double GetSumEven(int[] numbers)
{
    double sum = 0;
    foreach (int number in numbers)
    {
        if (number % 2 == 0)
        {
            sum += number;
        }
    }
    return sum;
}

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

