/*
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int  NewArray( int[] array)
{
    int count = 0;
    for( int i = 0; i < array.Length; i ++)
    {
        if (array[i] % 2 == 0) 
        count ++;

    }
    return count;
}
Console.Write("Input sie of array: ");
int size=  Convert.ToInt32(Console.ReadLine());
int [] newarray =CreateRandomeArray(size, 100,1000);
ShowArray(newarray);
Console.WriteLine(" - Четные числа в массиве: " +  NewArray( newarray));


//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int  SumElements(int [] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i ++)
    if( i % 2 != 0)
    sum = array[i] + sum;
    return sum;
}
Console.Write("Input size of array: ");
int size=  Convert.ToInt32(Console.ReadLine());

int[]array = CreateRandomeArray(size, -10, 150);
ShowArray(array);
Console.Write($" Сумма элементов, стоящих на нечетных позицияз : {SumElements(array)} ");



//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int  Difference (int [] array)
{
    int max = array[1];
    for(int i = 0; i < array.Length; i ++)

    {
        if (array[i] > max ) max = array[i];
        
        
    }
    



    int min = array[1];
    for(int i = 0; i < array.Length; i ++)

    {
        if (array[i] < min ) min = array[i];
        
    }
    
    int difference = max - min;
    return difference;

}
Console.Write("Input size of array: ");
int size=  Convert.ToInt32(Console.ReadLine());

int[]array = CreateRandomeArray(size, -10, 150);
ShowArray(array);
Console.Write($"Разница между максимальным числом и минимальным равна : {Difference(array)} ");

*/
