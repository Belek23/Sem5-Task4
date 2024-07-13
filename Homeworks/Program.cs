// Урок 2. Простые Алгоритмы
// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

bool multiplicity (int x)
{
    if (x % 7 == 0 && x % 23 == 0)
    {
        return true;
    }
    return false;
}

void Result(int x)
{
    if(multiplicity (x)) 
    {
        System.Console.WriteLine("да");
    }
    else
    {
        System.Console.WriteLine("нет");
    }
}
Console.WriteLine("Input number: ");
int x = Convert.ToInt32(Console.ReadLine());
Result (x);


// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

System.Console.WriteLine("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x != 0 && y != 0)
{
if (x > 0 && y > 0)
    {
     Console.WriteLine("1");
    }
else if (x < 0 && y > 0)
    {
    Console.WriteLine("2");
    }
else if (x < 0 && y < 0)
    {
    Console.WriteLine("3");
    }
else 
    {
    Console.WriteLine("4");
    }
    }

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

System.Console.WriteLine("Введите целое число от 10 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <= 99)
{
 int firstDigit = number / 10; 
 int secondDigit = number % 10; 

if (firstDigit >= secondDigit)
  {
   System.Console.WriteLine("=> " + firstDigit);
  }
else
  {
   System.Console.WriteLine("=> " + secondDigit);
  }
}


// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

System.Console.WriteLine("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string number = N.ToString();

for (int i = 0; i < number.Length - 1; i++)
 {
  System.Console.Write(number[i] + ", ");
 }
 {
  System.Console.WriteLine(number[number.Length - 1]);
 }
