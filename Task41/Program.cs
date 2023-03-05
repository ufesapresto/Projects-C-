// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

//медод ввода данных
int Printline(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// метод создания массива

int[] CreateArray(int number)
{
    int[] array = new int[number];
    int i = 0;
    while (i < number)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    return array;
}

// метод вывода массива
void PrintArray(int[] array)
{
    Console.Write("Введен массив [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1) Console.Write(",");
    }
    Console.Write("]. ");
}
// метод вычисления количества чисел больше 0

int SummPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int arrayLength = Printline("Введите длину массива");
int[] newArray = CreateArray(arrayLength);
int summ = SummPositiveNumbers(newArray);
PrintArray(newArray);
Console.WriteLine($"Количество положительных чисел в массиве -> {summ}");