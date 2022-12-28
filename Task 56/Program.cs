
// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.WriteLine("Введите количетво столбцов прямоугольного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетво строк прямоугольного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
while (n==m)
{
  Console.WriteLine("Массив не прямоугольный! Введите правильные данные: ");
  Console.WriteLine("Введите количетво столбцов прямоугольного массива: ");
  n = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Введите количетво строк прямоугольного массива: ");
  m = Convert.ToInt32(Console.ReadLine());
}
int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n {minSumLine+1}я строкa с наименьшей суммой элементов = {sumLine} ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}


void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,10);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}