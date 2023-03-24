// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine ("Введите любое неотрицательное число");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите любое неотрицательное число");
int number2 = int.Parse(Console.ReadLine());
if (number1 < 0 || number2 < 0) Console.WriteLine("Ошибка ввода");
else
{
int Ackerman(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else
    {
        if (num2 == 0)
        return Ackerman(num1 - 1, 1);
    }    
    return Ackerman(num1 - 1, Ackerman(num1, num2 - 1));

}

Console.WriteLine($"Результат функции Акермана введенных чисел - > {Ackerman(number1, number2)}");
}