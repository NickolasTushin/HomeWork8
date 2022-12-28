// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите количество строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите глубину массива: ");
int z = Convert.ToInt32(Console.ReadLine());

while ((x*y)*z >= 100)
{
Console.WriteLine("Количество элементов массива превышает количество неповторяющихся двузначных чисел ");

Console.WriteLine("Введите количество строк: ");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите глубину массива: ");
z = Convert.ToInt32(Console.ReadLine());
}

int[,,] array3D = new int[x,y,z];

FillArrayRandom(array3D);
WriteArray3D(array3D);

void FillArrayRandom(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        array3D[i, j, k] = temp[count];
        count++;
      }
    }
  }
}


void WriteArray3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            Console.Write($"{array3D[i, j, k]}  инд({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}