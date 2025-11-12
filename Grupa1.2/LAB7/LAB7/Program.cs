// See https://aka.ms/new-console-template for more information
using LAB7;

Animal animal1 = new Animal("Leo", 3);
Animal animal2 = new Animal("Leo", 3);

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
{
    Console.WriteLine("sunt egale");
}
else
{
    Console.WriteLine("nu sunt egale");
}

Animal animal3 = animal1;
animal3.Name = "changed name";

Console.WriteLine(animal3.Name);
Console.WriteLine(animal1.Name);

animal2.ToString();
Console.WriteLine(animal2);

