// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//метод создания массива
int[] CreateNewRndInt (int size, int min, int max)
{
    int [] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
// метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)Console.Write(",");
    }
    Console.WriteLine("]");
} 
//медод поиска суммы чисел, стоящих на четных позициях
int SummOddNumbers(int[] array)
{
    int summ = 0;
for (int i = 0; i < array.Length; i++)
    {
    if (i % 2 != 0) summ += array[i];
    }
return summ;
} 


int[] arr = CreateNewRndInt(5, -10, 10);
PrintArray(arr);
int summOddNumbers = SummOddNumbers(arr);
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях -> {summOddNumbers}");  
