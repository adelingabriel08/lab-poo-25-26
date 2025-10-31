// See https://aka.ms/new-console-template for more information

// ===================================================
// Program – logica principală
// ===================================================

using Problema_lab5;


List<Apartment> apartments = new List<Apartment>();
List<Reservation> reservations = new List<Reservation>();

// adaugam apartamente initiale in lista
apartments.Add(new Apartment(1, "Str. Exemplu 10, București", 4, 70M));
apartments.Add(new Apartment(2, "Bd. Libertății 5, Cluj-Napoca", 2, 50M));
apartments.Add(new Apartment(3, "Rue de Paris 12, Lyon", 3, 90M));
apartments.Add(new Apartment(4, "Via Roma 7, Milano", 5, 120M));
    

Console.WriteLine("=== Aplicație rezervări apartamente ===");

while (true)
{
    Console.WriteLine("\nMeniu:");
    Console.WriteLine("1. Adaugă o rezervare");
    Console.WriteLine("2. Caută rezervări după nume");
    Console.WriteLine("3. Listează toate rezervările");
    Console.WriteLine("4. Ieșire");
    Console.Write("Alegeți (1-4): ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1": AddReservation(); break;
        case "2": SearchReservationByName(); break;
        case "3": ListAllReservations(); break;
        case "4": return;
        default: Console.WriteLine("Opțiune invalidă."); break;
    }
}

Apartment FindApartmentById(int id)
{
    // Căutăm apartamentul cu id-ul dat iterand prin listă
    foreach (var ap in apartments)
        if (ap.Id == id)
            return ap;
    return null;
}

void AddReservation()
{
    Console.WriteLine("\nApartamente disponibile:");
    foreach (var ap in apartments)
        ap.ShowInfo();

    Apartment selectedApartment = null;
    while (selectedApartment == null)
    {
        Console.Write("ID apartament: ");
        if (int.TryParse(Console.ReadLine(), out int id))
            selectedApartment = FindApartmentById(id);
        if (selectedApartment == null)
            Console.WriteLine("ID invalid.");
    }

    Console.Write("Numele persoanei care face rezervarea: ");
    string booker = Console.ReadLine();

    Console.Write("Data începerii (yyyy-MM-dd): ");
    DateTime startDate = DateTime.Parse(Console.ReadLine());

    Console.Write("Durata (zile): ");
    int duration = int.Parse(Console.ReadLine());

    List<Person> guests = new List<Person>();
    Console.WriteLine("Introduceți persoane cazate (Enter pentru a termina):");
    while (true)
    {
        Console.Write("Nume complet: ");
        string guestName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(guestName)) break;

        Console.Write("Anul nașterii: ");
        int year = int.Parse(Console.ReadLine());
        guests.Add(new Person(guestName, year));
    }

    Console.WriteLine("Țara pentru calcul taxe: 1. România  2. Franța  3. Italia");
    TaxCalculator taxCalc = null;
    while (taxCalc == null)
    {
        Console.Write("Alegeți (1-3): ");
        string opt = Console.ReadLine();
        if (opt == "1") taxCalc = new RomaniaTaxCalculator();
        else if (opt == "2") taxCalc = new FranceTaxCalculator();
        else if (opt == "3") taxCalc = new ItalyTaxCalculator();
        else Console.WriteLine("Opțiune invalidă.");
    }

    Reservation r = new Reservation(selectedApartment, booker, startDate, duration, guests, taxCalc);
    reservations.Add(r);

    Console.WriteLine("\nRezervare creată cu succes:\n------------------------");
    r.ShowInfo();
}

void SearchReservationByName()
{
    Console.Write("Căutați după nume: ");
    string query = Console.ReadLine()?.ToLower();
    bool found = false;

    foreach (var r in reservations)
    {
        if (r.BookerFullName.ToLower().Contains(query))
        {
            r.ShowInfo();
            found = true;
        }
        else
        {
            foreach (var g in r.Guests)
            {
                if (g.FullName.ToLower().Contains(query))
                {
                    r.ShowInfo();
                    found = true;
                    break;
                }
            }
        }
    }

    if (!found)
        Console.WriteLine("Nu s-au găsit rezervări.");
}

void ListAllReservations()
{
    if (reservations.Count == 0)
    {
        Console.WriteLine("Nu există rezervări.");
        return;
    }

    int i = 1;
    foreach (var r in reservations)
    {
        Console.WriteLine($"\n--- Rezervare #{i++} ---");
        r.ShowInfo();
    }
}


