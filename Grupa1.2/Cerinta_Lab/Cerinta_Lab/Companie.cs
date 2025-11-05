namespace Cerinta_Lab;

public class Companie
{
    private List<Rezervare> rezervari;
    
    public Companie()
    {
        rezervari = new List<Rezervare>();
    }
    
    public void AdaugaRezervare(Rezervare rezervare)
    {
        string error = rezervare.Validate();
        if (error != null)
        {
            Console.WriteLine(error);
            return;
        }
        rezervari.Add(rezervare);
    }
}