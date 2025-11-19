namespace LAB8;

public interface ICalculator<T>
{
    T Add(T a, T b);
    T Add(T a, T b, T c);
    T Subtract(T a, T b);
    T Multiply(T a, T b);
}