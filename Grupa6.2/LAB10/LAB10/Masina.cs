namespace LAB10;

public class Masina
{
    public string Marca { get; }
    public string Model { get; }
    public int AnFabricatie { get; }
    
    public Masina(string marca, string model, int anFabricatie)
    {
        Marca = marca;
        Model = model;
        AnFabricatie = anFabricatie;
    }
}