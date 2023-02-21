// 3 Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

string EvenNum(int arg1, int arg2)
{
if (arg1 % arg2 == 0)
{
  string resultEven = "Кратно";
  return resultEven;
}
else
{
  string resultOdd = "Не кратно, остаток = " + (arg1 % arg2);
  return resultOdd;
}
}

Console.Clear();

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(EvenNum(firstNumber, secondNumber));