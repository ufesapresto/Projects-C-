Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
bool Square(int num1, int num2)
{
	return num1 * num1 == num2 || num2 * num2 == num1;
}
if (Square(numberOne, numberTwo)) Console.WriteLine("Yes");
else Console.WriteLine("No");
