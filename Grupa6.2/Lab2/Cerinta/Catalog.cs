namespace Cerinta;

public class Catalog
{
    private Dictionary<Disciplina, List<int>> Note { get; } = new Dictionary<Disciplina, List<int>>();
    
    public void AdaugareNota(Disciplina disciplina, int nota)
    {
        if (Note.ContainsKey(disciplina))
        {
            Note[disciplina].Add(nota);
        }
        else
        {
            Note[disciplina] = new List<int> { nota };
        }
    }
    
    public double CalculareMedieStudentDisciplina(Disciplina disciplina)
    {
        if (!Note.ContainsKey(disciplina))
            return 0;
        
        var note = Note[disciplina];
        
        return note.Average();
    }
    
    public double CalculareMedieAnuala(int an)
    {
        List<double> medii = new List<double>();
        foreach (var disciplina in Note.Keys)
        {
            if (disciplina.An == an)
            {
                var medie = CalculareMedieStudentDisciplina(disciplina);
                medii.Add(medie);
            }
        }

        return medii.Average();
    }
    
    public double CalculareMedieMultianuala()
    {
        List<double> medii = new List<double>();
        foreach (var disciplina in Note.Keys)
        {
            var medie = CalculareMedieStudentDisciplina(disciplina);
            medii.Add(medie);
        }

        return medii.Average();
    }
}