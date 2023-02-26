// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

//медод ввода данных
int Printline(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int number = Printline("Введите любое число");

//метод рассчета

int SummNumber(int a)
{
    int summ = 0;
    while (a > 0)
    {
        summ = summ + a % 10;
        a = a / 10;
    }
    return summ;
}

int answer = SummNumber(number);
Console.WriteLine($"Сумма цифр числа {number} -> {answer}");