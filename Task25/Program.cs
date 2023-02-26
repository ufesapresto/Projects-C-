// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//медод ввода данных
int Printline(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int number = Printline("Введите любое число");
int degree = Printline("Введите любое число, больше 0");

if (degree > 0) /*проверка условия*/
{//Метод расчета
    int Degree(int a, int b)
    {
        int result = a;
        for (int i = 2; i <= b; i++)
        {
            result = result * a;
        }
        return result;
    }

    int answer = Degree(number, degree);
    Console.WriteLine($"{number}, {degree} -> {answer}");
}
else Console.WriteLine($"Второе число не соответствует параметрам");