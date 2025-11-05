namespace Cerinta_Lab;

public class Persoana
{
    public string NumePrenume { get; }
    public int AnNastere { get; }
    
    public Persoana(string numePrenume, int anNastere)
    {
        NumePrenume = numePrenume;
        AnNastere = anNastere;
    }
    
    public string Validate()
    {
        if (string.IsNullOrEmpty(NumePrenume) || NumePrenume.Length > 30)
        {
            return "NumePrenume is not valid.";
        }

        if (AnNastere >= DateTime.Now.Year)
        {
            return "AnNastere is not valid.";
        }
        return null;
    }
}