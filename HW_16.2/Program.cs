Console.Write("Enter number: ");
string input = Console.ReadLine();

try
{
    
    decimal number = Convert.ToDecimal(input);
    
    Console.WriteLine($"You entered number: {number}");
}
catch (FormatException)
{
    Console.WriteLine("Error: The entered value is not a number!");
}
catch (OverflowException)
{
    Console.WriteLine("Error: The entered number is outside the allowable range!");
}
catch(Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}


