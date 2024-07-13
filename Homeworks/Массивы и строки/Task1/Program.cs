// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

char[,] array = { { 's', 't', 'r' }, { 'i', 'n', 'g' } };
string result = string.Empty;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result += array[i, j];
    }
    System.Console.WriteLine(result);
}