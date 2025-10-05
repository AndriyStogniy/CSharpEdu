using System.Text;

string encryptedWord = "letters";
int wordLength = encryptedWord.Length;
int mistakesCount = 10;
bool isLoopContinue = true;

StringBuilder usedLetters = new StringBuilder();

StringBuilder decryptedWord = new StringBuilder();
for (int i = 0; i < wordLength; i++)
{
    decryptedWord.Append('_');
}

Console.WriteLine("Hello! Try to guess the encrypted word!");
Console.WriteLine($"Number of letters in a word: {wordLength}");
Console.WriteLine($"Number of possible mistakes: {mistakesCount}\n");

do
{
    Console.Write("Enter your letter: ");
    string input = Console.ReadLine().ToLower();
    bool isLetterFound = false;

    if (string.IsNullOrEmpty(input) || input.Length != 1)
    {
        Console.WriteLine("Please enter **one** letter\n");
        continue;
    }

    char letter = input[0];

    if (usedLetters.ToString().Contains(letter))
    {
        Console.WriteLine("You have already entered this letter.\n");
        continue;
    }

    usedLetters.Append(letter);

    for (int i = 0; i < wordLength; i++)
    {
        if (encryptedWord[i] == letter)
        {
            decryptedWord[i] = letter;
            isLetterFound = true;
        }
    }

    if (isLetterFound)
    {
        Console.WriteLine($"Success! The letter {letter} has been found!");
        Console.WriteLine($"Current result: {decryptedWord}\n");
    }
    else
    {
        mistakesCount--;
        Console.WriteLine($"Unfortunately the letter {letter} hasn't been found! Please try again!");
        Console.WriteLine($"Number of possible mistakes: {mistakesCount} \n");
    }

} while (mistakesCount > 0 && decryptedWord.ToString() != encryptedWord);

if (decryptedWord.ToString() == encryptedWord)
    Console.WriteLine($"Congratulations, you guessed the word! Encrypted word: {decryptedWord}.");
else
    Console.WriteLine($"Unfortunately, the attempts are over. The word was: {encryptedWord}.");

Console.WriteLine("Thanks for the game.");