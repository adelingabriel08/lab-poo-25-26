// See https://aka.ms/new-console-template for more information

using Lab3;

Console.WriteLine("Hello, World!");

Pisica pisica = new Pisica("Tom", 3);
Catel catel = new Catel("Spike", 5);

Animal animal3 = new Pisica("Garfield", 4);

List<Animal> animale = new List<Animal> { pisica, catel, animal3 };

foreach (var item in animale)
{
    Console.WriteLine("Animal: " + item.Name + ", Age: " + item.Age + ", Sound: " + item.ScoateSunet());
}


