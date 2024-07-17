// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. Использовать рекурсию, 
// не использовать циклы.

int m = 1;
int n = 7;
PrintNumbers(m, n);

void PrintNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }
    Console.Write(m + " ");
    PrintNumbers(m + 1, n);
}




// Задача 2: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return akkerman(m - 1, 1);
    else return akkerman(m - 1, akkerman(m, n - 1));
}

Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");




// Задача 3: Задайте произвольный массив. Выведете его элементы,
// начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = {1, 2, 3, 4, 5}; 
PrintArrReversed(array, array.Length - 1);

void PrintArrReversed(int[] arr, int index)
{
    if (index < 0) 
      { 
      	return;
      } 
    System.Console.Write(array[index] + " "); 
    PrintArrReversed(array, index - 1); 
}  