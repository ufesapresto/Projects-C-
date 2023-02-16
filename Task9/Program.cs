int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit)
//     Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else
//     Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    
    // int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    // return result;

    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
//
//Console.WriteLine("Введите первое число: ");
//int numberOne = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int numberTwo = Convert.ToInt32(Console.ReadLine());

//if (Square(numberOne, numberTwo)) Console.WriteLine("Одно число является квадратом второго");
//else Console.WriteLine("Никакое число не является квадратом другого");
//
//bool Square(int num1, int num2)
//{
//	return num1 * num1 == num2 || num2 * num2 == num1;
//}

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