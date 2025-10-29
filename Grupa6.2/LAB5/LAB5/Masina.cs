namespace LAB5;

public class Masina
{
    public string Marca { get; }
    public string Model { get; }
    public int AnFabricatie { get; }
    public Motor MotorulMasinii { get; }
    
    public Masina(string marca, string model, int anFabricatie, Motor motorulMasinii)
    {
        Marca = marca;
        Model = model;
        AnFabricatie = anFabricatie;
        MotorulMasinii = motorulMasinii;
    }
    
    public void PornesteMasina()
    {
        MotorulMasinii.PornesteMotorul();
        Console.WriteLine($"Masina {Marca} {Model} a pornit.");
    }
}