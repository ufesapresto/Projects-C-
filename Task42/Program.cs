// Программа преобразования десятичного числа в двоичное

//метод ввода двоичного числа
int Printline(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int number = Printline("Введите число");
// 45/2= 22 (1), 22/2= 11 (0), 11/2= 5 (1), 5/2= 2 (1), 2/2= 1 (0), 1/2= 0 (1)-> 101101

int NewNumber(int num)
{
    int newNumber = 1;
    int rez = 0;
while (num > 0)
{    
    rez = rez + num % 2 * newNumber;
    num = num / 2;
    newNumber *= 10;
}
return rez;
}

int a = NewNumber(number);
Console.WriteLine(a);


//int beNumber = Console.ReadLine()* 10 + 1;

//while (beNumber / 10 > 0)
//{
//    int answer = beNumber % 10;
//    (answer);
//    beNumber = beNumber / 10;
//}
