// See https://aka.ms/new-console-template for more information

using LAB6;

Console.WriteLine("Hello, World!");


// while (true)
// {
//     string input = Console.ReadLine();
//
//     try
//     {
//         int number = int.Parse(input);
//         Console.WriteLine("Your number is: " + number);
//         int number2 = 0;
//         Console.WriteLine(12 / number2);
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Invalid input provided. Try again.");
//     }
//     catch (DivideByZeroException ex)
//     {
//         Console.WriteLine("Division by zero is not allowed. " + ex.Message);
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine("An unexpected error occurred: " + ex.Message);
//     }
//     finally
//     {
//         Console.WriteLine("End of iteration.");
//     }
// }


// string input = Console.ReadLine();
// if (input == "admin")
// {
//     throw new Exception("Admin access is not allowed.");
// }
//
// Console.WriteLine("Passed!");

Masina masina = new Masina("Dacia", 2020, 5, "#FFFFFF");
Masina masina2 = new Masina("Dacia", -10, 13, "abc");

string validationMessage1 = masina.Validate();
string validationMessage2 = masina2.Validate();

Masina masina3 = null;

// Console.WriteLine(masina3.Name);

if (validationMessage1 == null)
{
    Console.WriteLine("Masina 1 is valid.");
}
else
{
    Console.WriteLine("Masina 1 is not valid: " + validationMessage1);
}

if (validationMessage2 == null)
{
    Console.WriteLine("Masina 2 is valid.");
}
else
{
    Console.WriteLine("Masina 2 is not valid: " + validationMessage2);
}