/*
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 int Degree(int num1, int num2)
 {
    int result = 1;
    for(int i = 1; i < num2; i ++)
    result = result * num1;
    return result;
 }
Console.Write("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число A: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Degree(number1, number2);
Console.WriteLine($"Цифра {number1} в степени {number2} = {number3}");
 
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumOfDigits(int num )
{
    int count= 0;
    while(num > 0)
    {
        int num1 = num%10;
        count+=num1;
        num /= 10;
    }
    return count;
}
Console.Write("Введите целое число : ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 =SumOfDigits(number1);
Console.WriteLine($"Сумма цифр в числе {number1} равна: {number2}");


 //Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int []Array(int size)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i ++)
    {
        Console.Write($"Input { i+1 } element of {size} : ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length;i ++)
        Console.Write (array [i]  + " ");
   
}
int[] binaryArray = Array( 8 );
ShowArray(binaryArray);

*/
