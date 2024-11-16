using Utils;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    // Data input
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();
    Console.WriteLine("*** CALCULO DEL NÚMERO e ***");
    var n = ConsoleExtension.GetInt("Cuantos términos de presición quieres: ");

    // Do process
    var e = CalculateE(n);

    // Show results
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine($"El valor de 'e' con: {n} términos de presición es: {e}");

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;


    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]i, [N]o?", options);
        Console.WriteLine();
        Console.WriteLine();
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

double CalculateE(int n)
{
    double sum = 0;
    for (var i = 0; i < n; i++)
    {
        sum += 1 / MyMath.Factorial(i);
    }
    return sum;
}