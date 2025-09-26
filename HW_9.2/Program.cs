using System;
using System.Text;

StringBuilder report = new StringBuilder();
bool isLoopContinue = true;
string input = System.String.Empty;
int index = 1;

report.AppendLine("============REPORT============");
report.AppendLine("\nEvents:\n");



do
{
    Console.Write("Enter event (or press \"Enter\" to finish): ");
    input = Console.ReadLine();

    if (input != "")
    {
        report.AppendLine($"{index,3}. {input}");
        report.AppendLine($"     Date: {DateTime.Now.ToString("dd.mm.yyyy HH:mm:ss")}\n");
        index++;
    }
    else
        isLoopContinue = false;

    Console.Clear();

} while (isLoopContinue);

Console.Write(report);


