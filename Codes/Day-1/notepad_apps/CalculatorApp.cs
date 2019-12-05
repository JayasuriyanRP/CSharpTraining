using System;

namespace CalculatorApp
{
class Calculator
{
	static void Main()
	{
	int firstValue = 10;
	int secondValue = 20;
	int addResult = Add(firstValue,secondValue);
	Console.WriteLine(addResult);
	Subtract(firstValue,secondValue);
	}

	static int Add(int firstArgument,int secondArgument)
	{
	//int a = 10;
	//int b = 20;
	int result = firstArgument+secondArgument;
	//Console.WriteLine(res);
	return result;
	}

	static void Subtract(int firstArgument,int secondArgument)
	{
	//int c = 10;
	//int d = 20;
	int resultSub = firstArgument-secondArgument;
	Console.WriteLine(resultSub);
	}
}
}