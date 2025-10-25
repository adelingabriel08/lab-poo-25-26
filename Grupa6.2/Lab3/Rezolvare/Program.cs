// See https://aka.ms/new-console-template for more information

using Rezolvare;

List<Pachet> pachete = new List<Pachet>
{
    new PachetBaza("Ion Popescu", 8.5),
    new PachetNoapte("Maria", 3.0),
    new PachetAvansat("Andrei Ionescu", 12.0),
    new PachetBaza("Elena Georgescu", 15.0),
    new PachetNoapte("Vasile", 1.5),
    new PachetAvansat("Ana Marinescu", 7.0)
};



foreach (var pachet in pachete)
{
    Console.WriteLine(pachet);
}