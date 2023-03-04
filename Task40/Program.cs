// Программа, которая принимает на вход 3 числа и проверяет
// может ли существовать треугольник с такими длинами сторон

//метод ввода чисел
int Printline(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//метод проверки

bool TriangleExist(int a, int b, int c)
{
return(a < b + c && b < c + a && c < a + b);
}

int firstNumber = Printline("Введите первое число");
int secondNumber = Printline("Введите второе число");
int thirdNumber = Printline ("Введите третье число");
if(TriangleExist(firstNumber, secondNumber, thirdNumber))
Console.WriteLine("Треугольник с такими длинами сторон существует");
else Console.WriteLine("Треугольник с такими длинами сторон не существует");