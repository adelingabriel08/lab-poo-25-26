namespace RezolvareCerinta;

public class Adresa
{
    public Adresa(string strada, int numar, string oras)
    {
        Strada = strada;
        Numar = numar;
        Oras = oras;
    }

    private string Strada { get; set; }
    private int Numar { get; set; }
    private string Oras { get; set; }
    
    public Adresa DeepCopy()
    {
        return new Adresa(Strada, Numar, Oras);
    }
}