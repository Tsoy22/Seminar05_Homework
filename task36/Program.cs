// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = new int[4];
for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(-99, 100);
  Console.Write(array[i] + "\t");
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел {array[1]} и {array[3]} равна: {array[1] + array[3]} ");
Console.ReadKey();
