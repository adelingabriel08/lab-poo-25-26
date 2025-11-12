// See https://aka.ms/new-console-template for more information

using LAB7;

Animal animal1 = new Animal("leu", 3);
Animal animal2 = new Animal("leu", 3);

if (animal1 == animal2) 
{
    Console.WriteLine("sunt egale");
}
else
{
    Console.WriteLine("nu sunt egale");
}

if (animal1.Equals(animal2))
{
    Console.WriteLine("sunt egale");
}
else
{
    Console.WriteLine("nu sunt egale");
}

string str1 = "test";
string str2 = "test";

if (str1 == str2)
    Console.WriteLine("string-urile sunt egale");
    
    
Console.WriteLine(animal1);

Animal animal3 = animal1;
animal3.Nume = "tigru";

Console.WriteLine(animal1);