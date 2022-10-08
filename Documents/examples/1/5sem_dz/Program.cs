// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void Zadacha34()
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray34(numbers);
    PrintArray34(numbers);
    FindArray34(numbers);

}

void FindArray34(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}


void FillArray34(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-99, 1000);
    }
}

void PrintArray34(int[] numbers)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < numbers.Length; i++)
    {

        Console.Write(numbers[i] + " ");
    }
    Console.Write(" ");
    Console.WriteLine();
}

// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Zadacha36()

{
    int size = 5;
    int[] numbers = new int[size];
    FillArray36(numbers, -99,99);
    PrintArray36(numbers);
    FindArray36(numbers);

}

void FindArray36(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i !=0 && i % 2 != 0)
        {
            sum = sum + numbers[i];
        }        
    }
    Console.WriteLine(sum);
}

void FillArray36(int[] numbers, int minValue, int maxValue)
{
    maxValue++;   
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray36(int[] numbers)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write(" ");
    Console.WriteLine();
}


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3,21 7,04 22,93 -2,71 78,24] -> max = 78,24, min = - 2,71, difference = 80,95

void Zadacha38()

{
    int size = 15;
    double[] numbers = new double[size];
    FillArray38(numbers);
    PrintArray38(numbers);

}

void FillArray38(double[] numbers)
{
    double minNumber = 0;
    double maxNumber = 0;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    { 
        numbers[i] = Math.Round(random.NextDouble()*200 - 100, 2);
        if (numbers[i] <  minNumber)
        {
                minNumber = numbers[i];
        }
        if (numbers[i] >  maxNumber)
        {
                maxNumber = numbers[i];
        }    
    }    
    Console.WriteLine($"Миниальное число {minNumber}, максимальное {maxNumber}");
}

void PrintArray38(double[] numbers)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.Write(" ");
    Console.WriteLine();
}


Zadacha38();
