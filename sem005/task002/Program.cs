using static Shared;

// Задача 2: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Подзадачи:
// 1. Запросить у пользователя N элементов массива
// 2. Создать массив
// 3. Заполнить массив случайными числами
// 4. Замеить знак в массиве
void ChangeSign (int[]array)
{
for (int i = 0; i < array.Length; i++)
{
  array[i] = array[i]*-1;
}
}
// 5. Печать результата

// Решение:
int userNumber = GetIntNumber("Input number of elements in array: ");
int[] numbers = CreateIntArray(userNumber);
FillRandomIntArray(numbers,-100,100);
PrintArray(numbers);
ChangeSign(numbers);
PrintArray(numbers);
