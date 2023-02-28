// Напишите программу, которая на вход принимает два 
// числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Решение:

Console.Write("Input first number: ");
int userFirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int userSecondNumber = Convert.ToInt32(Console.ReadLine());

if (Math.Pow(userSecondNumber,2) == userFirstNumber)
{
Console.WriteLine($"{userFirstNumber} is square number of {userSecondNumber}");
}
else
{
Console.WriteLine($"{userFirstNumber} is not square number of {userSecondNumber}");
}
