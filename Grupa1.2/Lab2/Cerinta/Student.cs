namespace Cerinta;

public class Student
{
    public string FirstName { get; }
    public string LastName { get; }
    public string Registration { get; }
    public int Year { get; }
    public Catalog Catalog { get; }
    
    public Student(string firstName, string lastName, string registration, int year, Catalog catalog)
    {
        FirstName = firstName;
        LastName = lastName;
        Registration = registration;
        Year = year;
        Catalog = catalog;
    }
}