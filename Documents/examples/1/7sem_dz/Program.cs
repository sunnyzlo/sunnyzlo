
//ДЗ 7

// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void Zadacha47()
{

    Random random = new Random();
    int rows = 3;
    int columns = 4; 
    Console.WriteLine ($"Массив рамзера {rows}x{columns}");
    Console.WriteLine();
    double [,] numbers = new double [rows, columns];  

    FillArray47(numbers);
    PrintArray47(numbers);



}
    void FillArray47(double[,] numbers)
    {
        Random random = new Random();
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                numbers[i,j] = random.NextDouble()*20-10;

                //random.Next(-10, 10);
            }    
        }
    }


    void PrintArray47(double[,] numbers)
    {
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);       
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                numbers[i,j] = Math.Round(numbers[i,j], 1);
                Console.Write(numbers[i,j] + "  ");
            }
            Console.WriteLine();
        }   
    }    



// Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void Zadacha50()
{

    Random random = new Random();
    int rows = random.Next(4,8);
    int columns = random.Next(4,8); 
    Console.WriteLine($"Введите индекс массива ij: ");
    int index = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ($"Массив рамзера {rows}x{columns}");
    int [,] numbers = new int [rows, columns];  

    FillArray50(numbers);
    PrintArray50(numbers, index);
        
}

    void FillArray50(int[,] numbers)
    {
        Random random = new Random();
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                numbers[i,j] = random.Next(-10, 10);
            }    
        }
    }


    void PrintArray50(int[,] numbers, int index)
    {

        int rows = numbers.GetLength(0);
        int ijIndex = 0;
        int columns = numbers.GetLength(1);       
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(numbers[i,j] + " ");
                if (index/10 == i && index%10 == j) ijIndex = numbers[i,j];
            

            }
            Console.WriteLine();
        }   
        if (ijIndex != 0) Console.WriteLine ($"Есть такой нумер: {ijIndex}");
        else Console.WriteLine ($"Нет такого нумера");
    }    


// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void Zadacha51()
{

    Random random = new Random();
    int rows = random.Next(2,2);
    int columns = random.Next(3,4); 
    Console.WriteLine ($"Массив рамзера {rows}x{columns}");
    double [,] numbers = new double [rows, columns];  

    FillArray47(numbers);
    PrintArray47(numbers);
    Console.Write ($"Среднее арифметическое :");
    PrintArraySum(numbers);
        
}
   
    void PrintArraySum(double[,] numbers)
    {
        double sum = 0;
        double sumSred = 0;
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);       
        for (int j = 0; j < columns; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                sumSred = sumSred + numbers[i,j]; 
            }
            sum = Math.Round(sumSred/rows, 1);
            Console.Write ($"{sum}, ");
            sumSred = 0;
        }   
    }    

Zadacha51();
