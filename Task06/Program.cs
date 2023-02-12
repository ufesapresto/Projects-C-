// // Программа, которая
// на вход принимает число
// и выдает, является ли число четным

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 2 == 0) 
{
Console.WriteLine($"Число {numberA} является четным");
}
else
{
Console.WriteLine($"Число {numberA} не является четным");
}