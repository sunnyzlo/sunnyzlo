
// ДЗ4
// Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
// 3, 5 -> 243 
// 2, 4 -> 16
void Zadacha25 ()

{
    Console.WriteLine ($"Введите число, которое нужно возвести в степень: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ($"И в какую степень возводить: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    int sum = 1;

    for (int i = 1; i <= number2; i++)
    {
         sum = sum*number1;
    }

    
    Console.Write ($"{sum}\n");
}


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 
// 82 -> 10 
// 9012 -> 21

void Zadacha27 ()
{
       Console.WriteLine("Узнаю сумму цифр в числе, введите число: ");
       int num = Convert.ToInt32(Console.ReadLine());
       int current = num;
       int count = 0;
       int numOne = 0;
       int sum = 0;

       for (int i = 0; count < num; i++)
       {   
           numOne = num %10;
           num = num / 10;
           Console.WriteLine ($"{num} + {numOne}"); 
           sum = sum + numOne;
           count++;
       }
       Console.WriteLine ($"{current} --> {num+sum}"); 


}


// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив
// -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19] 
// 6, 1, -33 -> [1, 6, -33]

void Zadacha29 ()

{   
// Сортировка одномерного массива
// Случайный массив до 8 чисел
{   
    Random random = new Random ();
    int size = random.Next (4,9);
    int [] numbers = new int [size];
    Console.WriteLine (size);
    
    FillArray29 (numbers);
    PrintArray29 (numbers);
    SelectionSort29(numbers);
    PrintArray29 (numbers);
}

//заполнять случайно массив
void FillArray29 (int[] num)

{
    Random random = new Random ();
    for (int i = 0; i < num.Length; i++)
    {
        num [i] = random.Next(-100,100);
    }

}

// печатать массив
void PrintArray29 (int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write (num[i]+ " ");
    }
    Console.WriteLine ();
}

// сортировка
void SelectionSort29(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;
        int arrayAbs = 0;
        for (int j = i + 1; j < array.Length; j++)
        {

            if (Math.Abs(array[j]) < Math.Abs(array[minPosition])) minPosition = j;
            
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
            // if (array[j]<0) 
            // {    
            //      array[j] = array[j] * -1;
            // }     
            // else if (arrayAbs <0) array[j] = arrayAbs;
}

Zadacha29 ();