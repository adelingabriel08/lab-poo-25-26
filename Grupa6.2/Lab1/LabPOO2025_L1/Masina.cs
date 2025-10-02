namespace LabPOO2025_L1;

public class Masina
{
    public string Name { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Masina()
    {
        Console.WriteLine("Masina a fost creata");
    }
    
    public Masina(string name, string model, int year)
    {
        if (name == "Dacia")
            Console.WriteLine("Masina este romaneasca");
        Name = name;
        Model = model;
        Year = year;
    }
}