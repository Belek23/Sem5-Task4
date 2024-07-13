// Количество элементов массива на отрезке

// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
// Начальные условия: int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5


// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
// int count = 0;


// // Находим количество элементов в отрезке [10,90]
// foreach (int number in array)
// {
//     if (number >= 10 && number <= 90)
//     {
//         count++;
//     }
// }

// Console.WriteLine("Количество элементов в отрезке [10,90]: " + count);


// ИЛИ

// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
//     // Подсчет количества элементов массива, попадающих в заданный диапазон
//     // numbers - массив, в котором ведется подсчет
//     // minRange - минимальная граница диапазона
//     // maxRange - максимальная граница диапазона
//     public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
//     {
//       int count = 0;
//       for (int i =0; i < numbers.Length; i++)
//         {
//          if (numbers[i] >= minRange && numbers[i] <= maxRange)
//            {
//          count = count +1;
//            }
//         }
// return count;
//     }

//     public static void PrintResult(int[] array)
//     {
//        int result = CountItemsRange(array, 10, 90);
//       Console.WriteLine(result);
//           //Введите сюда свое решение
//     }

// }


// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;
        

//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();
            
//             // Теперь arr содержит преобразованные в целые числа из командной строки
        
//         } else {
//            // Если аргументов на входе нет
//             array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }

