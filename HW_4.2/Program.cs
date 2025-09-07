double firstItem = 0;
double secondItem = 0;
char mathOperation = '_';
double result = 0;
string errorText = "";

Console.Write("Enter first number: ");
double.TryParse(Console.ReadLine(), out firstItem);

Console.Write("Enter second number: ");
double.TryParse(Console.ReadLine(), out secondItem);

Console.Write("Enter a mathematical operation: ");
char.TryParse(Console.ReadLine(), out mathOperation);

switch (mathOperation)
{
    case '+':
        result = firstItem + secondItem;
        break;
    case '-':
        result = firstItem - secondItem;
        break;
    case '*':
        result = firstItem * secondItem;
        break;
    case '/':
        if (secondItem == 0)
        {
            errorText = "ERROR: Division by zero is impossible";
        }
        else
        {
            result = firstItem / secondItem;
        }
        break;
    default:
        errorText = $"ERROR: Entered an undefined mathematical operation ({mathOperation}). Please try again.";
        break;
}

if (errorText != "")
{
    Console.WriteLine(errorText);
}
else
    Console.WriteLine($"Result:{result}");