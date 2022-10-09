//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.0, 7, 8, -2, -2 -> 2  /-1, -7, 567, 89, 223-> 3

void Zadacha41()
{

{
    int size = 20;
    int[] numbers = new int[size];
    int[] other = new int[size]; 
    FillArray41(numbers);
    PrintArray41(numbers);
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($"Введите число, я собиру их все и скажу сколько отрицательных. Когда закончите введите 0: ");
        int x = Convert.ToInt32(Console.ReadLine());  
        if (x == 0) break;
        other[i] =  x;
    } 
    Console.WriteLine();    
    PrintArray41(other);
}

void FillArray41(int[] num)

{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = 0;
    }
}

void PrintArray41(int[] numbers)
{
    int count = 0;
    Console.WriteLine("Отрицательные числа: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0) 
        { 
           Console.Write(numbers[i] + " ");
           count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Всего: {count}");
}


}


//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
void Zadacha43()

{

Console.WriteLine($"Найду пересечение линий, уравнений y = k1*x + b1 и y = k2*x + b2");
Console.WriteLine($"Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine($"Теперь b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine($"k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine($"И b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine($"Итак, нужная точка тут: A({(b2-b1)/(k1-k2)}: {k1*(b2-b1)/(k1-k2)+b1})");

}

Zadacha43();

