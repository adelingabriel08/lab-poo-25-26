namespace LAB7;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; }
    
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public override bool Equals(object? obj)
    {
        Animal animal = obj as Animal;
        Animal animal2 = (Animal)obj;
        if (obj is Animal other)
        {
            return Name == other.Name && Age == other.Age;
        }
        return false;
    }
    
    public static bool operator ==(Animal a1, Animal a2)
    {
        return a1.Name == a2.Name;
    }
    
    public static bool operator !=(Animal a1, Animal a2)
    {
        return a1.Name != a2.Name || a1.Age != a2.Age;
    }
    
    public override string ToString()
    {
        return $"Animal: Name = {Name}, Age = {Age}";
    }
}