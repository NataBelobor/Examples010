//Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. 
//Напишите программу, которая покажет количество 
//чётных чисел в массиве.

int[] numbers = new int[4];

void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ )
  {
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ )
    {
    Console.Write(array[i] + " ");
    }
  Console.WriteLine();
}
int Pos(int[] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++ )
    {
    if (array[i] % 2 == 0)
        {
      count++;
        }
    }
  return count;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int count = Pos(numbers);
Console.WriteLine($"чётных чисел в массиве: {count}");
