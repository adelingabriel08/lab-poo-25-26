// See https://aka.ms/new-console-template for more information

using LAB6;

Console.WriteLine("Hello, World!");

// while (true)
// {
//     string text = Console.ReadLine();
//
//     try
//     {
//         int number = int.Parse(text);
//         Console.WriteLine(number);
//         Console.WriteLine("Division:" + (10 / number));
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Invalid number");
//     }
//     catch (DivideByZeroException)
//     {
//         Console.WriteLine("The number cannot be zero");
//     }
//     catch (Exception e)
//     {
//         Console.WriteLine("Exception occurred: " + e.Message);
//     }
//
// }

// string text = Console.ReadLine();
//
// if (text == "admin")
// {
//     throw new Exception("Admin access is not allowed.");
// }
// Console.WriteLine("Passed!");

Masina masina1 = new Masina("Dacia", 2020, 5, "#FFFFFF");
Masina masina2 = new Masina("Dacia", -10, 13, "abc");

// Masina masina3 = null;
//
// Console.WriteLine(masina3.Name);

string validationMessage1 = masina1.Validate();
string validationMessage2 = masina2.Validate();

if (validationMessage1 != null)
{
    Console.WriteLine("Masina 1 is not valid: " + validationMessage1);
}
else
{
    Console.WriteLine("Masina 1 is valid.");
}

if (validationMessage2 != null)
{
    Console.WriteLine("Masina 2 is not valid: " + validationMessage2);
}
else
{
    Console.WriteLine("Masina 2 is valid.");
}