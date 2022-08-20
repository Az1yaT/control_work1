/* Написать программу которая из имеющегося массива строк,
формирует массив строк, длинна которых меньше или равна 3 символа
Первоначальный массив, можно ввести на старте или задать с клавиатуры */

// 1. Задаем одномерный массив строк: 

string[] arrString = { "hello", "2", "world", ":-)", "xD" };

// 2. Выводим на печать исходный массив: 
void PrintArray(string[] arrString)
{
    for (int i = 0; i < arrString.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arrString.Length - 1) Console.Write(arrString[i] + ", ");
        else Console.Write(arrString[i] + "]");
    }
}
