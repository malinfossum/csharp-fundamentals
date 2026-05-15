namespace CsharpFundamentals;

// Modul 2: Random Hobby
public class RandomHobby
{
    public void Run()
    {
        Console.Write("Who would like a new hobby? ");
        var name = Console.ReadLine();

        var hobbies = new[]
        {
            "magician. Poof, magic!",
            "official toad-licker. Sorry.",
            "competitive cheese-roller. Watch out below!",
            "amateur cloud-namer. Look, a sheep!",
            "professional puddle-jumper. Splash!"
        };

        var index = Random.Shared.Next(hobbies.Length);
        var hobby = hobbies[index];

        Console.WriteLine($"{name} is now a {hobby}");
    }
}
