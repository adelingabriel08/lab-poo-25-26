// See https://aka.ms/new-console-template for more information

using LAB5;

Console.WriteLine("Hello, World!");

Motor motor = new Motor(2000, 150);
Masina masina = new Masina("Dacia", "Logan", 2020, motor);
Masina masina2 = new Masina("Toyota", "Corolla", 2021, motor);

// Pisica este un animal => este => mostenire
// Masina are un motor => are => compozitie