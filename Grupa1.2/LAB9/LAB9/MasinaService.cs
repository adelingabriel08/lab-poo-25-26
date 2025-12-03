namespace LAB9;

public class MasinaService
{
    private ILogger _logger;
    private List<Masina> _masini = new List<Masina>();

    public MasinaService(ILogger logger)
    {
        _logger = logger;
    }
    
    public void Adauga(string marca, string model)
    {
        var masina = new Masina(marca, model, _logger);
        
        if (marca.Length < 3 || model.Length < 3)
        {
            _logger.Log("Eroare: Marca si modelul trebuie sa aiba cel putin 3 caractere.");
            return;
        }
        
        if (_masini.Any(x => x.Model == model))
        {
            _logger.Log("Eroare: Exista deja o masina cu acest model.");
            return;
        }
        
        _masini.Add(masina);
        _logger.Log($"Masina adaugata: {marca} {model}");
    }

    public List<Masina> GetAll()
    {
        return _masini;
    }
    
    public Masina? GetByMarca(string marca)
    {
        return _masini.FirstOrDefault(x => x.Marca == marca);
    }
    
    public void Sterge(Masina masina)
    {
        _masini.Remove(masina);
        _logger.Log($"Masina stearsa: {masina.Marca} {masina.Model}");
    }
    
    public void Update(Masina masina)
    {
        if (masina.Marca.Length < 3 || masina.Model.Length < 3)
        {
            _logger.Log("Eroare: Marca si modelul trebuie sa aiba cel putin 3 caractere.");
            return;
        }
        
        if (_masini.Any(x => x.Model == masina.Model))
        {
            _logger.Log("Eroare: Exista deja o masina cu acest model.");
            return;
        }
        
        var masinaExistenta = _masini.FirstOrDefault(x => x.Marca == masina.Marca);
        if (masinaExistenta != null)
        {
            masinaExistenta = masina;
            _logger.Log($"Masina actualizata: {masina.Marca} {masina.Model}");
        }
        else
        {
            _logger.Log("Eroare: Masina nu exista.");
        }

    }
    
}