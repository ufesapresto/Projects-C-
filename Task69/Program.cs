// Программа, которая принимает на ввод 2 числа и возводит первое в степень второго
Console.WriteLine ("Введите любое натуральное число");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите любое натуральное число");
int number2 = int.Parse(Console.ReadLine());

int DigitNumbers(int num1, int num2)
{
 if(num2 == 0) return 1;
 else return num1 * DigitNumbers(num1, num2-1);
}
Console.WriteLine($"{DigitNumbers(number1, number2)}");