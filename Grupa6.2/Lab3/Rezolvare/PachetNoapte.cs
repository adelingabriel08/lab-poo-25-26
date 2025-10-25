namespace Rezolvare;

public class PachetNoapte : Pachet
{
    public PachetNoapte(string destinatar, double greutate)
        : base(destinatar, greutate) { }

    public override double CalculeazaCost()
    {
        return Greutate * 10.0;
    }

    public override int CalculeazaTimpLivrare()
    {
        return 1;
    }
}