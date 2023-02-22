//Программа, которая по номеру четверти
//сообщает диапазон координат

//методы
int Printline(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine()); 
    return num;   
}

string Range (int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return "0";
}

//тело программы
int number = Printline("Введите номер четверти");
string range = Range(number);
string result = range == "0"
                    ?"Ошибка ввода"
                    : $"Диапазон возможных координат точек в этой четверти {range}";

Console.WriteLine(result);
