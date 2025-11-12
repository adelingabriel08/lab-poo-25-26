namespace LAB7;

public class Animal
{
    public string Nume { get; set; }
    private int Varsta { get; }
    
    public Animal(string nume, int varsta)
    {
        Nume = nume;
        Varsta = varsta;
    }
    
    public override bool Equals(object? obj)
    {
        Animal animal = (Animal)obj;
        Animal animal2 = obj as Animal;
        if (obj is Animal otherAnimal)
        {
            return this.Nume == otherAnimal.Nume && this.Varsta == otherAnimal.Varsta;
        }
        return false;
    }

    public static bool operator ==(Animal animal1, Animal animal2)
    {
        return animal1.Nume == animal2.Nume && animal1.Varsta == animal2.Varsta;
    }
    
    public static bool operator !=(Animal animal1, Animal animal2)
    {
        return animal1.Nume != animal2.Nume || animal1.Varsta != animal2.Varsta;
    }

    public override string ToString()
    {
        return "Nume: " + Nume + ", Varsta: " + Varsta;
    }
}