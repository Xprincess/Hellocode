﻿// using System.Runtime.CompilerServices;
// using System.Security.AccessControl;

// // Перввая группа методов - ничего не принимают и ничего не возвращают

// // void Method1()
// // {
// //     Console.WriteLine("Автор ...");
// // }
// // Method1();

// // Второая группа методов - ничего не возвращают, но могут принимать аргументы

// // void Method2(string msg)
// // {
// //     Console.WriteLine(msg);
// // }
// // Method21("Текс сообщения");
// // void Method21(string msg, int count)
// // {
// //     int i = 0;
// //     while(i < count)
// //     {
// //         Console.WriteLine(msg);
// //         i++;
// //     }
// // }
// // Method21(count: 4, msg: "Новый текс");

// //Третья группа методов - ничего не принимают, но что-то возвращают

// // int Method3()
// // {
// //     return DateTime.Now.Year;
// // }
// // int year = Method3();
// // Console.WriteLine(year);

// //Четвертая группа методов - что-то принимают и что-то возвращают

// // string Method4(int count, string text)
// // {
// //     int i = 0;
// //     string result = String.Empty; // пустая строка
// //     while(i < count)
// //     {
// //         result = result + text;
// //         i++;
// //     }
// //     return result;
// // }
// // string result = Method4(5, "Hello World! ");
// // Console.WriteLine(result);

// //Запишем Method4 используя цикл for

// // string Method4(int count, string text)
// // {

// //     string result = String.Empty; // пустая строка
// //     for (int i = 0; i < count; i++) // (инициализация переменной, условие счетчика, инкремент переменной)
// //     {
// //         result = result + text;
// //     }
// //     return result;
// // }
// // string result = Method4(5, "Hello World! ");
// // Console.WriteLine(result);

// //Использую вложенный цикл for, напишем программу для вывода таблицы умножения

// // for (int i = 2; i <= 10; i++)
// // {
// //     for (int j = 2; j <= 10; j++)
// //     {
// //         Console.WriteLine($"{i} X {j} = {i * j}");
// //     }
// //     Console.WriteLine();
// // }

// //===== Задача №1 - Работа с текстом   
// //Дан текст. В тексте нужно все пробелы заменить черточками, 
// //меленькие буквы “к” заменить большими “К”, 
// //а большие “С” заменить на меленькими “с”

// // string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
// //             + "ежели бы вас послали вместо нашего милого Винценгероде,"
// //             + "вы бы взяли приступом согласие пруссого короля. "
// //             + "Вы так красноречивы. Вы дадите мне чаю?";

// // // string s = "qwerty"
// // //             012
// // // s[3] // r
// // string Replace(string text, char oldValue, char newValue)
// // {
// //     int length = text.Length;
// //     string result = String.Empty;
// //     for(int i = 0; i < length; i++)
// //     {
// //         if(text[i] == oldValue) result = result + $"{newValue}";
// //         else result = result + $"{text[i]}";
// //     }
// //     return result;
// // }
// // string newText = Replace(text, ' ', '|');
// // Console.WriteLine(newText);
// // Console.WriteLine();
// // newText = Replace(newText, 'к', 'К');
// // Console.WriteLine(newText);
// // Console.WriteLine();
// // newText = Replace(newText, 'С', 'с');
// // Console.WriteLine(newText);

// //===== Задача №2 - Отсортировать массив, так чтобы минимальные значения были сначала

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[]array) //метод для печати массива
// {
//     int count = array.Length;
//     for(int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[]array)
// {
//     for( int i = 0; i < array.Length - 1; i++)   //Во внешнем цикле мы перебираем все элементы, 
//         {                                        //если элемент меньше следующего, то меняем местами
//         int minPosition = i;
//             for(int j = i + 1; j < array.Length; j++)   //Во внутреннем цикле проверяем два сосдених элемента, какой больше
//             {
//                 if(array[j] < array[minPosition]) minPosition = j;
//             }
//         int temp = array[i];                    //Временная переменная, для замены элементов местами
//         array[i] = array[minPosition];
//         array[minPosition] = temp;
//         }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);