namespace CsharpFundamentals;

// Modul 2: Gjett Tallet!
public class GuessTheNumber
{
    public void Run()
    {
        while (true)
        {
            var target = Random.Shared.Next(1, 101);

            while (true)
            {
                Console.Write("Gjett et tall mellom 1 og 100: ");
                if (!int.TryParse(Console.ReadLine(), out int guess))
                {
                    Console.WriteLine("Ikke et tall.");
                    continue;
                }

                if (guess < target)
                {
                    Console.WriteLine("Høyere!");
                }
                else if (guess > target)
                {
                    Console.WriteLine("Lavere!");
                }
                else
                {
                    Console.WriteLine($"Riktig! Tallet var {target}.");
                    break;
                }
            }

            Console.Write("Spille på nytt? (j/n): ");
            if (Console.ReadLine() != "j") return;
            Console.WriteLine();
        }
    }
}
