namespace LAB9;

public class MasinaService
{
    private readonly ILogger _logger;
    private List<Masina> _masini = new List<Masina>();

    public MasinaService(ILogger logger)
    {
        _logger = logger;
    }

    public bool Add(string marca, string model)
    {
        var masina = new Masina(marca, model, _logger);
        if (string.IsNullOrEmpty(masina.Marca) || masina.Marca.Length > 20)
        {
            _logger.LogError("Marca invalida");
            return false;
        }
        
        _masini.Add(masina);
        
        _logger.Log("Masina adaugata: " + masina.Marca + " " + masina.Model);

        return true;
    }
    
    public bool Update(Masina masina)
    {
        if (string.IsNullOrEmpty(masina.Marca) || masina.Marca.Length > 20)
        {
            _logger.LogError("Marca invalida");
            return false;
        }
        
        var existingMasina = _masini.FirstOrDefault(m => m.Marca == masina.Marca);
        
        if (existingMasina == null)
        {
            _logger.LogError("Masina nu exista: " + masina.Marca);
            return false;
        }
        
        _masini.Remove(existingMasina);
        _masini.Add(masina);
        
        _logger.Log("Masina editata: " + masina.Marca + " " + masina.Model);

        return true;  
    }
    
    public bool Remove(Masina masina)
    {
        var existingMasina = _masini.FirstOrDefault(m => m.Marca == masina.Marca);

        if (existingMasina == null)
        {
            _logger.LogError("Masina nu exista: " + masina.Marca);
            return false;
        }
        
        _masini.Remove(existingMasina);
        
        return true;
    }
    
    public List<Masina> GetAll()
    {
        return _masini;
    }
    
    public Masina? GetByMarca(string marca)
    {
        return _masini.FirstOrDefault(x => x.Marca == marca);
    }
}