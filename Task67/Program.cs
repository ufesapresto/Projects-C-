//Программа, которая считает сумму чисел в числе

Console.WriteLine ("Введите любое натуральное число");
int number = int.Parse(Console.ReadLine());

//SumNumbers(number);

int SumNumbers(int num)
{
    if(num == 0) return 0;
    else return num % 10 + SumNumbers(num / 10);
}
Console.WriteLine($"{SumNumbers(number)}");
