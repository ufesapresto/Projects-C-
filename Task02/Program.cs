// // Программа, которая 
// на ввод принимает 2 числа
// и выдает, кокое из них больше, а какое меньше

Console.WriteLine("Введите число 1");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB)
{
    Console.WriteLine($"Число {numberA} больше");
}
else
{
    Console.WriteLine($"Число {numberB} больше");
}