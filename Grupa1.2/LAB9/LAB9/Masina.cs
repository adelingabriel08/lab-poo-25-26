namespace LAB9;

public class Masina
{
    public string Marca { get; }
    public string Model { get; }
    private ILogger _logger;
    
    public Masina(string marca, string model, ILogger logger)
    {
        Marca = marca;
        Model = model;
        _logger = logger;
    }
    
    public void AfiseazaDetalii()
    {
        _logger.Log($"Masina: {Marca} {Model}");
    }
    
    public static string Version = "2.0.0";
    
    public static string GetType()
    {
        return "Masina";
    }
}