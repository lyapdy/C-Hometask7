﻿// Задача 3: Задайте произвольный массив. Выведете его элементы,начиная с конца.
//Использовать рекурсию, не использовать циклы.


void Main()
{
    int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
    ShowArray(arr1, arr1.Length - 1);
}

void ShowArray(int[] array, int i)
{
    if (i == 0)
    {
        System.Console.Write(array[i]);
        return;
    }
    System.Console.Write(array[i] + " ");
    ShowArray(array, i - 1);
    return;
}

Main();

