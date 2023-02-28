// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Решение:

Console.Write("Input number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Square number of {userNumber} is {Math.Pow(userNumber,2)}");