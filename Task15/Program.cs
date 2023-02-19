//Задача 15: Напишите программу, которая 
//принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
Console.WriteLine("Введите любое число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 7)
{
    bool Holiday(int num)
    {
        return num > 5 && num < 8;
    }
    if (Holiday(number)) Console.WriteLine($"Да");
    else Console.WriteLine($"Нет");
}
else Console.WriteLine("Вы ввели неверное число");


