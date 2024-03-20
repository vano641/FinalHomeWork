//Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;
using static System.Console;
Clear();
//1
Write("Введите элементы массива через ПРОБЕЛ: ");
string[] array = GetArrayFromString(ReadLine());
WriteLine(String.Join(",", array));


//1 Метод создающий массив из строки
string[] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string[] result = new string[numS.Length];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = numS[i];
        }
    return result;
}
