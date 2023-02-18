Console.WriteLine("Введите число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
bool Multiplicity(int num1)
{
	return num1 % (7*23) == 0;
}
if (Multiplicity(numberOne)) Console.WriteLine("Введенное число кратно 7 и 23");
else Console.WriteLine("Нет");
