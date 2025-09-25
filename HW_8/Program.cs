#region Task 1: Second largest element of the array (Bubble sort)
/*
int[] numbers = { 12, 45, 88, 89, 45, 89, 89, 67 };


for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers.Length - 1; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
}

int maxNumber = numbers[numbers.Length - 1];

int secondMax = 0;
//We are looking for the second largest (the numbers may be the same)
for (int i = numbers.Length - 2; i >= 0; i--)
{
    if (numbers[i] < maxNumber)
    {
        secondMax = numbers[i];
        break;
    }
}

Console.Write("Sorted array: ");

foreach (int number in numbers)
{
    Console.Write($"{number, 5}");
}

Console.WriteLine($"\nSecond max number is: {secondMax}");
*/
#endregion

#region Task 2: Sorting elements of a two-dimensional array in ascending order.
/*
int[,] array2D = {{ 9, 25, 7 }, { 20, 5, 2 }, { 1, 1, 11 }};

int rows = array2D.GetLength(0);
int cols = array2D.GetLength(1);

int[] array1D = new int[rows * cols];
int index = 0;

for (int i = 0; i < rows; i++)
    for (int j = 0; j < cols; j++)
        array1D[index++] = array2D[i, j];

// Sorting a 1D array (Bubble sort was shown in task 1)
Array.Sort(array1D);

index = 0;
for (int i = 0; i < rows; i++)
    for (int j = 0; j < cols; j++)
        array2D[i, j] = array1D[index++];

Console.WriteLine("Sorted array: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
        Console.Write($"{array2D[i, j], 3}");
    Console.WriteLine();
}
*/
#endregion

#region Task 3: Removing element from array at specified index.
/*
int[] numbers = { 10, 20, 30, 40, 50 };
int[] newArray = new int[numbers.Length - 1];
int index = -1;

Console.Write("Current array: ");
foreach (int number in numbers)
{
    Console.Write($"{number,5}");
}

Console.Write("\nEnter index for removing (zero-based): ");

int.TryParse(Console.ReadLine(), out index);

if (index < 0 || index >= numbers.Length)
{
    Console.WriteLine("Incorrect index!");
    return;
}

for (int i = 0, j = 0; i < numbers.Length; i++)
{
    if (i == index) 
        continue;
    newArray[j++] = numbers[i];
}

Console.Write("Array after removing: ");
foreach (int number in newArray)
{
    Console.Write($"{number,5}");
}
*/
#endregion

#region Task 4: Sum of the elements along the diagonal in a two-dimensional array.
/*
int[,] matrix ={{ 10, 12, 31 }, { 51, 25, 16 }, { 25, 1, 30 }};

int rows = matrix.GetLength(0);
int cols = matrix.GetLength(1);

int sum = 0;
for (int i = 0; i < Math.Min(rows, cols); i++)
{
    sum += matrix[i, i];
}
Console.WriteLine($"Sum of the elements along the main diagonal: {sum}");

int sumSecondary = 0;
for (int i = 0; i < Math.Min(rows, cols); i++)
{
    sumSecondary += matrix[i, cols - 1 - i];
}
Console.WriteLine($"Sum of the elements along the secondary diagonal: {sumSecondary}");
*/
#endregion