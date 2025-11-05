namespace LAB6;

public class Masina
{
    public string Name { get; }
    public int Year { get; }
    public string ColorHash { get; }
    public int Month { get; }
    
    public Masina(string name, int year, int month, string colorHash)
    {
        Name = name;
        Year = year;
        Month = month;
        ColorHash = colorHash;
        // throw new Exception("Dummy exception in constructor for demonstration purposes.");
    }
    
    public string Validate()
    {
        if (Year < 1886 || Year > DateTime.Now.Year + 1)
        {
            return "Year is not valid.";
        }

        if (Month < 1 || Month > 12)
        {
            return "Month is not valid.";
        }

        if (!ColorHash.StartsWith("#"))
        {
            return "ColorHash is not valid.";
        }

        if (Name.Length < 3)
        {
            return "Name is not valid.";
        }

        return null;
    }
}