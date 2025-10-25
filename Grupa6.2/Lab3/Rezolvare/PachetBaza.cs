namespace Rezolvare;

public class PachetBaza : Pachet
{
    public PachetBaza(string destinatar, double greutate)
        : base(destinatar, greutate) { }

    public override double CalculeazaCost()
    {
        return Greutate * 5.0;
    }

    public override int CalculeazaTimpLivrare()
    {
        return Greutate > 10 ? 6 : 5;
    }
}