namespace Problema_lab5;

// ===================================================
// CLASA ABSTRACTĂ TaxCalculator
// ===================================================
// Concept: ABSTRACȚIE și POLIMORFISM
// Definește o interfață comună pentru calculul taxelor, fără implementare concretă.
public abstract class TaxCalculator
{
    public abstract string CountryName { get; }
    public abstract decimal Calculate(Reservation reservation);
}