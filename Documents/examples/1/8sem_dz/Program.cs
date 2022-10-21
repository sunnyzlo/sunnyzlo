//ДЗ 8
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


void Zadacha54()
{
    var random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    Console.WriteLine($"Массив рамзера {rows}x{columns}");

    FillArrayNormal(numbers);
    PrintArrayNormal(numbers);
    SelectionSort54(numbers);
    Console.WriteLine();
    PrintArrayNormal(numbers);


    void SelectionSort54(int[,] numbers)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int z = 0; z < columns - 1; z++)
            {
                int minPosition = z;
                for (int j = z + 1; j < columns; j++)
                {

                    if (numbers[i,j] > numbers[i,minPosition]) minPosition = j;

                }
                int temporary = numbers[i,z];
                numbers[i,z] = numbers[i, minPosition];
                numbers[i, minPosition] = temporary;
            }

        }
    }


}


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Zadacha56()
{
    var random = new Random();
    int rows = random.Next(4, 4);
    int columns = random.Next(4, 4);
    int[,] numbers = new int[rows, columns];
    Console.WriteLine($"Массив рамзера {rows}x{columns}");

    FillArrayNormal(numbers);
    PrintArrayNormal(numbers);
    SelectionSum56(numbers);


void SelectionSum56(int[,] numbers)
{
    int sum = 0;
    int sumMensh = 0;
    int iMensh = 1;    
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sum = sum + numbers[i, j];
        }
        if (i == 0) sumMensh = sum;  
        if (sum < sumMensh) iMensh = i+1; 
        Console.Write($"Сумма в {i+1} строке: {sum}");
        Console.WriteLine();
        sum = 0;
    }
    Console.Write($"Наименьшая сумма в {iMensh} строке");
    Console.WriteLine();
}

}
// Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04   00 01 02 03
// 12 13 14 05   10 11 12 13
// 11 16 15 06   20 21 22 23
// 10 09 08 07   30 31 32 33
void Zadacha58()
{

int n = 4;
int[,] numbers = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= numbers.GetLength(0) * numbers.GetLength(1))
{
  numbers[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < numbers.GetLength(1) - 1) j++;
  else if (i < j && i + j >= numbers.GetLength(0) - 1) i++;
  else if (i >= j && i + j > numbers.GetLength(1) - 1) j--;
  else i--;
}

WriteArray(numbers);

void WriteArray (int[,] numbers)
{
  for (int i = 0; i < numbers.GetLength(0); i++)
  {
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
      if (numbers[i,j] / 10 <= 0)
      Console.Write($" {numbers[i,j]} ");

      else Console.Write($"{numbers[i,j]} ");
    }
    Console.WriteLine();
  }
}

}
Zadacha58();