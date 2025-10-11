namespace Cerinta;

public class Disciplina
{
    public string Nume { get; }
    public int An { get; }
    
    public Disciplina(string nume, int an)
    {
        Nume = nume;
        An = an;
    }
}