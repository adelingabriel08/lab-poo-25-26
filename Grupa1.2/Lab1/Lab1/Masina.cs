namespace Lab1POO_1._2;

public class Masina
{
    public string Nume;
    public string Producator;
    public int AnFabricatie;
    public Motor Motor;
    
    public Masina()
    {
        Console.WriteLine("Am creat o masina");
    }
    
    public Masina(string n, string producator, int anFabricatie, string capacitateMotor)
    {
        if (anFabricatie < 1)
            throw new Exception("Anul de fabricatie trebuie sa fie pozitiv");
        Nume = n;
        Producator = producator;
        AnFabricatie = anFabricatie;
        Motor = new Motor(capacitateMotor);
    }
    
    public Masina(string n, string producator, int anFabricatie, Motor motor)
    {
        if (anFabricatie < 1)
            throw new Exception("Anul de fabricatie trebuie sa fie pozitiv");
        Nume = n;
        Producator = producator;
        AnFabricatie = anFabricatie;
        Motor = motor;
    }
}