// See https://aka.ms/new-console-template for more information

using LAB3;

Console.WriteLine("Hello, World!");

Catel catel = new Catel("Rex", 3);
Pisica pisica = new Pisica("Mittens", 2, "SomeValue");
Animal animalPisica = new Pisica("Whiskers", 4, "AnotherValue");
// Animal animal = new Animal("Croco", 5);
Console.WriteLine($"Catel: {catel.Nume}, Varsta: {catel.Varsta}");

List<Animal> animals = new List<Animal>();
animals.Add(catel);
animals.Add(pisica);
animals.Add(animalPisica);

foreach (var animal in animals)
{
    Console.WriteLine($"Animal: {animal.Nume}, Varsta: {animal.Varsta}, Sunet: {animal.ScoateSunet()}");
}
