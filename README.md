# Условие задачи:
* Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. 

* Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

* При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Примеры:

1. [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

2. [“1234”, “1567”, “-2”, “computer science”] → [“-2”]

3. [“Russia”, “Denmark”, “Kazan”] → []

# Решение:
1. Просим пользователя ввести элементы массива с клавиатуры через пробел
2. Создадим метод создающий массив из строки 
string[] array = GetArrayFromString(ReadLine());

    * Разбиваем строку на подстроки и возвращаем массив строк
        * string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);  
    * Результирующий массив который получается считываением элементов из numS
        * string[] result = new string[numS.Length];
3. Для проверки распечатываем получившийся массив 
    * WriteLine(String.Join(",", array));

4. Создаем метод сиздающий новый массив строк из элементов первого массива (передаем первый массив в этот метод). Предварительно осторитировав их.

    * string[] result = ResultArray(array); 
        * Создаем результирующий массив строк
            * string[] result = new string[array.Length];
        * Обходим массив поэлементно.
            * for (int i = 0; i < array.Length; i++)
        * При этом каждый элемент превращаем в Строку
            * string element = array[i];
        * По скольку строка является массивом, мы опрашиваем эту строку на соответствие условию по количеству элементов в строке
    
            * if(element.Length <= 3)
                {
                result[i] = array[i];
                }
    * На выходе получаем новый Массив строк удовлетворяющий условию задачи
5. Распечатываем результирующий массив
    * WriteLine(String.Join(" ", result));