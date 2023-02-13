// // Программа, которая
// на вход принимает число N
// и на выходе выдает, все четные числа от 1 до N

Console.WriteLine("Введите число больше 0: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;
if (number >= 1)
{
    while (index <= number)
    {
        if (index % 2 == 0)
        {
            Console.Write($"{index} ");
        }
        index++;
    }
}
else Console.WriteLine("Вы ввели неверное число");
