bool displayMenu = true;
while (displayMenu)
{
    displayMenu = mainMenu();
}


bool mainMenu()
{
    Console.Clear();
    string b = string.Format("{0:n}", 27676378786555);
    Console.WriteLine(b);
    Console.WriteLine("choose one option");
    Console.WriteLine("1) option 1");
    Console.WriteLine("2) option 2");
    Console.WriteLine("3) exist");

    string result = Console.ReadLine();

    if (result == "1")
    {
        printNumbers();
        return true;
    }
    else if (result == "2")
    {
        guessingGame();
        return true;
    }
    else if (result == "3")
    {
        return false;
    }
    else
    {
        return true;
    }
}

void printNumbers()
{
    Console.Clear();
    Console.WriteLine("enter a number");
    int n = int.Parse(Console.ReadLine());
    int c = 1;

    while (c < n + 1)
    {
        Console.WriteLine(c);
        c++;
    }
    Console.ReadLine();
}

void guessingGame()
{
    Console.Clear();
    Console.WriteLine("guessing game");

    Random myRandom = new Random();
    int randomNumber = myRandom.Next(0, 11);

    int guess = 0;
    bool inCollect = true;

    do
    {
        Console.WriteLine("guess any number btn 1 - 10 to win the prize");
        string result = Console.ReadLine();
        guess++;
        if (result == randomNumber.ToString())
        {
            inCollect = false;
        }
        else
        {
            Console.WriteLine("ooh my god your lose you try {0}", guess);
        }

    } while (inCollect);
    Console.WriteLine("you win a prize after {0} attempt", guess);

    Console.ReadLine();
}
