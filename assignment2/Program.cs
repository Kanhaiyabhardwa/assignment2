using System;

class ShoppingCart
{
    static void Main()
    {
        // Prices of the items
        double[] prices = { 450.75, 1500.00, 320.50, 780.90, 540.00 };
        double totalPrice = 0.0;

        // Calculate total price
        foreach (double price in prices)
        {
            totalPrice += price;
        }

        // Apply discount if total price exceeds Rs. 3000
        if (totalPrice > 3000)
        {
            totalPrice *= 0.90; 
        }

        TemperatureConverter temperatureConverter = new TemperatureConverter();
        temperatureConverter.Main1();

        SimpleATM simpleATM = new SimpleATM();
        simpleATM.Main2();

        SubjectMarks subjectMarks = new SubjectMarks();
        subjectMarks.Main3();

        Console.WriteLine($"Total Price after discount (if applicable): Rs. {totalPrice:F2}");
        Console.ReadKey();
    }
}

