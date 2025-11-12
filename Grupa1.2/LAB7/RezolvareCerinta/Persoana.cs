namespace RezolvareCerinta;

public class Persoana
{
    private string Nume { get; set; }
    private Adresa Adresa { get; set; }
    
    public Persoana(string nume, Adresa adresa)
    {
        Nume = nume;
        Adresa = adresa;
    }
    
    public Persoana DeepCopy()
    {
        return new Persoana(Nume, Adresa.DeepCopy());
    }
}