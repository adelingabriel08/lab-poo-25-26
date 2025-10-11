namespace Lab2;

public class Masina
{
    private string Name;
    public string Model { get; }
    public int Year { get; set; }
    public string Color { get; set; }

    private string Id;
    
    public Masina(string name, string model, int year, string color)
    {
        Name = name;
        Model = model;
        Year = year;
        Color = color;
        Id = "this-is-unique";
    }

    public string GetNume()
    {
        return Name;
    }
    
    public void SetNume(string name)
    {
        Name = name;
    }
    
}