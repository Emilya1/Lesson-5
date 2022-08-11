 // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.\
int GreaterThanZero(int size)
{
    int count = 0;
    int i = 0;
    while (i < size)
    {
         Console.Write($"Input {i+1} element of {size} : ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        count++;
        i++;
    }
    return count;
}
Console.Write("Input size : ");
 int size = Convert.ToInt32(Console.ReadLine());
 int num2 = GreaterThanZero( size);
Console.WriteLine($"{num2} - чисел больше нуля");
/*
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Input b1 : ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2 : ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1 : ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2 : ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;
Console.WriteLine($"Точка пересечения двух прямых {x},{y}");

*/


