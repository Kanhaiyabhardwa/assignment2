using System;

class TemperatureConverter
{
    public void Main1()
    {
        Console.Write("Enter temperature in Celsius: ");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            // Convert Celsius to Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}°F");

            // Check for freezing temperature
            if (celsius < 0)
            {
                Console.WriteLine("Warning: The temperature is below freezing!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
}