// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите значение массива: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "   ");        
    }
}

void ChangeArray (string[] array)
{
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[i] = array[i];
            Console.Write(result[i] + "   ");
        }
    }
}

Console.WriteLine("Введите длину массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] array = new string[m];

FillArray(array);
PrintArray(array);

Console.WriteLine();

Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа: ");
ChangeArray (array);





