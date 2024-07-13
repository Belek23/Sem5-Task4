Задача 1: Напишите программу, которая бесконечно запрашивает 
целые числа с консоли. Программа завершается при вводе символа 
‘q’ или при вводе числа, сумма цифр которого чётная.

while (true)
{
    Console.Write("Введите целое число или 'q' для выхода: ");
    string input = Console.ReadLine();
        
 if (input.ToLower() == "q")
     {
         break;
     }
            
 if (int.TryParse(input, out int number))
    {
      int sum = 0;
      while (number > 0)
    {
     sum += number % 10;
     number /= 10;
    }
 if (sum % 2 == 0)
    {
       Console.WriteLine("Сумма цифр введенного числа четная. Программа завершена.");
       break;
    }
    }
     else
     {
        Console.WriteLine("Введено не число. Попробуйте снова.");
    }
}




Задача 2: Задайте массив заполненный случайными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

Random random = new Random();
int[] numbers = new int[10];
int evenCount = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(100, 1000);
    System.Console.Write(numbers[i] + " ");
    if(numbers[i] % 2 == 0)
    {
        evenCount++;
    }
}
 System.Console.WriteLine($"\nКоличество чётных чисел в массиве: {evenCount}");




Задача 3: Напишите программу, которая перевернёт одномерный массив
(первый элемент станет последним, второй – предпоследним и т.д.)

int[] Array = { 1, 2, 3, 4, 5 };
int[] reversedArray = new int[Array.Length];

for (int i = 0; i < Array.Length; i++)
    {
        reversedArray[i] = Array[Array.Length - 1 - i];
    }
Console.WriteLine("Перевернутый массив:");
 foreach (int element in reversedArray)
    {
        Console.Write(element + " ");
    }