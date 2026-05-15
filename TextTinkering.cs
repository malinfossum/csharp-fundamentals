namespace CsharpFundamentals;

// Modul 2: TekstTukling
public class TextTinkering
{
    public void Run()
    {
        Console.WriteLine("1 - RotateText");
        Console.WriteLine("2 - Change word");
        Console.Write("Velg: ");
        var choice = Console.ReadLine();

        Console.Write("Skriv inn et ord: ");
        var word = Console.ReadLine() ?? "";

        var result = choice switch
        {
            "1" => RotateText(word),
            "2" => ChangeWord(word),
            _ => "Ugyldig valg."
        };

        Console.WriteLine($"Resultat: {result}");
    }

    public string RotateText(string text)
    {
        var chars = text.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public string ChangeWord(string text)
    {
        return text.Replace('e', 'a');
    }
}
