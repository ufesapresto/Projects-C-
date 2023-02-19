Console.WriteLine("Введите координаты точки");
Console.Write("X:");
int xc = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int yc = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter (xc, yc);
string result = quarter > 0 
                ? $"Указанные данные соответствуют четверти {quarter}"
                : "Вы ввели неверные координаты";
Console.WriteLine(result);

int Quarter (int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
