namespace Lab2;

public class Masina
{
    public string Marca { get; set; }
    public string Model { get; set; }
    public int AnFabricatie { get; set; }
    public string Culoare { get; set; }

    public Masina(string marca, string model, int anFabricatie, string culoare)
    {
        Marca = marca;
        Model = model;
        AnFabricatie = anFabricatie;
        Culoare = culoare;
    }
}