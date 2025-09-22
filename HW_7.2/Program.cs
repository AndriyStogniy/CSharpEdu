char[] cells = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

//3 rows, 3 columns, 2 diagonals
int[,] winCombinations = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };

int currentPlayer = 1; // 1 - X, 2 - O
bool isGameOver = false;

do
{
    //Generate game field
    Console.Clear();
    for (int i = 0; i < 9; i += 3)
    {
        Console.WriteLine($" {cells[i]} | {cells[i + 1]} | {cells[i + 2]}");
        if (i < 6)
            Console.WriteLine("---+---+---");
    }

    //Move check for both players
    int move = 0;
    Console.Write($"\nPlayer {currentPlayer} move is: ");
    while (!int.TryParse(Console.ReadLine(), out move) || move < 1 || move > 9 || cells[move - 1] == 'X' || cells[move - 1] == 'O')
    {
        Console.Write("Wrong move! Try again: ");
    }

    if (currentPlayer == 1)
        cells[move - 1] = 'X';
    else
        cells[move - 1] = 'O';

    //Win combination check
    bool win = false;
    for (int i = 0; i < winCombinations.GetLength(0); i++)
    {
        if (cells[winCombinations[i, 0]] == cells[winCombinations[i, 1]] && cells[winCombinations[i, 1]] == cells[winCombinations[i, 2]])
        {
            win = true;
            break;
        }
    }

    if (win)
    {
        //Regenerate game field for checking result and show the winner
        Console.Clear();
        for (int i = 0; i < 9; i += 3)
        {
            Console.WriteLine($" {cells[i]} | {cells[i + 1]} | {cells[i + 2]}");
            if (i < 6)
                Console.WriteLine("---+---+---");
        }
        Console.WriteLine($"Player {currentPlayer} won!");
        isGameOver = true;
    }
    else
    {
        //Check if there are free cells
        bool draw = true;
        foreach (char c in cells)
        {
            if (c != 'X' && c != 'O')
            {
                draw = false;
                break;
            }
        }
        if (draw)
        {
            // Regenerate field game result If there aren't free cells
            Console.Clear();
            for (int i = 0; i < 9; i += 3)
            {
                Console.WriteLine($" {cells[i]} | {cells[i + 1]} | {cells[i + 2]}");
                if (i < 6)
                    Console.WriteLine("---+---+---");
            }
            Console.WriteLine("\nDraw!");
            isGameOver = true;
        }
        else
        {
            //Player changing
            if (currentPlayer == 1)
                currentPlayer = 2;
            else
                currentPlayer = 1;
        }
    }
}
while (!isGameOver);
Console.WriteLine("Game is over!");

