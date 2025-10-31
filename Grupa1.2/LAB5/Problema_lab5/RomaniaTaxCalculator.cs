namespace Problema_lab5;

// ===================================================
// CLASE DERIVATE — folosesc MOȘTENIRE și POLIMORFISM
// ===================================================
class RomaniaTaxCalculator : TaxCalculator
{
    public override string CountryName => "România";
    public override decimal Calculate(Reservation reservation)
    {
        return Math.Round(reservation.TotalValue * 0.19M, 2);
    }
}
