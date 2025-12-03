// See https://aka.ms/new-console-template for more information

using LAB9;


Console.WriteLine(Utility.Version + " - " + Utility.GetAppName());

ILogger logger = new ConsoleLogger();

Masina masina = new Masina("Dacia", "Logan", logger);
Console.WriteLine(Masina.GetType());
masina.AfiseazaDetalii();

MasinaService masinaService = new MasinaService(logger);

masinaService.Adauga("Dacia", "Logan");
masinaService.Adauga("Fo", "Focus");
var masinaDacia = masinaService.GetByMarca("Dacia");

masinaService.Sterge(masinaDacia);
