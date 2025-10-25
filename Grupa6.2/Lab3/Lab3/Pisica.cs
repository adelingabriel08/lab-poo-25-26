namespace Lab3;

public class Pisica : Animal
{
    public Pisica(string name, int age) : base(name, age)
    {
    }

    public override string ScoateSunet()
    {
        return "Miau";
    }
}