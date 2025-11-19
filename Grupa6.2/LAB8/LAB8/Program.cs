// See https://aka.ms/new-console-template for more information

using LAB8;

ICalculator<int> calculator = new Calculator<int>();
ICalculator<float> calculator2 = new Calculator<float>();
ICalculator<decimal> calculator3 = new Calculator<decimal>();

List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
Console.WriteLine("Addition: " + calculator.Add(5, 3));
calculator.Add(1,7,6);