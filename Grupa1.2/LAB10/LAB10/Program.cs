// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using LAB10;

File.WriteAllText("output.txt", "Hello, World!");

File.AppendAllText("output.txt", "Goodbye World!");

var lines = new List<string> {"Line 1", "Line 2", "Line 3"};
File.WriteAllLines("lines.txt", lines);

var readText = File.ReadAllText("output.txt");
Console.WriteLine(readText);

var readLines = File.ReadAllLines("lines.txt");
foreach (var line in readLines)
{
    Console.WriteLine(line);
}

var reader = new StreamReader("output.txt");

while (!reader.EndOfStream)
{
    var line = reader.ReadLine();
    Console.WriteLine(line);
}

reader.Close();

using var fileStream = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

var masina = new Masina("Dacia", "Logan", 2020);
var serializedMasina = JsonSerializer.Serialize(masina);
Console.WriteLine(serializedMasina);
File.WriteAllText("masini.txt", serializedMasina);

var masinaFromFileText = File.ReadAllText("masini.txt");
var deserializedMasina = JsonSerializer.Deserialize<Masina>(masinaFromFileText);

Console.WriteLine(deserializedMasina);