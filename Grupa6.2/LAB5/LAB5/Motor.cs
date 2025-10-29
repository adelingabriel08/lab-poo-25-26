namespace LAB5;

public class Motor
{
    public int Cilindree { get; }
    public int Putere { get; set; }
    
    public Motor(int cilindree, int putere)
    {
        Cilindree = cilindree;
        Putere = putere;
    }

    public void PornesteMotorul()
    {
        Console.WriteLine("Motorul a pornit.");
    }
}