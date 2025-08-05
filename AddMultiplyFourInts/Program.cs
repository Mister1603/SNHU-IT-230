using System;

class AddMultiplyFourInts
{
    static void Main()
    {
        // Initialize four integer variables
        int num1 = 13;
        int num2 = 55;
        int num3 = 123;
        int num4 = 325;

        // Calculate the sum and the product
        int sum = num1 + num2 + num3 + num4;
        int product = num1 * num2 * num3 * num4;

        // Output the results
        Console.WriteLine($"The sum of {num1}, {num2}, {num3}, and {num4} = {sum}");
        Console.WriteLine($"The product of {num1}, {num2}, {num3}, and {num4} = {product}");

        // Wait for user to press a key
        Console.WriteLine("Press any key to continue , Connor Medeiros. . .");
        Console.ReadKey();
    }
}
