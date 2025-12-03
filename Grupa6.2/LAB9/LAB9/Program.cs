// See https://aka.ms/new-console-template for more information

using LAB9;

Console.WriteLine("Hello, World!");

Console.WriteLine(Utility.AppName);
Console.WriteLine(Utility.GetInfo());
Utility.AppName = "Updated LAB9 Application";

ILogger consolelogger = new ConsoleLogger();
Masina masina = new Masina("Dacia", "Logan", consolelogger);

masina.LogMasina();

MasinaService masinaService = new MasinaService(consolelogger);

masinaService.Add("Dacia", "Duster");
masinaService.Update(new Masina("Dacia", "Sandero", consolelogger));
masinaService.Remove(masina);

