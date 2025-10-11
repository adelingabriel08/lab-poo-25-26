// See https://aka.ms/new-console-template for more information


using Lab2;

Masina masina1 = new Masina("Dacia", "Logan", 2020, "Alb");
Masina masina2 = new Masina("Ford", "Focus", 2018, "Negru");

// string input = Console.ReadLine();
// Console.WriteLine($"Masina 1: {masina1.Marca} {masina1.Model}, An: {masina1.AnFabricatie}, Culoare: {masina1.Culoare}");
// Console.WriteLine($"Masina 2: {masina2.Marca} {masina2.Model}, An: {masina2.AnFabricatie}, Culoare: {masina2.Culoare}");

Dealership dealer = new Dealership("AutoLux");
dealer.AdaugaMasina(masina1);
dealer.AdaugaMasina(masina2);

dealer.AfisareMasini();

Dealership dealer2 = new Dealership("AutoLux2");
dealer2.AfisareMasini();

Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(1, "One");
dict.Add(2, "Two");
