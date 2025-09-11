#region Task 1: Calculation of average salary
/*
bool isRepeatLoop = true;
double currentSalary = 0;
double sumOfSalaries = 0;
int countOfEmployee = 0;
double averageSalary = 0;

while (isRepeatLoop)
{
    Console.Write("Please enter the salary of current employee or press Enter (or another invalid value) to exit: ");
    double.TryParse(Console.ReadLine(), out currentSalary);
    if (currentSalary != 0)
    {
        sumOfSalaries += currentSalary;
        countOfEmployee += 1;
        averageSalary = sumOfSalaries / countOfEmployee;
        Console.WriteLine($"Count of employees: {countOfEmployee}");
        Console.WriteLine($"Average salary: {averageSalary}\n");
    }
    else
        break;
}
*/
#endregion

#region Task 2: Plotting a graph with stars
/*
int starsCount = 0;
string stars = "";

Console.Write("Please enter count of stars: ");
int.TryParse(Console.ReadLine(), out starsCount);

for (int i = 1;i <= starsCount; i++)
{
    stars += "*";
    Console.WriteLine(stars);
}
*/
#endregion

#region Task 3: Prime number generation
/*
int endNumber = 0;
bool isPrime = false;

Console.Write("Enter the end number: ");
int.TryParse(Console.ReadLine(), out endNumber);

for (int i = 2; i <= endNumber; i++)
{
    isPrime = true;

    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.Write(i + " ");
    }
}
*/
#endregion

#region Task 4: Password verification
/*
int standardPasswordLen = 8;
string password = "";
int passwordLen = 0;
string message = "";

bool isDigit = false;
bool isLetter = false;
bool isSymbol = false;

Console.Write("Enter your password: ");
password = Console.ReadLine();
passwordLen = password.Length;
if (passwordLen >= standardPasswordLen)
{
    for (int i = 0; i < passwordLen; i++)
    {
        if (Char.IsDigit(password[i]))
        {
            isDigit = true;
        }
        else if (Char.IsLetter(password[i]))
        {
            isLetter = true;
        }
        else
            isSymbol = true;
    }
    if (isDigit && isLetter && isSymbol)
        message = "Password is correct";
    else
        message = "The password needs to include at least one letter, digit and symbol";
}
else
    message = "The password is too short";
Console.WriteLine(message);
*/
#endregion

#region Task 5: Fibonacci sequence generation
/*
int count = 0;
int firstNumber = 0;
int secondNumber = 1;
int temp = 0;

Console.Write("Enter the number of Fibonacci numbers: ");
int.TryParse(Console.ReadLine(), out count);

for (int i = 0; i <= count; i++)
{
    Console.Write($"{firstNumber} \t");
    temp = firstNumber + secondNumber;
    firstNumber = secondNumber;
    secondNumber = temp;  
}
*/
#endregion

#region Task 6: Hourly rate calculator
/*
int hours = 0;
double hourlyRate = 0;
double result = 0;
bool isLoopContinue = true;

do
{
    Console.Write("Enter the number of hours: ");
    isLoopContinue = int.TryParse(Console.ReadLine(), out hours);

    Console.Write("Enter hourly rate: ");
    isLoopContinue = double.TryParse(Console.ReadLine(), out hourlyRate);
    if (isLoopContinue)
    {
        result += hours * hourlyRate;
        Console.WriteLine($"Result: {result}\n");
    }
    else
        Console.WriteLine("Unexpected values. Restart program and try again.");
}
while (isLoopContinue);
*/
#endregion

#region Task 7: Generating a multiplication table for a specific number
/*
int number = 0;
int result = 0;

Console.Write("Enter value: ");
int.TryParse(Console.ReadLine(), out number);

for (int i = 1;i <= 10; i++)
{
    result = number * i;
    Console.WriteLine($"{i} x {number} = {result}");
}
*/
#endregion

#region Task 8: Simplicity check
/*
int number = 0;
bool isLoopContinue = true;
bool isPrime = true;

do
{
    Console.Write("Enter value: ");
    isLoopContinue = int.TryParse(Console.ReadLine(), out number);
    isPrime = true;

    if (number < 2)
        isPrime = false;
    else
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

    if (isPrime)
        Console.WriteLine($"Number {number} is prime.\n");
    else
        Console.WriteLine($"Number {number} isn't prime.\n");
}
while (isLoopContinue);
*/
#endregion