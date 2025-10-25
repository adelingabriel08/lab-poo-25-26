namespace Rezolvare;

public abstract class Pachet
{
    public string Destinatar { get; }
    public double Greutate { get; }

    public Pachet(string destinatar, double greutate)
    {
        Destinatar = destinatar;
        Greutate = greutate;
    }

    public abstract double CalculeazaCost();
    public abstract int CalculeazaTimpLivrare();

    public override string ToString()
    {
        return $"{GetType().Name} pentru {Destinatar}, " +
               $"Greutate: {Greutate} kg, " +
               $"Cost: {CalculeazaCost()} EUR, " +
               $"Livrare: {CalculeazaTimpLivrare()} zile";
    }
}