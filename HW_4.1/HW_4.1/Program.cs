int dayNumber = 0;
string dayName = "";
string errorText = "ERROR: Entered an undefined day number. Please check number and try again.";

Console.Write("Please enter the day number: ");
int.TryParse(Console.ReadLine(), out dayNumber);
// Long switch
/*
switch (dayNumber)
{
    case 1:
        dayName = "Monday";
        break;
    case 2:
        dayName = "Tuesday";
        break;
    case 3:
        dayName = "Wednesday";
        break;
    case 4:
        dayName = "Thursday";
        break;
    case 5:
        dayName = "Friday";
        break;
    case 6:
        dayName = "Saturday";
        break;
    case 7:
        dayName = "Sunday";
        break;
    default:
        dayName = errorText;
        break;

}
*/
//Short switch
dayName = dayNumber switch
{
    1 => "Monday",
    2 => "Tuesday",
    3 => "Wednesday",
    4 => "Thursday",
    5 => "Friday",
    6 => "Saturday",
    7 => "Sunday",
    _ => errorText,
};

Console.WriteLine($"Entered day: {dayName}");
