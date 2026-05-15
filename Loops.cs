namespace CsharpFundamentals;

// Modul 2: Løkker
public class Loops
{
    public void Run()
    {
        Console.WriteLine("--- Oppgave 1: for-løkke ---");
        ForLoop();

        Console.WriteLine();
        Console.WriteLine("--- Oppgave 2: foreach-løkke ---");
        ForeachLoop("Terje");

        Console.WriteLine();
        Console.WriteLine("--- Oppgave 3: while-løkke ---");
        WhileLoop();
    }

    public void ForLoop()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Terje er kul");
        }
    }

    public void ForeachLoop(string text)
    {
        foreach (char c in text)
        {
            Console.WriteLine(c);
        }
    }

    public void WhileLoop()
    {
        int n = 1;
        while (n < 10)
        {
            Console.WriteLine($"Runde nr {n}");
            n++;
        }
    }
}
