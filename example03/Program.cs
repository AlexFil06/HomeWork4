// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = new int[8];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 101);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int pos = 0;
    Console.Write("[");
    while (pos < count)
    {
        Console.Write($"{col[pos]}");
        pos++;
        if (pos < count) Console.Write(", ");
    }
    Console.Write("]");
}

FillArray(array);
PrintArray(array);