using System;

namespace TempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter!");
            Console.WriteLine("What is the temperature?");
            string stringInput = (Console.ReadLine());
            decimal decimalInput = System.Convert.ToDecimal(stringInput);
            Console.WriteLine("What unit is that? (F = Fahrenheit, C = Celsius).");
            string tempInput = Console.ReadLine();
            if (tempInput == "F")
            {
                decimal tempCelsius = (decimalInput - 32) * 5 / 9;
                decimal roundTempCelsius = Math.Round(tempCelsius, 1);
                Console.WriteLine($"{decimalInput} degrees Fahrenheit is {roundTempCelsius} degrees Celsius.");
            }
            else if (tempInput == "C")
            {
                decimal tempFahrenheit = decimalInput * 9 / 5 + 32;
                decimal roundTempFahrenheit = Math.Round(tempFahrenheit, 1);
                Console.WriteLine($"{decimalInput} degrees Celsius is {roundTempFahrenheit} degrees Fahrenheit.");
            }

            if (decimalInput >= 80.0m)
            {
                Console.WriteLine("That's really warm!");
            }

            Console.WriteLine("Would you like to convert another temperature? Answer only Y or N");
            string inputContinue = Console.ReadLine();

            
        }
    }
}
