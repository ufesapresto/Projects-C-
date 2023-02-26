// Программа, которая на ввод принимает любое число N
//и выдаёт количество цифр в числе

//методы
///метод ввода данных
int printLine(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int lenthNumber(int number)
{
    int lenth = 0;
    while (number != 0)
    {
        lenth = lenth + 1;
        number = number / 10;

    }
    return lenth;
}
int n = printLine("Введите любое число");
int l = lenthNumber(n);
Console.WriteLine($"Количество знаков в числе {n} -> {l}");
