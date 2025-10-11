// See https://aka.ms/new-console-template for more information

using Cerinta;

var catalog = new Catalog();
var student = new Student("Ion", "Popescu", "12345", 2, catalog);
var disciplina1 = new Disciplina("Matematica", 1);
var disciplina2 = new Disciplina("Informatica", 2);

catalog.AdaugareNota(disciplina1, 9);
catalog.AdaugareNota(disciplina1, 10);
catalog.AdaugareNota(disciplina2, 8);
catalog.AdaugareNota(disciplina2, 7);
catalog.AdaugareNota(disciplina2, 9);

Console.WriteLine($"Media la {disciplina1.Nume}: {catalog.CalculareMedieStudentDisciplina(disciplina1)}");
Console.WriteLine($"Media la {disciplina2.Nume}: {catalog.CalculareMedieStudentDisciplina(disciplina2)}");
Console.WriteLine($"Media anuala pentru anul 1: {catalog.CalculareMedieAnuala(1)}");
Console.WriteLine($"Media anuala pentru anul 2: {catalog.CalculareMedieAnuala(2)}");
Console.WriteLine($"Media multianuala: {catalog.CalculareMedieMultianuala()}");
