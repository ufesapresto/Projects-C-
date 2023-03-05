// Программа, которая выводит первые N чисел Фибоначчи

//метод ввода числа N
int Printline(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// метод вывода массива чисел Фибоначи
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

//медод создания массива Фибоначи
int[] FibNumbers(int num)
{
    int[] fibArr = new int[num];
    fibArr[0] = 0;
    if (num > 1) fibArr[1] = 1;
    for (int i = 2; i < num; i++)
    {
       fibArr [i] = fibArr[i - 1] + fibArr[i - 2];
    }
    return fibArr;
}

int number = Printline("Введите число");
int[] arrN = FibNumbers(number);
PrintArray(arrN);
