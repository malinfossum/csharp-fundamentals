namespace CsharpFundamentals;

// Modul 2: Switch
public class Switch
{
    public void Run()
    {
        Console.WriteLine("--- Oppgave 1: hardcoded number ---");
        DayFromInt(3);

        Console.WriteLine();
        Console.WriteLine("--- Oppgave 2: from user input ---");
        DayFromInput();
    }

    // Oppgave 1: Map an int 1–7 to a weekday and print it.
    public void DayFromInt(int n)
    {
        var day = n switch
        {
            1 => "Mandag",
            2 => "Tirsdag",
            3 => "Onsdag",
            4 => "Torsdag",
            5 => "Fredag",
            6 => "Lørdag",
            7 => "Søndag",
            _ => "Ugyldig tall (må være 1–7)"
        };

        Console.WriteLine($"{n} er {day}");
    }

    // Oppgave 2: Read an int from the user. On invalid input, restart.
    public void DayFromInput()
    {
        Console.Write("Skriv et tall mellom 1 og 7: ");
        var input = Console.ReadLine();

        if (!int.TryParse(input, out var n))
        {
            Console.WriteLine("Ikke et tall. Prøver igjen.");
            Console.WriteLine();
            DayFromInput();
            return;
        }

        DayFromInt(n);
    }
}
