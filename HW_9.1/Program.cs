Console.Write("Enter Name and Surname: ");
string input = Console.ReadLine();

string[] words = input.Split(' ');

string name = words[0];
string surname = words[1];

if (char.ToUpper(name[0]) == char.ToUpper(surname[0]))
    Console.WriteLine("Last name start with the same letter as first name");

else
    Console.WriteLine("Last name does not start with the same letter as first name");