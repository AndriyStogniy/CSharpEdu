using System.Text;

StringBuilder todoList = new StringBuilder();
StringBuilder statuses = new StringBuilder();

bool isLoopContinue = true;

while (isLoopContinue)
{
    Console.Clear();
    Console.WriteLine("---Options---");
    Console.WriteLine("1. Add task");
    Console.WriteLine("2. Mark task as complete");
    Console.WriteLine("3. Delete task");
    Console.WriteLine("0. Exit\n");

    ShowTodos(todoList, statuses);
    
    Console.Write("\nSelect option: ");

    int choice = 0;
    int.TryParse(Console.ReadLine(), out choice);

    switch (choice)
    {
        case 1:
            AddTodo(todoList, statuses);
            break;
        case 2:
            MarkAsDone(todoList, statuses);
            break;
        case 3:
            DeleteTodo(todoList, statuses);
            break;
        case 0:
            isLoopContinue = false;
            break;
        default:
            break;
    }
}

static void AddTodo(StringBuilder todo, StringBuilder statusList)
{
    Console.Write("Enter task name: ");
    string taskName = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(taskName))
    {
        return;
    }
    
    todo.AppendLine(taskName);
    statusList.AppendLine("[ ]");
    
}

static void ShowTodos(StringBuilder todo, StringBuilder statusList)
{
    Console.WriteLine("=== TODO List===");
    if (todo.Length == 0)
    {
        Console.WriteLine("empty");
        return;
    }
    string[] tasks = todo.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
    string[] statuses = statusList.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

    for(int i = 0;i < tasks.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {statuses[i]} {tasks[i]}");
    }
}

static void MarkAsDone(StringBuilder todo, StringBuilder statusList)
{
    if(todo.Length == 0)
    {
        return;
    }

    Console.Write("Enter the task number to mark as done: ");
    int number = -1;
    bool numberIsCorrect = int.TryParse(Console.ReadLine(), out number);

    if (numberIsCorrect)
    {
        string[] tasks = todo.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        string[] statuses = statusList.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        if (number >= 1 && number <= tasks.Length)
        {
            statuses[number - 1] = "[V]";

            statusList.Clear();
            foreach (string i in statuses)
                statusList.AppendLine(i);
        }
    }
}

static void DeleteTodo(StringBuilder todo, StringBuilder statusList)
{
    if (todo.Length == 0)
    {
        return;
    }

    Console.Write("Enter the task number to delete: ");
    int number = -1;
    bool numberIsCorrect = int.TryParse(Console.ReadLine(), out number);

    if (numberIsCorrect)
    {
        string[] tasks = todo.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        string[] statuses = statusList.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        if (number >= 1 && number < tasks.Length)
        {
            string removed = tasks[number - 1];
            todo.Clear();
            statusList.Clear();
            for (int i = 0; i < tasks.Length; i++)
            {
                if (i != number - 1)
                {
                    todo.AppendLine(tasks[i]);
                    statusList.AppendLine(statuses[i]);
                }
            }
        }
    }
}
