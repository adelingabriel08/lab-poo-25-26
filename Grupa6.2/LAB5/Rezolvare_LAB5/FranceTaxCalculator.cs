namespace Problema_lab5;

public class FranceTaxCalculator : TaxCalculator
{
    public override string CountryName => "Franța";
    public override decimal Calculate(Reservation reservation)
    {
        decimal value = reservation.TotalValue;
        return Math.Round(value * (value > 1000 ? 0.25M : 0.10M), 2);
    }
}