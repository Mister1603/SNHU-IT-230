using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter any value: ");
        string input = Console.ReadLine();

        Console.WriteLine("\nOriginal string: " + input);

        // Convert to int
        try
        {
            int intValue = Convert.ToInt32(input);
            Console.WriteLine("Converted to int: " + intValue);
        }
        catch
        {
            Console.WriteLine("Cannot convert to int.");
        }

        // Convert to double
        try
        {
            double doubleValue = Convert.ToDouble(input);
            Console.WriteLine("Converted to double: " + doubleValue);
        }
        catch
        {
            Console.WriteLine("Cannot convert to double.");
        }

        // Convert to bool (from either numeric or string input)
        try
        {
            bool boolValue;

            // Try numeric to bool
            if (int.TryParse(input, out int numericInput))
            {
                boolValue = Convert.ToBoolean(numericInput);
            }
            else
            {
                // Try direct string to bool (like "true" or "false")
                boolValue = Convert.ToBoolean(input);
            }

            Console.WriteLine("Converted to bool: " + boolValue);
        }
        catch
        {
            Console.WriteLine("Cannot convert to bool.");
        }
    }
}
