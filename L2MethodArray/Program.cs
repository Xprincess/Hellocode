// Алгоритм
// Допустим, у нас есть массив array, в котором n элементов. Найдём элемент, совпадающий с
// некоторым значением, который определяет пользователей.
// 1. Сохраним его в переменную find. Затем установим счётчик в нулевую позицию.
// 2. Если на текущей позиции элемент совпал с find, операцию можно завершить, потому
// что мы нашли позицию.
// 15
// 3. Если элемент не совпал с find, увеличиваем значение счётчика index на 1 и переходим
// на предыдущий шаг.
// 4. Сравниваем снова. И если элемент совпал с find, значит, алгоритм закончил работу.
// 5. Если элемент совпал с find, снова увеличиваем индекс. Смотрим результат.
// 6. В результате если элемент находится, операция завершается успешно. А если этого
// элемента так и нет, надо сообщить об этом.


// int[] array = {1, 12, 31, 4, 5, 16, 71, 18, 19};

// int n = array.Length;   //вовращает длину или колличество элементов массива.
// int find = 71; //пользователь определяет число 

// int index =0;
// while (index < n)
// {
//     if(array[index] == find )
//     {
//         Console.WriteLine(index);
//     }
//     //index = index+1
//     index ++;
// }


