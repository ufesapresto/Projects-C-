// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine ("Введите любое натуральное число");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите любое натуральное число");
int number2 = int.Parse(Console.ReadLine());

int DigitNumbers(int num1, int num2)
{
 if(num1 > num2) return 0;
 else return num1 + DigitNumbers(num1 +1, num2);
}
if(number1 < number2) 
Console.WriteLine($"Сумма чисел заданного промежутка -> {DigitNumbers(number1, number2)}");
if(number1 > number2) 
Console.WriteLine($"Сумма чисел заданного промежутка -> {DigitNumbers(number2, number1)}");