// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

// int CountGreaterZero (int number, int count)
// {
//     if (number > 0) count++;
//     return count;
// }

// Console.WriteLine("Input as many numbers as you want. To stay input 's'.");
// string s = Console.ReadLine();
// string sNumber = String.Empty;
// int countAll = 0;
// while(s != "s")
// {
//     countAll = CountGreaterZero(Convert.ToInt32(s), countAll);
//     s = Console.ReadLine();
// }
// Console.WriteLine($"Count of the numbers as greater than 0 is {countAll}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindXY (double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double x = (b1 - b2)/(k2 - k1);
        Console.WriteLine($"[{x}; {k1 * x + b1}]");
    }
    else
    {
        Console.WriteLine("No");
    }
}

Console.WriteLine("I can help solve a system of equations:");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");
Console.WriteLine();
Console.Write("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

FindXY(b1, k1, b2, k2);