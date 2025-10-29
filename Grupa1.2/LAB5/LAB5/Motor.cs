namespace LAB5;

public class Motor
{
    public int Cilindree { get; }
    public int Putere { get; }
    
    public Motor(int cilindree, int putere)
    {
        Cilindree = cilindree;
        Putere = putere;
    }

    public void Porneste()
    {
        Console.WriteLine("Motorul a pornit.");
    }
}