namespace Lab3;

public abstract class Animal
{
    public string Name { get; }
    public int Age { get; }
    
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract string ScoateSunet();
}