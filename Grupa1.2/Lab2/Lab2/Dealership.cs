namespace Lab2;

public class Dealership
{
    private List<Masina> Masini;
    public string Name { get; }
    
    public Dealership(string name)
    {
        Name = name;
        Masini = new List<Masina>();
    }
    
    public void AdaugaMasina(Masina masina)
    {
        if (!IsValid(masina))
            return;
        
        Masini.Add(masina);
    }
    
    public void StergeMasina(Masina masina)
    {
        Masini.Remove(masina);
    }
    
    public void AfisareMasini()
    {
        foreach (var masina in Masini)
        {
            Console.WriteLine(masina.GetNume() + " " + masina.Model);
        }
    }
    
    private bool IsValid(Masina masina)
    {
        if (masina.Year < 2010)
            return false;
        return true;
    }
}