// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

Console.WriteLine("Введите строку:");
string input = Console.ReadLine();

if (IsPalindrome(input))
{
    Console.WriteLine("Строка является палиндромом.");
}
else
{
    Console.WriteLine("Строка не является палиндромом.");
}

static bool IsPalindrome(string str)
{
    int left = 0;
    int right = str.Length - 1;

    while (left < right)
    {
        if (char.ToLower(str[left]) != char.ToLower(str[right]))
        {
            return false;
        }
        left++;
        right--;
    }

    return true;
}