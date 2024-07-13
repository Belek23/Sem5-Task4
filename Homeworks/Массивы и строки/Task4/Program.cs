// Задача 4: Задайте строку, состоящую из слов, разделенных пробелами.
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

Console.WriteLine("Введите строку из слов:");
string input = Console.ReadLine();

string reversed = ReverseWords(input);
Console.WriteLine("Строка с обратным порядком слов:");
Console.WriteLine(reversed);

string ReverseWords(string str)
{
    string[] words = str.Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words);
}



