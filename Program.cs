// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

int CountGreaterZero (int number, int count)
{
    if (number > 0) count++;
    return count;
}

Console.WriteLine("Input as many numbers as you want. To stay input 's'.");
string s = Console.ReadLine();
string sNumber = String.Empty;
int countAll = 0;
while(s != "s")
{
    countAll = CountGreaterZero(Convert.ToInt32(s), countAll);
    s = Console.ReadLine();
}
Console.WriteLine($"Count of the numbers as greater than 0 is {countAll}");