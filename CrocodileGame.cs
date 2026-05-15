namespace CsharpFundamentals;

// Modul 2: Krokodillespillet
public class CrocodileGame
{
    public void Run()
    {
        var score = 0;
        while (true)
        {
            var a = Random.Shared.Next(1, 12);
            var b = Random.Shared.Next(1, 12);
            Console.WriteLine($"{a} _ {b}");
            Console.Write("Svar (<, >, =): ");
            var input = Console.ReadLine();

            if (input != "<" && input != ">" && input != "=")
            {
                Console.WriteLine($"Spillet er over. Sluttpoengsum: {score}");
                return;
            }

            var correct = (a < b && input == "<")
                       || (a > b && input == ">")
                       || (a == b && input == "=");

            if (correct)
            {
                score++;
                Console.WriteLine($"Riktig! Poeng: {score}");
            }
            else
            {
                score--;
                Console.WriteLine($"Feil. Poeng: {score}");
            }
            Console.WriteLine();
        }
    }
}
