Console.WriteLine("Enter the operation (c/f):");
char userChoice = Char.ToLower(Char.Parse(Console.ReadLine()));

Console.WriteLine("Enter the temperature:");
double temperature = Convert.ToDouble(Console.ReadLine());

switch (userChoice)
{
    case 'c':
        ConvertToCelsius(temperature);
        break;
    case 'f':
        ConvertToFahrenheit(temperature);
        break;
    default:
        Console.WriteLine("Invalid choice. Please enter 'c' for Celsius or 'f' for Fahrenheit.");
        break;
}

void ConvertToCelsius(double fahrenheit)
{
    double celsius = (fahrenheit - 32) * 5.0 / 9.0;
    Console.WriteLine($"{fahrenheit} Fahrenheit is {celsius} Celsius");
}

void ConvertToFahrenheit(double celsius)
{
    double fahrenheit = (celsius * 9.0 / 5.0) + 32;
    Console.WriteLine($"{celsius} Celsius is {fahrenheit} Fahrenheit");
}