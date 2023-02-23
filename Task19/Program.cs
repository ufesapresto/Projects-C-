// Программа, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

//медод ввода данных
int Printline(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
//метод реверса
int Reverse(int number)
{
    int rev = number % 10 * 10000 +
              (number % 100 - number % 10) * 100 +
              (number % 1000 - number % 100) +
              (number % 10000 - number % 1000) / 100 +
              number / 10000;
    return rev;
}
//программа
int N = Printline("Введите любое пятизначное число");
int R = Reverse(N);

if (N > 9999 && N < 100000)
{
    if (N == R) Console.WriteLine("Данное число является палиндромом"); 
    else Console.WriteLine("Данное число не является палиндромом");
}
else Console.WriteLine("Данное число не является пятизначным. Введите пятизначное число");