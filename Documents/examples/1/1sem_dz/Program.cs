// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Привет!Я угадаю какое число меньше другого");
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a < b)
// {
//     Console.WriteLine($"{a} меньше"); 
// }
    
// else if (a > b)
// {
//         Console.WriteLine($"{b} меньше");
// }

// else 
// {
//     Console.WriteLine("Хитрец, числа равны");
// }




// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Привет!Я угадаю какое число из трёх самое большое");
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a > b && a > c)
// {
//     Console.WriteLine($"{a} больше"); 
// }
    
// else if (b > c && b > a)
// {
//         Console.WriteLine($"{b} больше");
// }

// else if (c > a && c > b)
// {
//         Console.WriteLine($"{c} больше");
// }

// else 
// {
//     Console.WriteLine("Хитрец, какие-то числа равны");
// }




// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Привет!Я угадаю чётное ли число или нет");
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a % 2 == 0)
// {
//     Console.WriteLine($"{a} чётное"); 
// }
    
// else 
// {
//     Console.WriteLine($"{a} нечётное"); 
// }


// Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Привет! Введи число, а я покажу все чётные числа до него");
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
a = Math.Abs(a);

if (a % 2 != 0)
{
    a = a - 1;
}

while (a >= 2)
{  
  Console.Write(a + " ");
  a = a-2;
}
Console.WriteLine();
