namespace LAB5;

public class Masina
{
    public string Marca { get; }
    public string Model { get; }
    public int AnFabricatie { get; }
    public Motor Motor { get; }

    public Masina(string marca, string model, int anFabricatie, Motor motor)
    {
        Marca = marca;
        Model = model;
        AnFabricatie = anFabricatie;
        Motor = motor;
    }

    public void PornesteMasina()
    {
        Motor.Porneste();
    }
}