namespace LAB9;

public class Masina
{
    public string Marca { get; }
    
    public string Model { get; }
    private ILogger _logger;

    public Masina(string marca, string model, ILogger logger)
    {
        _logger = logger;
        Marca = marca;
        Model = model;
    }

    public void LogMasina()
    {
        _logger.Log("Masina creata: " + Marca + " " + Model);
    }

    public static string GetInfo()
    {
        return "Masina info";
    }

    public static string Type = "Masina";
}