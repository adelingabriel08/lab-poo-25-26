// See https://aka.ms/new-console-template for more information

using Lab1POO_1._2;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("hello!");
        // Console.WriteLine("Hello, World!");
        //
        // string input = Console.ReadLine();
        //
        // Console.WriteLine("You entered: " + input);
        //
        // int number;
        //
        // if (!int.TryParse(input, out number))
        //     Console.WriteLine("You entered wrong number");
        //
        // Console.WriteLine(input);
        //
        // string concat = "Hello, " + input + 32;
        // Console.WriteLine(concat);
        //
        //
        // for (int i=0; i< input.Length; i++)
        // {
        //     Console.WriteLine(input[i]);
        // }
        //
        // foreach (char c in input)
        // {
        //     Console.WriteLine(c);
        // }
        //
        // if (input.StartsWith('a'))
        // {
        //     Console.WriteLine("Incepe cu a");
        // }
        
        Masina masina1 = new Masina();
        masina1.Nume = "Seria 3";
        masina1.Producator = "BMW";
        masina1.AnFabricatie = 2020;
        
        Masina[] masiniArr = new Masina[3];
        List<Masina> masini = new List<Masina>();
        masini.Add(masina1);
        
        Console.WriteLine(masina1.Nume);
        Console.WriteLine(masina1.Producator);
        Console.WriteLine(masina1.AnFabricatie);
        Console.WriteLine($"Masina {masina1.Nume} este produsa de {masina1.Producator} in anul {masina1.AnFabricatie}");

        
        Masina masina2 = new Masina();
        masina2.Nume = "A4";
        masina2.Producator = "Audi";
        masina2.AnFabricatie = 2018;
        masini.Add(masina2);
        
        Masina masina3 = new Masina();
        masina3.Nume = "Civic";
        masina3.Producator = "Honda";
        masina3.AnFabricatie = 2019;
        masini.Add(masina3);

        Masina masina4 = new Masina()
        {
            Nume = "Model 3",
            Producator = "Tesla",
            AnFabricatie = 2021
        };
        masini.Add(masina4);
        
        Masina masina5 = new Masina("X5", "BMW", -5, "3.0");
        
        // Vehicul vehicul1 = new Vehicul();
        // vehicul1.Nume = "Vehicul 1";
        // masini.Add(vehicul1);

        foreach (Masina masina in masini)
        {
            Console.WriteLine(masina.AnFabricatie);
        }
        
    }
}