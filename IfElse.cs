namespace CsharpFundamentals;

// Modul 2: lesson exercises 1–3
public class IfElse
{
    public void Run()
    {
        Console.WriteLine("--- Oppgave 1: AreEqual ---");
        Console.WriteLine($"AreEqual(5, 5) = {AreEqual(5, 5)}");
        Console.WriteLine($"AreEqual(3, 7) = {AreEqual(3, 7)}");

        Console.WriteLine();
        Console.WriteLine("--- Oppgave 2: SumOrProduct ---");
        Console.WriteLine($"SumOrProduct(3, 5) = {SumOrProduct(3, 5)}");
        Console.WriteLine($"SumOrProduct(4, 4) = {SumOrProduct(4, 4)}");

        Console.WriteLine();
        Console.WriteLine("--- Oppgave 3: EitherOrSumIs30 ---");
        Console.WriteLine($"EitherOrSumIs30(30, 5) = {EitherOrSumIs30(30, 5)}");
        Console.WriteLine($"EitherOrSumIs30(10, 20) = {EitherOrSumIs30(10, 20)}");
        Console.WriteLine($"EitherOrSumIs30(5, 7) = {EitherOrSumIs30(5, 7)}");
    }

    // Oppgave 1: Returns true if the two numbers are equal.
    public bool AreEqual(int a, int b)
    {
        return a == b;
    }

    // Oppgave 2: Returns the sum if numbers are unequal, the product if equal.
    public int SumOrProduct(int a, int b)
    {
        if (a == b)
        {
            return a * b;
        }
        return a + b;
    }

    // Oppgave 3: Returns true if either number is 30, or their sum equals 30.
    public bool EitherOrSumIs30(int a, int b)
    {
        return a == 30 || b == 30 || a + b == 30;
    }
}
