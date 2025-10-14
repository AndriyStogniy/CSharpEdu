using System;

static int Fibonacci(int number)
{
    switch (number)
    {
        case 1:
            return 0;
        case 2:
            return 1;
        default:
            return Fibonacci(number - 1) + Fibonacci(number - 2);

    }  
}

int input = 0;

Console.Write("Enter the Fibonacci sequence number: ");
int.TryParse(Console.ReadLine(), out input);

if (input > 0)
    Console.WriteLine($"Fibonacci number is: {Fibonacci(input)}");
else
    Console.WriteLine("The number must be positive!");