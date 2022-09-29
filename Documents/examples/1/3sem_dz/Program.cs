
// ДЗ 3
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Zadacha19 ()
{
  Console.Write("Введите пятизначное число, а я скажу палиндром ли это: ");
  int a = Convert.ToInt32(Console.ReadLine());
  a = Math.Abs(a);

  if (a > 9999 && a < 100000)
  {
      int znak1 = a / 10000 % 10;
      int znak2 = a / 1000 % 10;
      int znak4 = a / 10 % 10;
      int znak5 = a / 1 % 10;

      if ( znak1 == znak5 && znak2 == znak4 )
      {
            Console.WriteLine($"Палиндром!"); 
      }
      else
      {
            Console.WriteLine($"Не палиндром");     
      }  
  }

}


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
void Zadacha21 ()
{
Random RundNum = new Random ();
    int Ax = RundNum.Next(-10, 11);
    int Ay = RundNum.Next(-10, 11);   
    int Az = RundNum.Next(-10, 11);   

    int Bx = RundNum.Next(-10, 11);  
    int By = RundNum.Next(-10, 11);
    int Bz = RundNum.Next(-10, 11);
    
    Console.WriteLine ($"Точки: А({Ax}, {Ay}, {Az}), B({Bx}, {By}, {Bz}) ");
    Console.WriteLine ($"Расстояние между точками A и В: {Math.Sqrt(Math.Pow((Bx-Ax),2) + Math.Pow((By-Ay),2) + Math.Pow((Bz-Az),2))}");
}



// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Zadacha23  ()
//таблица с квабратами от 0 до X
{
    Console.WriteLine ($"Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine ("Число\tКуб");
    for (int i = 1; i <= number; i++)
    {
         Console.WriteLine ("{0}\t{1}\t", i, i*i*i);
    }
}


//Zadacha19 ();
//Zadacha21 ();
Zadacha23 ();