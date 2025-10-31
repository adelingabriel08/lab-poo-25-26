namespace Problema_lab5;

// ===================================================
// CLASA Reservation
// ===================================================
// Concept: COMPOZIȚIE – conține obiecte din alte clase (Apartment, Person, TaxCalculator)
// ENCAPSULARE – proprietățile pot fi doar citite, pentru a proteja consistența datelor.
public class Reservation
{
    // Proprietăți readonly — se stabilesc doar în constructor.
    // Encapsulare: protejăm integritatea rezervării după ce a fost creată.
    public Apartment Apartment { get; }
    public string BookerFullName { get; }
    public DateTime StartDate { get; }
    public int DurationDays { get; }
    public List<Person> Guests { get; }

    // Proprietate privată — nu vrem să fie vizibilă în afara clasei
    private TaxCalculator TaxCalc { get; }

    // Proprietate calculată — exemplu de ENCAPSULARE:
    // logica pentru valoarea totală este ascunsă în interiorul clasei.
    public decimal TotalValue => Apartment.PricePerDay * DurationDays;

    public Reservation(Apartment apartment,
                       string bookerFullName,
                       DateTime startDate,
                       int durationDays,
                       List<Person> guests,
                       TaxCalculator taxCalculator)
    {
        Apartment = apartment;
        BookerFullName = bookerFullName;
        StartDate = startDate;
        DurationDays = durationDays;
        Guests = guests;
        TaxCalc = taxCalculator;
    }

    // Aplică POLIMORFISM — fiecare subclasă de TaxCalculator are propria logică de calcul.
    public decimal CalculateTax() => TaxCalc.Calculate(this);

    public void ShowInfo()
    {
        Console.WriteLine($"Rezervare pentru: {BookerFullName}");
        Console.WriteLine($"  Apartament: {Apartment.Address} (id {Apartment.Id})");
        Console.WriteLine($"  Începe: {StartDate:yyyy-MM-dd}, Durata: {DurationDays} zile");
        Console.WriteLine($"  Total valoare: {TotalValue:0.00} €");
        Console.WriteLine($"  Țara taxelor: {TaxCalc.CountryName}, Taxă: {CalculateTax():0.00} €");

        if (Guests.Count == 0)
            Console.WriteLine("  Persoane: (fără alți cazați)");
        else
        {
            Console.Write("  Persoane: ");
            for (int i = 0; i < Guests.Count; i++)
            {
                Guests[i].ShowInfo();
                if (i < Guests.Count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}