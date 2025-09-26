Console.Write("Enter text with words separated by commas: ");
string input = Console.ReadLine();

string result = input.Replace(" ", "");

Console.WriteLine("Result: " + result);