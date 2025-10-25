namespace Rezolvare;

public class PachetAvansat : Pachet
{
    public PachetAvansat(string destinatar, double greutate)
        : base(destinatar, greutate) { }

    public override double CalculeazaCost()
    {
        return (Greutate * 6.0) + 2.0;
    }

    public override int CalculeazaTimpLivrare()
    {
        return 2;
    }
}