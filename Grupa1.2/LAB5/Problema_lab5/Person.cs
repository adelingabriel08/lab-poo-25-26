namespace Problema_lab5;

// ===================================================
// CLASA Person
// ===================================================
// Concept: ENCAPSULARE — BirthYear are doar get (valoarea nu ar trebui schimbată după creare).
public class Person
{
    public string FullName { get; set; }

    // BirthYear are doar get (nu vrem să-l putem schimba după ce am creat persoana)
    public int BirthYear { get; }

    public Person(string fullName, int birthYear)
    {
        FullName = fullName;
        BirthYear = birthYear;
    }

    public void ShowInfo()
    {
        Console.Write($"{FullName} (n. {BirthYear})");
    }
}