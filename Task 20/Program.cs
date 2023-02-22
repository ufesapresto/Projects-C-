//Программа, которая принимает на вход координаты двух точек
//и находит расстояние между ними

//методы
int Printline(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine()); 
    return num;   
}
double Distanse (int X1, int Y1, int X2, int Y2)
{  
    return Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1));
}

//тело программы

int x1 = Printline("Введите координату х1");
int y1 = Printline("Введите координату y1");
int x2 = Printline("Введите координату х2");
int y2 = Printline("Введите координату y2");

double d = Distanse(x1,y1,x2,y2);
double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
Console.WriteLine(dRound);

