namespace RezolvareCerinta;

public class Masina
{
    private string PlateNumber { get; set; }
    private string Color { get; set;}
    private Motor Engine { get; set; }
    private Persoana Owner { get; set; }
    private int Year { get; set; }
    
    public Masina(string plateNumber, string color, Motor engine, Persoana owner, int year)
    {
        PlateNumber = plateNumber;
        Color = color;
        Engine = engine;
        Owner = owner;
        Year = year;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Masina)
        {
            Masina other = (Masina)obj;
            return PlateNumber == other.PlateNumber;
        }
        return false;
    }

    public Masina DeepCopy()
    {
        return new Masina(PlateNumber, Color, Engine.DeepCopy(), Owner.DeepCopy(), Year);
    }
    
}