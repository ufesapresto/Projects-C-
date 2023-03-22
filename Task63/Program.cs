// Рекурсия. Программа вывода чисел от 1 до N

Console.WriteLine ("Введите любое натуральное число");
int number = int.Parse(Console.ReadLine());

NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if(num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
    
}
