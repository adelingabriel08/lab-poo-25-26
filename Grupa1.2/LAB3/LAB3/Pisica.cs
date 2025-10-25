namespace LAB3;

public class Pisica : Animal
{
    public string Ceva { get; }
    public Pisica(string nume, int varsta, string ceva) : base(nume, varsta)
    {
        Ceva = ceva;
    }

    public override string ScoateSunet()
    {
        return "Miau Miau";
    }
}