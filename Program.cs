/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

/* int[] CreateArray(int size){

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(99,999 + 1);
        Console.Write(array[i] + " ");
    }
    Console.Write(" ==> ");
    return array;
}

int Create(int[] array){

int sumUnexpected = 0;

    for (int j = 0; j < array.Length; j++)
    {
        
        if (array[j] % 2 == 0)
        {
            sumUnexpected += 1;
            Console.Write(array[j] + " ");
        }
    }
    Console.Write(" ==> ");
    return sumUnexpected;
}
Console.Write("Введите размер предпологаемого массива и на выходе вы получите колличесвто четных чисел:");

Console.Write(" ");

int SizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write(Create(CreateArray(SizeArray))); */

/* Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

/* int[] CreateArray (int size, int min,int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max);

        Console.Write(array[i]+ " ");
        }
        

    return array;
}

void FindOdd(int[] array)
{
    int sum = 0;
    for (int j = 1; j < array.Length; j++)
    {
        if (j % 2 == 1) sum += array[j];
        
       
    }
    Console.WriteLine("|Сумма элементов на нечётных позициях|==> " + sum);
}

Console.Write("Необходимо задать размер массива и его ограничение по типу Размер:");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Минимальное значение:");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное значние:");
int maxVal = Convert.ToInt32(Console.ReadLine());
Console.Write("|Заданный массив|");
int[] collection = CreateArray(arraySize,minVal,maxVal);

FindOdd(collection); */

/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.0 7.2 22.7 2.1 78.3] -> 76.2 */




void PrintArray(double[] arrays) 
{
    for (int j = 0; j < arrays.Length; j++)
    {
        Console.Write(arrays[j]);
    }
}
double Between(double[] collection)
{
    double min = collection[0];
    double max = collection[0];

   for (int i = 0; i < collection.Length; i++)
   {
         if (collection[i] < min) min = collection[i];
    else if (collection[i] > max) max = collection[i];
   }
    return(max - min) ;
}

double[] array = {3.0, 7.2, 22.7, 2.1, 78.3};

Console.Write("Исходный массив ==> ");
PrintArray(array);
Console.WriteLine(" У данного массива разница между максимальным и минимальным значение массива => "+Between(array));