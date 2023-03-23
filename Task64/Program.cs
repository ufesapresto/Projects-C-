// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите любое натуральное число");
int number = int.Parse(Console.ReadLine());
if (number <= 0) Console.WriteLine("Ошибка ввода");
else
{
    NaturalNumbers(1, number);
    void NaturalNumbers(int i, int num)
    {
        if (i > num) return;
        NaturalNumbers(i + 1, num);
        Console.Write($"{(i)} ");
    }

}
