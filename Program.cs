using CsharpFundamentals;

Run();

void Run()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("=== csharp-fundamentals ===");
        Console.WriteLine();
        Console.WriteLine("1 - If/else exercises");
        Console.WriteLine("2 - Random Hobby");
        Console.WriteLine("3 - Crocodile Game");
        Console.WriteLine("4 - Text Tinkering");
        Console.WriteLine("5 - Code Reading");
        Console.WriteLine("6 - Guess The Number");
        Console.WriteLine("7 - Switch");
        Console.WriteLine("8 - Loops");
        Console.WriteLine("0 - Exit");
        Console.WriteLine();
        Console.Write("Choose: ");

        var input = Console.ReadLine();
        Console.WriteLine();

        switch (input)
        {
            case "1": new IfElse().Run(); break;
            case "2": new RandomHobby().Run(); break;
            case "3": new CrocodileGame().Run(); break;
            case "4": new TextTinkering().Run(); break;
            case "5": new CodeReading().Run(); break;
            case "6": new GuessTheNumber().Run(); break;
            case "7": new Switch().Run(); break;
            case "8": new Loops().Run(); break;
            case "0": return;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }

        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
