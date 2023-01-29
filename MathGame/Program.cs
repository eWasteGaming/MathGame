
Console.WriteLine("Please input your name: ");

string userName = Console.ReadLine();
DateTime localNow = DateTime.Now;

Console.WriteLine("--------------------------------------------");
Console.WriteLine($"Hello {userName}! It is currently {localNow.ToString("f")}. Welcome to the Math Practice Game!\n");

Menu();


//Methods begin below
void Menu()
{
    string menuInput = "";
    while (menuInput != "q")
    {
        Console.WriteLine(@"Which game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit");
        Console.WriteLine("--------------------------------------------");

        menuInput = Console.ReadLine().Trim().ToLower();

        switch (menuInput)
        {
            case "a":
                additionGame();
                break;
            case "s":
                subtractionGame();
                break;
            case "m":
                multiplicationGame();
                break;
            case "d":
                divisionGame();
                break;
            case "q":
                Console.WriteLine("Goodbye, thanks for playing!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid Selection");
                break;
        }
    }
}
void additionGame()
{
    Console.WriteLine("Addition Selected");
}

void subtractionGame()
{
    Console.WriteLine("Subtraction Selected");
}

void multiplicationGame()
{
    Console.WriteLine("Multiplication Selected");
}

void divisionGame()
{
    Console.WriteLine("Division Selected");
}