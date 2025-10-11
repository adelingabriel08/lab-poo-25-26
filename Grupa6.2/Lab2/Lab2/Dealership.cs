namespace Lab2;

public class Dealership
{
    public string Name { get; }
    private List<Masina> Masini { get; set; }

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
            Console.WriteLine(masina.Marca + " " + masina.Model);
        }
    }
    
    private bool IsValid(Masina masina)
    {
        if (masina.AnFabricatie < 2010)
            return false;
        return true;
    }
}