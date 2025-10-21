int firstNumber = 0;
int secondNumber = 0;
int result = 0;

try
{
    Console.Write("Enter first number: ");
    firstNumber = int.Parse(Console.ReadLine());

    Console.Write("Enter second number: ");
    secondNumber = int.Parse(Console.ReadLine());

    result = firstNumber / secondNumber;
    Console.WriteLine("Result: ");
}
catch(DivideByZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (FormatException)
{
    Console.WriteLine($"Number isn't correct");
}

