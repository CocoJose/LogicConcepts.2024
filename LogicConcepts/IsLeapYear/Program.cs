using Utils;

do
{
    var currentYaer = DateTime.Now.Year;
    var message = string.Empty;
    var year = ConsoleExtension.GetInt("Ingrese año: ");

    if (year == currentYaer)
    {
        message = "es";
    }else if (year > currentYaer)
    {
        message = "va a ser";
    }
    else
    {
        message = "fue";
    }

    if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine($"El año: {year}, SI {message} biciesto.");
            }
            else
            {
                Console.WriteLine($"El año: {year}, NO {message} biciesto.");
            }
        }
        else
        {
            Console.WriteLine($"El año: {year}, SI {message} biciesto.");
        }
    }
    else
    {
        Console.WriteLine($"El año: {year}, NO {message} biciesto.");
    }
    

} while (true);

Console.WriteLine("Game Over.");
