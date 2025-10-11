// See https://aka.ms/new-console-template for more information

using Lab2;


Masina masina1 = new Masina("Dacia", "Logan", 2020, "Alb");
Masina masina2 = new Masina("Ford", "Focus", 2018, "Negru");
masina2.SetNume("Ford Updated");
Console.WriteLine(masina2.GetNume());

Dealership dealership = new Dealership("AutoLux");
dealership.AdaugaMasina(masina1);
dealership.AdaugaMasina(masina2);
dealership.AfisareMasini();


var masina3 = new Masina("Toyota", "Corolla", 2009, "Gri");
// dealership.Masini.Add(masina3);

Dictionary<Dealership, Masina> masini = new Dictionary<Dealership, Masina>();
masini.Add(dealership, masina1);