int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");

int digit = Digit (number);
Console.WriteLine($"Answer {digit}");

int Digit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
return firstDigit * 10 + secondDigit;
}

