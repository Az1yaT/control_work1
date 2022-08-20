/* Написать программу которая из имеющегося массива строк,
формирует массив строк, длинна которых меньше или равна 3 символа
Первоначальный массив, можно ввести на старте или задать с клавиатуры */

// 1. Задаем одномерный массив строк: 

string[] arrString = { "hello", "2", "world", ":-)"};

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

// 3. Находим количество элементов длинной <=3 символам.
int CountElem(int count)
{
    for (int i = 0; i < arrString.Length; i++)
    {
        if (arrString[i].Length <= 3)
            count++;
    }
    return count;
}

// 4. Инициализируем и печатаем новый массив с числом элементов в которых содержится <=3 символа.
int count = 0;
int countElem = CountElem(count);
string[] arrNew = new string[countElem];
void SelectElem(string[] arrNew)
{
    for (int i = 0; i < countElem; i++)
    {
        string length = arrString[i + 1];
        if (length.Length <= 3)
        {
            arrNew[i] = length;
        }
        if (i == 0) Console.Write("[");
        if (i < arrNew.Length - 1) Console.Write(arrNew[i] + ", ");
        else Console.Write(arrNew[i] + "]");
    }
}
Console.Write("Исходный массив: ");
PrintArray(arrString);
Console.WriteLine("");
Console.Write("Конечный массив: ");
SelectElem(arrNew);