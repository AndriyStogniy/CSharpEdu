#region Task 1-2: Array of random numbers / Check that sum of array elements is greater than 0.
/*
int[] numbers = new int[10];
int sumOfNumbers = 0;
Random random = new Random();

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(-10, 10);
    sumOfNumbers += numbers[i];
    if (i % 2 == 0)
    {
        Console.WriteLine($"Number with index {i} is even number = {numbers[i]}");
    }
    else
        Console.WriteLine($"Number with index {i} is odd number = {numbers[i]}");
}
if (sumOfNumbers > 0)
    Console.WriteLine($"Sum of array elements ({sumOfNumbers}) is greater than 0.");
else
    Console.WriteLine($"Sum of array elements ({sumOfNumbers}) isn't greater than 0.");
*/
#endregion

#region Task 3: Multiplication table
/*
int[,] array2D = new int[9, 9];

for(int i = 1; i<= 9; i++)
{
    Console.Write($"{i,2} multiplication results| ");
    for (int j = 1; j <= 9; j++)
    {
        array2D[i-1, j-1] = i * j;
        Console.Write($"{i * j, 2}| ");
    }
    Console.WriteLine("\n-------------------------+---+---+---+---+---+---+---+---+---+");
}
*/
#endregion

#region Task 4: Array 5x5
/*
int[,] array2D = new int[5, 5];
Random rnd = new Random();

Console.WriteLine("Check table:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        array2D[i, j] = rnd.Next(-50, 50);
        Console.Write($"{array2D[i, j], 4} ");
    }
    Console.WriteLine();
}

int maxValue = 0;
int maxRow = 0;
int maxCol = 0;

int minValue = 0;
int minRow = 0;
int minCol = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (array2D[i, j] > maxValue)
        {
            maxValue = array2D[i, j];
            maxRow = i;
            maxCol = j;
        }
        if (array2D[i, j] < minValue)
        {
            minValue = array2D[i, j];
            minRow = i;
            minCol = j;
        }
    }
}
Console.WriteLine($"\nMax element: {maxValue}, coordinates: [{maxRow}, {maxCol}]");
Console.WriteLine($"Min element: {minValue}, coordinates: [{minRow}, {minCol}]");
*/
#endregion

#region Task 5: Week day (enum)
/*
int days = 0;

Console.Write("Enter number of days: ");
int.TryParse(Console.ReadLine(), out days);

int resultDay = days % 7;
var day = (DaysOfWeek)resultDay;
Console.WriteLine($"Result: {day}");
enum DaysOfWeek
{
    Monday = 0,
    Tuesday = 1,
    Wednesday = 2,
    Thursday = 3,
    Friday = 4,
    Saturday = 5,
    Sunday = 6
}
*/
#endregion