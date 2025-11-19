namespace LAB8;

public class Calculator<T> : ICalculator<T> where T : System.Numerics.INumber<T>
{
    public T Add(T a, T b)
    {
        return a + b;
    }

    public T Add(T a, T b, T c)
    {
        return a + b + c;
    }

    public T Subtract(T a, T b)
    {
        return a - b;
    }

    public T Multiply(T a, T b)
    {
        return a * b;
    }
}