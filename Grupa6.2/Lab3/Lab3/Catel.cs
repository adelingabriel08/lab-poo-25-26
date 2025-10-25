namespace Lab3;

public class Catel : Animal
{
    public Catel(string name, int age) : base(name, age)
    {
    }

    public override string ScoateSunet()
    {
        return "Ham";
    }
}