// See https://aka.ms/new-console-template for more information

using RezolvareCerinta;

var adresa = new Adresa("Strada Florilor", 10, "Bucuresti");
var persoana = new Persoana("Ion Popescu", adresa);
var motor = new Motor("Diesel", 150);
var masina = new Masina("B123XYZ", "Rosu", motor, persoana, 2020);
var masina2 = new Masina("B123XYZ", "Verde", motor, persoana, 2024);

if (masina.Equals(masina2))
{
    Console.WriteLine("Masinile sunt egale.");
}
else
{
    Console.WriteLine("Masinile nu sunt egale.");
}

Masina masina3 = masina.DeepCopy();

if (masina3 == masina)
{
    Console.WriteLine("Referintele sunt egale.");
}
else
{
    Console.WriteLine("Referintele nu sunt egale.");
}
