Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int Add = numberOne % numberTwo;
bool Square(int num1, int num2)
{
	return num1 * num1 == num2 || num2 * num2 == num1;
}
if (Square(numberOne, numberTwo)) Console.WriteLine("Одно число является квадратом второго");
else Console.WriteLine(Add);



//Console.WriteLine("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (Multiplicity(number)) Console.WriteLine("Кратно");
//else Console.WriteLine("Не кратно");
//
//bool Multiplicity(int num)
//{
//	int multCheck1 = num % 7;
//	int multCheck2 = num % 23;
//	return multCheck1 == 0 && multCheck2 == 0;
//}
