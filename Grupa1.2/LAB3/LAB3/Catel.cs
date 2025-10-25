namespace LAB3;

public class Catel : Animal
{
    public Catel(string nume, int varsta) : base(nume, varsta)
    {
    }

    public override string ScoateSunet()
    {
        return "Ham Ham";
    }
}