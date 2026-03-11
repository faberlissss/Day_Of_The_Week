Console.Write("Enter the number of the day of the week: ");
string? userNum = Console.ReadLine();

int.TryParse(userNum, out int numDayOfTheWeek);

switch (numDayOfTheWeek)
{
    case 1:
        Console.Write("Monday");
        break;
    case 2:
        Console.Write("Tuesday");
        break;
    case 3:
        Console.Write("Wednesday");
        break;
    case 4:
        Console.Write("Thursday");
        break;
    case 5:
        Console.Write("Friday");
        break;
    case 6:
        Console.Write("Saturday");
        break;
    case 7:
        Console.Write("Sunday");
        break;
    default:
        Console.Write("You entered an incorrect number");
        break;
}