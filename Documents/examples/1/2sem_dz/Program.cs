// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void Zadacha10 ()

{
  Console.Write("Введите трёхзначное число, а я покажу вторую цифру: ");
  int a = Convert.ToInt32(Console.ReadLine());

  if ( a < 1000 && a > 99)
  {
      int tens = a /10 % 10;
      Console.WriteLine($"Вторая цифра {tens} "); 
  }
  else
      Console.WriteLine($"В числе не 3 знака("); 
}

//Zadacha10 ();

// Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 3267432979 -> 6

void Zadacha13 ()

{
  Console.Write("Введите трёхзначное число, а я покажу вторую цифру: ");
  int a = Convert.ToInt32(Console.ReadLine());
  a = Math.Abs(a);

  if (a > 99)
  {
      int b = Convert.ToString(a).Length;
      b = Convert.ToInt32(Math.Pow (10, b-2));
      int tens = a / b % 10;
      Console.WriteLine($"Вторая цифра {tens}"); 
  }
  else
      Console.WriteLine($"В числе не 3 знака(");     
}

//Zadacha13 ();

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


void Zadacha15 ()

{

    Console.Write("Введите число, а я скажу выходной ли оно: ");
    int a = Convert.ToInt32(Console.ReadLine());

    if (a < 6 && a > 0)
       Console.WriteLine($"Это будень");  

    else if (a == 6 || a == 7)   
    {
       Console.WriteLine($"ВыходнооооЙ!!");  
    }

    else
      Console.WriteLine($"Такого дня недели нет");  

}

Zadacha15 ();