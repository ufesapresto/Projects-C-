//Программа, которая на ввод принимает любое число N
//и выдаёт таблицу кубов чисел от 1 до N

//методы
///метод ввода данных
int Printline(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string Square(int N)
{
    string result = String.Empty;
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i,5} - {i * i * i,5}");
    }
    return result;
}
int n = Printline("Введите любое число");
if (n > 0) Console.WriteLine(Square(n));
else Console.WriteLine("Неверное число. Введите натуральное число от 1 до N");