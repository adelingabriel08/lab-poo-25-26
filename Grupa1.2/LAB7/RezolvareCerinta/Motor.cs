namespace RezolvareCerinta;

public class Motor
{
    private string FuelType { get; set; }
    private int HorsePower { get; set; }
    
    public Motor(string fuelType, int horsePower)
    {
        FuelType = fuelType;
        HorsePower = horsePower;
    }
    
    public Motor DeepCopy()
    {
        return new Motor(FuelType, HorsePower);
    }
}