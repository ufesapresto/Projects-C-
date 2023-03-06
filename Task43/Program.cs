// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// x  = (b2 -b1) / (k1 - k2)
//
//  
//

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//медод ввода данных
double Printline(string massage)
{
    Console.WriteLine(massage);
    double num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// метод рассчета

double CrossPointX(double b1, double k1, double b2,  double k2)
{
     return (b2 - b1) / (k1 - k2);   
}

double CrossPointY(double b1, double k1, double x)
{
    return k1 * x + b1;
}

double coefficientB1 = Printline("Введите коэффициент b1");
double coefficientK1 = Printline("Введите коэффициент k1");
double coefficientB2 = Printline("Введите коэффициент b2");
double coefficientK2 = Printline("Введите коэффициент k2");

double x = CrossPointX(coefficientB1, coefficientK1, coefficientB2, coefficientK2);
double xRound = Math.Round(x, 2);
double y = CrossPointY(coefficientB1, coefficientK1, x);
double yRound = Math.Round(y, 2);
if (coefficientB1 == coefficientB2) Console.WriteLine("Заданные прямые параллельны");
else Console.WriteLine($"Прямые пересекаются в точке х {x}, y {y}");