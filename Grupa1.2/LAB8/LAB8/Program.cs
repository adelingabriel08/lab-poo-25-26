// See https://aka.ms/new-console-template for more information

using LAB8;

ICalculator<int> calculator = new Calculator<int>();
ICalculator<float> calculatorFloat = new Calculator<float>();
ICalculator<double> calculatorDouble = new Calculator<double>();


calculatorFloat.Add(1.5f, 2.5f);
calculatorFloat.Add(1, 2, 7);
calculatorDouble.Add(1, 2, 7);
calculator.Add(1, 2, 7);
Console.WriteLine("Addition: " + calculator.Add(5, 3));