//Задача 10: Напишите программу, которая 
//принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите любое трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int digit = Digit(number);
    Console.WriteLine($"Answer {digit}");

    int Digit(int num)
    {
        int firstDigit = num % 100;
        int secondDigit = num % 10;
        return (firstDigit - secondDigit) / 10;
    }

}
else Console.WriteLine("Вы ввели неверное число");