// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
//  [3 7 22 2 78] -> 76

int[] array = new int[5];
int max = 0, min = 100;
Console.Write("Введите 5 целых чисел массива: \n");
for (int i = 0; i < array.Length; i++)
  array[i] = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{
  if (array[i] > max) max = array[i];
  if (array[i] < min) min = array[i];
}
for (int i = 0; i < array.Length; i++)
  Console.Write(" " + array[i]);
Console.WriteLine();
Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Минимальное число: " + min);
Console.WriteLine("Разница между максимальным и минимальм числами массива: " + (max - min));
Console.ReadKey();