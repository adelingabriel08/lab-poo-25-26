// See https://aka.ms/new-console-template for more information


using System.Text.Json;
using LAB10;

File.WriteAllText("file.txt", "Hello, World!\n");
File.AppendAllText("file.txt", "lab10\n");

var lines = new List<string> { "First line", "Second line", "Third line" };
File.AppendAllLines("file.txt", lines);


string content = File.ReadAllText("file.txt");

string[] allLines = File.ReadAllLines("file.txt");

using var reader = new StreamReader("file.txt");

while (!reader.EndOfStream)
{
    string line = reader.ReadLine();
    Console.WriteLine(line);
}

Console.WriteLine(content);

// Masina: marca, model, anFabricatie

var masina = new Masina("Dacia", "Logan", 2020);

var serializedMasina = JsonSerializer.Serialize(masina);

File.WriteAllText("masini.txt", serializedMasina);

var readSerializedMasina = File.ReadAllText("masini.txt");
Console.WriteLine(readSerializedMasina);

var deserializedMasina = JsonSerializer.Deserialize<Masina>(readSerializedMasina);
Console.WriteLine(deserializedMasina);