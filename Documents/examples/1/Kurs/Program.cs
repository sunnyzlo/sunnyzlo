
//Итоговая задача 

//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

//Примеры:
//["Hello",  "2” , "World" , "=)" -> ["2" , "=)"]
//["1234", "1567", "-2", "сошри*ег зшепсе"] -> ["-2"]
//["Кд1881а", "Пешпагк", "Кагап"] -> []



void Zadacha()
{

{
   //Random random = new Random();
    Console.WriteLine($"Введите сколько будет значений: ");
    int size = Convert.ToInt32(Console.ReadLine());

    string[] array = new string[size];

    // Заполнять с клавы
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива: ");
        array[i] = Console.ReadLine();
    }
    PrintArray(array);
}


//Заполняем и печатаем новый массив
void PrintArray(string[] array)
{
    Console.WriteLine();
    Console.WriteLine("Выбрали вот эти: ");
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        int sluchai = random.Next(0, 2);
        if (sluchai != 0) Console.Write(array[i] + " ");
    }
    Console.Write(" ");
    Console.WriteLine();
}

}

Zadacha();