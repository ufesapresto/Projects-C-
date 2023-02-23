//Программф, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

int Printline(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
double Distanse(int X1, int Y1,  int Z1, int X2, int Y2,  int Z2)
{
    return Math.Sqrt((X2 - X1) * (X2 - X1) +
                     (Y2 - Y1) * (Y2 - Y1) +
                     (Z2 - Z1) * (Z2 - Z1));
}


int x1 = Printline("Введите координату х1");
int y1 = Printline("Введите координату y1");
int z1 = Printline("Введите координату z1");
int x2 = Printline("Введите координату х2");
int y2 = Printline("Введите координату y2");
int z2 = Printline("Введите координату z2");
double d = Distanse(x1, y1, z1, x2, y2, z2);
double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
Console.WriteLine(dRound);

