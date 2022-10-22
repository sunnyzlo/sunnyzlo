
// ДЗ 9 финал
// Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
// M = 1; N = 9. -> "3, 6, 9"
// M = 13; N = 20. -> "15, 18"
void Zadacha64()
{

    Console.WriteLine("Введите M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите N больше M: ");
    int n = Convert.ToInt32(Console.ReadLine());
    FindNatural64(m, n);
    
    void FindNatural64(int m, int numbers)
    {
        if (m%3 == 0) Console.Write($"{m}, ");
        m++;
        if (m > n) return;
        FindNatural64(m, n);
    }
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
void Zadacha66()
{

    Console.WriteLine("Введите M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    FindNatural66(m, n);
    
    void FindNatural66(int m, int n, int sum = 0)
    {
        sum = sum + m;
        m++;
        if (m > n) 
        {
            Console.WriteLine($"{sum}");
            return;
        }
        FindNatural66(m, n, sum);
    }
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
void Zadacha68()
{

Console.WriteLine("Введите начальное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

Ackerman (numberM, numberN);

int Ackerman (int numberM, int numberN)
{
    if (numberM == 0) return  numberN += 1;
    if (numberM != 0 && numberN == 0) return Ackerman(numberM - 1, 1); 
    if (numberM > 0 && numberN > 0) return Ackerman(numberM - 1, Ackerman(numberM, numberN - 1));
    return Ackerman(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {Ackerman(numberM, numberN)}");

}

Zadacha68();
