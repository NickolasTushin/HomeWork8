// Дополнительная задача 61: Вывести N строк треугольника Паскаля. 
Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] pascalT = new double[n + 1, 2 * n + 1];

FillPascalT(pascalT);

Console.WriteLine();

WriteArray(pascalT);

TransPascalT(pascalT);

Console.WriteLine();
WriteArray(pascalT);

void TransPascalT(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int count = 0;
    for (int j = array.GetLength(1) - 1; j >= 0; j--)
    {
      if (array[i, j] != 0)
      {
        array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
        array[i, j] = 0;
        count++;
      }
    }
  }
  array[array.GetLength(0) - 1, 0] = 1;
}

void FillPascalT(double[,] pascalT)
{
  for (int k = 0; k < pascalT.GetLength(0); k++)
  {
    pascalT[k, 0] = new Random().Next(1,10);
  }
  for (int i = 1; i < pascalT.GetLength(0); i++)
  {
    for (int j = 1; j < i + 1; j++)
    {
      pascalT[i, j] = pascalT[i - 1, j] + pascalT[i - 1, j - 1];
    }
  }
}

void WriteArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] != 0)
      {
          Console.Write($"{array[i, j]} ");
      }
      else Console.Write("  ");
    }
    Console.WriteLine();
  }
}
