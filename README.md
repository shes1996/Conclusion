# Инструкция
Данный файл содержит несколько блоков для решения следующей [задачи](https://gbcdn.mrgcdn.ru/uploads/asset/4283449/attachment/1251e74b703108ee483caaa98787097d.png): 
> Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
1. Создание двух массивов, один пустой, другой с заранее заданными значениями:
```
string[] words = {"hello", "2", "world",":-)"};
string[] itog = new string[words.Length];
```
2. Проверка элементов заданного массива на количество символов и запись таких элементов в пустой массив:
```
for (int i = 0; i < words.Length; ++i)
    {               
        if (words[i].Length <= 3) itog[i] = words[i];
    }
```
3. Вывод получившегося массива с элементами, содержащими 3 или меньше символов, исключая пустые строки:
```
for (int j = 0; j < words.Length; j++)
    {
        if (itog[j] != null) Console.Write(itog[j] + ' ');
    }
```
## Вывод программы
В случае изначально заданного массива в виде: "hello", "2", "world",":-)", на выходе мы получим: "2 :-) "
