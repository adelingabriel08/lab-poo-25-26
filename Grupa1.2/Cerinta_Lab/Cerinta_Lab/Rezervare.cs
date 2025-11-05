namespace Cerinta_Lab;

public class Rezervare
{
    public string NumePrenume { get; }
    public DateTime DataInceperii { get; }
    public int Durata { get; }
    public List<Persoana> Participanti { get; }
    public string CodApartament { get; }
    
    public Rezervare(string numePrenume, DateTime dataInceperii, int durata, List<Persoana> participanti, string codApartament)
    {
        NumePrenume = numePrenume;
        DataInceperii = dataInceperii;
        Durata = durata;
        Participanti = participanti;
        CodApartament = codApartament;
    }
    
    public string Validate()
    {
        if (string.IsNullOrEmpty(NumePrenume) || NumePrenume.Length > 30)
        {
            return "NumePrenume is not valid.";
        }

        if (DataInceperii >= DateTime.Now)
        {
            return "DataInceperii is not valid.";
        }

        if (Durata < 1 || Durata > 60)
        {
            return "Durata is not valid.";
        }

        if (Participanti == null || Participanti.Count == 0)
        {
            return "Participanti list is not valid.";
        }

        foreach (var participant in Participanti)
        {
            var validationMessage = participant.Validate();
            if (validationMessage != null)
            {
                return "Participant is not valid: " + validationMessage;
            }
        }

        if (CodApartament.Length != 4 || !CodApartament.StartsWith("A") || !char.IsDigit(CodApartament[1]) ||
            !char.IsDigit(CodApartament[2]) || !char.IsDigit(CodApartament[3]))
        {
            return "CodApartament is not valid.";
        }

        return null;
    }
}