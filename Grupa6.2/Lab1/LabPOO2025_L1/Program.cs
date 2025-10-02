// See https://aka.ms/new-console-template for more information

using LabPOO2025_L1;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Introduce un nume:");
        // string input = Console.ReadLine();
        // if (int.TryParse(input, out int num))
        //     Console.WriteLine("Am introdus un numar: " + num);
        // else
        // {
        //     for(int i = 0; i < input.Length; i++)
        //         Console.WriteLine(input[i]);
        //
        //     foreach (var character in input)
        //     {
        //         Console.WriteLine(character);
        //     }
        //     
        //     if (input.StartsWith("a") || input.StartsWith("A"))
        //         Console.WriteLine("Numele incepe cu a");
        //     
        //     string concatenated = input + " este un nume frumos";
        //     Console.WriteLine(concatenated);
        // }
        //
        // List<string> names = new List<string>();
        // names.Add("Ana");
        // names.Add("Maria");
        // names.Add("Ion");
        // names.Add("George");
        //
        // foreach (var name in names)
        // {
        //     Console.WriteLine(name);
        // }
        // if (names.Contains("Ana"))
        //     Console.WriteLine("Ana este in lista");
        
        Masina masina1 = new Masina();
        masina1.Year = 2025;
        masina1.Model = "Model S";
        masina1.Name = "Tesla";
        
        int[] numbers = new int[5];
        
        Masina masina2 = new Masina()
        {
            Year = 2020,
            Model = "A4",
            Name = "Audi"
        };
        Masina masina3 = new Masina("Dacia", "Logan", 2018);
        
        Console.WriteLine($"Masina 1: {masina1.Name} {masina1.Model} {masina1.Year}");
        Console.WriteLine($"Masina 2: {masina2.Name} {masina2.Model} {masina2.Year}");
        Console.WriteLine($"Masina 3: {masina3.Name} {masina3.Model} {masina3.Year}");
    }
}