// See https://aka.ms/new-console-template for more information


using LAB5;

Motor motor = new Motor(2000, 150);

Masina masina = new Masina("Dacia", "Logan", 2020, motor);
Masina masina2 = new Masina("Ford", "Focus", 2018, motor);

masina.PornesteMasina();
masina2.PornesteMasina();

// Pisica este un Animal => este => mostenire
// Masina are un Motor => are => compozitie
