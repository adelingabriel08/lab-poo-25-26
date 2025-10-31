namespace Problema_lab5;

public class ItalyTaxCalculator : TaxCalculator
{
    public override string CountryName => "Italia";
    public override decimal Calculate(Reservation reservation)
    {
        decimal value = reservation.TotalValue;
        return Math.Round((2M * reservation.DurationDays) + (value * 0.09M), 2);
    }
}