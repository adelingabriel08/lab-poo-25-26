namespace LAB10;

public class Masina
{
    public string Name { get; }
    public string Model { get; }
    public int Year { get; }
    
    public Masina(string name, string model, int year)
    {
        Name = name;
        Model = model;
        Year = year;
    }
}