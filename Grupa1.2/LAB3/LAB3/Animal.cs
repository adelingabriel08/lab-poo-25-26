namespace LAB3;

public abstract class Animal
{
    public string Nume { get; }
    public int Varsta { get; }
    public Animal(string nume, int varsta)
    {
        Nume = nume;
        Varsta = varsta;
    }
    public abstract string ScoateSunet();
}
/*
Crearea unei ierarhii de clase care să modeleze diferitele 
tipuri de colete furnizate de o companie de transport.
Există trei tipuri de colete, cu costuri și timpi de livrare:

Pachetul de bază: 
costă 5 EUR pe kilogram și este livrat în 5 zile. 
Dacă greutatea pachetului este mai mare de 10 kilograme, este necesară încă o zi.
Pachet avansat: costă 6 EUR per kilogram cu o taxă 
suplimentară de 2 EUR. Pachetul se livrează în 2 zile.
Pachet peste noapte: Livrat a doua zi și costă 10 EUR pe kg.
În metoda principală, trebuie să se poată introduce pachete de 
toate tipurile într-o Lista. La sfârșit, trebuie afisate toate pachetele într-o buclă.
*/
