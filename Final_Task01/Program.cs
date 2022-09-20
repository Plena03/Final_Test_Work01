// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ";-)"] -> ["2", ";-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.WriteLine("Программа из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.");
Console.WriteLine();

string[] array = new string[8] {"1234", "1567", "-2", "computer science", "hello", "2", "world", ";-)"};
string[] arrayNew = new string[array.Length];

void NewArray(string[] array, string[] arrayNew)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        arrayNew[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}   ");
    }
    Console.WriteLine();
}

NewArray(array, arrayNew);
Console.WriteLine("Изначальный массив:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Новый массив:");
PrintArray(arrayNew);
Console.WriteLine();

