// Программа, которая на ввод принимает любое число N
//и выдаёт произведение чисел от 1 до N

//методы
///метод ввода данных
int printLine(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int summ(int number)
{
    int s = 1;
    for (int i = 1; i <= number; i++)
    {
       checked
       {
        s = s * i;
       }    
    
    }
    return s;
    //while (i <= number)
    //{
      //  s = s * (i);
      //  i++;
    //}
    //
}
int n = printLine("Введите любое число");
int result = summ(n);
Console.WriteLine($"Произведение чисел от 1 до {n} -> {result}");
